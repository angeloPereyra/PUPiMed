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
    public partial class UCItemEquipment : UserControl
    {
        FormAddEquipment equipmentForm;
        public UCItemEquipment()
        {
            InitializeComponent();
        }

        private void addequipment_Click(object sender, EventArgs e)
        {
            equipmentForm = new FormAddEquipment(this);
            equipmentForm.choice = 0;
            equipmentForm.Show();
        }

        private void editequipment_Click(object sender, EventArgs e)
        {
            if (gridEquipment.CurrentRow != null)
            {
                equipmentForm = new FormAddEquipment(this);
                equipmentForm.choice = 1;
                equipmentForm.txtCode.Text = gridEquipment.CurrentRow.Cells[0].Value.ToString();
                equipmentForm.txtName.Text = gridEquipment.CurrentRow.Cells[1].Value.ToString();
                equipmentForm.txtGen.Text = gridEquipment.CurrentRow.Cells[2].Value.ToString();
                equipmentForm.txtManu.Text = gridEquipment.CurrentRow.Cells[3].Value.ToString();
                equipmentForm.txtMin.Text = gridEquipment.CurrentRow.Cells[4].Value.ToString();
                equipmentForm.txtMax.Text = gridEquipment.CurrentRow.Cells[5].Value.ToString();

                equipmentForm.Show();
            }
            
        }

        private void deleteequipment_Click(object sender, EventArgs e)
        {


            if (gridEquipment.CurrentRow != null)
            {
                var result = MetroMessageBox.Show(this.Parent.Parent, "Are you sure?", "DELETE CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (result == DialogResult.Yes)
                {
                    string strQuery;
                    string col1;
                    if (gridEquipment.CurrentRow.Cells[0] != null)
                    {
                        col1 = gridEquipment.CurrentRow.Cells[0].Value.ToString();

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

        private void UCEquipment_Load(object sender, EventArgs e)
        {
            updateTable();
        }
        public void updateTable()
        {
            using (Program.conn)
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT strItemCode AS Equipment_Code,strItemName AS Equipment,strItemGeneric AS Generic_Name, strItemManuCode AS Manufacturer, intItemMin as Min, intItemMax as Max FROM tblItem WHERE (intItemType=3 AND boolItemDeleted=0);", Program.conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            if (dt != null)
                            {
                                sda.Fill(dt);
                                gridEquipment.DataSource = dt;
                            }
                            else
                            {

                            }

                        }
                    }
                }
            }
        }
    }
}
