using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace PUPiMed
{
    public partial class FormAddItem : MetroForm
    {
        public UCItem parent;
        public int choice = 0, itemType = 1;
        bool newManufacturer = false;
        ArrayList aListCode;
        ComboBoxFn mn = new ComboBoxFn();

        string strCode, strName, strGen, strManu;
        int intMin, intMax;
        
        public FormAddItem(UCItem parent, int itemType)
        {
            this.itemType = itemType;
            this.parent = parent;
            InitializeComponent();
        }
        public FormAddItem(int itemType)
        {
            this.itemType = itemType;
            choice = 0;
            InitializeComponent();
        }

        private bool everythingIsOkay()
        {
            strCode = txtCode.Text;
            strName = txtName.Text;
            strGen = txtGen.Text;
            strManu = txtManu.Text;
            
            if (!(Int32.TryParse(txtMin.Text, out intMin)))
            {
                return false;
            }
            if (!(Int32.TryParse(txtMax.Text, out intMax)))
            {
                return false;
            }
            
            if (string.IsNullOrEmpty(strCode) || string.IsNullOrEmpty(strName) || string.IsNullOrEmpty(strGen) || string.IsNullOrEmpty(strManu))
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strQuery;
            if (everythingIsOkay())
            {
                if (intMin >= intMax)
                {
                    status.Text = "Max must be greater than the minimum value.";
                    status.BackColor = Color.Tomato;
                }else
                {
                    if (string.IsNullOrEmpty(Program.getNextCode(strCode)))
                    {
                        txtCode.Focus();
                        status.Text = "Invalid code.";
                        status.BackColor = Color.Tomato;
                    }
                    else
                    {
                        if (cbManufacturer.SelectedItem.ToString().Equals("Others..."))
                        {
                            strManu = Program.getNextCode(aListCode[aListCode.Count - 2].ToString());
                        }
                        if (newManufacturer)
                        {
                            //save manufacturer to db
                            if (!string.IsNullOrWhiteSpace(txtManuName.Text))
                            {
                                if (!Program.ExecuteQuery("INSERT INTO tblManufacturer VALUES('" + strManu + "','" + txtManuName.Text + "');"))
                                {
                                    status.Text = "Failed to save manufacturer.";
                                    status.BackColor = Color.Tomato;
                                }
                            }
                            else
                            {
                                status.Text = "Manufacturer name can't be empty.";
                                status.BackColor = Color.Tomato;
                            }
                        }
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
                            loadManufacturer();
                            strCode = Program.getNextCode(strCode);
                            txtCode.Text = strCode;
                            txtCode.Enabled = false;
                            txtName.Clear();
                            txtName.Focus();
                            txtGen.Clear();
                            txtManu.Clear();
                            txtMin.Clear();
                            txtMax.Clear();
                            txtManuName.Clear();
                            if (cbManufacturer.Items != null)
                            {
                                cbManufacturer.SelectedIndex = 0;
                                txtManu.Text = aListCode[cbManufacturer.SelectedIndex].ToString();
                            }
                                
                            if (parent != null)
                                parent.updateTable();

                            status.Text = "Saved.";
                            status.BackColor = Color.LimeGreen;
                            if (choice == 1)
                                this.Dispose();
                        }
                        else
                        {
                            //fail
                            status.Text = "Failed to make changes.";
                            status.BackColor = Color.Tomato;
                        }
                    }
                }
            }
            else
            {
                //tell them it's not :(
                status.Text = "All fields are required.";
                status.BackColor = Color.Tomato;
            }
        }

        private void loadManufacturer()
        {
            newManufacturer = !mn.fillComboBox(cbManufacturer, "SELECT * FROM tblManufacturer;", out aListCode);
            if (newManufacturer)
            {
                cbManufacturer.Visible = false;
                txtManu.Visible = true;
                txtManuName.Enabled = true;
                lblManu1.Text = "Manufacturer Code : ";
                lblManu2.Text = "Manufacturer Name : ";
            }
            else
            {
                cbManufacturer.Items.Add("Others...");
                aListCode.Add("");
                cbManufacturer.Visible = true;
                txtManu.Visible = false;
                txtManuName.Enabled = false;
                lblManu1.Text = "Manufacturer Name : ";
                lblManu2.Text = "                    Others : ";
                cbManufacturer.SelectedIndex= 0;
            }
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            switch (this.itemType)
            {
                case 1:
                    this.icon.Image = global::PUPiMed.Properties.Resources.pill_teal;
                    Title.Text = "MEDICINE";
                    lblCode.Text = "Medicine Code: ";
                    break;
                case 2:
                    this.icon.Image = global::PUPiMed.Properties.Resources.supplies_teal;
                    Title.Text = "SUPPLY";
                    lblCode.Text = "Supply Code: ";
                    break;
                case 3:
                    this.icon.Image = global::PUPiMed.Properties.Resources.wheelchair_teal;
                    Title.Text = "EQUIPMENT";
                    lblCode.Text = "Equipment Code: ";
                    break;
            }
            loadManufacturer();
            if (choice == 1)
            {
                txtCode.Enabled = false;
                txtName.Focus();
            }
            else
            {
                getCode();
            }
        }

        private void getCode()
        {
            //check if theres an existing code
            string prevCode = Program.getPrevCode("SELECT * from tblItem WHERE intItemType=" + itemType + " ORDER by strItemCode DESC LIMIT 1;");
            if (string.IsNullOrEmpty(prevCode))
            {
                this.txtCode.Enabled = true;
                this.txtCode.Focus();
            }
            else
            {
                strCode = Program.getNextCode(prevCode);
                this.txtCode.Text = strCode;
                this.txtCode.Enabled = false;
                this.txtName.Focus();
            }
        }

        private void cbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbManufacturer.SelectedItem=="Others...")
            {
                txtManuName.Enabled = true;
                newManufacturer = true;
            }
            else
            {
                newManufacturer = false;
                txtManuName.Enabled = false;
                txtManu.Text = aListCode[cbManufacturer.SelectedIndex].ToString();
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            status.Text = "";
            status.BackColor = Color.DarkCyan;
        }
        private void txtCode_Click(object sender, EventArgs e)
        {
            status.Text = "";
            status.BackColor = Color.DarkCyan;
        }
        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
