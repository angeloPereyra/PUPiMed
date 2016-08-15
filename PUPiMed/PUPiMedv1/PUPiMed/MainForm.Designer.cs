using MetroFramework.Controls;
using System.Drawing;

namespace PUPiMed
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mpLeftPanel = new MetroFramework.Controls.MetroPanel();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.mtDistribute = new MetroFramework.Controls.MetroTile();
            this.picItemDistribution = new System.Windows.Forms.PictureBox();
            this.mtPatientRecords = new MetroFramework.Controls.MetroTile();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.mtItemLibrary = new MetroFramework.Controls.MetroTile();
            this.picItemLibrary = new System.Windows.Forms.PictureBox();
            this.mtLogout = new MetroFramework.Controls.MetroTile();
            this.mtAdmin = new MetroFramework.Controls.MetroTile();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.mtFaculty = new MetroFramework.Controls.MetroTile();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.mtStudent = new MetroFramework.Controls.MetroTile();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.mtPatient = new MetroFramework.Controls.MetroTile();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.mtEquipment = new MetroFramework.Controls.MetroTile();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.mtSupplies = new MetroFramework.Controls.MetroTile();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mtMedicine = new MetroFramework.Controls.MetroTile();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mtInventory = new MetroFramework.Controls.MetroTile();
            this.picItemInventory = new System.Windows.Forms.PictureBox();
            this.mpanel = new MetroFramework.Controls.MetroPanel();
            this.mpLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.mtDistribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemDistribution)).BeginInit();
            this.mtPatientRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.mtItemLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemLibrary)).BeginInit();
            this.mtAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.mtFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.mtStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.mtPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.mtEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.mtSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.mtMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mtInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // mpLeftPanel
            // 
            this.mpLeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mpLeftPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mpLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mpLeftPanel.Controls.Add(this.lblTime);
            this.mpLeftPanel.Controls.Add(this.picLogo);
            this.mpLeftPanel.Controls.Add(this.mtDistribute);
            this.mpLeftPanel.Controls.Add(this.mtPatientRecords);
            this.mpLeftPanel.Controls.Add(this.mtItemLibrary);
            this.mpLeftPanel.Controls.Add(this.mtLogout);
            this.mpLeftPanel.Controls.Add(this.mtAdmin);
            this.mpLeftPanel.Controls.Add(this.mtFaculty);
            this.mpLeftPanel.Controls.Add(this.mtStudent);
            this.mpLeftPanel.Controls.Add(this.mtPatient);
            this.mpLeftPanel.Controls.Add(this.mtEquipment);
            this.mpLeftPanel.Controls.Add(this.mtSupplies);
            this.mpLeftPanel.Controls.Add(this.mtMedicine);
            this.mpLeftPanel.Controls.Add(this.mtInventory);
            this.mpLeftPanel.HorizontalScrollbarBarColor = true;
            this.mpLeftPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpLeftPanel.HorizontalScrollbarSize = 10;
            this.mpLeftPanel.Location = new System.Drawing.Point(-1, -2);
            this.mpLeftPanel.Name = "mpLeftPanel";
            this.mpLeftPanel.Size = new System.Drawing.Size(292, 678);
            this.mpLeftPanel.Style = MetroFramework.MetroColorStyle.Red;
            this.mpLeftPanel.TabIndex = 0;
            this.mpLeftPanel.UseCustomBackColor = true;
            this.mpLeftPanel.UseStyleColors = true;
            this.mpLeftPanel.VerticalScrollbarBarColor = true;
            this.mpLeftPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpLeftPanel.VerticalScrollbarSize = 10;
            this.mpLeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mpLeftPanel_Paint);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(148, 639);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(129, 19);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "0000-00-00 00:00:00";
            this.lblTime.UseCustomBackColor = true;
            this.lblTime.UseCustomForeColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::PUPiMed.Properties.Resources.Patient_Logs_and_Inventory_System_Logo_teal;
            this.picLogo.Location = new System.Drawing.Point(0, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(288, 133);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // mtDistribute
            // 
            this.mtDistribute.ActiveControl = null;
            this.mtDistribute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtDistribute.BackColor = System.Drawing.Color.Teal;
            this.mtDistribute.Controls.Add(this.picItemDistribution);
            this.mtDistribute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtDistribute.ForeColor = System.Drawing.Color.White;
            this.mtDistribute.Location = new System.Drawing.Point(5, 182);
            this.mtDistribute.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtDistribute.Name = "mtDistribute";
            this.mtDistribute.Size = new System.Drawing.Size(283, 48);
            this.mtDistribute.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtDistribute.TabIndex = 9;
            this.mtDistribute.Text = "         Item Distribution";
            this.mtDistribute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtDistribute.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtDistribute.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDistribute.UseCustomBackColor = true;
            this.mtDistribute.UseCustomForeColor = true;
            this.mtDistribute.UseSelectable = true;
            this.mtDistribute.Click += new System.EventHandler(this.mtDistribute_Click);
            this.mtDistribute.MouseEnter += new System.EventHandler(this.main_MouseEnter);
            this.mtDistribute.MouseLeave += new System.EventHandler(this.main_MouseExit);
            // 
            // picItemDistribution
            // 
            this.picItemDistribution.Image = global::PUPiMed.Properties.Resources.deliver_white;
            this.picItemDistribution.Location = new System.Drawing.Point(12, 7);
            this.picItemDistribution.Name = "picItemDistribution";
            this.picItemDistribution.Size = new System.Drawing.Size(42, 34);
            this.picItemDistribution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItemDistribution.TabIndex = 0;
            this.picItemDistribution.TabStop = false;
            this.picItemDistribution.Click += new System.EventHandler(this.mtDistribute_Click);
            // 
            // mtPatientRecords
            // 
            this.mtPatientRecords.ActiveControl = null;
            this.mtPatientRecords.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtPatientRecords.BackColor = System.Drawing.Color.Teal;
            this.mtPatientRecords.Controls.Add(this.pictureBox10);
            this.mtPatientRecords.Cursor = System.Windows.Forms.Cursors.Default;
            this.mtPatientRecords.ForeColor = System.Drawing.Color.White;
            this.mtPatientRecords.Location = new System.Drawing.Point(5, 454);
            this.mtPatientRecords.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtPatientRecords.Name = "mtPatientRecords";
            this.mtPatientRecords.Size = new System.Drawing.Size(283, 48);
            this.mtPatientRecords.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPatientRecords.TabIndex = 8;
            this.mtPatientRecords.Text = "         Patient Records";
            this.mtPatientRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtPatientRecords.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPatientRecords.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPatientRecords.UseCustomBackColor = true;
            this.mtPatientRecords.UseCustomForeColor = true;
            this.mtPatientRecords.UseSelectable = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::PUPiMed.Properties.Resources.save1;
            this.pictureBox10.Location = new System.Drawing.Point(24, 8);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(28, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // mtItemLibrary
            // 
            this.mtItemLibrary.ActiveControl = null;
            this.mtItemLibrary.AllowDrop = true;
            this.mtItemLibrary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtItemLibrary.BackColor = System.Drawing.Color.Teal;
            this.mtItemLibrary.Controls.Add(this.picItemLibrary);
            this.mtItemLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtItemLibrary.ForeColor = System.Drawing.Color.White;
            this.mtItemLibrary.Location = new System.Drawing.Point(5, 233);
            this.mtItemLibrary.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtItemLibrary.Name = "mtItemLibrary";
            this.mtItemLibrary.Size = new System.Drawing.Size(283, 48);
            this.mtItemLibrary.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtItemLibrary.TabIndex = 13;
            this.mtItemLibrary.Text = "         Item Library";
            this.mtItemLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtItemLibrary.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtItemLibrary.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtItemLibrary.UseCustomBackColor = true;
            this.mtItemLibrary.UseCustomForeColor = true;
            this.mtItemLibrary.UseSelectable = true;
            this.mtItemLibrary.Click += new System.EventHandler(this.ItemLibrary_Click);
            this.mtItemLibrary.MouseEnter += new System.EventHandler(this.main_MouseEnter);
            this.mtItemLibrary.MouseLeave += new System.EventHandler(this.main_MouseExit);
            // 
            // picItemLibrary
            // 
            this.picItemLibrary.Image = global::PUPiMed.Properties.Resources.library_white;
            this.picItemLibrary.Location = new System.Drawing.Point(16, 10);
            this.picItemLibrary.Name = "picItemLibrary";
            this.picItemLibrary.Size = new System.Drawing.Size(35, 33);
            this.picItemLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItemLibrary.TabIndex = 0;
            this.picItemLibrary.TabStop = false;
            this.picItemLibrary.Click += new System.EventHandler(this.ItemLibrary_Click);
            // 
            // mtLogout
            // 
            this.mtLogout.AccessibleName = "Logout";
            this.mtLogout.ActiveControl = null;
            this.mtLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mtLogout.Location = new System.Drawing.Point(16, 637);
            this.mtLogout.Name = "mtLogout";
            this.mtLogout.Size = new System.Drawing.Size(98, 23);
            this.mtLogout.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtLogout.TabIndex = 10;
            this.mtLogout.Text = "LOG OUT";
            this.mtLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtLogout.TileImage = global::PUPiMed.Properties.Resources.logout;
            this.mtLogout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtLogout.UseCustomBackColor = true;
            this.mtLogout.UseCustomForeColor = true;
            this.mtLogout.UseSelectable = true;
            this.mtLogout.UseStyleColors = true;
            this.mtLogout.UseTileImage = true;
            this.mtLogout.Click += new System.EventHandler(this.tilelogout_Click);
            // 
            // mtAdmin
            // 
            this.mtAdmin.ActiveControl = null;
            this.mtAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mtAdmin.Controls.Add(this.pictureBox9);
            this.mtAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtAdmin.ForeColor = System.Drawing.Color.White;
            this.mtAdmin.Location = new System.Drawing.Point(5, 584);
            this.mtAdmin.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtAdmin.Name = "mtAdmin";
            this.mtAdmin.Size = new System.Drawing.Size(283, 38);
            this.mtAdmin.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtAdmin.TabIndex = 7;
            this.mtAdmin.Text = "              > Admin";
            this.mtAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtAdmin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtAdmin.UseCustomBackColor = true;
            this.mtAdmin.UseCustomForeColor = true;
            this.mtAdmin.UseSelectable = true;
            this.mtAdmin.UseStyleColors = true;
            this.mtAdmin.Click += new System.EventHandler(this.mtFaculty_Click);
            this.mtAdmin.MouseEnter += new System.EventHandler(this.sub_MouseEnter);
            this.mtAdmin.MouseLeave += new System.EventHandler(this.sub_MouseExit);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox9.Image = global::PUPiMed.Properties.Resources.user_login_512;
            this.pictureBox9.Location = new System.Drawing.Point(49, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 25);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.mtFaculty_Click);
            // 
            // mtFaculty
            // 
            this.mtFaculty.ActiveControl = null;
            this.mtFaculty.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtFaculty.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mtFaculty.Controls.Add(this.pictureBox8);
            this.mtFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtFaculty.ForeColor = System.Drawing.Color.White;
            this.mtFaculty.Location = new System.Drawing.Point(5, 545);
            this.mtFaculty.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtFaculty.Name = "mtFaculty";
            this.mtFaculty.Size = new System.Drawing.Size(283, 38);
            this.mtFaculty.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtFaculty.TabIndex = 6;
            this.mtFaculty.Text = "              > Faculty";
            this.mtFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtFaculty.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtFaculty.UseCustomBackColor = true;
            this.mtFaculty.UseCustomForeColor = true;
            this.mtFaculty.UseSelectable = true;
            this.mtFaculty.Click += new System.EventHandler(this.mtAdmin_Click);
            this.mtFaculty.MouseEnter += new System.EventHandler(this.sub_MouseEnter);
            this.mtFaculty.MouseLeave += new System.EventHandler(this.sub_MouseExit);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::PUPiMed.Properties.Resources.faculty_white;
            this.pictureBox8.Location = new System.Drawing.Point(49, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.mtAdmin_Click);
            // 
            // mtStudent
            // 
            this.mtStudent.ActiveControl = null;
            this.mtStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtStudent.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mtStudent.Controls.Add(this.pictureBox7);
            this.mtStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtStudent.ForeColor = System.Drawing.Color.White;
            this.mtStudent.Location = new System.Drawing.Point(5, 505);
            this.mtStudent.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtStudent.Name = "mtStudent";
            this.mtStudent.Size = new System.Drawing.Size(283, 39);
            this.mtStudent.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtStudent.TabIndex = 5;
            this.mtStudent.Text = "              > Student";
            this.mtStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtStudent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtStudent.UseCustomBackColor = true;
            this.mtStudent.UseCustomForeColor = true;
            this.mtStudent.UseSelectable = true;
            this.mtStudent.Click += new System.EventHandler(this.mtStudent_Click);
            this.mtStudent.MouseEnter += new System.EventHandler(this.sub_MouseEnter);
            this.mtStudent.MouseLeave += new System.EventHandler(this.sub_MouseExit);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PUPiMed.Properties.Resources.student_white;
            this.pictureBox7.Location = new System.Drawing.Point(49, 8);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.mtStudent_Click);
            // 
            // mtPatient
            // 
            this.mtPatient.ActiveControl = null;
            this.mtPatient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtPatient.BackColor = System.Drawing.Color.Teal;
            this.mtPatient.Controls.Add(this.pictureBox6);
            this.mtPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtPatient.ForeColor = System.Drawing.Color.White;
            this.mtPatient.Location = new System.Drawing.Point(5, 403);
            this.mtPatient.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtPatient.Name = "mtPatient";
            this.mtPatient.Size = new System.Drawing.Size(283, 48);
            this.mtPatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPatient.TabIndex = 4;
            this.mtPatient.Text = "         Patient Logs (DTR)";
            this.mtPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtPatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPatient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPatient.UseCustomBackColor = true;
            this.mtPatient.UseCustomForeColor = true;
            this.mtPatient.UseSelectable = true;
            this.mtPatient.Click += new System.EventHandler(this.mtPatient_Click);
            this.mtPatient.MouseEnter += new System.EventHandler(this.main_MouseEnter);
            this.mtPatient.MouseLeave += new System.EventHandler(this.main_MouseExit);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PUPiMed.Properties.Resources.patient_white;
            this.pictureBox6.Location = new System.Drawing.Point(22, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.mtPatient_Click);
            // 
            // mtEquipment
            // 
            this.mtEquipment.ActiveControl = null;
            this.mtEquipment.AllowDrop = true;
            this.mtEquipment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtEquipment.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mtEquipment.Controls.Add(this.pictureBox5);
            this.mtEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtEquipment.ForeColor = System.Drawing.Color.White;
            this.mtEquipment.Location = new System.Drawing.Point(5, 362);
            this.mtEquipment.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtEquipment.Name = "mtEquipment";
            this.mtEquipment.Size = new System.Drawing.Size(283, 38);
            this.mtEquipment.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtEquipment.TabIndex = 3;
            this.mtEquipment.Text = "              > Equipment";
            this.mtEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtEquipment.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtEquipment.UseCustomBackColor = true;
            this.mtEquipment.UseCustomForeColor = true;
            this.mtEquipment.UseSelectable = true;
            this.mtEquipment.Click += new System.EventHandler(this.mtEquipment_Click);
            this.mtEquipment.MouseEnter += new System.EventHandler(this.sub_MouseEnter);
            this.mtEquipment.MouseLeave += new System.EventHandler(this.sub_MouseExit);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PUPiMed.Properties.Resources.wheelchair_white;
            this.pictureBox5.Location = new System.Drawing.Point(49, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.mtEquipment_Click);
            // 
            // mtSupplies
            // 
            this.mtSupplies.ActiveControl = null;
            this.mtSupplies.AllowDrop = true;
            this.mtSupplies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtSupplies.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mtSupplies.Controls.Add(this.pictureBox4);
            this.mtSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtSupplies.ForeColor = System.Drawing.Color.White;
            this.mtSupplies.Location = new System.Drawing.Point(5, 323);
            this.mtSupplies.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtSupplies.Name = "mtSupplies";
            this.mtSupplies.Size = new System.Drawing.Size(283, 38);
            this.mtSupplies.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtSupplies.TabIndex = 2;
            this.mtSupplies.Text = "              > Supplies";
            this.mtSupplies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtSupplies.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtSupplies.UseCustomBackColor = true;
            this.mtSupplies.UseCustomForeColor = true;
            this.mtSupplies.UseSelectable = true;
            this.mtSupplies.Click += new System.EventHandler(this.mtSupplies_Click);
            this.mtSupplies.MouseEnter += new System.EventHandler(this.sub_MouseEnter);
            this.mtSupplies.MouseLeave += new System.EventHandler(this.sub_MouseExit);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PUPiMed.Properties.Resources.supplies;
            this.pictureBox4.Location = new System.Drawing.Point(49, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.mtSupplies_Click);
            // 
            // mtMedicine
            // 
            this.mtMedicine.ActiveControl = null;
            this.mtMedicine.AllowDrop = true;
            this.mtMedicine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtMedicine.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mtMedicine.Controls.Add(this.pictureBox3);
            this.mtMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtMedicine.ForeColor = System.Drawing.Color.White;
            this.mtMedicine.Location = new System.Drawing.Point(5, 284);
            this.mtMedicine.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtMedicine.Name = "mtMedicine";
            this.mtMedicine.Size = new System.Drawing.Size(283, 38);
            this.mtMedicine.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtMedicine.TabIndex = 1;
            this.mtMedicine.Text = "              > Medicines";
            this.mtMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtMedicine.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtMedicine.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtMedicine.UseCustomBackColor = true;
            this.mtMedicine.UseCustomForeColor = true;
            this.mtMedicine.UseSelectable = true;
            this.mtMedicine.UseTileImage = true;
            this.mtMedicine.Click += new System.EventHandler(this.mtMedicine_Click);
            this.mtMedicine.MouseEnter += new System.EventHandler(this.sub_MouseEnter);
            this.mtMedicine.MouseLeave += new System.EventHandler(this.sub_MouseExit);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PUPiMed.Properties.Resources.pill_241;
            this.pictureBox3.Location = new System.Drawing.Point(49, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.mtMedicine_Click);
            // 
            // mtInventory
            // 
            this.mtInventory.ActiveControl = null;
            this.mtInventory.AllowDrop = true;
            this.mtInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtInventory.BackColor = System.Drawing.Color.Teal;
            this.mtInventory.Controls.Add(this.picItemInventory);
            this.mtInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtInventory.ForeColor = System.Drawing.Color.White;
            this.mtInventory.Location = new System.Drawing.Point(5, 131);
            this.mtInventory.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.mtInventory.Name = "mtInventory";
            this.mtInventory.Size = new System.Drawing.Size(283, 48);
            this.mtInventory.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtInventory.TabIndex = 0;
            this.mtInventory.Text = "         Item Inventory";
            this.mtInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mtInventory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtInventory.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtInventory.UseCustomBackColor = true;
            this.mtInventory.UseCustomForeColor = true;
            this.mtInventory.UseSelectable = true;
            this.mtInventory.UseStyleColors = true;
            this.mtInventory.Click += new System.EventHandler(this.mtInventory_Click);
            this.mtInventory.MouseEnter += new System.EventHandler(this.main_MouseEnter);
            this.mtInventory.MouseLeave += new System.EventHandler(this.main_MouseExit);
            // 
            // picItemInventory
            // 
            this.picItemInventory.Image = global::PUPiMed.Properties.Resources.Solutions_Icon_17;
            this.picItemInventory.Location = new System.Drawing.Point(16, 10);
            this.picItemInventory.Name = "picItemInventory";
            this.picItemInventory.Size = new System.Drawing.Size(35, 33);
            this.picItemInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItemInventory.TabIndex = 0;
            this.picItemInventory.TabStop = false;
            this.picItemInventory.Click += new System.EventHandler(this.mtInventory_Click);
            // 
            // mpanel
            // 
            this.mpanel.AccessibleName = "mpanel";
            this.mpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpanel.AutoSize = true;
            this.mpanel.BackColor = System.Drawing.Color.White;
            this.mpanel.HorizontalScrollbarBarColor = true;
            this.mpanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanel.HorizontalScrollbarSize = 10;
            this.mpanel.Location = new System.Drawing.Point(287, 1);
            this.mpanel.Name = "mpanel";
            this.mpanel.Size = new System.Drawing.Size(790, 672);
            this.mpanel.TabIndex = 4;
            this.mpanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mpanel.UseCustomBackColor = true;
            this.mpanel.UseCustomForeColor = true;
            this.mpanel.VerticalScrollbarBarColor = true;
            this.mpanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpanel.VerticalScrollbarSize = 10;
            this.mpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mpanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::PUPiMed.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = global::PUPiMed.Properties.Resources.bg;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1076, 675);
            this.Controls.Add(this.mpLeftPanel);
            this.Controls.Add(this.mpanel);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.HotPink;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mpLeftPanel.ResumeLayout(false);
            this.mpLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.mtDistribute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemDistribution)).EndInit();
            this.mtPatientRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.mtItemLibrary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemLibrary)).EndInit();
            this.mtAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.mtFaculty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.mtStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.mtPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.mtEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.mtSupplies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.mtMedicine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mtInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void sub_MouseEnter(object sender, System.EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            tile.BackColor = System.Drawing.Color.LightCoral;
            //Color subColor = new Color();
            //subColor = Color.FromArgb(251, 105, 0);
            //tile.BackColor = subColor;

        }
        private void sub_MouseExit(object sender, System.EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            tile.BackColor = System.Drawing.Color.LightSeaGreen;
            //Color subColor = new Color();
            //subColor = Color.FromArgb(0, 128, 128);
            //tile.BackColor = subColor;
        }

        private void main_MouseEnter(object sender, System.EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            //Color mainColor = new Color();
            //mainColor = Color.FromArgb(246, 55, 0);
            tile.BackColor = System.Drawing.Color.IndianRed;
            //tile.BackColor = mainColor;


        }
        private void main_MouseExit(object sender, System.EventArgs e)
        {
            MetroTile tile = sender as MetroTile;
            tile.BackColor = System.Drawing.Color.Teal;
            //Color mainColor = new Color();
            //mainColor = Color.FromArgb(0,64,64);
            //tile.BackColor = mainColor;

        }
        #endregion

        private MetroFramework.Controls.MetroPanel mpLeftPanel;
        private MetroFramework.Controls.MetroTile mtInventory;
        private MetroFramework.Controls.MetroTile mtAdmin;
        private MetroFramework.Controls.MetroTile mtFaculty;
        private MetroFramework.Controls.MetroTile mtStudent;
        private MetroFramework.Controls.MetroTile mtPatient;
        private MetroFramework.Controls.MetroTile mtEquipment;
        private MetroFramework.Controls.MetroTile mtSupplies;
        private MetroFramework.Controls.MetroTile mtMedicine;
        private MetroFramework.Controls.MetroTile mtDistribute;
        private MetroFramework.Controls.MetroTile mtPatientRecords;
        private System.Windows.Forms.PictureBox picLogo;
        private MetroFramework.Controls.MetroTile mtLogout;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox picItemDistribution;
        private System.Windows.Forms.PictureBox picItemInventory;
        private MetroPanel mpanel;
        private MetroTile mtItemLibrary;
        private System.Windows.Forms.PictureBox picItemLibrary;
        private MetroLabel lblTime;
    }
}