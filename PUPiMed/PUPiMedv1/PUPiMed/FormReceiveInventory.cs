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
        ArrayList alistCode, alistCode1;
        ComboBoxFn mn = new ComboBoxFn();
        string strType, strCode, strName, strQty, strSupplier, strDate, strRCode;

        public FormReceiveInventory()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
            loadItemComboBox(cbType.SelectedIndex+1);
            loadSupplierComboBox();
        }

        private void loadItemComboBox(int type)
        {
            if (!mn.fillComboBox(cbName, "SELECT strItemCode, strItemName FROM tblItem WHERE intItemType="+type+" AND boolItemDeleted=FALSE;", out alistCode))
            {
                //cbName.Items.Add("[Empty Library]");
                pbAddItem.Focus();
            }
            else
            {
                txtCode.Text = alistCode[0].ToString();
                cbName.SelectedIndex = 0;
                
            }
            cbName.SelectedIndex = 0;

        }

        private void loadSupplierComboBox()
        {
            if (!mn.fillComboBox(cbSupplier, "SELECT strDistCode, strDistName FROM tblDistributor;", out alistCode1))
            {
                pbAddSupplier.Focus();
            }
            else
            {
                cbSupplier.SelectedIndex = 0;
            }
            cbSupplier.SelectedIndex = 0;
        }

        private void gridRI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pbAddItem_Click(object sender, EventArgs e)
        {
            if (cbType != null)
            {
                if (cbType.SelectedItem.Equals("Medicine"))
                    new FormAddItem(1).ShowDialog();
                else if (cbType.SelectedItem.Equals("Supply"))
                    new FormAddItem(2).ShowDialog();
                else if (cbType.SelectedItem.Equals("Equipment"))
                    new FormAddItem(3).ShowDialog();
                else 
                    cbType.Focus();
                loadItemComboBox(cbType.SelectedIndex + 1);
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
                //row[4] = strSupplier;
                //row[5] = strDate;

                listReceived.Items.Add(new ListViewItem(row));
            }
            else
            {
                row[0] = strType;
                row[1] = "Item Code";
                row[2] = "Item Name";
                row[3] = "Quantity";
                //row[4] = "Supplier";
                //row[5] = strDate;

                listReceived.Items.Add(new ListViewItem(row));
            }
        }

        private void FormReceiveInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        
        private void pbAddSupplier_Click(object sender, EventArgs e)
        {
            new FormAddSupplier().ShowDialog();
            loadSupplierComboBox();
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
            strDate = dtReceived.Value.ToString("yyyy-MM-dd");

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
            if (!mn.fillComboBox(cbName, "SELECT strItemCode, strItemName FROM tblItem WHERE intItemType="+(cbType.SelectedIndex+1)+" AND boolItemDeleted=0;", out alistCode))
            {
                pbAddItem.Focus();
            }
            else cbName.SelectedIndex = 0;
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