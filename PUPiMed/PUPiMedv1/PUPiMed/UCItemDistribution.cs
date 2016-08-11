using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUPiMed
{
    public partial class UCItemDistribution : UserControl
    {
        public UCItemDistribution()
        {
            InitializeComponent();
        }

        private void gridDistribution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void AddDistibItem_Click(object sender, EventArgs e)
        {
            new FormAddDistribItem().Show();
        }
    }
}
