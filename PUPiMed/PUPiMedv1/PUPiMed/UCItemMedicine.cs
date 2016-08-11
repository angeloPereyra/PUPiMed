using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace PUPiMed
{
    public partial class UCItemMedicine : UserControl
    {
        
        public UCItemMedicine()
        {
            InitializeComponent();
        }
        AddMedicine medicineForm;

        private void ucMedicine_Load(object sender, EventArgs e)
        {
            updateTable();
        }

        public void updateTable()
        {
            using (Program.conn)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT strItemCode AS Medicine_Code,strItemName AS Medicine,strItemGeneric AS Generic_Name, strItemManuCode AS Manufacturer, intItemMin as Min, intItemMax as Max FROM tblItem WHERE (intItemType=1 AND boolItemDeleted=0);", Program.conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            if (dt != null)
                            {
                                sda.Fill(dt);
                                gridMedicine.DataSource = dt;
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
            if(gridMedicine.CurrentRow!=null)
            {
                medicineForm = new AddMedicine(this);
                medicineForm.choice = 1;
                medicineForm.txtCode.Text = gridMedicine.CurrentRow.Cells[0].Value.ToString();
                medicineForm.txtName.Text = gridMedicine.CurrentRow.Cells[1].Value.ToString();
                medicineForm.txtGen.Text = gridMedicine.CurrentRow.Cells[2].Value.ToString();
                medicineForm.txtManu.Text = gridMedicine.CurrentRow.Cells[3].Value.ToString();
                medicineForm.txtMin.Text = gridMedicine.CurrentRow.Cells[4].Value.ToString();
                medicineForm.txtMax.Text = gridMedicine.CurrentRow.Cells[5].Value.ToString();

                medicineForm.Show();
            }
            
        }
        private void mbAdd_Click(object sender, EventArgs e)
        {
            medicineForm = new AddMedicine(this);
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
                if (gridMedicine.CurrentRow.Cells[0] != null)
                {
                    col1 = gridMedicine.CurrentRow.Cells[0].Value.ToString();

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
