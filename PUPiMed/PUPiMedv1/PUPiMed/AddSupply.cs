using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class AddSupply : MetroForm
    {
        public UCItemSupply parent;
        public int choice = 0, itemType = 2;
        string strQuery = string.Empty;
        string prevCode = string.Empty;
        String strCode = string.Empty;
        String strName;
        String strGen;
        String strManu;
        int intMin;
        int intMax;
        SmartCounter sc;

        public AddSupply()
        {
            choice = 0;
            InitializeComponent();
        }

        public AddSupply(UCItemSupply parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void AddSupply_Load(object sender, EventArgs e)
        {

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
    }
}
