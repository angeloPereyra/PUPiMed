using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace PUPiMed
{
    public partial class UCItem : UserControl
    {
        int itemType;
        string strItem;
        FormAddItem itemForm;

        public UCItem(int itemType)
        {
            this.itemType = itemType;
            InitializeComponent();
        }

        private void ucMedicine_Load(object sender, EventArgs e)
        {
            switch (this.itemType)
            {
                case 1:
                    this.icon.Image = global::PUPiMed.Properties.Resources.mecidine_teal;
                    title.Text = "MEDICINES";
                    strItem = "Medicine";
                    break;
                case 2:
                    this.icon.Image = global::PUPiMed.Properties.Resources.supplies_teal;
                    title.Text = "SUPPLIES";
                    strItem = "Supply";
                    break;
                case 3:
                    this.icon.Image = global::PUPiMed.Properties.Resources.wheelchair_teal;
                    title.Text = "EQUIPMENT";
                    strItem = "Equipment";
                    break;
            }
            updateTable();
        }

        public void updateTable()
        {
            using (Program.conn)
            { 
                using (MySqlCommand cmd = new MySqlCommand("SELECT strItemCode AS '" + strItem + " Code', strItemName AS '" + strItem + "', strItemGeneric AS 'Generic Name', b.strManuName AS Manufacturer, intItemMin as Min, intItemMax as Max FROM tblItem, tblManufacturer b WHERE (intItemType=" + itemType + " AND boolItemDeleted=0 AND strItemManuCode=b.strManuCode);", Program.conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            if (dt != null)
                            {
                                sda.Fill(dt);
                                grid.DataSource = dt;
                            }else
                            {
                                
                            }
                                
                        }
                    }
                }
            }
        }

        private void mbView_Click(object sender, EventArgs e)
        {
            if(grid.CurrentRow!=null)
            {
                itemForm = new FormAddItem(this, itemType);
                itemForm.choice = 1;
                itemForm.txtCode.Text = grid.CurrentRow.Cells[0].Value.ToString();
                itemForm.txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
                itemForm.txtGen.Text = grid.CurrentRow.Cells[2].Value.ToString();
                itemForm.txtManu.Text = grid.CurrentRow.Cells[3].Value.ToString();
                itemForm.txtMin.Text = grid.CurrentRow.Cells[4].Value.ToString();
                itemForm.txtMax.Text = grid.CurrentRow.Cells[5].Value.ToString();

                itemForm.ShowDialog();
            }
            
        }
        private void mbAdd_Click(object sender, EventArgs e)
        {
            itemForm = new FormAddItem(this, itemType);
            itemForm.choice = 0;
            itemForm.ShowDialog();
        }

        private void deletemedicine_Click(object sender, EventArgs e)
        {
            var result = MetroMessageBox.Show(this.Parent.Parent ,"Are you sure?", "DELETE CONFIRMATION",MessageBoxButtons.YesNo,MessageBoxIcon.None);
            if (result == DialogResult.Yes)
            {
                string strQuery;
                string col1;
                if (grid.CurrentRow.Cells[0] != null)
                {
                    col1 = grid.CurrentRow.Cells[0].Value.ToString();

                    strQuery = "UPDATE tblItem SET boolItemDeleted=1 WHERE strItemCode = '" + col1 + "';";

                    if (Program.ExecuteQuery(strQuery))
                    {
                        //success
                        updateTable();
                    }
                    else
                    {
                        //fail
                    }
                }
            }
            
        }
    }
}
