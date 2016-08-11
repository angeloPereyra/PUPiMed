namespace PUPiMed
{
    partial class UCItemInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mpanel = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReceiveInventory = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.gridItemInventory = new MetroFramework.Controls.MetroGrid();
            this.mpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // mpanel
            // 
            this.mpanel.AccessibleName = "pnlInventory";
            this.mpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpanel.AutoSize = true;
            this.mpanel.BackColor = System.Drawing.Color.White;
            this.mpanel.Controls.Add(this.gridItemInventory);
            this.mpanel.Controls.Add(this.pictureBox1);
            this.mpanel.Controls.Add(this.ReceiveInventory);
            this.mpanel.Controls.Add(this.label1);
            this.mpanel.Controls.Add(this.pictureBox12);
            this.mpanel.HorizontalScrollbarBarColor = true;
            this.mpanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanel.HorizontalScrollbarSize = 10;
            this.mpanel.Location = new System.Drawing.Point(0, 0);
            this.mpanel.Name = "mpanel";
            this.mpanel.Size = new System.Drawing.Size(787, 676);
            this.mpanel.TabIndex = 3;
            this.mpanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mpanel.UseCustomBackColor = true;
            this.mpanel.UseCustomForeColor = true;
            this.mpanel.VerticalScrollbarBarColor = true;
            this.mpanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpanel.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::PUPiMed.Properties.Resources.invent;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(600, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ReceiveInventory
            // 
            this.ReceiveInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReceiveInventory.BackColor = System.Drawing.Color.White;
            this.ReceiveInventory.Highlight = true;
            this.ReceiveInventory.Location = new System.Drawing.Point(595, 87);
            this.ReceiveInventory.Name = "ReceiveInventory";
            this.ReceiveInventory.Size = new System.Drawing.Size(183, 37);
            this.ReceiveInventory.Style = MetroFramework.MetroColorStyle.Teal;
            this.ReceiveInventory.TabIndex = 19;
            this.ReceiveInventory.Text = "   RECEIVE INVENTORY";
            this.ReceiveInventory.UseCustomBackColor = true;
            this.ReceiveInventory.UseSelectable = true;
            this.ReceiveInventory.UseStyleColors = true;
            this.ReceiveInventory.Click += new System.EventHandler(this.ReceiveInventory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(152, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Inventory";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::PUPiMed.Properties.Resources._01inventory2;
            this.pictureBox12.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(147, 133);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 3;
            this.pictureBox12.TabStop = false;
            // 
            // gridItemInventory
            // 
            this.gridItemInventory.AccessibleName = "";
            this.gridItemInventory.AllowDrop = true;
            this.gridItemInventory.AllowUserToAddRows = false;
            this.gridItemInventory.AllowUserToDeleteRows = false;
            this.gridItemInventory.AllowUserToResizeRows = false;
            this.gridItemInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItemInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItemInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridItemInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItemInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridItemInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridItemInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItemInventory.ColumnHeadersHeight = 28;
            this.gridItemInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridItemInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridItemInventory.EnableHeadersVisualStyles = false;
            this.gridItemInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridItemInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItemInventory.Location = new System.Drawing.Point(8, 130);
            this.gridItemInventory.MultiSelect = false;
            this.gridItemInventory.Name = "gridItemInventory";
            this.gridItemInventory.ReadOnly = true;
            this.gridItemInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridItemInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridItemInventory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridItemInventory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridItemInventory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.gridItemInventory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.gridItemInventory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridItemInventory.RowTemplate.DividerHeight = 1;
            this.gridItemInventory.RowTemplate.ErrorText = "n/a";
            this.gridItemInventory.RowTemplate.Height = 40;
            this.gridItemInventory.RowTemplate.ReadOnly = true;
            this.gridItemInventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItemInventory.ShowEditingIcon = false;
            this.gridItemInventory.Size = new System.Drawing.Size(770, 538);
            this.gridItemInventory.StandardTab = true;
            this.gridItemInventory.Style = MetroFramework.MetroColorStyle.Teal;
            this.gridItemInventory.TabIndex = 27;
            this.gridItemInventory.UseStyleColors = true;
            // 
            // UCItemInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpanel);
            this.Name = "UCItemInventory";
            this.Size = new System.Drawing.Size(787, 674);
            this.mpanel.ResumeLayout(false);
            this.mpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpanel;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton ReceiveInventory;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroGrid gridItemInventory;
    }
}
