using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormReceiveInventory : MetroForm
    {
        ArrayList alistCode;
        Manufacturer mn = new Manufacturer();

        public FormReceiveInventory()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
            if (!mn.fillComboBox( cbName, "SELECT strItemCode, strItemName FROM tblItem WHERE intItemType=1 AND boolItemDeleted=FALSE;", out alistCode))
            {
                //cbName.Items.Add("[Empty Library]");
                pbAddItem.Focus();
            }
            else
            {
                txtCode.Text = alistCode[0].ToString();
                
                //cbItem.SelectedIndex = 0;
                //cbSupplier.SelectedIndex = 0;
            }cbName.SelectedIndex = 0;


        }

        private void gridRI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void pbAddItem_Click(object sender, EventArgs e)
        {
            if (cbType != null)
            {
                if (cbType.SelectedItem.Equals("Medicine"))
                    new AddMedicine().Show();
                else if (cbType.SelectedItem.Equals("Supply"))
                    new AddSupply().Show();
                else if (cbType.SelectedItem.Equals("Equipment"))
                    new AddEquipment().Show();
                else 
                    cbType.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(getValues())
            {

            }
        }

        private bool getValues()
        {
            bool okay = true;
            strType = cbType.SelectedItem.ToString();
            strCode = txtCode.Text;
            strName = cbName.SelectedItem.ToString();
            strQty = txtQty.Text;
            strSupplier = cbSupplier.SelectedItem.ToString();
            strDate = dtReceived.Value.ToString();

            if(string.IsNullOrEmpty(strType)|| string.IsNullOrEmpty(strCode)|| string.IsNullOrEmpty(strName)
                || string.IsNullOrEmpty(strQty)|| string.IsNullOrEmpty(strSupplier)|| string.IsNullOrEmpty(strDate))
            {
                okay = false;
            }

           return okay;
        }

        string strType, strCode, strName, strQty, strSupplier, strDate;

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem.Equals("Medicine"))
            {
                if (!mn.fillComboBox( cbName, "SELECT strItemCode, strItemName FROM tblItem WHERE intItemType=1 AND boolItemDeleted=0;", out alistCode))
                {
                    //cbName.Items.Add("[Empty Library]");
                    pbAddItem.Focus();
                }
                else cbName.SelectedIndex = 0;
                    
            }
            else if (cbType.SelectedItem.Equals("Supply"))
            {
                if (!mn.fillComboBox( cbName, "SELECT strItemCode, strItemName FROM tblItem WHERE intItemType=2 AND boolItemDeleted=0;", out alistCode))
                {
                    //cbName.Items.Add("[Empty Library]");
                    pbAddItem.Focus();
                }
                else cbName.SelectedIndex = 0;
            }
            else if (cbType.SelectedItem.Equals("Equipment"))
            {
                if (!mn.fillComboBox( cbName, "SELECT strItemCode, strItemName FROM tblItem WHERE intItemType=3 AND boolItemDeleted=0;",out alistCode))
                {

                    //cbName.Items.Add("[Empty Library]");
                    pbAddItem.Focus();
                }
                else cbName.SelectedIndex = 0;
            }
            else
                cbType.Focus();
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbName.SelectedIndex<=alistCode.Count)
                txtCode.Text = alistCode[cbName.SelectedIndex].ToString();
        }
    }
}
