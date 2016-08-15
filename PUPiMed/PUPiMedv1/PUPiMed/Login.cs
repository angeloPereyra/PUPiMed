using MetroFramework.Forms;
using System;

namespace PUPiMed
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void btnLOGIN_Click(object sender, System.EventArgs e)
        {
            new MainForm().ShowDialog();
        }

        private void Login_Load(object sender, System.EventArgs e)
        {
            StartTimer();
        }
        private void StartTimer()
        {
            System.Windows.Forms.Timer timer1 = null;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
