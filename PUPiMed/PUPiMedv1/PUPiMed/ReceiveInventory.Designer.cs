namespace PUPiMed
{
    partial class ReceiveInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mbDelete = new MetroFramework.Controls.MetroButton();
            this.mbAdd = new MetroFramework.Controls.MetroButton();
            this.gridRI = new MetroFramework.Controls.MetroGrid();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemtype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAddpatient = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::PUPiMed.Properties.Resources.add;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::PUPiMed.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(678, 589);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PUPiMed.Properties.Resources.add;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(561, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mbDelete
            // 
            this.mbDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbDelete.Highlight = true;
            this.mbDelete.Location = new System.Drawing.Point(672, 584);
            this.mbDelete.Name = "mbDelete";
            this.mbDelete.Size = new System.Drawing.Size(99, 37);
            this.mbDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbDelete.TabIndex = 30;
            this.mbDelete.Text = "    Cancel";
            this.mbDelete.UseCustomBackColor = true;
            this.mbDelete.UseSelectable = true;
            this.mbDelete.UseStyleColors = true;
            this.mbDelete.Click += new System.EventHandler(this.mbDelete_Click);
            // 
            // mbAdd
            // 
            this.mbAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbAdd.Highlight = true;
            this.mbAdd.Location = new System.Drawing.Point(556, 584);
            this.mbAdd.Name = "mbAdd";
            this.mbAdd.Size = new System.Drawing.Size(99, 37);
            this.mbAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbAdd.TabIndex = 28;
            this.mbAdd.Text = "   Save";
            this.mbAdd.UseCustomBackColor = true;
            this.mbAdd.UseSelectable = true;
            this.mbAdd.UseStyleColors = true;
            this.mbAdd.Click += new System.EventHandler(this.mbAdd_Click);
            // 
            // gridRI
            // 
            this.gridRI.AllowUserToAddRows = false;
            this.gridRI.AllowUserToDeleteRows = false;
            this.gridRI.AllowUserToResizeRows = false;
            this.gridRI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.itemtype,
            this.name,
            this.qty,
            this.consumed,
            this.remaining,
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
            this.gridRI.Location = new System.Drawing.Point(0, 85);
            this.gridRI.Name = "gridRI";
            this.gridRI.ReadOnly = true;
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
            this.gridRI.Size = new System.Drawing.Size(781, 493);
            this.gridRI.Style = MetroFramework.MetroColorStyle.Teal;
            this.gridRI.TabIndex = 27;
            this.gridRI.UseCustomBackColor = true;
            this.gridRI.UseCustomForeColor = true;
            // 
            // code
            // 
            this.code.HeaderText = "Item Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // itemtype
            // 
            this.itemtype.HeaderText = "Item Type";
            this.itemtype.Name = "itemtype";
            this.itemtype.ReadOnly = true;
            this.itemtype.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemtype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // consumed
            // 
            this.consumed.HeaderText = "UOM";
            this.consumed.Name = "consumed";
            this.consumed.ReadOnly = true;
            // 
            // remaining
            // 
            this.remaining.HeaderText = "Supplier";
            this.remaining.Name = "remaining";
            this.remaining.ReadOnly = true;
            // 
            // dateReceive
            // 
            this.dateReceive.HeaderText = "Date Received";
            this.dateReceive.Name = "dateReceive";
            this.dateReceive.ReadOnly = true;
            // 
            // lblAddpatient
            // 
            this.lblAddpatient.AccessibleName = "lblAddPatient";
            this.lblAddpatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddpatient.Depth = 0;
            this.lblAddpatient.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddpatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddpatient.Location = new System.Drawing.Point(-1, 30);
            this.lblAddpatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddpatient.Name = "lblAddpatient";
            this.lblAddpatient.Size = new System.Drawing.Size(782, 42);
            this.lblAddpatient.TabIndex = 35;
            this.lblAddpatient.Text = "RECEIVE INVENTORY";
            this.lblAddpatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReceiveInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 632);
            this.Controls.Add(this.lblAddpatient);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mbDelete);
            this.Controls.Add(this.mbAdd);
            this.Controls.Add(this.gridRI);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "ReceiveInventory";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton mbDelete;
        private MetroFramework.Controls.MetroButton mbAdd;
        public MetroFramework.Controls.MetroGrid gridRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumed;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceive;
        private MaterialSkin.Controls.MaterialLabel lblAddpatient;
    }
}