using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace PUPiMed
{
    public partial class UCItem : UserControl
    {
        
        public UCItem()
        {
            InitializeComponent();
        }
        FormAddMedicine medicineForm;

        private void ucMedicine_Load(object sender, EventArgs e)
        {
            updateTable();
        }

        public void updateTable()
        {
            using (Program.conn)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT strItemCode AS 'Medicine Code', strItemName AS Medicine, strItemGeneric AS 'Generic Name', b.strManuName AS Manufacturer, intItemMin as Min, intItemMax as Max FROM tblItem, tblManufacturer b WHERE (intItemType=1 AND boolItemDeleted=0 AND strItemManuCode=b.strManuCode);", Program.conn))
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
                medicineForm = new FormAddMedicine(this);
                medicineForm.choice = 1;
                medicineForm.txtCode.Text = grid.CurrentRow.Cells[0].Value.ToString();
                medicineForm.txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
                medicineForm.txtGen.Text = grid.CurrentRow.Cells[2].Value.ToString();
                medicineForm.txtManu.Text = grid.CurrentRow.Cells[3].Value.ToString();
                medicineForm.txtMin.Text = grid.CurrentRow.Cells[4].Value.ToString();
                medicineForm.txtMax.Text = grid.CurrentRow.Cells[5].Value.ToString();

                medicineForm.Show();
            }
            
        }
        private void mbAdd_Click(object sender, EventArgs e)
        {
            medicineForm = new FormAddMedicine(this);
            medicineForm.choice = 0;
            medicineForm.Show();
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
