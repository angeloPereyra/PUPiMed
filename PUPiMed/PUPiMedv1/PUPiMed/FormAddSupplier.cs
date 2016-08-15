
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormAddSupplier : MetroForm
    {
        public FormAddSupplier()
        {
            InitializeComponent();
            getCode();
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            status.Text = "";
            status.BackColor = Color.DarkCyan;
        }

        string strCode, strName, strACode, strContact, strEmail, strNo, strStreet, strTown, strCity;
        
        private bool everythingIsOkay()
        {
            strCode = txtCode.Text;
            strName = txtName.Text;
            strContact = txtContact.Text;
            strEmail = txtEmail.Text;
            strNo = txtNo.Text;
            strStreet = txtStreet.Text;
            strTown = txtTown.Text;
            strCity = txtCity.Text;

            if (string.IsNullOrEmpty(strCode)|| string.IsNullOrEmpty(strName) || string.IsNullOrEmpty(strContact) || string.IsNullOrEmpty(strEmail) || string.IsNullOrEmpty(strNo) || string.IsNullOrEmpty(strStreet) || string.IsNullOrEmpty(strTown) || string.IsNullOrEmpty(strCity))
            {
                //check if email is valid
                 return false;
            }
            return true;
        }
        private bool addressIsOkay()
        {
            //check if there's a prev address code
            //default ADDR-000
            //increment if there's one
            string prevCode = Program.getPrevCode("SELECT * from tblAddress ORDER by strAddrCode DESC LIMIT 1;");
            if (string.IsNullOrEmpty(prevCode))
            {
                strACode = "ADDR-000";
            }
            else
            {
                strACode = Program.getNextCode(prevCode);
            }
            
            return saveAddress();
        }
        private bool saveAddress()
        {
            if (!Program.ExecuteQuery("INSERT INTO tblAddress VALUES('" + strACode + "','" + strNo + "','" + strStreet + "','" + strTown + "','" + strCity + "');"))
            {
                status.Text =  "Failed to save address.";
                return false;
            }
            return true;
        }
        private void getCode()
        {
            string prevCode = Program.getPrevCode("SELECT * from tblDistributor ORDER by strDistCode DESC LIMIT 1;");
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (everythingIsOkay())
            {
                if (addressIsOkay())
                {
                    if (string.IsNullOrEmpty(Program.getNextCode(strCode)))
                    {
                        txtCode.Focus();
                        status.Text = "Invalid code.";
                        status.BackColor = Color.Tomato;
                    }
                    else
                    {
                        //save to db
                        if (!Program.ExecuteQuery("INSERT INTO tblDistributor VALUES ('" + strCode + "','" + strName + "','" + strACode + "','" + strContact + "','" + strEmail + "'" + ");"))
                        {
                            //tell them something's wrong
                            status.Text = "Failed to save distributor.";
                            status.BackColor = Color.Tomato;
                        }
                        else
                        {

                            strCode = Program.getNextCode(strCode);
                            txtCode.Text = strCode;
                            txtName.Clear();
                            txtName.Focus();
                            txtContact.Clear();
                            txtEmail.Clear();
                            txtNo.Clear();
                            txtStreet.Clear();
                            txtTown.Clear();
                            txtCity.Clear();
                            status.Text = "Saved.";
                            status.BackColor = Color.LimeGreen;
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
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
