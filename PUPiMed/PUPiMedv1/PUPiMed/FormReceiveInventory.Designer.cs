namespace PUPiMed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceiveInventory));
            this.gridRI = new MetroFramework.Controls.MetroGrid();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.dtReceived = new MetroFramework.Controls.MetroDateTime();
            this.cbSupplier = new MetroFramework.Controls.MetroComboBox();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.cbName = new MetroFramework.Controls.MetroComboBox();
            this.listType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listReceived = new MaterialSkin.Controls.MaterialListView();
            this.listExp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRCode = new MetroFramework.Controls.MetroTextBox();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.pbAddItem = new System.Windows.Forms.PictureBox();
            this.pbAddSupplier = new System.Windows.Forms.PictureBox();
            this.picCancel = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtExp = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.gridRI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRI.ColumnHeadersHeight = 40;
            this.gridRI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridRI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.code,
            this.name,
            this.qty,
            this.exp,
            this.filler,
            this.ok});
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
            this.gridRI.Location = new System.Drawing.Point(0, 118);
            this.gridRI.MultiSelect = false;
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
            this.gridRI.Size = new System.Drawing.Size(962, 40);
            this.gridRI.Style = MetroFramework.MetroColorStyle.Teal;
            this.gridRI.TabIndex = 3;
            this.gridRI.UseCustomBackColor = true;
            this.gridRI.UseCustomForeColor = true;
            this.gridRI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRI_CellContentClick);
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
            // 
            // code
            // 
            this.code.FillWeight = 100.0319F;
            this.code.Frozen = true;
            this.code.HeaderText = "Item Code";
            this.code.MaxInputLength = 20;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 180;
            // 
            // name
            // 
            this.name.FillWeight = 146.5758F;
            this.name.Frozen = true;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.FillWeight = 70.03075F;
            this.qty.Frozen = true;
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 180;
            // 
            // exp
            // 
            this.exp.FillWeight = 105.2244F;
            this.exp.Frozen = true;
            this.exp.HeaderText = "Expiration Date";
            this.exp.MinimumWidth = 40;
            this.exp.Name = "exp";
            this.exp.ReadOnly = true;
            this.exp.Width = 80;
            // 
            // filler
            // 
            this.filler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.filler.FillWeight = 76.14214F;
            this.filler.Frozen = true;
            this.filler.HeaderText = "";
            this.filler.Name = "filler";
            this.filler.ReadOnly = true;
            this.filler.Width = 200;
            // 
            // ok
            // 
            this.ok.Frozen = true;
            this.ok.HeaderText = "";
            this.ok.Name = "ok";
            this.ok.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(125, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 49);
            this.label1.TabIndex = 26;
            this.label1.Text = "Receive Items";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "btncancel";
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Highlight = true;
            this.btnCancel.Location = new System.Drawing.Point(832, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 37);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCancel.TabIndex = 113;
            this.btnCancel.Text = "     Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "btnadd";
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(713, 582);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 37);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSave.TabIndex = 112;
            this.btnSave.Text = "   Save";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.cbType.Location = new System.Drawing.Point(21, 176);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 29);
            this.cbType.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbType.TabIndex = 102;
            this.cbType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbType.UseSelectable = true;
            this.cbType.UseStyleColors = true;
            this.cbType.ValueMember = "Medicine";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // txtQty
            // 
            this.txtQty.DisplayIcon = false;
            this.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(461, 176);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.Size = new System.Drawing.Size(81, 29);
            this.txtQty.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtQty.TabIndex = 105;
            this.txtQty.UseCustomBackColor = true;
            this.txtQty.UseSelectable = true;
            // 
            // dtReceived
            // 
            this.dtReceived.AllowDrop = true;
            this.dtReceived.Checked = false;
            this.dtReceived.DisplayFocus = true;
            this.dtReceived.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtReceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReceived.Location = new System.Drawing.Point(713, 383);
            this.dtReceived.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtReceived.Name = "dtReceived";
            this.dtReceived.Size = new System.Drawing.Size(229, 29);
            this.dtReceived.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtReceived.TabIndex = 111;
            this.dtReceived.UseStyleColors = true;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.ItemHeight = 23;
            this.cbSupplier.Location = new System.Drawing.Point(713, 454);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(195, 29);
            this.cbSupplier.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbSupplier.TabIndex = 112;
            this.cbSupplier.UseSelectable = true;
            this.cbSupplier.UseStyleColors = true;
            // 
            // txtCode
            // 
            this.txtCode.DisplayIcon = false;
            this.txtCode.Enabled = false;
            this.txtCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(148, 176);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(138, 29);
            this.txtCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCode.TabIndex = 103;
            this.txtCode.UseCustomBackColor = true;
            this.txtCode.UseSelectable = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "btnadd";
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(711, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 29);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 107;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.AccessibleName = "btnadd";
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(871, 176);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(74, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 109;
            this.metroButton1.Text = "Delete";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.AccessibleName = "btnadd";
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(791, 176);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(74, 29);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton2.TabIndex = 108;
            this.metroButton2.Text = "Edit";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.ItemHeight = 23;
            this.cbName.Location = new System.Drawing.Point(292, 176);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(132, 29);
            this.cbName.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbName.TabIndex = 104;
            this.cbName.UseSelectable = true;
            this.cbName.UseStyleColors = true;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // listType
            // 
            this.listType.Text = "Item Type";
            this.listType.Width = 120;
            // 
            // listCode
            // 
            this.listCode.Text = "Item Code";
            this.listCode.Width = 150;
            // 
            // listName
            // 
            this.listName.Text = "Name";
            this.listName.Width = 200;
            // 
            // listQty
            // 
            this.listQty.Text = "Quantity";
            this.listQty.Width = 80;
            // 
            // listReceived
            // 
            this.listReceived.AutoArrange = false;
            this.listReceived.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listType,
            this.listCode,
            this.listName,
            this.listQty,
            this.listExp});
            this.listReceived.Depth = 0;
            this.listReceived.Font = new System.Drawing.Font("Roboto", 24F);
            this.listReceived.FullRowSelect = true;
            this.listReceived.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listReceived.Location = new System.Drawing.Point(21, 220);
            this.listReceived.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listReceived.MouseState = MaterialSkin.MouseState.OUT;
            this.listReceived.MultiSelect = false;
            this.listReceived.Name = "listReceived";
            this.listReceived.OwnerDraw = true;
            this.listReceived.Size = new System.Drawing.Size(672, 404);
            this.listReceived.TabIndex = 94;
            this.listReceived.UseCompatibleStateImageBehavior = false;
            this.listReceived.View = System.Windows.Forms.View.Details;
            // 
            // listExp
            // 
            this.listExp.Text = "Exp";
            this.listExp.Width = 120;
            // 
            // txtRCode
            // 
            this.txtRCode.AccessibleName = "";
            this.txtRCode.BackColor = System.Drawing.Color.White;
            this.txtRCode.Lines = new string[0];
            this.txtRCode.Location = new System.Drawing.Point(713, 323);
            this.txtRCode.MaxLength = 32767;
            this.txtRCode.Name = "txtRCode";
            this.txtRCode.PasswordChar = '\0';
            this.txtRCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRCode.SelectedText = "";
            this.txtRCode.Size = new System.Drawing.Size(229, 29);
            this.txtRCode.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtRCode.TabIndex = 110;
            this.txtRCode.UseCustomBackColor = true;
            this.txtRCode.UseSelectable = true;
            // 
            // lblCode
            // 
            this.lblCode.AccessibleName = "";
            this.lblCode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCode.Location = new System.Drawing.Point(713, 301);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(143, 19);
            this.lblCode.TabIndex = 116;
            this.lblCode.Text = "Receiving Code :";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbAddItem
            // 
            this.pbAddItem.BackColor = System.Drawing.Color.Transparent;
            this.pbAddItem.BackgroundImage = global::PUPiMed.Properties.Resources.add_gray_box;
            this.pbAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddItem.Location = new System.Drawing.Point(430, 178);
            this.pbAddItem.Name = "pbAddItem";
            this.pbAddItem.Size = new System.Drawing.Size(25, 25);
            this.pbAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddItem.TabIndex = 113;
            this.pbAddItem.TabStop = false;
            this.pbAddItem.Click += new System.EventHandler(this.pbAddItem_Click);
            // 
            // pbAddSupplier
            // 
            this.pbAddSupplier.BackColor = System.Drawing.Color.Transparent;
            this.pbAddSupplier.BackgroundImage = global::PUPiMed.Properties.Resources.add_gray_box;
            this.pbAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddSupplier.Location = new System.Drawing.Point(917, 456);
            this.pbAddSupplier.Name = "pbAddSupplier";
            this.pbAddSupplier.Size = new System.Drawing.Size(25, 25);
            this.pbAddSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddSupplier.TabIndex = 106;
            this.pbAddSupplier.TabStop = false;
            this.pbAddSupplier.Click += new System.EventHandler(this.pbAddSupplier_Click);
            // 
            // picCancel
            // 
            this.picCancel.BackColor = System.Drawing.Color.White;
            this.picCancel.BackgroundImage = global::PUPiMed.Properties.Resources.cancel_teal_box;
            this.picCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCancel.Location = new System.Drawing.Point(837, 587);
            this.picCancel.Name = "picCancel";
            this.picCancel.Size = new System.Drawing.Size(26, 26);
            this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancel.TabIndex = 93;
            this.picCancel.TabStop = false;
            this.picCancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // picSave
            // 
            this.picSave.BackColor = System.Drawing.Color.Transparent;
            this.picSave.BackgroundImage = global::PUPiMed.Properties.Resources.add_teal_box;
            this.picSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSave.Location = new System.Drawing.Point(719, 587);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(26, 26);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSave.TabIndex = 91;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "";
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(713, 361);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 19);
            this.metroLabel1.TabIndex = 117;
            this.metroLabel1.Text = "Date Received   :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "";
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(713, 432);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 19);
            this.metroLabel2.TabIndex = 118;
            this.metroLabel2.Text = "Supplier   :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtExp
            // 
            this.dtExp.AllowDrop = true;
            this.dtExp.Checked = false;
            this.dtExp.DisplayFocus = true;
            this.dtExp.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.dtExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExp.Location = new System.Drawing.Point(548, 176);
            this.dtExp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtExp.Name = "dtExp";
            this.dtExp.Size = new System.Drawing.Size(145, 29);
            this.dtExp.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtExp.TabIndex = 106;
            this.dtExp.UseStyleColors = true;
            // 
            // FormReceiveInventory
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(960, 645);
            this.Controls.Add(this.dtExp);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtRCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.pbAddItem);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.pbAddSupplier);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.dtReceived);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.listReceived);
            this.Controls.Add(this.picCancel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridRI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormReceiveInventory";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.FormReceiveInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroGrid gridRI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox picCancel;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.PictureBox picSave;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroTextBox txtQty;
        private MetroFramework.Controls.MetroDateTime dtReceived;
        private MetroFramework.Controls.MetroComboBox cbSupplier;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.PictureBox pbAddSupplier;
        private System.Windows.Forms.PictureBox pbAddItem;
        private MetroFramework.Controls.MetroComboBox cbName;
        private System.Windows.Forms.ColumnHeader listType;
        private System.Windows.Forms.ColumnHeader listCode;
        private System.Windows.Forms.ColumnHeader listName;
        private System.Windows.Forms.ColumnHeader listQty;
        private MaterialSkin.Controls.MaterialListView listReceived;
        public MetroFramework.Controls.MetroTextBox txtRCode;
        private MetroFramework.Controls.MetroLabel lblCode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn filler;
        private System.Windows.Forms.DataGridViewButtonColumn ok;
        private MetroFramework.Controls.MetroDateTime dtExp;
        private System.Windows.Forms.ColumnHeader listExp;
    }
}