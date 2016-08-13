namespace PUPiMed
{
    partial class FormAddPatient
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
            this.suppcode = new MetroFramework.Controls.MetroLabel();
            this.patientcode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.fname = new MetroFramework.Controls.MetroTextBox();
            this.midname = new MetroFramework.Controls.MetroTextBox();
            this.lname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.patientype = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.combodept = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.combocourse = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.male = new MetroFramework.Controls.MetroRadioButton();
            this.female = new MetroFramework.Controls.MetroRadioButton();
            this.section = new MetroFramework.Controls.MetroTextBox();
            this.year = new MetroFramework.Controls.MetroTextBox();
            this.lblAddpatient = new MaterialSkin.Controls.MaterialLabel();
            this.otherinfos = new MetroFramework.Controls.MetroTile();
            this.basicinfo = new MetroFramework.Controls.MetroTile();
            this.height = new MetroFramework.Controls.MetroLabel();
            this.weight = new MetroFramework.Controls.MetroLabel();
            this.height1 = new MetroFramework.Controls.MetroTextBox();
            this.weight1 = new MetroFramework.Controls.MetroTextBox();
            this.cm = new MetroFramework.Controls.MetroLabel();
            this.kg = new MetroFramework.Controls.MetroLabel();
            this.contactno = new MetroFramework.Controls.MetroLabel();
            this.bloodtype = new MetroFramework.Controls.MetroLabel();
            this.contactnumber = new MetroFramework.Controls.MetroTextBox();
            this.comboBloodType = new MetroFramework.Controls.MetroComboBox();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.bday = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.medicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicon)).BeginInit();
            this.SuspendLayout();
            // 
            // suppcode
            // 
            this.suppcode.AccessibleName = "patientCode";
            this.suppcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.suppcode.AutoSize = true;
            this.suppcode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.suppcode.Location = new System.Drawing.Point(71, 299);
            this.suppcode.Name = "suppcode";
            this.suppcode.Size = new System.Drawing.Size(103, 19);
            this.suppcode.Style = MetroFramework.MetroColorStyle.Teal;
            this.suppcode.TabIndex = 26;
            this.suppcode.Text = "Patient Code :";
            this.suppcode.Click += new System.EventHandler(this.suppcode_Click);
            // 
            // patientcode
            // 
            this.patientcode.AccessibleName = "patientCode";
            this.patientcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientcode.Lines = new string[0];
            this.patientcode.Location = new System.Drawing.Point(43, 326);
            this.patientcode.MaxLength = 32767;
            this.patientcode.Name = "patientcode";
            this.patientcode.PasswordChar = '\0';
            this.patientcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.patientcode.SelectedText = "";
            this.patientcode.Size = new System.Drawing.Size(159, 23);
            this.patientcode.Style = MetroFramework.MetroColorStyle.Teal;
            this.patientcode.TabIndex = 27;
            this.patientcode.UseSelectable = true;
            this.patientcode.Click += new System.EventHandler(this.medname_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "fname";
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(271, 185);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "First Name :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AccessibleName = "mname";
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(252, 223);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Middle Name :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AccessibleName = "lname";
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(273, 261);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(87, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel6.TabIndex = 28;
            this.metroLabel6.Text = "Last Name :";
            // 
            // fname
            // 
            this.fname.AccessibleName = "fname";
            this.fname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fname.Lines = new string[0];
            this.fname.Location = new System.Drawing.Point(388, 181);
            this.fname.MaxLength = 32767;
            this.fname.Name = "fname";
            this.fname.PasswordChar = '\0';
            this.fname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fname.SelectedText = "";
            this.fname.Size = new System.Drawing.Size(185, 23);
            this.fname.Style = MetroFramework.MetroColorStyle.Teal;
            this.fname.TabIndex = 27;
            this.fname.UseCustomBackColor = true;
            this.fname.UseSelectable = true;
            this.fname.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // midname
            // 
            this.midname.AccessibleName = "mname";
            this.midname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.midname.Lines = new string[0];
            this.midname.Location = new System.Drawing.Point(388, 219);
            this.midname.MaxLength = 32767;
            this.midname.Name = "midname";
            this.midname.PasswordChar = '\0';
            this.midname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.midname.SelectedText = "";
            this.midname.Size = new System.Drawing.Size(185, 23);
            this.midname.Style = MetroFramework.MetroColorStyle.Teal;
            this.midname.TabIndex = 27;
            this.midname.UseCustomBackColor = true;
            this.midname.UseSelectable = true;
            this.midname.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // lname
            // 
            this.lname.AccessibleName = "lname";
            this.lname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lname.Lines = new string[0];
            this.lname.Location = new System.Drawing.Point(388, 257);
            this.lname.MaxLength = 32767;
            this.lname.Name = "lname";
            this.lname.PasswordChar = '\0';
            this.lname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lname.SelectedText = "";
            this.lname.Size = new System.Drawing.Size(185, 23);
            this.lname.Style = MetroFramework.MetroColorStyle.Teal;
            this.lname.TabIndex = 27;
            this.lname.UseCustomBackColor = true;
            this.lname.UseSelectable = true;
            this.lname.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "course";
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(627, 181);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Course :";
            // 
            // patientype
            // 
            this.patientype.AccessibleName = "ptype";
            this.patientype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientype.FormattingEnabled = true;
            this.patientype.ItemHeight = 23;
            this.patientype.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "Admin"});
            this.patientype.Location = new System.Drawing.Point(388, 136);
            this.patientype.Name = "patientype";
            this.patientype.Size = new System.Drawing.Size(185, 29);
            this.patientype.Style = MetroFramework.MetroColorStyle.Teal;
            this.patientype.TabIndex = 29;
            this.patientype.UseSelectable = true;
            this.patientype.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "depOrCollege";
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(593, 146);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Department :";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // combodept
            // 
            this.combodept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combodept.FormattingEnabled = true;
            this.combodept.ItemHeight = 23;
            this.combodept.Location = new System.Drawing.Point(718, 136);
            this.combodept.Name = "combodept";
            this.combodept.Size = new System.Drawing.Size(121, 29);
            this.combodept.Style = MetroFramework.MetroColorStyle.Teal;
            this.combodept.TabIndex = 29;
            this.combodept.UseSelectable = true;
            this.combodept.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "ptype";
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(259, 146);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(101, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel8.TabIndex = 28;
            this.metroLabel8.Text = "Patient Type :";
            // 
            // combocourse
            // 
            this.combocourse.AccessibleName = "course";
            this.combocourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combocourse.FormattingEnabled = true;
            this.combocourse.ItemHeight = 23;
            this.combocourse.Location = new System.Drawing.Point(718, 175);
            this.combocourse.Name = "combocourse";
            this.combocourse.Size = new System.Drawing.Size(121, 29);
            this.combocourse.Style = MetroFramework.MetroColorStyle.Teal;
            this.combocourse.TabIndex = 29;
            this.combocourse.UseSelectable = true;
            this.combocourse.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "year";
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(642, 221);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Year :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AccessibleName = "section";
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(624, 261);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(66, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Section :";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AccessibleName = "gender";
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(624, 299);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(66, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel10.TabIndex = 28;
            this.metroLabel10.Text = "Gender :";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // male
            // 
            this.male.AccessibleName = "male";
            this.male.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.DisplayFocus = true;
            this.male.Location = new System.Drawing.Point(718, 303);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 15);
            this.male.Style = MetroFramework.MetroColorStyle.Teal;
            this.male.TabIndex = 30;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseSelectable = true;
            // 
            // female
            // 
            this.female.AccessibleName = "female";
            this.female.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(778, 302);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(61, 15);
            this.female.Style = MetroFramework.MetroColorStyle.Teal;
            this.female.TabIndex = 31;
            this.female.Text = "Female";
            this.female.UseSelectable = true;
            // 
            // section
            // 
            this.section.AccessibleName = "section";
            this.section.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section.Lines = new string[0];
            this.section.Location = new System.Drawing.Point(718, 261);
            this.section.MaxLength = 32767;
            this.section.Name = "section";
            this.section.PasswordChar = '\0';
            this.section.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.section.SelectedText = "";
            this.section.Size = new System.Drawing.Size(121, 23);
            this.section.Style = MetroFramework.MetroColorStyle.Teal;
            this.section.TabIndex = 32;
            this.section.UseCustomBackColor = true;
            this.section.UseSelectable = true;
            // 
            // year
            // 
            this.year.AccessibleName = "year";
            this.year.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.year.Lines = new string[0];
            this.year.Location = new System.Drawing.Point(718, 223);
            this.year.MaxLength = 32767;
            this.year.Name = "year";
            this.year.PasswordChar = '\0';
            this.year.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.year.SelectedText = "";
            this.year.Size = new System.Drawing.Size(121, 23);
            this.year.Style = MetroFramework.MetroColorStyle.Teal;
            this.year.TabIndex = 33;
            this.year.UseCustomBackColor = true;
            this.year.UseSelectable = true;
            // 
            // lblAddpatient
            // 
            this.lblAddpatient.AccessibleName = "lblAddPatient";
            this.lblAddpatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddpatient.Depth = 0;
            this.lblAddpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblAddpatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddpatient.Location = new System.Drawing.Point(-1, 16);
            this.lblAddpatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddpatient.Name = "lblAddpatient";
            this.lblAddpatient.Size = new System.Drawing.Size(935, 83);
            this.lblAddpatient.TabIndex = 34;
            this.lblAddpatient.Text = "PATIENT INFORMATION";
            this.lblAddpatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddpatient.Click += new System.EventHandler(this.lblAddpatient_Click);
            // 
            // otherinfos
            // 
            this.otherinfos.AccessibleName = "otherinfos";
            this.otherinfos.ActiveControl = null;
            this.otherinfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherinfos.BackColor = System.Drawing.Color.DarkCyan;
            this.otherinfos.Enabled = false;
            this.otherinfos.Location = new System.Drawing.Point(43, 365);
            this.otherinfos.Name = "otherinfos";
            this.otherinfos.Size = new System.Drawing.Size(838, 32);
            this.otherinfos.TabIndex = 35;
            this.otherinfos.Text = "Other Information";
            this.otherinfos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.otherinfos.UseCustomBackColor = true;
            this.otherinfos.UseSelectable = true;
            // 
            // basicinfo
            // 
            this.basicinfo.AccessibleName = "basicinfos";
            this.basicinfo.ActiveControl = null;
            this.basicinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basicinfo.BackColor = System.Drawing.Color.DarkCyan;
            this.basicinfo.Enabled = false;
            this.basicinfo.Location = new System.Drawing.Point(43, 84);
            this.basicinfo.Name = "basicinfo";
            this.basicinfo.Size = new System.Drawing.Size(838, 32);
            this.basicinfo.TabIndex = 35;
            this.basicinfo.Text = "Basic Information";
            this.basicinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.basicinfo.UseCustomBackColor = true;
            this.basicinfo.UseSelectable = true;
            // 
            // height
            // 
            this.height.AccessibleName = "height";
            this.height.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.height.AutoSize = true;
            this.height.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.height.Location = new System.Drawing.Point(298, 413);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(62, 19);
            this.height.Style = MetroFramework.MetroColorStyle.Teal;
            this.height.TabIndex = 36;
            this.height.Text = "Height :";
            // 
            // weight
            // 
            this.weight.AccessibleName = "weight";
            this.weight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weight.AutoSize = true;
            this.weight.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.weight.Location = new System.Drawing.Point(295, 451);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(65, 19);
            this.weight.Style = MetroFramework.MetroColorStyle.Teal;
            this.weight.TabIndex = 37;
            this.weight.Text = "Weight :";
            // 
            // height1
            // 
            this.height1.AccessibleName = "height";
            this.height1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.height1.Lines = new string[0];
            this.height1.Location = new System.Drawing.Point(388, 413);
            this.height1.MaxLength = 32767;
            this.height1.Name = "height1";
            this.height1.PasswordChar = '\0';
            this.height1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.height1.SelectedText = "";
            this.height1.Size = new System.Drawing.Size(116, 23);
            this.height1.Style = MetroFramework.MetroColorStyle.Teal;
            this.height1.TabIndex = 38;
            this.height1.UseCustomBackColor = true;
            this.height1.UseSelectable = true;
            // 
            // weight1
            // 
            this.weight1.AccessibleName = "weight";
            this.weight1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weight1.Lines = new string[0];
            this.weight1.Location = new System.Drawing.Point(388, 447);
            this.weight1.MaxLength = 32767;
            this.weight1.Name = "weight1";
            this.weight1.PasswordChar = '\0';
            this.weight1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.weight1.SelectedText = "";
            this.weight1.Size = new System.Drawing.Size(115, 23);
            this.weight1.Style = MetroFramework.MetroColorStyle.Teal;
            this.weight1.TabIndex = 39;
            this.weight1.UseCustomBackColor = true;
            this.weight1.UseSelectable = true;
            // 
            // cm
            // 
            this.cm.AccessibleName = "cm";
            this.cm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(510, 416);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(27, 19);
            this.cm.TabIndex = 40;
            this.cm.Text = "cm";
            // 
            // kg
            // 
            this.kg.AccessibleName = "kg";
            this.kg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kg.AutoSize = true;
            this.kg.Location = new System.Drawing.Point(510, 447);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(23, 19);
            this.kg.TabIndex = 41;
            this.kg.Text = "kg";
            // 
            // contactno
            // 
            this.contactno.AccessibleName = "Contactno";
            this.contactno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactno.AutoSize = true;
            this.contactno.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.contactno.Location = new System.Drawing.Point(576, 413);
            this.contactno.Name = "contactno";
            this.contactno.Size = new System.Drawing.Size(92, 19);
            this.contactno.Style = MetroFramework.MetroColorStyle.Teal;
            this.contactno.TabIndex = 42;
            this.contactno.Text = "Contact No :";
            // 
            // bloodtype
            // 
            this.bloodtype.AccessibleName = "bloodtype";
            this.bloodtype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bloodtype.AutoSize = true;
            this.bloodtype.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.bloodtype.Location = new System.Drawing.Point(574, 447);
            this.bloodtype.Name = "bloodtype";
            this.bloodtype.Size = new System.Drawing.Size(94, 19);
            this.bloodtype.Style = MetroFramework.MetroColorStyle.Teal;
            this.bloodtype.TabIndex = 43;
            this.bloodtype.Text = "Blood Type :";
            // 
            // contactnumber
            // 
            this.contactnumber.AccessibleName = "contactno";
            this.contactnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactnumber.Lines = new string[0];
            this.contactnumber.Location = new System.Drawing.Point(696, 409);
            this.contactnumber.MaxLength = 32767;
            this.contactnumber.Name = "contactnumber";
            this.contactnumber.PasswordChar = '\0';
            this.contactnumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contactnumber.SelectedText = "";
            this.contactnumber.Size = new System.Drawing.Size(121, 23);
            this.contactnumber.Style = MetroFramework.MetroColorStyle.Teal;
            this.contactnumber.TabIndex = 44;
            this.contactnumber.UseCustomBackColor = true;
            this.contactnumber.UseSelectable = true;
            // 
            // comboBloodType
            // 
            this.comboBloodType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBloodType.FormattingEnabled = true;
            this.comboBloodType.ItemHeight = 23;
            this.comboBloodType.Location = new System.Drawing.Point(696, 437);
            this.comboBloodType.Name = "comboBloodType";
            this.comboBloodType.Size = new System.Drawing.Size(121, 29);
            this.comboBloodType.TabIndex = 45;
            this.comboBloodType.UseSelectable = true;
            // 
            // btncancel
            // 
            this.btncancel.AccessibleName = "btncancel";
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.BackColor = System.Drawing.Color.White;
            this.btncancel.Highlight = true;
            this.btncancel.Location = new System.Drawing.Point(799, 493);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(99, 37);
            this.btncancel.Style = MetroFramework.MetroColorStyle.Teal;
            this.btncancel.TabIndex = 48;
            this.btncancel.Text = "     Cancel";
            this.btncancel.UseCustomBackColor = true;
            this.btncancel.UseSelectable = true;
            this.btncancel.UseStyleColors = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "btnadd";
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(680, 493);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "   Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bday
            // 
            this.bday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bday.Location = new System.Drawing.Point(388, 299);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(185, 20);
            this.bday.TabIndex = 50;
            this.bday.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "section";
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(302, 298);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "B-Day :";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::PUPiMed.Properties.Resources.cancel_teal_box;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(804, 498);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PUPiMed.Properties.Resources.add_teal_box;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(685, 498);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // medicon
            // 
            this.medicon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicon.BackColor = System.Drawing.Color.White;
            this.medicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.medicon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicon.Image = global::PUPiMed.Properties.Resources.add_w_perseon;
            this.medicon.Location = new System.Drawing.Point(43, 133);
            this.medicon.Name = "medicon";
            this.medicon.Size = new System.Drawing.Size(159, 159);
            this.medicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medicon.TabIndex = 25;
            this.medicon.TabStop = false;
            this.medicon.Click += new System.EventHandler(this.medicon_Click);
            // 
            // AddPatient
            // 
            this.AccessibleName = "frmAddPatient";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 553);
            this.Controls.Add(this.bday);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBloodType);
            this.Controls.Add(this.contactnumber);
            this.Controls.Add(this.bloodtype);
            this.Controls.Add(this.contactno);
            this.Controls.Add(this.kg);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.weight1);
            this.Controls.Add(this.height1);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.basicinfo);
            this.Controls.Add(this.otherinfos);
            this.Controls.Add(this.section);
            this.Controls.Add(this.year);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.combocourse);
            this.Controls.Add(this.combodept);
            this.Controls.Add(this.patientype);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.midname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.patientcode);
            this.Controls.Add(this.suppcode);
            this.Controls.Add(this.medicon);
            this.Controls.Add(this.lblAddpatient);
            this.MaximizeBox = false;
            this.Name = "AddPatient";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.AddPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox medicon;
        private MetroFramework.Controls.MetroLabel suppcode;
        private MetroFramework.Controls.MetroTextBox patientcode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox fname;
        private MetroFramework.Controls.MetroTextBox midname;
        private MetroFramework.Controls.MetroTextBox lname;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox patientype;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox combodept;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox combocourse;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroRadioButton male;
        private MetroFramework.Controls.MetroRadioButton female;
        private MetroFramework.Controls.MetroTextBox section;
        private MetroFramework.Controls.MetroTextBox year;
        private MaterialSkin.Controls.MaterialLabel lblAddpatient;
        private MetroFramework.Controls.MetroTile otherinfos;
        private MetroFramework.Controls.MetroTile basicinfo;
        private MetroFramework.Controls.MetroLabel height;
        private MetroFramework.Controls.MetroLabel weight;
        private MetroFramework.Controls.MetroTextBox height1;
        private MetroFramework.Controls.MetroTextBox weight1;
        private MetroFramework.Controls.MetroLabel cm;
        private MetroFramework.Controls.MetroLabel kg;
        private MetroFramework.Controls.MetroLabel contactno;
        private MetroFramework.Controls.MetroLabel bloodtype;
        private MetroFramework.Controls.MetroTextBox contactnumber;
        private MetroFramework.Controls.MetroComboBox comboBloodType;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btncancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.DateTimePicker bday;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}