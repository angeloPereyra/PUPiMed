namespace PUPiMed
{
    partial class Login
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
            this.btnLOGIN = new MaterialSkin.Controls.MaterialFlatButton();
            this.boxUserID = new MetroFramework.Controls.MetroTextBox();
            this.lblPassCode = new MetroFramework.Controls.MetroLabel();
            this.lblUserCode = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.boxPassCode = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLOGIN
            // 
            this.btnLOGIN.AccessibleName = "btnLogin";
            this.btnLOGIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLOGIN.AutoSize = true;
            this.btnLOGIN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLOGIN.Depth = 0;
            this.btnLOGIN.Location = new System.Drawing.Point(217, 299);
            this.btnLOGIN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLOGIN.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLOGIN.Name = "btnLOGIN";
            this.btnLOGIN.Primary = false;
            this.btnLOGIN.Size = new System.Drawing.Size(52, 36);
            this.btnLOGIN.TabIndex = 3;
            this.btnLOGIN.Text = "LOGIN";
            this.btnLOGIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLOGIN.UseVisualStyleBackColor = true;
            this.btnLOGIN.Click += new System.EventHandler(this.btnLOGIN_Click);
            // 
            // boxUserID
            // 
            this.boxUserID.AccessibleName = "boxUserID";
            this.boxUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxUserID.Lines = new string[0];
            this.boxUserID.Location = new System.Drawing.Point(135, 228);
            this.boxUserID.MaxLength = 32767;
            this.boxUserID.Name = "boxUserID";
            this.boxUserID.PasswordChar = '\0';
            this.boxUserID.PromptText = "Username";
            this.boxUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.boxUserID.SelectedText = "";
            this.boxUserID.Size = new System.Drawing.Size(251, 23);
            this.boxUserID.Style = MetroFramework.MetroColorStyle.Teal;
            this.boxUserID.TabIndex = 1;
            this.boxUserID.UseCustomBackColor = true;
            this.boxUserID.UseSelectable = true;
            this.boxUserID.UseStyleColors = true;
            // 
            // lblPassCode
            // 
            this.lblPassCode.AccessibleName = "lblPassCode";
            this.lblPassCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassCode.AutoSize = true;
            this.lblPassCode.Location = new System.Drawing.Point(38, 266);
            this.lblPassCode.Name = "lblPassCode";
            this.lblPassCode.Size = new System.Drawing.Size(77, 19);
            this.lblPassCode.TabIndex = 9;
            this.lblPassCode.Text = "Pass Code :";
            // 
            // lblUserCode
            // 
            this.lblUserCode.AccessibleName = "lblUserCode";
            this.lblUserCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.Location = new System.Drawing.Point(58, 230);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(58, 19);
            this.lblUserCode.TabIndex = 7;
            this.lblUserCode.Text = "User ID :";
            // 
            // metroPanel1
            // 
            this.metroPanel1.AccessibleName = "mpanel";
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 13);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(170, 25);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // boxPassCode
            // 
            this.boxPassCode.AccessibleName = "boxPassCode";
            this.boxPassCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxPassCode.Lines = new string[0];
            this.boxPassCode.Location = new System.Drawing.Point(135, 264);
            this.boxPassCode.MaxLength = 32767;
            this.boxPassCode.Name = "boxPassCode";
            this.boxPassCode.PasswordChar = '●';
            this.boxPassCode.PromptText = "Password";
            this.boxPassCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.boxPassCode.SelectedText = "";
            this.boxPassCode.Size = new System.Drawing.Size(251, 23);
            this.boxPassCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.boxPassCode.TabIndex = 2;
            this.boxPassCode.UseCustomBackColor = true;
            this.boxPassCode.UseSelectable = true;
            this.boxPassCode.UseStyleColors = true;
            this.boxPassCode.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PUPiMed.Properties.Resources.Patient_Logs_and_Inventory_System_Logo3;
            this.pictureBox1.Location = new System.Drawing.Point(29, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 351);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnLOGIN);
            this.Controls.Add(this.boxUserID);
            this.Controls.Add(this.boxPassCode);
            this.Controls.Add(this.lblPassCode);
            this.Controls.Add(this.lblUserCode);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.Login_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnLOGIN;
        private MetroFramework.Controls.MetroTextBox boxUserID;
        private MetroFramework.Controls.MetroTextBox boxPassCode;
        private MetroFramework.Controls.MetroLabel lblPassCode;
        private MetroFramework.Controls.MetroLabel lblUserCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label1;
    }
}