namespace PUPiMed
{
    partial class FormAddDistribItem
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
            this.lblAddpatient = new MaterialSkin.Controls.MaterialLabel();
            this.basicinfo = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.itemtype = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.itemcode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.available = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.qty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.UOM = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.total = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.balance = new MetroFramework.Controls.MetroTextBox();
            this.materialCheckBox11 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox12 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox13 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox14 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox15 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox6 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox7 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox8 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox9 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox10 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox5 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox4 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.itemname = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddpatient
            // 
            this.lblAddpatient.AccessibleName = "lblAddPatient";
            this.lblAddpatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddpatient.Depth = 0;
            this.lblAddpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblAddpatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddpatient.Location = new System.Drawing.Point(-2, 8);
            this.lblAddpatient.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddpatient.Name = "lblAddpatient";
            this.lblAddpatient.Size = new System.Drawing.Size(883, 83);
            this.lblAddpatient.TabIndex = 35;
            this.lblAddpatient.Text = "ADD ITEM TO DISTRIBUTE";
            this.lblAddpatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // basicinfo
            // 
            this.basicinfo.AccessibleName = "basicinfos";
            this.basicinfo.ActiveControl = null;
            this.basicinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basicinfo.BackColor = System.Drawing.Color.DarkCyan;
            this.basicinfo.Enabled = false;
            this.basicinfo.Location = new System.Drawing.Point(15, 79);
            this.basicinfo.Name = "basicinfo";
            this.basicinfo.Size = new System.Drawing.Size(815, 21);
            this.basicinfo.TabIndex = 36;
            this.basicinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.basicinfo.UseCustomBackColor = true;
            this.basicinfo.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AccessibleName = "ptype";
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(79, 315);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(84, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel8.TabIndex = 37;
            this.metroLabel8.Text = "Item Type :";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // itemtype
            // 
            this.itemtype.AccessibleName = "ptype";
            this.itemtype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemtype.FormattingEnabled = true;
            this.itemtype.ItemHeight = 23;
            this.itemtype.Items.AddRange(new object[] {
            "Medicines",
            "Supplies",
            "Equipments"});
            this.itemtype.Location = new System.Drawing.Point(169, 305);
            this.itemtype.Name = "itemtype";
            this.itemtype.Size = new System.Drawing.Size(185, 29);
            this.itemtype.Style = MetroFramework.MetroColorStyle.Teal;
            this.itemtype.TabIndex = 38;
            this.itemtype.UseSelectable = true;
            this.itemtype.SelectedIndexChanged += new System.EventHandler(this.itemtype_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "ptype";
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(72, 346);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Item Name :";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "ptype";
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(77, 379);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Item Code :";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // itemcode
            // 
            this.itemcode.AccessibleName = "fname";
            this.itemcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itemcode.Lines = new string[0];
            this.itemcode.Location = new System.Drawing.Point(169, 375);
            this.itemcode.MaxLength = 32767;
            this.itemcode.Name = "itemcode";
            this.itemcode.PasswordChar = '\0';
            this.itemcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemcode.SelectedText = "";
            this.itemcode.Size = new System.Drawing.Size(185, 23);
            this.itemcode.Style = MetroFramework.MetroColorStyle.Teal;
            this.itemcode.TabIndex = 42;
            this.itemcode.UseCustomBackColor = true;
            this.itemcode.UseSelectable = true;
            this.itemcode.Click += new System.EventHandler(this.itemcode_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AccessibleName = "ptype";
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(380, 315);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel4.TabIndex = 59;
            this.metroLabel4.Text = "Available : ";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // available
            // 
            this.available.AccessibleName = "fname";
            this.available.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.available.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.available.Lines = new string[0];
            this.available.Location = new System.Drawing.Point(476, 311);
            this.available.MaxLength = 32767;
            this.available.Name = "available";
            this.available.PasswordChar = '\0';
            this.available.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.available.SelectedText = "";
            this.available.Size = new System.Drawing.Size(103, 23);
            this.available.Style = MetroFramework.MetroColorStyle.Teal;
            this.available.TabIndex = 60;
            this.available.UseCustomBackColor = true;
            this.available.UseSelectable = true;
            this.available.Click += new System.EventHandler(this.available_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AccessibleName = "ptype";
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(386, 346);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel5.TabIndex = 61;
            this.metroLabel5.Text = "Quantity : ";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // qty
            // 
            this.qty.AccessibleName = "fname";
            this.qty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qty.Lines = new string[0];
            this.qty.Location = new System.Drawing.Point(476, 342);
            this.qty.MaxLength = 32767;
            this.qty.Name = "qty";
            this.qty.PasswordChar = '\0';
            this.qty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qty.SelectedText = "";
            this.qty.Size = new System.Drawing.Size(103, 23);
            this.qty.Style = MetroFramework.MetroColorStyle.Teal;
            this.qty.TabIndex = 62;
            this.qty.UseCustomBackColor = true;
            this.qty.UseSelectable = true;
            this.qty.Click += new System.EventHandler(this.qty_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AccessibleName = "ptype";
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(407, 379);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel6.TabIndex = 63;
            this.metroLabel6.Text = "UOM :";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // UOM
            // 
            this.UOM.AccessibleName = "ptype";
            this.UOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UOM.FormattingEnabled = true;
            this.UOM.ItemHeight = 23;
            this.UOM.Location = new System.Drawing.Point(476, 375);
            this.UOM.Name = "UOM";
            this.UOM.Size = new System.Drawing.Size(103, 29);
            this.UOM.Style = MetroFramework.MetroColorStyle.Teal;
            this.UOM.TabIndex = 64;
            this.UOM.UseSelectable = true;
            this.UOM.SelectedIndexChanged += new System.EventHandler(this.UOM_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AccessibleName = "ptype";
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(644, 315);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel7.TabIndex = 65;
            this.metroLabel7.Text = "Total : ";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // total
            // 
            this.total.AccessibleName = "fname";
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.total.Lines = new string[0];
            this.total.Location = new System.Drawing.Point(711, 311);
            this.total.MaxLength = 32767;
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(74, 23);
            this.total.Style = MetroFramework.MetroColorStyle.Teal;
            this.total.TabIndex = 66;
            this.total.UseCustomBackColor = true;
            this.total.UseSelectable = true;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AccessibleName = "ptype";
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(626, 346);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(73, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel9.TabIndex = 67;
            this.metroLabel9.Text = "Balance : ";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // balance
            // 
            this.balance.AccessibleName = "fname";
            this.balance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.balance.Lines = new string[0];
            this.balance.Location = new System.Drawing.Point(711, 342);
            this.balance.MaxLength = 32767;
            this.balance.Name = "balance";
            this.balance.PasswordChar = '\0';
            this.balance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.balance.SelectedText = "";
            this.balance.Size = new System.Drawing.Size(74, 23);
            this.balance.Style = MetroFramework.MetroColorStyle.Teal;
            this.balance.TabIndex = 68;
            this.balance.UseCustomBackColor = true;
            this.balance.UseSelectable = true;
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // materialCheckBox11
            // 
            this.materialCheckBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox11.AutoSize = true;
            this.materialCheckBox11.Depth = 0;
            this.materialCheckBox11.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox11.Location = new System.Drawing.Point(685, 243);
            this.materialCheckBox11.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox11.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox11.Name = "materialCheckBox11";
            this.materialCheckBox11.Ripple = true;
            this.materialCheckBox11.Size = new System.Drawing.Size(72, 30);
            this.materialCheckBox11.TabIndex = 84;
            this.materialCheckBox11.Text = "Unisan";
            this.materialCheckBox11.UseVisualStyleBackColor = true;
            this.materialCheckBox11.CheckedChanged += new System.EventHandler(this.materialCheckBox11_CheckedChanged);
            // 
            // materialCheckBox12
            // 
            this.materialCheckBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox12.AutoSize = true;
            this.materialCheckBox12.Depth = 0;
            this.materialCheckBox12.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox12.Location = new System.Drawing.Point(685, 213);
            this.materialCheckBox12.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox12.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox12.Name = "materialCheckBox12";
            this.materialCheckBox12.Ripple = true;
            this.materialCheckBox12.Size = new System.Drawing.Size(68, 30);
            this.materialCheckBox12.TabIndex = 83;
            this.materialCheckBox12.Text = "Ragay";
            this.materialCheckBox12.UseVisualStyleBackColor = true;
            this.materialCheckBox12.CheckedChanged += new System.EventHandler(this.materialCheckBox12_CheckedChanged);
            // 
            // materialCheckBox13
            // 
            this.materialCheckBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox13.AutoSize = true;
            this.materialCheckBox13.Depth = 0;
            this.materialCheckBox13.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox13.Location = new System.Drawing.Point(685, 153);
            this.materialCheckBox13.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox13.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox13.Name = "materialCheckBox13";
            this.materialCheckBox13.Ripple = true;
            this.materialCheckBox13.Size = new System.Drawing.Size(82, 30);
            this.materialCheckBox13.TabIndex = 82;
            this.materialCheckBox13.Text = "Malanay";
            this.materialCheckBox13.UseVisualStyleBackColor = true;
            this.materialCheckBox13.CheckedChanged += new System.EventHandler(this.materialCheckBox13_CheckedChanged);
            // 
            // materialCheckBox14
            // 
            this.materialCheckBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox14.AutoSize = true;
            this.materialCheckBox14.Depth = 0;
            this.materialCheckBox14.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox14.Location = new System.Drawing.Point(685, 183);
            this.materialCheckBox14.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox14.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox14.Name = "materialCheckBox14";
            this.materialCheckBox14.Ripple = true;
            this.materialCheckBox14.Size = new System.Drawing.Size(100, 30);
            this.materialCheckBox14.TabIndex = 81;
            this.materialCheckBox14.Text = "Sto. Tomas";
            this.materialCheckBox14.UseVisualStyleBackColor = true;
            this.materialCheckBox14.CheckedChanged += new System.EventHandler(this.materialCheckBox14_CheckedChanged);
            // 
            // materialCheckBox15
            // 
            this.materialCheckBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox15.AutoSize = true;
            this.materialCheckBox15.Depth = 0;
            this.materialCheckBox15.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox15.Location = new System.Drawing.Point(685, 123);
            this.materialCheckBox15.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox15.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox15.Name = "materialCheckBox15";
            this.materialCheckBox15.Ripple = true;
            this.materialCheckBox15.Size = new System.Drawing.Size(67, 30);
            this.materialCheckBox15.TabIndex = 80;
            this.materialCheckBox15.Text = "Lopez";
            this.materialCheckBox15.UseVisualStyleBackColor = true;
            this.materialCheckBox15.CheckedChanged += new System.EventHandler(this.materialCheckBox15_CheckedChanged);
            // 
            // materialCheckBox6
            // 
            this.materialCheckBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox6.AutoSize = true;
            this.materialCheckBox6.Depth = 0;
            this.materialCheckBox6.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox6.Location = new System.Drawing.Point(510, 243);
            this.materialCheckBox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox6.Name = "materialCheckBox6";
            this.materialCheckBox6.Ripple = true;
            this.materialCheckBox6.Size = new System.Drawing.Size(69, 30);
            this.materialCheckBox6.TabIndex = 79;
            this.materialCheckBox6.Text = "Cavite";
            this.materialCheckBox6.UseVisualStyleBackColor = true;
            this.materialCheckBox6.CheckedChanged += new System.EventHandler(this.materialCheckBox6_CheckedChanged);
            // 
            // materialCheckBox7
            // 
            this.materialCheckBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox7.AutoSize = true;
            this.materialCheckBox7.Depth = 0;
            this.materialCheckBox7.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox7.Location = new System.Drawing.Point(510, 213);
            this.materialCheckBox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox7.Name = "materialCheckBox7";
            this.materialCheckBox7.Ripple = true;
            this.materialCheckBox7.Size = new System.Drawing.Size(73, 30);
            this.materialCheckBox7.TabIndex = 78;
            this.materialCheckBox7.Text = "Bataan";
            this.materialCheckBox7.UseVisualStyleBackColor = true;
            this.materialCheckBox7.CheckedChanged += new System.EventHandler(this.materialCheckBox7_CheckedChanged);
            // 
            // materialCheckBox8
            // 
            this.materialCheckBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox8.AutoSize = true;
            this.materialCheckBox8.Depth = 0;
            this.materialCheckBox8.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox8.Location = new System.Drawing.Point(510, 153);
            this.materialCheckBox8.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox8.Name = "materialCheckBox8";
            this.materialCheckBox8.Ripple = true;
            this.materialCheckBox8.Size = new System.Drawing.Size(72, 30);
            this.materialCheckBox8.TabIndex = 77;
            this.materialCheckBox8.Text = "Taguig";
            this.materialCheckBox8.UseVisualStyleBackColor = true;
            this.materialCheckBox8.CheckedChanged += new System.EventHandler(this.materialCheckBox8_CheckedChanged);
            // 
            // materialCheckBox9
            // 
            this.materialCheckBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox9.AutoSize = true;
            this.materialCheckBox9.Depth = 0;
            this.materialCheckBox9.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox9.Location = new System.Drawing.Point(510, 183);
            this.materialCheckBox9.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox9.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox9.Name = "materialCheckBox9";
            this.materialCheckBox9.Ripple = true;
            this.materialCheckBox9.Size = new System.Drawing.Size(64, 30);
            this.materialCheckBox9.TabIndex = 76;
            this.materialCheckBox9.Text = "ITech";
            this.materialCheckBox9.UseVisualStyleBackColor = true;
            this.materialCheckBox9.CheckedChanged += new System.EventHandler(this.materialCheckBox9_CheckedChanged);
            // 
            // materialCheckBox10
            // 
            this.materialCheckBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox10.AutoSize = true;
            this.materialCheckBox10.Depth = 0;
            this.materialCheckBox10.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox10.Location = new System.Drawing.Point(510, 123);
            this.materialCheckBox10.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox10.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox10.Name = "materialCheckBox10";
            this.materialCheckBox10.Ripple = true;
            this.materialCheckBox10.Size = new System.Drawing.Size(127, 30);
            this.materialCheckBox10.TabIndex = 75;
            this.materialCheckBox10.Text = "Commonwealth";
            this.materialCheckBox10.UseVisualStyleBackColor = true;
            this.materialCheckBox10.CheckedChanged += new System.EventHandler(this.materialCheckBox10_CheckedChanged);
            // 
            // materialCheckBox5
            // 
            this.materialCheckBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox5.AutoSize = true;
            this.materialCheckBox5.Depth = 0;
            this.materialCheckBox5.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox5.Location = new System.Drawing.Point(331, 243);
            this.materialCheckBox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox5.Name = "materialCheckBox5";
            this.materialCheckBox5.Ripple = true;
            this.materialCheckBox5.Size = new System.Drawing.Size(77, 30);
            this.materialCheckBox5.TabIndex = 74;
            this.materialCheckBox5.Text = "Hasmin";
            this.materialCheckBox5.UseVisualStyleBackColor = true;
            this.materialCheckBox5.CheckedChanged += new System.EventHandler(this.materialCheckBox5_CheckedChanged);
            // 
            // materialCheckBox4
            // 
            this.materialCheckBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox4.AutoSize = true;
            this.materialCheckBox4.Depth = 0;
            this.materialCheckBox4.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox4.Location = new System.Drawing.Point(331, 213);
            this.materialCheckBox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox4.Name = "materialCheckBox4";
            this.materialCheckBox4.Ripple = true;
            this.materialCheckBox4.Size = new System.Drawing.Size(88, 30);
            this.materialCheckBox4.TabIndex = 73;
            this.materialCheckBox4.Text = "NDC-CEA";
            this.materialCheckBox4.UseVisualStyleBackColor = true;
            this.materialCheckBox4.CheckedChanged += new System.EventHandler(this.materialCheckBox4_CheckedChanged);
            // 
            // materialCheckBox3
            // 
            this.materialCheckBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox3.AutoSize = true;
            this.materialCheckBox3.Depth = 0;
            this.materialCheckBox3.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox3.Location = new System.Drawing.Point(331, 153);
            this.materialCheckBox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox3.Name = "materialCheckBox3";
            this.materialCheckBox3.Ripple = true;
            this.materialCheckBox3.Size = new System.Drawing.Size(104, 30);
            this.materialCheckBox3.TabIndex = 72;
            this.materialCheckBox3.Text = "High School";
            this.materialCheckBox3.UseVisualStyleBackColor = true;
            this.materialCheckBox3.CheckedChanged += new System.EventHandler(this.materialCheckBox3_CheckedChanged);
            // 
            // materialCheckBox2
            // 
            this.materialCheckBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox2.AutoSize = true;
            this.materialCheckBox2.Depth = 0;
            this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox2.Location = new System.Drawing.Point(331, 183);
            this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox2.Name = "materialCheckBox2";
            this.materialCheckBox2.Ripple = true;
            this.materialCheckBox2.Size = new System.Drawing.Size(57, 30);
            this.materialCheckBox2.TabIndex = 71;
            this.materialCheckBox2.Text = "COC";
            this.materialCheckBox2.UseVisualStyleBackColor = true;
            this.materialCheckBox2.CheckedChanged += new System.EventHandler(this.materialCheckBox2_CheckedChanged);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(331, 123);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(69, 30);
            this.materialCheckBox1.TabIndex = 70;
            this.materialCheckBox1.Text = "Dental";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AccessibleName = "ptype";
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(169, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel3.TabIndex = 69;
            this.metroLabel3.Text = "Branches/ Campuses :";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.Image = global::PUPiMed.Properties.Resources._01deliver2;
            this.pictureBox12.Location = new System.Drawing.Point(15, 118);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(313, 204);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 85;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::PUPiMed.Properties.Resources._00delete;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(764, 414);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 89;
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
            this.btncancel.Location = new System.Drawing.Point(759, 409);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(99, 37);
            this.btncancel.Style = MetroFramework.MetroColorStyle.Teal;
            this.btncancel.TabIndex = 88;
            this.btncancel.Text = "     Cancel";
            this.btncancel.UseCustomBackColor = true;
            this.btncancel.UseSelectable = true;
            this.btncancel.UseStyleColors = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PUPiMed.Properties.Resources._00add___Copy1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(645, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleName = "btnadd";
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(640, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 37);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "   Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // itemname
            // 
            this.itemname.AccessibleName = "ptype";
            this.itemname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemname.FormattingEnabled = true;
            this.itemname.ItemHeight = 23;
            this.itemname.Location = new System.Drawing.Point(169, 340);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(185, 29);
            this.itemname.Style = MetroFramework.MetroColorStyle.Teal;
            this.itemname.TabIndex = 90;
            this.itemname.UseSelectable = true;
            // 
            // FormAddDistribItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 469);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.materialCheckBox11);
            this.Controls.Add(this.materialCheckBox12);
            this.Controls.Add(this.materialCheckBox13);
            this.Controls.Add(this.materialCheckBox14);
            this.Controls.Add(this.materialCheckBox15);
            this.Controls.Add(this.materialCheckBox6);
            this.Controls.Add(this.materialCheckBox7);
            this.Controls.Add(this.materialCheckBox8);
            this.Controls.Add(this.materialCheckBox9);
            this.Controls.Add(this.materialCheckBox10);
            this.Controls.Add(this.materialCheckBox5);
            this.Controls.Add(this.materialCheckBox4);
            this.Controls.Add(this.materialCheckBox3);
            this.Controls.Add(this.materialCheckBox2);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.total);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.UOM);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.available);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.itemcode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.itemtype);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.basicinfo);
            this.Controls.Add(this.lblAddpatient);
            this.Controls.Add(this.pictureBox12);
            this.Name = "FormAddDistribItem";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.FormAddDistribItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblAddpatient;
        private MetroFramework.Controls.MetroTile basicinfo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox itemtype;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox itemcode;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox available;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox qty;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox UOM;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox total;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox balance;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox11;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox12;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox13;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox14;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox15;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox6;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox7;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox8;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox9;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox10;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox5;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox4;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox3;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btncancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroComboBox itemname;
    }
}