using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;

namespace PUPiMed
{
    public partial class UCItemSupply : UserControl
    {
        FormAddSupply supplyForm;

        public UCItemSupply()
        {
            InitializeComponent();
        }

        private void UCSUpply_Load(object sender, EventArgs e)
        {
            updateTable();
        }

        public void updateTable()
        {
            using (Program.conn)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT strItemCode AS Supply_Code,strItemName AS Supply,strItemGeneric AS Generic_Name, strItemManuCode AS Manufacturer, intItemMin as Min, intItemMax as Max FROM tblItem WHERE (intItemType=2 AND boolItemDeleted=0);", Program.conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            if (dt != null)
                            {
                                sda.Fill(dt);
                                gridSupply.DataSource = dt;
                            }
                            else
                            {

                            }

                        }
                    }
                }
            }
        }
        private void mbAdd_Click(object sender, EventArgs e)
        {
            supplyForm = new FormAddSupply(this);
            supplyForm.choice = 0;
            supplyForm.ShowDialog();
        }

        private void mbView_Click(object sender, EventArgs e)
        {
            if (gridSupply.CurrentRow != null)
            {
                supplyForm = new FormAddSupply(this);
                supplyForm.choice = 1;
                supplyForm.txtCode.Text = gridSupply.CurrentRow.Cells[0].Value.ToString();
                supplyForm.txtName.Text = gridSupply.CurrentRow.Cells[1].Value.ToString();
                supplyForm.txtGen.Text = gridSupply.CurrentRow.Cells[2].Value.ToString();
                supplyForm.txtManu.Text = gridSupply.CurrentRow.Cells[3].Value.ToString();
                supplyForm.txtMin.Text = gridSupply.CurrentRow.Cells[4].Value.ToString();
                supplyForm.txtMax.Text = gridSupply.CurrentRow.Cells[5].Value.ToString();

                supplyForm.ShowDialog();
            }
            
        }

        private void mbDelete_Click(object sender, EventArgs e)
        {
            if (gridSupply.CurrentRow != null)
            {
                var result = MetroMessageBox.Show(this.Parent.Parent, "Are you sure?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (result == DialogResult.Yes)
                {
                    string strQuery;
                    string col1;
                    if (gridSupply.CurrentRow.Cells[0] != null)
                    {
                        col1 = gridSupply.CurrentRow.Cells[0].Value.ToString();

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
}
