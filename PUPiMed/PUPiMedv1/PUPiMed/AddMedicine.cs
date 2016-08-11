using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class AddMedicine : MetroForm
    {
        public UCItemMedicine parent;
        public int choice = 0, itemType = 1;
        string strQuery = string.Empty;
        string prevCode = string.Empty;
        String strCode = string.Empty;
        String strName;
        String strGen;
        String strManu;
        int intMin;
        int intMax;
        SmartCounter sc;
        bool newManufacturer = false;

        public AddMedicine(UCItemMedicine parent)
        {
            this.parent = parent;
            InitializeComponent();

        }

        public AddMedicine()
        {
            choice = 0;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool okay = true;
            string error = "Invalid input for ";
            strCode = txtCode.Text;
            if (string.IsNullOrWhiteSpace(strCode) || !Regex.IsMatch(strCode, "^(?=.*?[0-9])(?=.*?[A-Za-z])[a-zA-Z0-9_]+$"))
            {
                txtCode.Enabled = true;
                txtCode.Clear();
                status.Text = "Input code.";
                txtCode.Focus();
                okay = false;
            }
            strName = txtName.Text;
            strGen = txtGen.Text;
            strManu = txtManu.Text;
            if (string.IsNullOrWhiteSpace(strCode) || string.IsNullOrWhiteSpace(strName) || string.IsNullOrWhiteSpace(strGen) || string.IsNullOrWhiteSpace(strManu))
            {
                okay = false;
            }
            if (!(Int32.TryParse(txtMin.Text, out intMin)))
            {
                //invalid input
                okay = false;
                error += "min ";
            }
            if (!(Int32.TryParse(txtMax.Text, out intMax)))
            {
                //invalid input
                okay = false;
                error += "max";
            }
            else
            {
                if (intMin >= intMax)
                {
                    okay = false;
                    MetroMessageBox.Show(this, "Max must be greater than the minimum value.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtMax.Clear();
                }
            }


            if (okay)
            {
                if (choice == 0)
                {
                    strQuery = "INSERT INTO tblItem VALUES ('" + strCode + "', '" + strName + "', '" + strGen + "', '" + strManu + "', " + intMin + ", " + intMax + ", " + itemType + ", 0 , 0000-00-00-00-00-00, '');";
                }
                else
                {
                    strQuery = "UPDATE tblItem SET strItemName='" + strName
                        + "', strItemGeneric='" + strGen
                        + "', strItemManuCode='" + strManu
                        + "', intItemMin=" + intMin
                        + ", intItemMax=" + intMax
                        + " WHERE strItemCode='" + strCode + "';";
                }

                if (Program.ExecuteQuery(strQuery))
                {
                    //success
                    status.Text = "Saved.";
                    sc = new SmartCounter(strCode);
                    txtCode.Text = sc.getCode();
                    txtCode.Enabled = false;
                    txtName.Clear();
                    txtName.Focus();
                    txtGen.Clear();
                    txtManu.Clear();
                    txtMin.Clear();
                    txtMax.Clear();
                    if(parent!=null)
                        parent.updateTable();
                    if (choice == 1)
                        this.Dispose();
                }
                else
                {
                    //fail
                    status.Text = "Failed to make changes.";
                }
            }
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            newManufacturer = Manufacturer.fillComboBox(cbManufacturer);
            if (newManufacturer)
            {
                cbManufacturer.Visible = false;
                txtManu.Visible = true;
                lblManu.Text = "Manufacturer Code : ";
                lblManuName.Text = "Manufacturer Name : ";
            }
            else
            {
                cbManufacturer.Visible = true;
                txtManu.Visible = false;
                lblManu.Text = "Manufacturer Name : ";
                lblManuName.Text = "Others : ";
            }
            

            if (choice == 1)
            {
                txtCode.Enabled = false;
                txtName.Focus();
            }
            else
            {
                //check if theres an existing code
                prevCode = Program.getPrevCode("SELECT * from tblItem WHERE intItemType=" + itemType + " ORDER by strItemCode DESC LIMIT 1;");
                if (prevCode.Equals(string.Empty))
                {
                    this.txtCode.Enabled = true;
                    status.Text = "Input code.";
                    txtCode.Focus();
                }
                else
                {
                    sc = new SmartCounter(prevCode);
                    strCode = sc.getCode();
                    txtCode.Text = strCode;
                    txtCode.Enabled = false;
                    txtName.Focus();
                    if (string.IsNullOrWhiteSpace(strCode) || !Regex.IsMatch(strCode, "^(?=.*?[0-9])(?=.*?[A-Za-z])[a-zA-Z0-9_]+$"))
                    {
                        txtCode.Enabled = true;
                        txtCode.Clear();
                        status.Text = "Input code.";
                        txtCode.Focus();
                    }
                }
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void lbltype_Click(object sender, EventArgs e)
        {

        }

        private void lblother_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void medcode_Click(object sender, EventArgs e)
        {

        }

        private void cbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbManufacturer.SelectedItem=="Others...")
            {
                txtOther.Enabled = true;
            }
            else
            {
                txtOther.Enabled = false;
            }
        }

        

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
