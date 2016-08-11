using MetroFramework.Controls;
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
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            mpanel.Controls.Add(new UCItemInventory());
            StartTimer();
        }

        private void StartTimer()
        {
            Timer timer1 = null;
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToString();
        }



        private void mpLeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mtMedicine_Click(object sender, EventArgs e)
        {

            MetroTile tile = sender as MetroTile;
            //tile.BackColor = System.Drawing.Color.Firebrick;
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCItemMedicine());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mtAdmin_Click(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            //tile.BackColor = System.Drawing.Color.Firebrick;
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCFacultyTab());
        }

        private void mtSupplies_Click(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            //tile.BackColor = System.Drawing.Color.Firebrick;
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCItemSupply());
        }

        private void mtEquipment_Click(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            //tile.BackColor = System.Drawing.Color.Firebrick;
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCItemEquipment());
        }

        private void mtDistribute_Click(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            //tile.BackColor = System.Drawing.Color.Firebrick;
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCItemDistribution());
        }

        private void mtStudent_Click(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            //tile.BackColor = System.Drawing.Color.Firebrick;
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCStudentTab());
        }

        private void mtFaculty_Click(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            //tile.BackColor = System.Drawing.Color.Firebrick;
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCAdminTab());
        }

        private void mtReceive_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void gridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tilelogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mtInventory_Click(object sender, EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            //tile.BackColor = System.Drawing.Color.Firebrick;
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCItemInventory());
        }

        private void mtPatient_Click(object sender, EventArgs e)
        {
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCPatientLogs_DTR_());
        }

        private void ItemLibrary_Click(object sender, EventArgs e)
        {
            mpanel.Controls.Clear();
            mpanel.Controls.Add(new UCItemLibrary());
        }

        private void mpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
