namespace Lesson2_Game_Rental_App
{
    partial class Form_Game_Rental
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
            this.tab_game_rental = new System.Windows.Forms.TabControl();
            this.tab_Admin = new System.Windows.Forms.TabPage();
            this.btnadmin_delete = new System.Windows.Forms.Button();
            this.ndadmin_checkedout = new System.Windows.Forms.NumericUpDown();
            this.lbladmin_checkedout = new System.Windows.Forms.Label();
            this.nudadmin_inventory = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadmin__Cancel = new System.Windows.Forms.Button();
            this.btnadmin_Save = new System.Windows.Forms.Button();
            this.btnadmin_Edit = new System.Windows.Forms.Button();
            this.btnadmin_Add = new System.Windows.Forms.Button();
            this.cbadmin_genre = new System.Windows.Forms.ComboBox();
            this.lbladmin_genre = new System.Windows.Forms.Label();
            this.datetime_admin = new System.Windows.Forms.DateTimePicker();
            this.cbadmin_rating = new System.Windows.Forms.ComboBox();
            this.lbladmin_rating = new System.Windows.Forms.Label();
            this.cbadmin_platform = new System.Windows.Forms.ComboBox();
            this.lbladmin_platform = new System.Windows.Forms.Label();
            this.lbladmin_releasedate = new System.Windows.Forms.Label();
            this.txtadmin_name = new System.Windows.Forms.TextBox();
            this.lbladmin_name = new System.Windows.Forms.Label();
            this.msadmin_file = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Check = new System.Windows.Forms.TabPage();
            this.lblcheckinout_copies = new System.Windows.Forms.Label();
            this.nudcheckinout_copies = new System.Windows.Forms.NumericUpDown();
            this.btncheck_Checkout = new System.Windows.Forms.Button();
            this.btncheck_Checkin = new System.Windows.Forms.Button();
            this.txtcheck_copies = new System.Windows.Forms.TextBox();
            this.lblcheck_copies = new System.Windows.Forms.Label();
            this.cbcheck_platform = new System.Windows.Forms.ComboBox();
            this.lblcheck_platform = new System.Windows.Forms.Label();
            this.txtcheck_name = new System.Windows.Forms.TextBox();
            this.lblcheck_name = new System.Windows.Forms.Label();
            this.tab_Search = new System.Windows.Forms.TabPage();
            this.lblsearch_inverntory = new System.Windows.Forms.Label();
            this.txtsearch_inventory = new System.Windows.Forms.TextBox();
            this.lblsearch_available = new System.Windows.Forms.Label();
            this.txtsearch_available = new System.Windows.Forms.TextBox();
            this.lblsearch_genre = new System.Windows.Forms.Label();
            this.txtsearch_genre = new System.Windows.Forms.TextBox();
            this.txtsearch_rating = new System.Windows.Forms.TextBox();
            this.btnsearch_Inventory = new System.Windows.Forms.Button();
            this.btnsearch_Gamesavailable = new System.Windows.Forms.Button();
            this.lblsearch_rating = new System.Windows.Forms.Label();
            this.txtsearch_releasedate = new System.Windows.Forms.TextBox();
            this.lblsearch_releasedate = new System.Windows.Forms.Label();
            this.btnsearch_Search = new System.Windows.Forms.Button();
            this.cbsearch_platform = new System.Windows.Forms.ComboBox();
            this.lblsearch_platform = new System.Windows.Forms.Label();
            this.txtsearch_name = new System.Windows.Forms.TextBox();
            this.lblsearch_name = new System.Windows.Forms.Label();
            this.tab_game_rental.SuspendLayout();
            this.tab_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndadmin_checkedout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudadmin_inventory)).BeginInit();
            this.msadmin_file.SuspendLayout();
            this.tab_Check.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcheckinout_copies)).BeginInit();
            this.tab_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_game_rental
            // 
            this.tab_game_rental.Controls.Add(this.tab_Admin);
            this.tab_game_rental.Controls.Add(this.tab_Check);
            this.tab_game_rental.Controls.Add(this.tab_Search);
            this.tab_game_rental.Location = new System.Drawing.Point(3, 2);
            this.tab_game_rental.Name = "tab_game_rental";
            this.tab_game_rental.SelectedIndex = 0;
            this.tab_game_rental.Size = new System.Drawing.Size(870, 515);
            this.tab_game_rental.TabIndex = 0;
            // 
            // tab_Admin
            // 
            this.tab_Admin.Controls.Add(this.btnadmin_delete);
            this.tab_Admin.Controls.Add(this.ndadmin_checkedout);
            this.tab_Admin.Controls.Add(this.lbladmin_checkedout);
            this.tab_Admin.Controls.Add(this.nudadmin_inventory);
            this.tab_Admin.Controls.Add(this.label1);
            this.tab_Admin.Controls.Add(this.btnadmin__Cancel);
            this.tab_Admin.Controls.Add(this.btnadmin_Save);
            this.tab_Admin.Controls.Add(this.btnadmin_Edit);
            this.tab_Admin.Controls.Add(this.btnadmin_Add);
            this.tab_Admin.Controls.Add(this.cbadmin_genre);
            this.tab_Admin.Controls.Add(this.lbladmin_genre);
            this.tab_Admin.Controls.Add(this.datetime_admin);
            this.tab_Admin.Controls.Add(this.cbadmin_rating);
            this.tab_Admin.Controls.Add(this.lbladmin_rating);
            this.tab_Admin.Controls.Add(this.cbadmin_platform);
            this.tab_Admin.Controls.Add(this.lbladmin_platform);
            this.tab_Admin.Controls.Add(this.lbladmin_releasedate);
            this.tab_Admin.Controls.Add(this.txtadmin_name);
            this.tab_Admin.Controls.Add(this.lbladmin_name);
            this.tab_Admin.Controls.Add(this.msadmin_file);
            this.tab_Admin.Location = new System.Drawing.Point(4, 29);
            this.tab_Admin.Name = "tab_Admin";
            this.tab_Admin.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Admin.Size = new System.Drawing.Size(862, 482);
            this.tab_Admin.TabIndex = 0;
            this.tab_Admin.Text = "Administration";
            this.tab_Admin.UseVisualStyleBackColor = true;
            this.tab_Admin.Click += new System.EventHandler(this.tab_Admin_Click);
            // 
            // btnadmin_delete
            // 
            this.btnadmin_delete.Location = new System.Drawing.Point(605, 294);
            this.btnadmin_delete.Name = "btnadmin_delete";
            this.btnadmin_delete.Size = new System.Drawing.Size(185, 53);
            this.btnadmin_delete.TabIndex = 24;
            this.btnadmin_delete.Text = "Delete";
            this.btnadmin_delete.UseVisualStyleBackColor = true;
            this.btnadmin_delete.Click += new System.EventHandler(this.btnadmin_delete_Click);
            // 
            // ndadmin_checkedout
            // 
            this.ndadmin_checkedout.Location = new System.Drawing.Point(644, 216);
            this.ndadmin_checkedout.Name = "ndadmin_checkedout";
            this.ndadmin_checkedout.Size = new System.Drawing.Size(120, 26);
            this.ndadmin_checkedout.TabIndex = 23;
            // 
            // lbladmin_checkedout
            // 
            this.lbladmin_checkedout.AutoSize = true;
            this.lbladmin_checkedout.Location = new System.Drawing.Point(500, 218);
            this.lbladmin_checkedout.Name = "lbladmin_checkedout";
            this.lbladmin_checkedout.Size = new System.Drawing.Size(106, 20);
            this.lbladmin_checkedout.TabIndex = 22;
            this.lbladmin_checkedout.Text = "Checked Out:";
            // 
            // nudadmin_inventory
            // 
            this.nudadmin_inventory.Location = new System.Drawing.Point(644, 163);
            this.nudadmin_inventory.Name = "nudadmin_inventory";
            this.nudadmin_inventory.Size = new System.Drawing.Size(120, 26);
            this.nudadmin_inventory.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Inventory:";
            // 
            // btnadmin__Cancel
            // 
            this.btnadmin__Cancel.Location = new System.Drawing.Point(459, 384);
            this.btnadmin__Cancel.Name = "btnadmin__Cancel";
            this.btnadmin__Cancel.Size = new System.Drawing.Size(128, 64);
            this.btnadmin__Cancel.TabIndex = 11;
            this.btnadmin__Cancel.Text = "Cancel";
            this.btnadmin__Cancel.UseVisualStyleBackColor = true;
            this.btnadmin__Cancel.Click += new System.EventHandler(this.btnadmin__Cancel_Click);
            // 
            // btnadmin_Save
            // 
            this.btnadmin_Save.Location = new System.Drawing.Point(227, 384);
            this.btnadmin_Save.Name = "btnadmin_Save";
            this.btnadmin_Save.Size = new System.Drawing.Size(128, 64);
            this.btnadmin_Save.TabIndex = 10;
            this.btnadmin_Save.Text = "Save";
            this.btnadmin_Save.UseVisualStyleBackColor = true;
            this.btnadmin_Save.Click += new System.EventHandler(this.btnadmin_Save_Click);
            // 
            // btnadmin_Edit
            // 
            this.btnadmin_Edit.Location = new System.Drawing.Point(307, 294);
            this.btnadmin_Edit.Name = "btnadmin_Edit";
            this.btnadmin_Edit.Size = new System.Drawing.Size(185, 53);
            this.btnadmin_Edit.TabIndex = 8;
            this.btnadmin_Edit.Text = "Edit";
            this.btnadmin_Edit.UseVisualStyleBackColor = true;
            this.btnadmin_Edit.Click += new System.EventHandler(this.btnadmin_Edit_Click);
            // 
            // btnadmin_Add
            // 
            this.btnadmin_Add.Location = new System.Drawing.Point(35, 294);
            this.btnadmin_Add.Name = "btnadmin_Add";
            this.btnadmin_Add.Size = new System.Drawing.Size(185, 53);
            this.btnadmin_Add.TabIndex = 7;
            this.btnadmin_Add.Text = "Add";
            this.btnadmin_Add.UseVisualStyleBackColor = true;
            this.btnadmin_Add.Click += new System.EventHandler(this.btnadmin_Add_Click);
            // 
            // cbadmin_genre
            // 
            this.cbadmin_genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbadmin_genre.FormattingEnabled = true;
            this.cbadmin_genre.Items.AddRange(new object[] {
            "Action",
            "Action-Adventure",
            "Role-play",
            "Strategy",
            "Sports",
            "Other"});
            this.cbadmin_genre.Location = new System.Drawing.Point(626, 107);
            this.cbadmin_genre.Name = "cbadmin_genre";
            this.cbadmin_genre.Size = new System.Drawing.Size(157, 28);
            this.cbadmin_genre.TabIndex = 4;
            // 
            // lbladmin_genre
            // 
            this.lbladmin_genre.AutoSize = true;
            this.lbladmin_genre.Location = new System.Drawing.Point(530, 110);
            this.lbladmin_genre.Name = "lbladmin_genre";
            this.lbladmin_genre.Size = new System.Drawing.Size(58, 20);
            this.lbladmin_genre.TabIndex = 8;
            this.lbladmin_genre.Text = "Genre:";
            // 
            // datetime_admin
            // 
            this.datetime_admin.Location = new System.Drawing.Point(203, 192);
            this.datetime_admin.Name = "datetime_admin";
            this.datetime_admin.Size = new System.Drawing.Size(200, 26);
            this.datetime_admin.TabIndex = 5;
            // 
            // cbadmin_rating
            // 
            this.cbadmin_rating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbadmin_rating.FormattingEnabled = true;
            this.cbadmin_rating.Items.AddRange(new object[] {
            "E (Everyone)",
            "E 10+ (Everyone 10+)",
            "T (Teen)",
            "M (Mature)",
            "AO (Adults Only)",
            ""});
            this.cbadmin_rating.Location = new System.Drawing.Point(203, 117);
            this.cbadmin_rating.Name = "cbadmin_rating";
            this.cbadmin_rating.Size = new System.Drawing.Size(177, 28);
            this.cbadmin_rating.TabIndex = 3;
            // 
            // lbladmin_rating
            // 
            this.lbladmin_rating.AutoSize = true;
            this.lbladmin_rating.Location = new System.Drawing.Point(49, 120);
            this.lbladmin_rating.Name = "lbladmin_rating";
            this.lbladmin_rating.Size = new System.Drawing.Size(109, 20);
            this.lbladmin_rating.TabIndex = 5;
            this.lbladmin_rating.Text = "ESRB Rating:";
            // 
            // cbadmin_platform
            // 
            this.cbadmin_platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbadmin_platform.FormattingEnabled = true;
            this.cbadmin_platform.Items.AddRange(new object[] {
            "Play Station 3",
            "Play Station 4",
            "X Box",
            "X Box 360",
            "Wii",
            "WiiU",
            "Nintendo DS"});
            this.cbadmin_platform.Location = new System.Drawing.Point(619, 52);
            this.cbadmin_platform.Name = "cbadmin_platform";
            this.cbadmin_platform.Size = new System.Drawing.Size(171, 28);
            this.cbadmin_platform.TabIndex = 2;
            // 
            // lbladmin_platform
            // 
            this.lbladmin_platform.AutoSize = true;
            this.lbladmin_platform.Location = new System.Drawing.Point(530, 60);
            this.lbladmin_platform.Name = "lbladmin_platform";
            this.lbladmin_platform.Size = new System.Drawing.Size(72, 20);
            this.lbladmin_platform.TabIndex = 3;
            this.lbladmin_platform.Text = "Platform:";
            // 
            // lbladmin_releasedate
            // 
            this.lbladmin_releasedate.AutoSize = true;
            this.lbladmin_releasedate.Location = new System.Drawing.Point(49, 197);
            this.lbladmin_releasedate.Name = "lbladmin_releasedate";
            this.lbladmin_releasedate.Size = new System.Drawing.Size(111, 20);
            this.lbladmin_releasedate.TabIndex = 2;
            this.lbladmin_releasedate.Text = "Release Date:";
            // 
            // txtadmin_name
            // 
            this.txtadmin_name.Location = new System.Drawing.Point(111, 52);
            this.txtadmin_name.Name = "txtadmin_name";
            this.txtadmin_name.Size = new System.Drawing.Size(348, 26);
            this.txtadmin_name.TabIndex = 1;
            // 
            // lbladmin_name
            // 
            this.lbladmin_name.AutoSize = true;
            this.lbladmin_name.Location = new System.Drawing.Point(31, 55);
            this.lbladmin_name.Name = "lbladmin_name";
            this.lbladmin_name.Size = new System.Drawing.Size(55, 20);
            this.lbladmin_name.TabIndex = 0;
            this.lbladmin_name.Text = "Name:";
            // 
            // msadmin_file
            // 
            this.msadmin_file.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msadmin_file.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msadmin_file.Location = new System.Drawing.Point(3, 3);
            this.msadmin_file.Name = "msadmin_file";
            this.msadmin_file.Size = new System.Drawing.Size(856, 33);
            this.msadmin_file.TabIndex = 25;
            this.msadmin_file.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFileToolStripMenuItem,
            this.binaryFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem,
            this.readToFileToolStripMenuItem});
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.textFileToolStripMenuItem.Text = "Text File";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(187, 30);
            this.saveToFileToolStripMenuItem.Text = "Save to File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // readToFileToolStripMenuItem
            // 
            this.readToFileToolStripMenuItem.Name = "readToFileToolStripMenuItem";
            this.readToFileToolStripMenuItem.Size = new System.Drawing.Size(187, 30);
            this.readToFileToolStripMenuItem.Text = "Open a File";
            this.readToFileToolStripMenuItem.Click += new System.EventHandler(this.readToFileToolStripMenuItem_Click);
            // 
            // binaryFileToolStripMenuItem
            // 
            this.binaryFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem1,
            this.readToFileToolStripMenuItem1});
            this.binaryFileToolStripMenuItem.Name = "binaryFileToolStripMenuItem";
            this.binaryFileToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.binaryFileToolStripMenuItem.Text = "Binary File";
            // 
            // saveToFileToolStripMenuItem1
            // 
            this.saveToFileToolStripMenuItem1.Name = "saveToFileToolStripMenuItem1";
            this.saveToFileToolStripMenuItem1.Size = new System.Drawing.Size(187, 30);
            this.saveToFileToolStripMenuItem1.Text = "Save to File";
            this.saveToFileToolStripMenuItem1.Click += new System.EventHandler(this.saveToFileToolStripMenuItem1_Click);
            // 
            // readToFileToolStripMenuItem1
            // 
            this.readToFileToolStripMenuItem1.Name = "readToFileToolStripMenuItem1";
            this.readToFileToolStripMenuItem1.Size = new System.Drawing.Size(187, 30);
            this.readToFileToolStripMenuItem1.Text = "Open a File";
            this.readToFileToolStripMenuItem1.Click += new System.EventHandler(this.readToFileToolStripMenuItem1_Click);
            // 
            // tab_Check
            // 
            this.tab_Check.Controls.Add(this.lblcheckinout_copies);
            this.tab_Check.Controls.Add(this.nudcheckinout_copies);
            this.tab_Check.Controls.Add(this.btncheck_Checkout);
            this.tab_Check.Controls.Add(this.btncheck_Checkin);
            this.tab_Check.Controls.Add(this.txtcheck_copies);
            this.tab_Check.Controls.Add(this.lblcheck_copies);
            this.tab_Check.Controls.Add(this.cbcheck_platform);
            this.tab_Check.Controls.Add(this.lblcheck_platform);
            this.tab_Check.Controls.Add(this.txtcheck_name);
            this.tab_Check.Controls.Add(this.lblcheck_name);
            this.tab_Check.Location = new System.Drawing.Point(4, 29);
            this.tab_Check.Name = "tab_Check";
            this.tab_Check.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Check.Size = new System.Drawing.Size(862, 482);
            this.tab_Check.TabIndex = 1;
            this.tab_Check.Text = "Check In/ Check Out";
            this.tab_Check.UseVisualStyleBackColor = true;
            // 
            // lblcheckinout_copies
            // 
            this.lblcheckinout_copies.AutoSize = true;
            this.lblcheckinout_copies.Location = new System.Drawing.Point(44, 181);
            this.lblcheckinout_copies.Name = "lblcheckinout_copies";
            this.lblcheckinout_copies.Size = new System.Drawing.Size(62, 20);
            this.lblcheckinout_copies.TabIndex = 10;
            this.lblcheckinout_copies.Text = "Copies:";
            // 
            // nudcheckinout_copies
            // 
            this.nudcheckinout_copies.Location = new System.Drawing.Point(150, 175);
            this.nudcheckinout_copies.Name = "nudcheckinout_copies";
            this.nudcheckinout_copies.Size = new System.Drawing.Size(120, 26);
            this.nudcheckinout_copies.TabIndex = 3;
            // 
            // btncheck_Checkout
            // 
            this.btncheck_Checkout.Location = new System.Drawing.Point(582, 192);
            this.btncheck_Checkout.Name = "btncheck_Checkout";
            this.btncheck_Checkout.Size = new System.Drawing.Size(192, 56);
            this.btncheck_Checkout.TabIndex = 5;
            this.btncheck_Checkout.Text = "Check Out";
            this.btncheck_Checkout.UseVisualStyleBackColor = true;
            this.btncheck_Checkout.Click += new System.EventHandler(this.btncheck_Checkout_Click);
            // 
            // btncheck_Checkin
            // 
            this.btncheck_Checkin.Location = new System.Drawing.Point(582, 87);
            this.btncheck_Checkin.Name = "btncheck_Checkin";
            this.btncheck_Checkin.Size = new System.Drawing.Size(192, 56);
            this.btncheck_Checkin.TabIndex = 4;
            this.btncheck_Checkin.Text = "Check In";
            this.btncheck_Checkin.UseVisualStyleBackColor = true;
            this.btncheck_Checkin.Click += new System.EventHandler(this.btncheck_checkin_Click);
            // 
            // txtcheck_copies
            // 
            this.txtcheck_copies.Location = new System.Drawing.Point(303, 267);
            this.txtcheck_copies.Name = "txtcheck_copies";
            this.txtcheck_copies.ReadOnly = true;
            this.txtcheck_copies.Size = new System.Drawing.Size(100, 26);
            this.txtcheck_copies.TabIndex = 6;
            // 
            // lblcheck_copies
            // 
            this.lblcheck_copies.AutoSize = true;
            this.lblcheck_copies.Location = new System.Drawing.Point(45, 273);
            this.lblcheck_copies.Name = "lblcheck_copies";
            this.lblcheck_copies.Size = new System.Drawing.Size(225, 20);
            this.lblcheck_copies.TabIndex = 4;
            this.lblcheck_copies.Text = "Number of Copies in Inventory:";
            // 
            // cbcheck_platform
            // 
            this.cbcheck_platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcheck_platform.FormattingEnabled = true;
            this.cbcheck_platform.Items.AddRange(new object[] {
            "Play Station 3",
            "Play Station 4",
            "X Box",
            "X Box 360",
            "Wii",
            "WiiU",
            "Nintendo DS"});
            this.cbcheck_platform.Location = new System.Drawing.Point(150, 102);
            this.cbcheck_platform.Name = "cbcheck_platform";
            this.cbcheck_platform.Size = new System.Drawing.Size(290, 28);
            this.cbcheck_platform.TabIndex = 2;
            this.cbcheck_platform.SelectedIndexChanged += new System.EventHandler(this.cbcheck_platform_SelectedIndexChanged);
            // 
            // lblcheck_platform
            // 
            this.lblcheck_platform.AutoSize = true;
            this.lblcheck_platform.Location = new System.Drawing.Point(44, 105);
            this.lblcheck_platform.Name = "lblcheck_platform";
            this.lblcheck_platform.Size = new System.Drawing.Size(72, 20);
            this.lblcheck_platform.TabIndex = 2;
            this.lblcheck_platform.Text = "Platform:";
            // 
            // txtcheck_name
            // 
            this.txtcheck_name.Location = new System.Drawing.Point(150, 35);
            this.txtcheck_name.Name = "txtcheck_name";
            this.txtcheck_name.Size = new System.Drawing.Size(348, 26);
            this.txtcheck_name.TabIndex = 1;
            this.txtcheck_name.TextChanged += new System.EventHandler(this.txtcheck_name_TextChanged);
            // 
            // lblcheck_name
            // 
            this.lblcheck_name.AutoSize = true;
            this.lblcheck_name.Location = new System.Drawing.Point(44, 38);
            this.lblcheck_name.Name = "lblcheck_name";
            this.lblcheck_name.Size = new System.Drawing.Size(55, 20);
            this.lblcheck_name.TabIndex = 0;
            this.lblcheck_name.Text = "Name:";
            // 
            // tab_Search
            // 
            this.tab_Search.Controls.Add(this.lblsearch_inverntory);
            this.tab_Search.Controls.Add(this.txtsearch_inventory);
            this.tab_Search.Controls.Add(this.lblsearch_available);
            this.tab_Search.Controls.Add(this.txtsearch_available);
            this.tab_Search.Controls.Add(this.lblsearch_genre);
            this.tab_Search.Controls.Add(this.txtsearch_genre);
            this.tab_Search.Controls.Add(this.txtsearch_rating);
            this.tab_Search.Controls.Add(this.btnsearch_Inventory);
            this.tab_Search.Controls.Add(this.btnsearch_Gamesavailable);
            this.tab_Search.Controls.Add(this.lblsearch_rating);
            this.tab_Search.Controls.Add(this.txtsearch_releasedate);
            this.tab_Search.Controls.Add(this.lblsearch_releasedate);
            this.tab_Search.Controls.Add(this.btnsearch_Search);
            this.tab_Search.Controls.Add(this.cbsearch_platform);
            this.tab_Search.Controls.Add(this.lblsearch_platform);
            this.tab_Search.Controls.Add(this.txtsearch_name);
            this.tab_Search.Controls.Add(this.lblsearch_name);
            this.tab_Search.Location = new System.Drawing.Point(4, 29);
            this.tab_Search.Name = "tab_Search";
            this.tab_Search.Size = new System.Drawing.Size(862, 482);
            this.tab_Search.TabIndex = 2;
            this.tab_Search.Text = "Search";
            this.tab_Search.UseVisualStyleBackColor = true;
            // 
            // lblsearch_inverntory
            // 
            this.lblsearch_inverntory.AutoSize = true;
            this.lblsearch_inverntory.Location = new System.Drawing.Point(430, 327);
            this.lblsearch_inverntory.Name = "lblsearch_inverntory";
            this.lblsearch_inverntory.Size = new System.Drawing.Size(228, 20);
            this.lblsearch_inverntory.TabIndex = 17;
            this.lblsearch_inverntory.Text = "Number of Games in Inventory:";
            // 
            // txtsearch_inventory
            // 
            this.txtsearch_inventory.Location = new System.Drawing.Point(698, 324);
            this.txtsearch_inventory.Name = "txtsearch_inventory";
            this.txtsearch_inventory.ReadOnly = true;
            this.txtsearch_inventory.Size = new System.Drawing.Size(119, 26);
            this.txtsearch_inventory.TabIndex = 18;
            // 
            // lblsearch_available
            // 
            this.lblsearch_available.AutoSize = true;
            this.lblsearch_available.Location = new System.Drawing.Point(430, 384);
            this.lblsearch_available.Name = "lblsearch_available";
            this.lblsearch_available.Size = new System.Drawing.Size(210, 20);
            this.lblsearch_available.TabIndex = 19;
            this.lblsearch_available.Text = "Number of Games Available:";
            // 
            // txtsearch_available
            // 
            this.txtsearch_available.Location = new System.Drawing.Point(698, 381);
            this.txtsearch_available.Name = "txtsearch_available";
            this.txtsearch_available.ReadOnly = true;
            this.txtsearch_available.Size = new System.Drawing.Size(119, 26);
            this.txtsearch_available.TabIndex = 20;
            // 
            // lblsearch_genre
            // 
            this.lblsearch_genre.AutoSize = true;
            this.lblsearch_genre.Location = new System.Drawing.Point(54, 324);
            this.lblsearch_genre.Name = "lblsearch_genre";
            this.lblsearch_genre.Size = new System.Drawing.Size(58, 20);
            this.lblsearch_genre.TabIndex = 16;
            this.lblsearch_genre.Text = "Genre:";
            // 
            // txtsearch_genre
            // 
            this.txtsearch_genre.Location = new System.Drawing.Point(203, 321);
            this.txtsearch_genre.Name = "txtsearch_genre";
            this.txtsearch_genre.ReadOnly = true;
            this.txtsearch_genre.Size = new System.Drawing.Size(162, 26);
            this.txtsearch_genre.TabIndex = 15;
            // 
            // txtsearch_rating
            // 
            this.txtsearch_rating.Location = new System.Drawing.Point(203, 387);
            this.txtsearch_rating.Name = "txtsearch_rating";
            this.txtsearch_rating.ReadOnly = true;
            this.txtsearch_rating.Size = new System.Drawing.Size(162, 26);
            this.txtsearch_rating.TabIndex = 14;
            // 
            // btnsearch_Inventory
            // 
            this.btnsearch_Inventory.Location = new System.Drawing.Point(445, 150);
            this.btnsearch_Inventory.Name = "btnsearch_Inventory";
            this.btnsearch_Inventory.Size = new System.Drawing.Size(169, 73);
            this.btnsearch_Inventory.TabIndex = 5;
            this.btnsearch_Inventory.Text = "Show Inventory";
            this.btnsearch_Inventory.UseVisualStyleBackColor = true;
            this.btnsearch_Inventory.Click += new System.EventHandler(this.btnsearch_Inventory_Click);
            // 
            // btnsearch_Gamesavailable
            // 
            this.btnsearch_Gamesavailable.Location = new System.Drawing.Point(663, 150);
            this.btnsearch_Gamesavailable.Name = "btnsearch_Gamesavailable";
            this.btnsearch_Gamesavailable.Size = new System.Drawing.Size(150, 73);
            this.btnsearch_Gamesavailable.TabIndex = 10;
            this.btnsearch_Gamesavailable.Text = "Games Available";
            this.btnsearch_Gamesavailable.UseVisualStyleBackColor = true;
            this.btnsearch_Gamesavailable.Click += new System.EventHandler(this.btnsearch_Gamesavailable_Click);
            // 
            // lblsearch_rating
            // 
            this.lblsearch_rating.AutoSize = true;
            this.lblsearch_rating.Location = new System.Drawing.Point(54, 390);
            this.lblsearch_rating.Name = "lblsearch_rating";
            this.lblsearch_rating.Size = new System.Drawing.Size(109, 20);
            this.lblsearch_rating.TabIndex = 13;
            this.lblsearch_rating.Text = "ESRB Rating:";
            // 
            // txtsearch_releasedate
            // 
            this.txtsearch_releasedate.Location = new System.Drawing.Point(203, 257);
            this.txtsearch_releasedate.Name = "txtsearch_releasedate";
            this.txtsearch_releasedate.ReadOnly = true;
            this.txtsearch_releasedate.Size = new System.Drawing.Size(255, 26);
            this.txtsearch_releasedate.TabIndex = 12;
            // 
            // lblsearch_releasedate
            // 
            this.lblsearch_releasedate.AutoSize = true;
            this.lblsearch_releasedate.Location = new System.Drawing.Point(54, 260);
            this.lblsearch_releasedate.Name = "lblsearch_releasedate";
            this.lblsearch_releasedate.Size = new System.Drawing.Size(111, 20);
            this.lblsearch_releasedate.TabIndex = 11;
            this.lblsearch_releasedate.Text = "Release Date:";
            // 
            // btnsearch_Search
            // 
            this.btnsearch_Search.Location = new System.Drawing.Point(36, 150);
            this.btnsearch_Search.Name = "btnsearch_Search";
            this.btnsearch_Search.Size = new System.Drawing.Size(329, 73);
            this.btnsearch_Search.TabIndex = 4;
            this.btnsearch_Search.Text = "Search";
            this.btnsearch_Search.UseVisualStyleBackColor = true;
            this.btnsearch_Search.Click += new System.EventHandler(this.btnsearch_Search_Click);
            // 
            // cbsearch_platform
            // 
            this.cbsearch_platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsearch_platform.FormattingEnabled = true;
            this.cbsearch_platform.Items.AddRange(new object[] {
            "Play Station 3",
            "Play Station 4",
            "X Box",
            "X Box 360",
            "Wii",
            "WiiU",
            "Nintendo DS"});
            this.cbsearch_platform.Location = new System.Drawing.Point(128, 79);
            this.cbsearch_platform.Name = "cbsearch_platform";
            this.cbsearch_platform.Size = new System.Drawing.Size(314, 28);
            this.cbsearch_platform.TabIndex = 3;
            // 
            // lblsearch_platform
            // 
            this.lblsearch_platform.AutoSize = true;
            this.lblsearch_platform.Location = new System.Drawing.Point(32, 82);
            this.lblsearch_platform.Name = "lblsearch_platform";
            this.lblsearch_platform.Size = new System.Drawing.Size(72, 20);
            this.lblsearch_platform.TabIndex = 2;
            this.lblsearch_platform.Text = "Platform:";
            // 
            // txtsearch_name
            // 
            this.txtsearch_name.Location = new System.Drawing.Point(128, 30);
            this.txtsearch_name.Name = "txtsearch_name";
            this.txtsearch_name.Size = new System.Drawing.Size(314, 26);
            this.txtsearch_name.TabIndex = 1;
            // 
            // lblsearch_name
            // 
            this.lblsearch_name.AutoSize = true;
            this.lblsearch_name.Location = new System.Drawing.Point(34, 33);
            this.lblsearch_name.Name = "lblsearch_name";
            this.lblsearch_name.Size = new System.Drawing.Size(55, 20);
            this.lblsearch_name.TabIndex = 0;
            this.lblsearch_name.Text = "Name:";
            // 
            // Form_Game_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 509);
            this.Controls.Add(this.tab_game_rental);
            this.Name = "Form_Game_Rental";
            this.Text = "Game Rental ";
            this.tab_game_rental.ResumeLayout(false);
            this.tab_Admin.ResumeLayout(false);
            this.tab_Admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndadmin_checkedout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudadmin_inventory)).EndInit();
            this.msadmin_file.ResumeLayout(false);
            this.msadmin_file.PerformLayout();
            this.tab_Check.ResumeLayout(false);
            this.tab_Check.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudcheckinout_copies)).EndInit();
            this.tab_Search.ResumeLayout(false);
            this.tab_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_game_rental;
        private System.Windows.Forms.TabPage tab_Admin;
        private System.Windows.Forms.TabPage tab_Check;
        private System.Windows.Forms.TabPage tab_Search;
        private System.Windows.Forms.DateTimePicker datetime_admin;
        private System.Windows.Forms.ComboBox cbadmin_rating;
        private System.Windows.Forms.Label lbladmin_rating;
        private System.Windows.Forms.ComboBox cbadmin_platform;
        private System.Windows.Forms.Label lbladmin_platform;
        private System.Windows.Forms.Label lbladmin_releasedate;
        private System.Windows.Forms.TextBox txtadmin_name;
        private System.Windows.Forms.Label lbladmin_name;
        private System.Windows.Forms.ComboBox cbadmin_genre;
        private System.Windows.Forms.Label lbladmin_genre;
        private System.Windows.Forms.Button btnadmin__Cancel;
        private System.Windows.Forms.Button btnadmin_Save;
        private System.Windows.Forms.Button btnadmin_Edit;
        private System.Windows.Forms.Button btnadmin_Add;
        private System.Windows.Forms.TextBox txtcheck_name;
        private System.Windows.Forms.Label lblcheck_name;
        private System.Windows.Forms.ComboBox cbcheck_platform;
        private System.Windows.Forms.Label lblcheck_platform;
        private System.Windows.Forms.Button btncheck_Checkout;
        private System.Windows.Forms.Button btncheck_Checkin;
        private System.Windows.Forms.TextBox txtcheck_copies;
        private System.Windows.Forms.Label lblcheck_copies;
        private System.Windows.Forms.ComboBox cbsearch_platform;
        private System.Windows.Forms.Label lblsearch_platform;
        private System.Windows.Forms.TextBox txtsearch_name;
        private System.Windows.Forms.Label lblsearch_name;
        private System.Windows.Forms.Button btnsearch_Gamesavailable;
        private System.Windows.Forms.Button btnsearch_Inventory;
        private System.Windows.Forms.Label lblsearch_genre;
        private System.Windows.Forms.TextBox txtsearch_genre;
        private System.Windows.Forms.TextBox txtsearch_rating;
        private System.Windows.Forms.Label lblsearch_rating;
        private System.Windows.Forms.TextBox txtsearch_releasedate;
        private System.Windows.Forms.Label lblsearch_releasedate;
        private System.Windows.Forms.Button btnsearch_Search;
        private System.Windows.Forms.NumericUpDown nudadmin_inventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsearch_inverntory;
        private System.Windows.Forms.TextBox txtsearch_inventory;
        private System.Windows.Forms.Label lblsearch_available;
        private System.Windows.Forms.TextBox txtsearch_available;
        private System.Windows.Forms.NumericUpDown ndadmin_checkedout;
        private System.Windows.Forms.Label lbladmin_checkedout;
        private System.Windows.Forms.Button btnadmin_delete;
        private System.Windows.Forms.MenuStrip msadmin_file;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToFileToolStripMenuItem1;
        private System.Windows.Forms.Label lblcheckinout_copies;
        private System.Windows.Forms.NumericUpDown nudcheckinout_copies;
    }
}

