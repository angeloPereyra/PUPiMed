using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class FormAddDistribItem : MetroForm
    {

        UCItemDistribution parent;
        ArrayList alistCode;
        ComboBoxFn mn = new ComboBoxFn();
        string strType, strCode, strName, strQty, strSupplier, strExp, strRDate, strRCode;

        public FormAddDistribItem(UCItemDistribution parent)
        {
            InitializeComponent();
            this.parent = parent;
            cbType.SelectedIndex = 0;
            cbUOM.SelectedIndex = 0;
            cbType.Focus();
        }

        private void FormAddDistribItem_Load(object sender, EventArgs e)
        {

        }

        private void UOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Success.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
   
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //this.parent.updateTable();
            this.Dispose();
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbName.SelectedIndex <= alistCode.Count && alistCode != null)
                txtCode.Text = alistCode[cbName.SelectedIndex].ToString();
        }

        private void loadItemComboBox(int type)
        {
            if (!mn.fillComboBox(cbName, "SELECT strItemCode, strItemName FROM tblItem WHERE intItemType=" + type + " AND boolItemDeleted=FALSE;", out alistCode))
            {
                txtCode.Text = "";
            }
            else
            {
                txtCode.Text = alistCode[0].ToString();
            }
            cbName.SelectedIndex = 0;

        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!mn.fillComboBox(cbName, "SELECT strItemCode, strItemName FROM tblItem WHERE intItemType=" + (cbType.SelectedIndex + 1) + " AND boolItemDeleted=0;", out alistCode))
            {
                status.Text = "No available item";
                status.BackColor = Color.Tomato;
            }
            else
            {
                cbName.SelectedIndex = 0;
                status.Text = "";
                status.BackColor = Color.DarkCyan;
            }
        }
    }
}
