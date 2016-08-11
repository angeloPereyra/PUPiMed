using MetroFramework.Forms;
using System;
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
        public FormReceiveInventory()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
            //cbItem.SelectedIndex = 0;
            //cbSupplier.SelectedIndex = 0;

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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        
    }
}
