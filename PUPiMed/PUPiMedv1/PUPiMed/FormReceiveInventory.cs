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
        UCItemInventory parent;
        ArrayList alistCode, alistCode1;
        ComboBoxFn mn = new ComboBoxFn();
        string strType, strCode, strName, strQty, strSupplier, strExp, strRDate, strRCode;

        public FormReceiveInventory(UCItemInventory parent)
        {
            this.parent = parent;
            InitializeComponent();
            cbType.SelectedIndex = 0;
            loadItemComboBox(cbType.SelectedIndex+1);
            loadSupplierComboBox();
        }

        private void loadItemComboBox(int type)
        {
            if (!mn.fillComboBox(cbName, "SELECT strItemCode, strItemName FROM tblItem WHERE intItemType="+type+" AND boolItemDeleted=FALSE;", out alistCode))
            {
                pbAddItem.Focus();
                txtCode.Text = "";
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
            this.parent.updateTable();
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
            string[] row = new string[5];
            int qty;
            if (!detailIsOkay())
            {
                MetroMessageBox.Show(this, "Please fill in the required fields before adding.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ((Int32.TryParse(strQty, out qty)))
                {
                    if (listReceived.FindItemWithText(strCode)==null)
                    {
                        row[0] = strType;
                        row[1] = strCode;
                        row[2] = strName;
                        row[3] = strQty;
                        row[4] = strExp;
                        listReceived.Items.Add(new ListViewItem(row));
                        cbType.SelectedIndex = 0;
                        cbName.SelectedIndex = 0;
                        txtQty.Clear();
                        dtExp.Value = DateTime.Today;
                        cbType.Focus();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Duplicate entry for " + strName + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Please enter a numeric value for 'Quantity'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormReceiveInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (headerIsOkay())
            {
                if (listReceived.Items.Count>0)
                {
                    if (saveHeader())
                    {
                        if (saveDetail())
                        {
                            MetroMessageBox.Show(this, "Success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            clearFields();
                        }

                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Please add an item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Please fill in the required fields before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool saveHeader()
        {
            string strQuery = "INSERT INTO tblReceiving VALUES('"+strRCode+"','"+alistCode1[cbSupplier.SelectedIndex]+"','"+strRDate+"');";
            if (!Program.ExecuteQuery(strQuery))
            {
                return false;
            }
            return true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem row in listReceived.SelectedItems)
            {
                listReceived.Items.Remove(row);

                cbType.SelectedItem = row.SubItems[0].Text;
                txtCode.Text = row.SubItems[1].Text;
                cbName.SelectedItem = row.SubItems[2].Text;
                txtQty.Text = row.SubItems[3].Text;
                dtExp.Value = DateTime.Parse(row.SubItems[4].Text);

            }
        }

        private bool saveDetail()
        {
            string strQuery;
            foreach (ListViewItem row in listReceived.Items)
            {
                strQuery =
                    "INSERT INTO tblReceDetail VALUES ('"
                    + strRCode + "','"
                    + row.SubItems[1].Text + "',"
                    + row.SubItems[3].Text + ",'"
                    + row.SubItems[4].Text
                    + "');";
                //MessageBox.Show(strQuery);
                if (!Program.ExecuteQuery(strQuery))
                {
                    return false;
                }
            }
            return true;
        }
       
        private void clearFields()
        {
            cbType.SelectedIndex = 0;
            loadItemComboBox(1);
            loadSupplierComboBox();
            txtQty.Clear();
            txtRCode.Clear();
            dtExp.Value = DateTime.Today;
            dtReceived.Value = DateTime.Today;
            listReceived.Items.Clear();
            cbType.Focus();

        }
         
        private void pbAddSupplier_Click(object sender, EventArgs e)
        {
            new FormAddSupplier().ShowDialog();
            loadSupplierComboBox();
        }


        private bool headerIsOkay()
        {
            strRCode = txtRCode.Text;
            strRDate = dtReceived.Value.ToString("yyyy-MM-dd");
            strSupplier = cbSupplier.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(strRCode) || string.IsNullOrWhiteSpace(strRDate) || string.IsNullOrWhiteSpace(strSupplier))
            {
                return false;
            }
            return true;
        }
        

        private bool detailIsOkay()
        {
            strType = cbType.SelectedItem.ToString();
            strCode = txtCode.Text;
            strName = cbName.SelectedItem.ToString();
            strQty = txtQty.Text;
            strExp = dtExp.Value.ToString("yyyy-MM-dd");
            
            if (string.IsNullOrWhiteSpace(strType) || string.IsNullOrWhiteSpace(strCode)|| string.IsNullOrWhiteSpace(strName)|| string.IsNullOrWhiteSpace(strQty) || string.IsNullOrWhiteSpace(strExp))
            {
                return false;
            }
           return true;
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