using System;

namespace PUPiMed
{
    partial class FormAddItem
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
            this.lblManu2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMin = new MetroFramework.Controls.MetroTextBox();
            this.txtMax = new MetroFramework.Controls.MetroTextBox();
            this.txtManuName = new MetroFramework.Controls.MetroTextBox();
            this.txtGen = new MetroFramework.Controls.MetroTextBox();
            this.lbltype = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.status = new MetroFramework.Controls.MetroTile();
            this.picCancel = new System.Windows.Forms.PictureBox();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.icon = new System.Windows.Forms.PictureBox();
            this.lblManu1 = new MetroFramework.Controls.MetroLabel();
            this.txtManu = new MetroFramework.Controls.MetroTextBox();
            this.Title = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbManufacturer
            // 
            this.cbManufacturer.AccessibleName = "";
            this.cbManufacturer.FormattingEnabled = true;
            this.cbManufacturer.ItemHeight = 23;
            this.cbManufacturer.Location = new System.Drawing.Point(371, 205);
            this.cbManufacturer.Name = "cbManufacturer";
            this.cbManufacturer.Size = new System.Drawing.Size(165, 29);
            this.cbManufacturer.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbManufacturer.TabIndex = 95;
            this.cbManufacturer.UseSelectable = true;
            this.cbManufacturer.Visible = false;
            this.cbManufacturer.SelectedIndexChanged += new System.EventHandler(this.cbManufacturer_SelectedIndexChanged);
            // 
            // lblManu2
            // 
            this.lblManu2.AccessibleName = "";
            this.lblManu2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblManu2.Location = new System.Drawing.Point(215, 247);
            this.lblManu2.Name = "lblManu2";
            this.lblManu2.Size = new System.Drawing.Size(151, 19);
            this.lblManu2.TabIndex = 111;
            this.lblManu2.Text = "Manufacturer Name :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "";
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(381, 287);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 110;
            this.metroLabel3.Text = "Maximum :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "";
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(216, 287);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 17);
            this.metroLabel2.TabIndex = 109;
            this.metroLabel2.Text = "Minimum :";
            // 
            // txtMin
            // 
            this.txtMin.AccessibleName = "";
            this.txtMin.BackColor = System.Drawing.Color.White;
            this.txtMin.Lines = new string[0];
            this.txtMin.Location = new System.Drawing.Point(302, 285);
            this.txtMin.MaxLength = 32767;
            this.txtMin.Name = "txtMin";
            this.txtMin.PasswordChar = '\0';
            this.txtMin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMin.SelectedText = "";
            this.txtMin.Size = new System.Drawing.Size(70, 23);
            this.txtMin.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtMin.TabIndex = 97;
            this.txtMin.UseCustomBackColor = true;
            this.txtMin.UseSelectable = true;
            this.txtMin.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtMin.Click += new System.EventHandler(this.txtCode_TextChanged);
            this.txtMin.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.AccessibleName = "";
            this.txtMax.BackColor = System.Drawing.Color.White;
            this.txtMax.Lines = new string[0];
            this.txtMax.Location = new System.Drawing.Point(468, 285);
            this.txtMax.MaxLength = 32767;
            this.txtMax.Name = "txtMax";
            this.txtMax.PasswordChar = '\0';
            this.txtMax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMax.SelectedText = "";
            this.txtMax.Size = new System.Drawing.Size(70, 23);
            this.txtMax.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtMax.TabIndex = 98;
            this.txtMax.UseCustomBackColor = true;
            this.txtMax.UseSelectable = true;
            this.txtMax.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtMax.Click += new System.EventHandler(this.txtCode_TextChanged);
            this.txtMax.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtManuName
            // 
            this.txtManuName.AccessibleName = "";
            this.txtManuName.BackColor = System.Drawing.Color.White;
            this.txtManuName.Lines = new string[0];
            this.txtManuName.Location = new System.Drawing.Point(371, 245);
            this.txtManuName.MaxLength = 32767;
            this.txtManuName.Name = "txtManuName";
            this.txtManuName.PasswordChar = '\0';
            this.txtManuName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManuName.SelectedText = "";
            this.txtManuName.Size = new System.Drawing.Size(165, 23);
            this.txtManuName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtManuName.TabIndex = 96;
            this.txtManuName.UseCustomBackColor = true;
            this.txtManuName.UseSelectable = true;
            this.txtManuName.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtManuName.Click += new System.EventHandler(this.txtCode_TextChanged);
            this.txtManuName.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtGen
            // 
            this.txtGen.AccessibleName = "";
            this.txtGen.BackColor = System.Drawing.Color.White;
            this.txtGen.Lines = new string[0];
            this.txtGen.Location = new System.Drawing.Point(338, 165);
            this.txtGen.MaxLength = 32767;
            this.txtGen.Name = "txtGen";
            this.txtGen.PasswordChar = '\0';
            this.txtGen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGen.SelectedText = "";
            this.txtGen.Size = new System.Drawing.Size(198, 23);
            this.txtGen.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtGen.TabIndex = 94;
            this.txtGen.UseCustomBackColor = true;
            this.txtGen.UseSelectable = true;
            this.txtGen.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtGen.Click += new System.EventHandler(this.txtCode_TextChanged);
            this.txtGen.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lbltype
            // 
            this.lbltype.AccessibleName = "";
            this.lbltype.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbltype.Location = new System.Drawing.Point(216, 167);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(116, 19);
            this.lbltype.TabIndex = 107;
            this.lbltype.Text = "Generic Name : ";
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "";
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(281, 125);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(255, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtName.TabIndex = 93;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtName.Click += new System.EventHandler(this.txtCode_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "";
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(216, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 106;
            this.metroLabel1.Text = "Name :";
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(-6, 68);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(594, 29);
            this.status.TabIndex = 100;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseSelectable = true;
            // 
            // picCancel
            // 
            this.picCancel.BackColor = System.Drawing.Color.White;
            this.picCancel.BackgroundImage = global::PUPiMed.Properties.Resources.cancel_teal_box;
            this.picCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCancel.Location = new System.Drawing.Point(444, 340);
            this.picCancel.Name = "picCancel";
            this.picCancel.Size = new System.Drawing.Size(26, 26);
            this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancel.TabIndex = 99;
            this.picCancel.TabStop = false;
            this.picCancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btncancel
            // 
            this.btncancel.AccessibleName = "btncancel";
            this.btncancel.BackColor = System.Drawing.Color.White;
            this.btncancel.Highlight = true;
            this.btncancel.Location = new System.Drawing.Point(439, 335);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(99, 37);
            this.btncancel.Style = MetroFramework.MetroColorStyle.Teal;
            this.btncancel.TabIndex = 100;
            this.btncancel.Text = "     Cancel";
            this.btncancel.UseCustomBackColor = true;
            this.btncancel.UseSelectable = true;
            this.btncancel.UseStyleColors = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // picAdd
            // 
            this.picAdd.BackColor = System.Drawing.Color.Transparent;
            this.picAdd.BackgroundImage = global::PUPiMed.Properties.Resources.add_teal_box;
            this.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdd.Location = new System.Drawing.Point(325, 340);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(26, 26);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 98;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "btnadd";
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(320, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "   Save";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "";
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(39, 312);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(143, 23);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 92;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseSelectable = true;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
            this.txtCode.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AccessibleName = "";
            this.lblCode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCode.Location = new System.Drawing.Point(39, 287);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(143, 19);
            this.lblCode.TabIndex = 94;
            this.lblCode.Text = "Medicine Code :";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.White;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon.Image = global::PUPiMed.Properties.Resources.pill_teal;
            this.icon.Location = new System.Drawing.Point(39, 125);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(143, 143);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 93;
            this.icon.TabStop = false;
            // 
            // lblManu1
            // 
            this.lblManu1.AccessibleName = "";
            this.lblManu1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblManu1.Location = new System.Drawing.Point(216, 207);
            this.lblManu1.Name = "lblManu1";
            this.lblManu1.Size = new System.Drawing.Size(146, 19);
            this.lblManu1.TabIndex = 113;
            this.lblManu1.Text = "Manufacturer Code :";
            // 
            // txtManu
            // 
            this.txtManu.AccessibleName = "";
            this.txtManu.BackColor = System.Drawing.Color.White;
            this.txtManu.Lines = new string[0];
            this.txtManu.Location = new System.Drawing.Point(371, 207);
            this.txtManu.MaxLength = 32767;
            this.txtManu.Name = "txtManu";
            this.txtManu.PasswordChar = '\0';
            this.txtManu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManu.SelectedText = "";
            this.txtManu.Size = new System.Drawing.Size(165, 23);
            this.txtManu.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtManu.TabIndex = 95;
            this.txtManu.UseCustomBackColor = true;
            this.txtManu.UseSelectable = true;
            this.txtManu.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            this.txtManu.Click += new System.EventHandler(this.txtCode_TextChanged);
            this.txtManu.Enter += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // Title
            // 
            this.Title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Title.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Title.Location = new System.Drawing.Point(100, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(354, 58);
            this.Title.TabIndex = 114;
            this.Title.Text = "MEDICINE";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAddMedicine
            // 
            this.AccessibleName = "frmAddMedicine";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 395);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txtManu);
            this.Controls.Add(this.lblManu1);
            this.Controls.Add(this.cbManufacturer);
            this.Controls.Add(this.lblManu2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtManuName);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.picCancel);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.icon);
            this.MaximizeBox = false;
            this.Name = "FormAddMedicine";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbManufacturer;
        private MetroFramework.Controls.MetroLabel lblManu2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox txtMin;
        public MetroFramework.Controls.MetroTextBox txtMax;
        public MetroFramework.Controls.MetroTextBox txtManuName;
        public MetroFramework.Controls.MetroTextBox txtGen;
        private MetroFramework.Controls.MetroLabel lbltype;
        public MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile status;
        private System.Windows.Forms.PictureBox picCancel;
        public MetroFramework.Controls.MetroButton btncancel;
        private System.Windows.Forms.PictureBox picAdd;
        public MetroFramework.Controls.MetroButton btnAdd;
        public MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel lblCode;
        private System.Windows.Forms.PictureBox icon;
        private MetroFramework.Controls.MetroLabel lblManu1;
        public MetroFramework.Controls.MetroTextBox txtManu;
        private MetroFramework.Controls.MetroLabel Title;
    }
}