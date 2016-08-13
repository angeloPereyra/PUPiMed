using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormReceiveInventory : MetroForm
    {
        ArrayList alistCode;
        ComboBoxFn mn = new ComboBoxFn();
        string strType, strCode, strName, strQty, strSupplier, strDate;

        public FormReceiveInventory()
        {
            InitializeComponent();
            dtReceived.CustomFormat=  "d-MMM-yyyy hh:mm:ss";
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
                    new FormAddMedicine().Show();
                else if (cbType.SelectedItem.Equals("Supply"))
                    new FormAddSupply().Show();
                else if (cbType.SelectedItem.Equals("Equipment"))
                    new FormAddEquipment().Show();
                else 
                    cbType.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] row = new string[6];
            if(getValues())
            {
                row[0] = strType;
                row[1] = strCode;
                row[2] = strName;
                row[3] = strQty;
                row[4] = strSupplier;
                row[5] = strDate;

                listReceived.Items.Add(new ListViewItem(row));
            }
            else
            {
                row[0] = strType;
                row[1] = "Item Code";
                row[2] = "Item Name";
                row[3] = "Quantity";
                row[4] = "Supplier";
                row[5] = strDate;

                listReceived.Items.Add(new ListViewItem(row));
            }
        }

        private bool getValues()
        {
            bool okay = true;
            strType = cbType.SelectedItem.ToString();
            strCode = txtCode.Text;
            strName = cbName.SelectedItem.ToString();
            strQty = txtQty.Text;
            try
            {
                strSupplier = cbSupplier.SelectedItem.ToString();
            }catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message.ToString());
                okay = false;
            }            
            strDate = dtReceived.Value.ToString("yyyy-MM-dd HH:mm:ss");

            if(string.IsNullOrEmpty(strType)|| string.IsNullOrEmpty(strCode)|| string.IsNullOrEmpty(strName)
                || string.IsNullOrEmpty(strQty)|| string.IsNullOrEmpty(strSupplier)|| string.IsNullOrEmpty(strDate))
            {
                okay = false;
            }

           return okay;
        }


        private void dtReceived_ValueChanged(object sender, EventArgs e)
        {
            DateTime result = dtReceived.Value;
            strDate = result.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem row in listReceived.SelectedItems)
            {
                listReceived.Items.Remove(row);
            }
        }

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
            if(cbName.SelectedIndex<=alistCode.Count&&alistCode!=null)
                txtCode.Text = alistCode[cbName.SelectedIndex].ToString();
        }

        private void addToList(string[] row)
        {
            listReceived.Items.Add("Item Code").SubItems.AddRange(row);
        }
    }
}


/*
There are several ways to do it, but here is one solution (for 4 columns).

string[] row1 = { "s1", "s2", "s3" };
listView1.Items.Add("Column1Text").SubItems.AddRange(row1);
And a more verbose way is here:

ListViewItem item1 = new ListViewItem("Something");
item1.SubItems.Add("SubItem1a");
item1.SubItems.Add("SubItem1b");
item1.SubItems.Add("SubItem1c");

ListViewItem item2 = new ListViewItem("Something2");
item2.SubItems.Add("SubItem2a");
item2.SubItems.Add("SubItem2b");
item2.SubItems.Add("SubItem2c");

ListViewItem item3 = new ListViewItem("Something3");
item3.SubItems.Add("SubItem3a");
item3.SubItems.Add("SubItem3b");
item3.SubItems.Add("SubItem3c");

ListView1.Items.AddRange(new ListViewItem[] {item1,item2,item3});
*/