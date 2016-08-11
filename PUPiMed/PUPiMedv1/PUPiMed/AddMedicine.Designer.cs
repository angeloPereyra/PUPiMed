using System;

namespace PUPiMed
{
    partial class AddMedicine
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
            this.cbManufacturer = new MetroFramework.Controls.MetroComboBox();
            this.lblManuName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMin = new MetroFramework.Controls.MetroTextBox();
            this.txtMax = new MetroFramework.Controls.MetroTextBox();
            this.txtOther = new MetroFramework.Controls.MetroTextBox();
            this.txtGen = new MetroFramework.Controls.MetroTextBox();
            this.lbltype = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.status = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.medcode = new MetroFramework.Controls.MetroLabel();
            this.medicon = new System.Windows.Forms.PictureBox();
            this.formlbl = new MaterialSkin.Controls.MaterialLabel();
            this.lblManu = new MetroFramework.Controls.MetroLabel();
            this.txtManu = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.AccessibleName = "manufacturer";
            this.cbManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.ItemHeight = 23;
            this.cbManufacturer.Location = new System.Drawing.Point(375, 216);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(165, 29);
            this.cbManufacturer.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbManufacturer.TabIndex = 112;
            this.cbManufacturer.UseSelectable = true;
            this.cbManufacturer.Visible = false;
            this.cbManufacturer.SelectedIndexChanged += new System.EventHandler(this.cbManufacturer_SelectedIndexChanged);
            // 
            // lblManuName
            // 
            this.lblManuName.AccessibleName = "lblmed";
            this.lblManuName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManuName.AutoSize = true;
            this.lblManuName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblManuName.Location = new System.Drawing.Point(215, 272);
            this.lblManuName.Name = "lblManuName";
            this.lblManuName.Size = new System.Drawing.Size(151, 19);
            this.lblManuName.TabIndex = 111;
            this.lblManuName.Text = "Manufacturer Name :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "lblmed";
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(383, 318);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 110;
            this.metroLabel3.Text = "Maximum :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "lblmed";
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(218, 318);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 109;
            this.metroLabel2.Text = "Minimum :";
            // 
            // txtMin
            // 
            this.txtMin.AccessibleName = "";
            this.txtMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMin.BackColor = System.Drawing.Color.White;
            this.txtMin.Lines = new string[0];
            this.txtMin.Location = new System.Drawing.Point(304, 314);
            this.txtMin.MaxLength = 32767;
            this.txtMin.Name = "txtMin";
            this.txtMin.PasswordChar = '\0';
            this.txtMin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMin.SelectedText = "";
            this.txtMin.Size = new System.Drawing.Size(70, 23);
            this.txtMin.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtMin.TabIndex = 104;
            this.txtMin.UseCustomBackColor = true;
            this.txtMin.UseSelectable = true;
            // 
            // txtMax
            // 
            this.txtMax.AccessibleName = "";
            this.txtMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMax.BackColor = System.Drawing.Color.White;
            this.txtMax.Lines = new string[0];
            this.txtMax.Location = new System.Drawing.Point(470, 314);
            this.txtMax.MaxLength = 32767;
            this.txtMax.Name = "txtMax";
            this.txtMax.PasswordChar = '\0';
            this.txtMax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMax.SelectedText = "";
            this.txtMax.Size = new System.Drawing.Size(70, 23);
            this.txtMax.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtMax.TabIndex = 105;
            this.txtMax.UseCustomBackColor = true;
            this.txtMax.UseSelectable = true;
            // 
            // txtOther
            // 
            this.txtOther.AccessibleName = "";
            this.txtOther.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOther.BackColor = System.Drawing.Color.White;
            this.txtOther.Lines = new string[0];
            this.txtOther.Location = new System.Drawing.Point(375, 272);
            this.txtOther.MaxLength = 32767;
            this.txtOther.Name = "txtOther";
            this.txtOther.PasswordChar = '\0';
            this.txtOther.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOther.SelectedText = "";
            this.txtOther.Size = new System.Drawing.Size(165, 23);
            this.txtOther.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtOther.TabIndex = 103;
            this.txtOther.UseCustomBackColor = true;
            this.txtOther.UseSelectable = true;
            // 
            // txtGen
            // 
            this.txtGen.AccessibleName = "";
            this.txtGen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGen.BackColor = System.Drawing.Color.White;
            this.txtGen.Lines = new string[0];
            this.txtGen.Location = new System.Drawing.Point(342, 171);
            this.txtGen.MaxLength = 32767;
            this.txtGen.Name = "txtGen";
            this.txtGen.PasswordChar = '\0';
            this.txtGen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGen.SelectedText = "";
            this.txtGen.Size = new System.Drawing.Size(198, 23);
            this.txtGen.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtGen.TabIndex = 102;
            this.txtGen.UseCustomBackColor = true;
            this.txtGen.UseSelectable = true;
            // 
            // lbltype
            // 
            this.lbltype.AccessibleName = "lbltype";
            this.lbltype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltype.AutoSize = true;
            this.lbltype.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbltype.Location = new System.Drawing.Point(220, 175);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(116, 19);
            this.lbltype.TabIndex = 107;
            this.lbltype.Text = "Generic Name : ";
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "";
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(285, 130);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(255, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtName.TabIndex = 101;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "lblmed";
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(220, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 106;
            this.metroLabel1.Text = "Name :";
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(-2, 74);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(594, 23);
            this.status.TabIndex = 100;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseSelectable = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::PUPiMed.Properties.Resources._00delete;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(446, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // btncancel
            // 
            this.btncancel.AccessibleName = "btncancel";
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.BackColor = System.Drawing.Color.White;
            this.btncancel.Highlight = true;
            this.btncancel.Location = new System.Drawing.Point(441, 373);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(99, 37);
            this.btncancel.Style = MetroFramework.MetroColorStyle.Teal;
            this.btncancel.TabIndex = 96;
            this.btncancel.Text = "     Cancel";
            this.btncancel.UseCustomBackColor = true;
            this.btncancel.UseSelectable = true;
            this.btncancel.UseStyleColors = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PUPiMed.Properties.Resources._00add___Copy1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(327, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "btnadd";
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(322, 373);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 95;
            this.btnAdd.Text = "   Save";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "medname";
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(43, 318);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(143, 23);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 92;
            this.txtCode.UseSelectable = true;
            // 
            // medcode
            // 
            this.medcode.AccessibleName = "medcode";
            this.medcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medcode.AutoSize = true;
            this.medcode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.medcode.Location = new System.Drawing.Point(56, 285);
            this.medcode.Name = "medcode";
            this.medcode.Size = new System.Drawing.Size(117, 19);
            this.medcode.Style = MetroFramework.MetroColorStyle.Teal;
            this.medcode.TabIndex = 94;
            this.medcode.Text = "Medicine Code :";
            // 
            // medicon
            // 
            this.medicon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicon.BackColor = System.Drawing.Color.White;
            this.medicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.medicon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicon.Image = global::PUPiMed.Properties.Resources.med321;
            this.medicon.Location = new System.Drawing.Point(43, 130);
            this.medicon.Name = "medicon";
            this.medicon.Size = new System.Drawing.Size(143, 143);
            this.medicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medicon.TabIndex = 93;
            this.medicon.TabStop = false;
            // 
            // formlbl
            // 
            this.formlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formlbl.Depth = 0;
            this.formlbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.formlbl.Location = new System.Drawing.Point(1, 13);
            this.formlbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.formlbl.Name = "formlbl";
            this.formlbl.Size = new System.Drawing.Size(591, 68);
            this.formlbl.TabIndex = 97;
            this.formlbl.Text = "MEDICINE";
            this.formlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManu
            // 
            this.lblManu.AccessibleName = "lblother";
            this.lblManu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManu.AutoSize = true;
            this.lblManu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblManu.Location = new System.Drawing.Point(215, 225);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(146, 19);
            this.lblManu.TabIndex = 113;
            this.lblManu.Text = "Manufacturer Code :";
            // 
            // txtManu
            // 
            this.txtManu.AccessibleName = "";
            this.txtManu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtManu.Lines = new string[0];
            this.txtManu.Location = new System.Drawing.Point(375, 219);
            this.txtManu.MaxLength = 32767;
            this.txtManu.Name = "txtManu";
            this.txtManu.PasswordChar = '\0';
            this.txtManu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManu.SelectedText = "";
            this.txtManu.Size = new System.Drawing.Size(165, 23);
            this.txtManu.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtManu.TabIndex = 114;
            this.txtManu.UseCustomBackColor = true;
            this.txtManu.UseSelectable = true;
            // 
            // AddMedicine
            // 
            this.AccessibleName = "frmAddMedicine";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 441);
            this.Controls.Add(this.txtManu);
            this.Controls.Add(this.lblManu);
            this.Controls.Add(this.cbManufacturer);
            this.Controls.Add(this.lblManuName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.medcode);
            this.Controls.Add(this.medicon);
            this.Controls.Add(this.formlbl);
            this.MaximizeBox = false;
            this.Name = "AddMedicine";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbManufacturer;
        private MetroFramework.Controls.MetroLabel lblManuName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox txtMin;
        public MetroFramework.Controls.MetroTextBox txtMax;
        public MetroFramework.Controls.MetroTextBox txtOther;
        public MetroFramework.Controls.MetroTextBox txtGen;
        private MetroFramework.Controls.MetroLabel lbltype;
        public MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile status;
        private System.Windows.Forms.PictureBox pictureBox2;
        public MetroFramework.Controls.MetroButton btncancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroButton btnAdd;
        public MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel medcode;
        private System.Windows.Forms.PictureBox medicon;
        private MaterialSkin.Controls.MaterialLabel formlbl;
        private MetroFramework.Controls.MetroLabel lblManu;
        public MetroFramework.Controls.MetroTextBox txtManu;
    }
}