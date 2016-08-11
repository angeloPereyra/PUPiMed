using System;

namespace PUPiMed
{
    partial class UCItemLibrary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mpanel = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.gridItemLibrary = new MetroFramework.Controls.MetroGrid();
            this.mpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // mpanel
            // 
            this.mpanel.AccessibleName = "mpanel";
            this.mpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpanel.AutoSize = true;
            this.mpanel.BackColor = System.Drawing.Color.White;
            this.mpanel.Controls.Add(this.gridItemLibrary);
            this.mpanel.Controls.Add(this.label1);
            this.mpanel.Controls.Add(this.pictureBox12);
            this.mpanel.HorizontalScrollbarBarColor = true;
            this.mpanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanel.HorizontalScrollbarSize = 10;
            this.mpanel.Location = new System.Drawing.Point(0, 0);
            this.mpanel.Name = "mpanel";
            this.mpanel.Size = new System.Drawing.Size(787, 676);
            this.mpanel.TabIndex = 5;
            this.mpanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mpanel.UseCustomBackColor = true;
            this.mpanel.UseCustomForeColor = true;
            this.mpanel.VerticalScrollbarBarColor = true;
            this.mpanel.VerticalScrollbarHighlightOnWheel = false;
            this.mpanel.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(162, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 49);
            this.label1.TabIndex = 25;
            this.label1.Text = "Item Library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::PUPiMed.Properties.Resources._01lib21;
            this.pictureBox12.Location = new System.Drawing.Point(9, 4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(138, 124);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 4;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // gridItemLibrary
            // 
            this.gridItemLibrary.AccessibleName = "";
            this.gridItemLibrary.AllowDrop = true;
            this.gridItemLibrary.AllowUserToAddRows = false;
            this.gridItemLibrary.AllowUserToDeleteRows = false;
            this.gridItemLibrary.AllowUserToResizeRows = false;
            this.gridItemLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItemLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItemLibrary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridItemLibrary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItemLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridItemLibrary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridItemLibrary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridItemLibrary.ColumnHeadersHeight = 28;
            this.gridItemLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridItemLibrary.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridItemLibrary.EnableHeadersVisualStyles = false;
            this.gridItemLibrary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridItemLibrary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItemLibrary.Location = new System.Drawing.Point(8, 130);
            this.gridItemLibrary.MultiSelect = false;
            this.gridItemLibrary.Name = "gridItemLibrary";
            this.gridItemLibrary.ReadOnly = true;
            this.gridItemLibrary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemLibrary.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridItemLibrary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridItemLibrary.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridItemLibrary.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridItemLibrary.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.gridItemLibrary.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.gridItemLibrary.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridItemLibrary.RowTemplate.DividerHeight = 1;
            this.gridItemLibrary.RowTemplate.ErrorText = "n/a";
            this.gridItemLibrary.RowTemplate.Height = 40;
            this.gridItemLibrary.RowTemplate.ReadOnly = true;
            this.gridItemLibrary.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItemLibrary.ShowEditingIcon = false;
            this.gridItemLibrary.Size = new System.Drawing.Size(770, 538);
            this.gridItemLibrary.StandardTab = true;
            this.gridItemLibrary.Style = MetroFramework.MetroColorStyle.Teal;
            this.gridItemLibrary.TabIndex = 26;
            this.gridItemLibrary.UseStyleColors = true;
            // 
            // UCItemLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mpanel);
            this.Name = "UCItemLibrary";
            this.Size = new System.Drawing.Size(787, 676);
            this.mpanel.ResumeLayout(false);
            this.mpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpanel;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroGrid gridItemLibrary;
    }
}
