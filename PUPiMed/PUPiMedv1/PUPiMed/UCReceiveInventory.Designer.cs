namespace PUPiMed
{
    partial class UCReceive_Inventory
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
            this.mbDelete = new MetroFramework.Controls.MetroButton();
            this.mbView = new MetroFramework.Controls.MetroButton();
            this.mbAdd = new MetroFramework.Controls.MetroButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridRI = new MetroFramework.Controls.MetroGrid();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRI)).BeginInit();
            this.SuspendLayout();
            // 
            // mbDelete
            // 
            this.mbDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbDelete.Highlight = true;
            this.mbDelete.Location = new System.Drawing.Point(677, 499);
            this.mbDelete.Name = "mbDelete";
            this.mbDelete.Size = new System.Drawing.Size(99, 37);
            this.mbDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbDelete.TabIndex = 23;
            this.mbDelete.Text = "    Delete";
            this.mbDelete.UseCustomBackColor = true;
            this.mbDelete.UseSelectable = true;
            this.mbDelete.UseStyleColors = true;
            // 
            // mbView
            // 
            this.mbView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbView.Highlight = true;
            this.mbView.Location = new System.Drawing.Point(572, 499);
            this.mbView.Name = "mbView";
            this.mbView.Size = new System.Drawing.Size(99, 37);
            this.mbView.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbView.TabIndex = 22;
            this.mbView.Text = "   Edit";
            this.mbView.UseCustomBackColor = true;
            this.mbView.UseSelectable = true;
            this.mbView.UseStyleColors = true;
            // 
            // mbAdd
            // 
            this.mbAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbAdd.Highlight = true;
            this.mbAdd.Location = new System.Drawing.Point(467, 499);
            this.mbAdd.Name = "mbAdd";
            this.mbAdd.Size = new System.Drawing.Size(99, 37);
            this.mbAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbAdd.TabIndex = 21;
            this.mbAdd.Text = "   Add";
            this.mbAdd.UseCustomBackColor = true;
            this.mbAdd.UseSelectable = true;
            this.mbAdd.UseStyleColors = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::PUPiMed.Properties.Resources.add;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::PUPiMed.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(683, 504);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PUPiMed.Properties.Resources.add;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::PUPiMed.Properties.Resources.edit;
            this.pictureBox2.Location = new System.Drawing.Point(578, 504);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PUPiMed.Properties.Resources.add;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(472, 504);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // gridRI
            // 
            this.gridRI.AllowUserToResizeRows = false;
            this.gridRI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridRI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridRI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRI.ColumnHeadersHeight = 28;
            this.gridRI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridRI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.type,
            this.name,
            this.qty,
            this.uom,
            this.supplier,
            this.dateReceive});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRI.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridRI.EnableHeadersVisualStyles = false;
            this.gridRI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRI.Location = new System.Drawing.Point(0, 0);
            this.gridRI.Name = "gridRI";
            this.gridRI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRI.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridRI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridRI.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridRI.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.gridRI.RowTemplate.DividerHeight = 1;
            this.gridRI.RowTemplate.ErrorText = "n/a";
            this.gridRI.RowTemplate.ReadOnly = true;
            this.gridRI.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRI.Size = new System.Drawing.Size(781, 62);
            this.gridRI.Style = MetroFramework.MetroColorStyle.Teal;
            this.gridRI.TabIndex = 2;
            this.gridRI.UseCustomBackColor = true;
            this.gridRI.UseCustomForeColor = true;
            this.gridRI.VirtualMode = true;
            // 
            // code
            // 
            this.code.HeaderText = "Item Code";
            this.code.MaxInputLength = 20;
            this.code.Name = "code";
            // 
            // type
            // 
            this.type.HeaderText = "Item Type";
            this.type.Name = "type";
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // uom
            // 
            this.uom.HeaderText = "UOM";
            this.uom.Name = "uom";
            this.uom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Supplier";
            this.supplier.Name = "supplier";
            // 
            // dateReceive
            // 
            this.dateReceive.HeaderText = "Date Received";
            this.dateReceive.Name = "dateReceive";
            // 
            // UCReceive_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mbDelete);
            this.Controls.Add(this.mbView);
            this.Controls.Add(this.mbAdd);
            this.Controls.Add(this.gridRI);
            this.Name = "UCReceive_Inventory";
            this.Size = new System.Drawing.Size(781, 541);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton mbDelete;
        private MetroFramework.Controls.MetroButton mbView;
        private MetroFramework.Controls.MetroButton mbAdd;
        public MetroFramework.Controls.MetroGrid gridRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewComboBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceive;
    }
}
