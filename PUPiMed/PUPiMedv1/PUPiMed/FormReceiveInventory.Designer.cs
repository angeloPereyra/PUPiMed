﻿namespace PUPiMed
{
    partial class FormReceiveInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Yoe");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ugm",
            "Hi",
            "Hello",
            "Hasslebruh"}, -1);
            this.gridRI = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.listType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDateReceived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.cbSupplier = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pbAddSupplier = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pbAddItem = new System.Windows.Forms.PictureBox();
            this.cbItem = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridRI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRI
            // 
            this.gridRI.AllowUserToAddRows = false;
            this.gridRI.AllowUserToDeleteRows = false;
            this.gridRI.AllowUserToResizeRows = false;
            this.gridRI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridRI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridRI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridRI.ColumnHeadersHeight = 40;
            this.gridRI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridRI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.code,
            this.name,
            this.qty,
            this.supplier,
            this.received,
            this.ok});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRI.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridRI.EnableHeadersVisualStyles = false;
            this.gridRI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridRI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridRI.Location = new System.Drawing.Point(10, 118);
            this.gridRI.MultiSelect = false;
            this.gridRI.Name = "gridRI";
            this.gridRI.ReadOnly = true;
            this.gridRI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRI.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridRI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridRI.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridRI.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
            this.gridRI.RowTemplate.DividerHeight = 1;
            this.gridRI.RowTemplate.ErrorText = "n/a";
            this.gridRI.RowTemplate.ReadOnly = true;
            this.gridRI.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRI.Size = new System.Drawing.Size(873, 40);
            this.gridRI.Style = MetroFramework.MetroColorStyle.Teal;
            this.gridRI.TabIndex = 3;
            this.gridRI.UseCustomBackColor = true;
            this.gridRI.UseCustomForeColor = true;
            this.gridRI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRI_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(125, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 49);
            this.label1.TabIndex = 26;
            this.label1.Text = "Receive Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncancel
            // 
            this.btncancel.AccessibleName = "btncancel";
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.BackColor = System.Drawing.Color.White;
            this.btncancel.Highlight = true;
            this.btncancel.Location = new System.Drawing.Point(767, 644);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(116, 37);
            this.btncancel.Style = MetroFramework.MetroColorStyle.Teal;
            this.btncancel.TabIndex = 112;
            this.btncancel.Text = "     Cancel";
            this.btncancel.UseCustomBackColor = true;
            this.btncancel.UseSelectable = true;
            this.btncancel.UseStyleColors = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "btnadd";
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(648, 644);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 37);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSave.TabIndex = 111;
            this.btnSave.Text = "   Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listType,
            this.listCode,
            this.listName,
            this.listQty,
            this.listSupplier,
            this.listDateReceived});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Roboto", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.materialListView1.Location = new System.Drawing.Point(10, 207);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.MultiSelect = false;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(781, 420);
            this.materialListView1.TabIndex = 94;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // listType
            // 
            this.listType.Text = "Item Type";
            this.listType.Width = 85;
            // 
            // listCode
            // 
            this.listCode.Text = "Item Code";
            this.listCode.Width = 121;
            // 
            // listName
            // 
            this.listName.Text = "Name";
            this.listName.Width = 165;
            // 
            // listQty
            // 
            this.listQty.Text = "Quantity";
            this.listQty.Width = 94;
            // 
            // listSupplier
            // 
            this.listSupplier.Text = "Supplier";
            this.listSupplier.Width = 140;
            // 
            // listDateReceived
            // 
            this.listDateReceived.Text = "Date Received";
            this.listDateReceived.Width = 233;
            // 
            // cbType
            // 
            this.cbType.DisplayMember = "Medicine";
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Items.AddRange(new object[] {
            "Medicine",
            "Supply",
            "Equipment"});
            this.cbType.Location = new System.Drawing.Point(10, 164);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 29);
            this.cbType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbType.TabIndex = 102;
            this.cbType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbType.UseSelectable = true;
            this.cbType.UseStyleColors = true;
            this.cbType.ValueMember = "Medicine";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.DisplayIcon = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(388, 164);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.Size = new System.Drawing.Size(89, 29);
            this.metroTextBox3.TabIndex = 105;
            this.metroTextBox3.UseCustomBackColor = true;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Checked = false;
            this.metroDateTime1.DisplayFocus = true;
            this.metroDateTime1.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.metroDateTime1.Location = new System.Drawing.Point(610, 164);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(181, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroDateTime1.TabIndex = 107;
            this.metroDateTime1.UseStyleColors = true;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.ItemHeight = 23;
            this.cbSupplier.Location = new System.Drawing.Point(483, 164);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(96, 29);
            this.cbSupplier.TabIndex = 106;
            this.cbSupplier.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.DisplayIcon = false;
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(137, 164);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(96, 29);
            this.metroTextBox1.TabIndex = 103;
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "btnadd";
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(809, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 29);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 108;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.AccessibleName = "btnadd";
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(809, 280);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(74, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 110;
            this.metroButton1.Text = "Delete";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.AccessibleName = "btnadd";
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(809, 245);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(74, 29);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton2.TabIndex = 109;
            this.metroButton2.Text = "Edit";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            // 
            // type
            // 
            this.type.FillWeight = 101.995F;
            this.type.Frozen = true;
            this.type.HeaderText = "Item Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.type.Width = 80;
            // 
            // code
            // 
            this.code.FillWeight = 100.0319F;
            this.code.Frozen = true;
            this.code.HeaderText = "Item Code";
            this.code.MaxInputLength = 20;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 130;
            // 
            // name
            // 
            this.name.FillWeight = 146.5758F;
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 130;
            // 
            // qty
            // 
            this.qty.FillWeight = 70.03075F;
            this.qty.Frozen = true;
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.FillWeight = 105.2244F;
            this.supplier.Frozen = true;
            this.supplier.HeaderText = "Supplier";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            this.supplier.Width = 130;
            // 
            // received
            // 
            this.received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.received.FillWeight = 76.14214F;
            this.received.Frozen = true;
            this.received.HeaderText = "Date Received";
            this.received.Name = "received";
            this.received.ReadOnly = true;
            this.received.Width = 200;
            // 
            // ok
            // 
            this.ok.Frozen = true;
            this.ok.HeaderText = "";
            this.ok.Name = "ok";
            this.ok.ReadOnly = true;
            // 
            // pbAddSupplier
            // 
            this.pbAddSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAddSupplier.BackColor = System.Drawing.Color.Transparent;
            this.pbAddSupplier.BackgroundImage = global::PUPiMed.Properties.Resources._00add___Copy;
            this.pbAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddSupplier.Location = new System.Drawing.Point(582, 166);
            this.pbAddSupplier.Name = "pbAddSupplier";
            this.pbAddSupplier.Size = new System.Drawing.Size(25, 25);
            this.pbAddSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddSupplier.TabIndex = 106;
            this.pbAddSupplier.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::PUPiMed.Properties.Resources._00delete;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(772, 649);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PUPiMed.Properties.Resources._00add___Copy1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(653, 649);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::PUPiMed.Properties.Resources.invent2;
            this.pictureBox12.Location = new System.Drawing.Point(3, 7);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(116, 105);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 27;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pbAddItem
            // 
            this.pbAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAddItem.BackColor = System.Drawing.Color.Transparent;
            this.pbAddItem.BackgroundImage = global::PUPiMed.Properties.Resources._00add___Copy;
            this.pbAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddItem.Location = new System.Drawing.Point(358, 166);
            this.pbAddItem.Name = "pbAddItem";
            this.pbAddItem.Size = new System.Drawing.Size(25, 25);
            this.pbAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddItem.TabIndex = 113;
            this.pbAddItem.TabStop = false;
            this.pbAddItem.Click += new System.EventHandler(this.pbAddItem_Click);
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.ItemHeight = 23;
            this.cbItem.Location = new System.Drawing.Point(240, 164);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(112, 29);
            this.cbItem.TabIndex = 114;
            this.cbItem.UseSelectable = true;
            // 
            // FormReceiveInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 692);
            this.Controls.Add(this.pbAddItem);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.pbAddSupplier);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridRI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReceiveInventory";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            ((System.ComponentModel.ISupportInitialize)(this.gridRI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroGrid gridRI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btncancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader listType;
        private System.Windows.Forms.ColumnHeader listCode;
        private System.Windows.Forms.ColumnHeader listName;
        private System.Windows.Forms.ColumnHeader listQty;
        private System.Windows.Forms.ColumnHeader listSupplier;
        private System.Windows.Forms.ColumnHeader listDateReceived;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroComboBox cbSupplier;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn received;
        private System.Windows.Forms.DataGridViewButtonColumn ok;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.PictureBox pbAddSupplier;
        private System.Windows.Forms.PictureBox pbAddItem;
        private MetroFramework.Controls.MetroComboBox cbItem;
    }
}