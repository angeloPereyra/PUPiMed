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
            this.medcode = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.formlbl = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.medicon = new System.Windows.Forms.PictureBox();
            this.status = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMin = new MetroFramework.Controls.MetroTextBox();
            this.txtMax = new MetroFramework.Controls.MetroTextBox();
            this.txtManu = new MetroFramework.Controls.MetroTextBox();
            this.txtGen = new MetroFramework.Controls.MetroTextBox();
            this.lblother = new MetroFramework.Controls.MetroLabel();
            this.lbltype = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicon)).BeginInit();
            this.SuspendLayout();
            // 
            // medcode
            // 
            this.medcode.AccessibleName = "medcode";
            this.medcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medcode.AutoSize = true;
            this.medcode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.medcode.Location = new System.Drawing.Point(43, 277);
            this.medcode.Name = "medcode";
            this.medcode.Size = new System.Drawing.Size(117, 19);
            this.medcode.Style = MetroFramework.MetroColorStyle.Teal;
            this.medcode.TabIndex = 7;
            this.medcode.Text = "Medicine Code :";
            // 
            // txtCode
            // 
            this.txtCode.AccessibleName = "medname";
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(29, 308);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(143, 23);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 0;
            this.txtCode.UseSelectable = true;
            // 
            // formlbl
            // 
            this.formlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.formlbl.Depth = 0;
            this.formlbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.formlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.formlbl.Location = new System.Drawing.Point(1, 4);
            this.formlbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.formlbl.Name = "formlbl";
            this.formlbl.Size = new System.Drawing.Size(546, 68);
            this.formlbl.TabIndex = 9;
            this.formlbl.Text = "MEDICINE";
            this.formlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "btnadd";
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(303, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "   Save";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btncancel
            // 
            this.btncancel.AccessibleName = "btncancel";
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.BackColor = System.Drawing.Color.White;
            this.btncancel.Highlight = true;
            this.btncancel.Location = new System.Drawing.Point(422, 302);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(99, 37);
            this.btncancel.Style = MetroFramework.MetroColorStyle.Teal;
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "     Cancel";
            this.btncancel.UseCustomBackColor = true;
            this.btncancel.UseSelectable = true;
            this.btncancel.UseStyleColors = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::PUPiMed.Properties.Resources._00delete;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(427, 307);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PUPiMed.Properties.Resources._00add___Copy1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(308, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
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
            this.medicon.Image = global::PUPiMed.Properties.Resources.med321;
            this.medicon.Location = new System.Drawing.Point(29, 115);
            this.medicon.Name = "medicon";
            this.medicon.Size = new System.Drawing.Size(143, 143);
            this.medicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medicon.TabIndex = 6;
            this.medicon.TabStop = false;
            // 
            // status
            // 
            this.status.ActiveControl = null;
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.BackColor = System.Drawing.Color.DarkCyan;
            this.status.Location = new System.Drawing.Point(-2, 62);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(549, 23);
            this.status.TabIndex = 18;
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.status.UseCustomBackColor = true;
            this.status.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "lblmed";
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(365, 263);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 62;
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
            this.metroLabel2.Location = new System.Drawing.Point(200, 263);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 61;
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
            this.txtMin.Location = new System.Drawing.Point(286, 261);
            this.txtMin.MaxLength = 32767;
            this.txtMin.Name = "txtMin";
            this.txtMin.PasswordChar = '\0';
            this.txtMin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMin.SelectedText = "";
            this.txtMin.Size = new System.Drawing.Size(70, 23);
            this.txtMin.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtMin.TabIndex = 56;
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
            this.txtMax.Location = new System.Drawing.Point(451, 261);
            this.txtMax.MaxLength = 32767;
            this.txtMax.Name = "txtMax";
            this.txtMax.PasswordChar = '\0';
            this.txtMax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMax.SelectedText = "";
            this.txtMax.Size = new System.Drawing.Size(70, 23);
            this.txtMax.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtMax.TabIndex = 57;
            this.txtMax.UseCustomBackColor = true;
            this.txtMax.UseSelectable = true;
            // 
            // txtManu
            // 
            this.txtManu.AccessibleName = "";
            this.txtManu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManu.BackColor = System.Drawing.Color.White;
            this.txtManu.Lines = new string[0];
            this.txtManu.Location = new System.Drawing.Point(321, 211);
            this.txtManu.MaxLength = 32767;
            this.txtManu.Name = "txtManu";
            this.txtManu.PasswordChar = '\0';
            this.txtManu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManu.SelectedText = "";
            this.txtManu.Size = new System.Drawing.Size(200, 23);
            this.txtManu.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtManu.TabIndex = 55;
            this.txtManu.UseCustomBackColor = true;
            this.txtManu.UseSelectable = true;
            // 
            // txtGen
            // 
            this.txtGen.AccessibleName = "";
            this.txtGen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGen.BackColor = System.Drawing.Color.White;
            this.txtGen.Lines = new string[0];
            this.txtGen.Location = new System.Drawing.Point(321, 161);
            this.txtGen.MaxLength = 32767;
            this.txtGen.Name = "txtGen";
            this.txtGen.PasswordChar = '\0';
            this.txtGen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGen.SelectedText = "";
            this.txtGen.Size = new System.Drawing.Size(200, 23);
            this.txtGen.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtGen.TabIndex = 54;
            this.txtGen.UseCustomBackColor = true;
            this.txtGen.UseSelectable = true;
            // 
            // lblother
            // 
            this.lblother.AccessibleName = "lblother";
            this.lblother.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblother.AutoSize = true;
            this.lblother.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblother.Location = new System.Drawing.Point(200, 213);
            this.lblother.Name = "lblother";
            this.lblother.Size = new System.Drawing.Size(107, 19);
            this.lblother.TabIndex = 60;
            this.lblother.Text = "Manufacturer :";
            // 
            // lbltype
            // 
            this.lbltype.AccessibleName = "lbltype";
            this.lbltype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltype.AutoSize = true;
            this.lbltype.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbltype.Location = new System.Drawing.Point(200, 163);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(116, 19);
            this.lbltype.TabIndex = 59;
            this.lbltype.Text = "Generic Name : ";
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "";
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(266, 116);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(255, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtName.TabIndex = 53;
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
            this.metroLabel1.Location = new System.Drawing.Point(200, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Name :";
            // 
            // AddMedicine
            // 
            this.AccessibleName = "frmAddMedicine";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 362);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtManu);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.lblother);
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
        private System.Windows.Forms.PictureBox medicon;
        private MetroFramework.Controls.MetroLabel medcode;
        private MaterialSkin.Controls.MaterialLabel formlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile status;
        public MetroFramework.Controls.MetroButton btnAdd;
        public MetroFramework.Controls.MetroButton btncancel;
        public MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox txtMin;
        public MetroFramework.Controls.MetroTextBox txtMax;
        public MetroFramework.Controls.MetroTextBox txtManu;
        public MetroFramework.Controls.MetroTextBox txtGen;
        private MetroFramework.Controls.MetroLabel lblother;
        private MetroFramework.Controls.MetroLabel lbltype;
        public MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}