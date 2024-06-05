
namespace equiscale
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.TitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.company = new System.Windows.Forms.Label();
            this.Address2 = new System.Windows.Forms.Label();
            this.Address1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogOutBtn = new FontAwesome.Sharp.IconButton();
            this.MinimizeBtn = new FontAwesome.Sharp.IconButton();
            this.MaximizeBtn = new FontAwesome.Sharp.IconButton();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.Settingbtn = new FontAwesome.Sharp.IconButton();
            this.Housebtn = new FontAwesome.Sharp.IconButton();
            this.Reportbtn = new FontAwesome.Sharp.IconButton();
            this.Printbtn = new FontAwesome.Sharp.IconButton();
            this.Weighbtn = new FontAwesome.Sharp.IconButton();
            this.Homebtn = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Homebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.Settingbtn);
            this.panelMenu.Controls.Add(this.Housebtn);
            this.panelMenu.Controls.Add(this.Reportbtn);
            this.panelMenu.Controls.Add(this.Printbtn);
            this.panelMenu.Controls.Add(this.Weighbtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 636);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.Homebtn);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.LogOutBtn);
            this.panelTitleBar.Controls.Add(this.MinimizeBtn);
            this.panelTitleBar.Controls.Add(this.MaximizeBtn);
            this.panelTitleBar.Controls.Add(this.CloseBtn);
            this.panelTitleBar.Controls.Add(this.TitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(763, 56);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // TitleChildForm
            // 
            this.TitleChildForm.AutoSize = true;
            this.TitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.TitleChildForm.Location = new System.Drawing.Point(55, 21);
            this.TitleChildForm.Name = "TitleChildForm";
            this.TitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.TitleChildForm.TabIndex = 1;
            this.TitleChildForm.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 56);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(763, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.tableLayoutPanel1);
            this.panelDesktop.Controls.Add(this.Date);
            this.panelDesktop.Controls.Add(this.Time);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 65);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(763, 571);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.061008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.939F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.company, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Address2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Address1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.08392F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.91608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 375);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // company
            // 
            this.company.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.ForeColor = System.Drawing.Color.Gainsboro;
            this.company.Location = new System.Drawing.Point(250, 133);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(258, 56);
            this.company.TabIndex = 47;
            this.company.Text = "Company";
            // 
            // Address2
            // 
            this.Address2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Address2.AutoSize = true;
            this.Address2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address2.ForeColor = System.Drawing.Color.Gainsboro;
            this.Address2.Location = new System.Drawing.Point(282, 331);
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(194, 44);
            this.Address2.TabIndex = 42;
            this.Address2.Text = "Address 2";
            // 
            // Address1
            // 
            this.Address1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Address1.AutoSize = true;
            this.Address1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Address1.Location = new System.Drawing.Point(282, 242);
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(194, 44);
            this.Address1.TabIndex = 41;
            this.Address1.Text = "Address 1";
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.Gainsboro;
            this.Date.Location = new System.Drawing.Point(567, 400);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(82, 36);
            this.Date.TabIndex = 46;
            this.Date.Text = "Date";
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Gainsboro;
            this.Time.Location = new System.Drawing.Point(99, 400);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(80, 36);
            this.Time.TabIndex = 45;
            this.Time.Text = "Time";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(485, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 36);
            this.label4.TabIndex = 44;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(19, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 43;
            this.label3.Text = "Time:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.LogOutBtn.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.LogOutBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.LogOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogOutBtn.IconSize = 32;
            this.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.Location = new System.Drawing.Point(339, 10);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.LogOutBtn.Size = new System.Drawing.Size(122, 32);
            this.LogOutBtn.TabIndex = 5;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogOutBtn.UseMnemonic = false;
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.MinimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeBtn.IconSize = 20;
            this.MinimizeBtn.Location = new System.Drawing.Point(694, 5);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(20, 10);
            this.MinimizeBtn.TabIndex = 4;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.MaximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeBtn.IconSize = 20;
            this.MaximizeBtn.Location = new System.Drawing.Point(720, -1);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(19, 23);
            this.MaximizeBtn.TabIndex = 3;
            this.MaximizeBtn.UseVisualStyleBackColor = true;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.CloseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseBtn.IconSize = 20;
            this.CloseBtn.Location = new System.Drawing.Point(745, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(18, 22);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // Settingbtn
            // 
            this.Settingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settingbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settingbtn.FlatAppearance.BorderSize = 0;
            this.Settingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settingbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settingbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Settingbtn.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.Settingbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Settingbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settingbtn.IconSize = 32;
            this.Settingbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settingbtn.Location = new System.Drawing.Point(0, 380);
            this.Settingbtn.Name = "Settingbtn";
            this.Settingbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Settingbtn.Size = new System.Drawing.Size(220, 60);
            this.Settingbtn.TabIndex = 6;
            this.Settingbtn.Text = "Settings";
            this.Settingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settingbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settingbtn.UseVisualStyleBackColor = true;
            this.Settingbtn.Click += new System.EventHandler(this.Settingbtn_Click);
            // 
            // Housebtn
            // 
            this.Housebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Housebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Housebtn.FlatAppearance.BorderSize = 0;
            this.Housebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Housebtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Housebtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Housebtn.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.Housebtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Housebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Housebtn.IconSize = 32;
            this.Housebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Housebtn.Location = new System.Drawing.Point(0, 320);
            this.Housebtn.Name = "Housebtn";
            this.Housebtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Housebtn.Size = new System.Drawing.Size(220, 60);
            this.Housebtn.TabIndex = 5;
            this.Housebtn.Text = "House-Keeping";
            this.Housebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Housebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Housebtn.UseVisualStyleBackColor = true;
            this.Housebtn.Click += new System.EventHandler(this.Housebtn_Click);
            // 
            // Reportbtn
            // 
            this.Reportbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reportbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reportbtn.FlatAppearance.BorderSize = 0;
            this.Reportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reportbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Reportbtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.Reportbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Reportbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reportbtn.IconSize = 32;
            this.Reportbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportbtn.Location = new System.Drawing.Point(0, 260);
            this.Reportbtn.Name = "Reportbtn";
            this.Reportbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Reportbtn.Size = new System.Drawing.Size(220, 60);
            this.Reportbtn.TabIndex = 3;
            this.Reportbtn.Text = "Reports";
            this.Reportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reportbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reportbtn.UseVisualStyleBackColor = true;
            this.Reportbtn.Click += new System.EventHandler(this.Reportbtn_Click);
            // 
            // Printbtn
            // 
            this.Printbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Printbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Printbtn.FlatAppearance.BorderSize = 0;
            this.Printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Printbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Printbtn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.Printbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Printbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Printbtn.IconSize = 32;
            this.Printbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Printbtn.Location = new System.Drawing.Point(0, 200);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Printbtn.Size = new System.Drawing.Size(220, 60);
            this.Printbtn.TabIndex = 2;
            this.Printbtn.Text = "Print Weight Slip";
            this.Printbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Printbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Printbtn.UseVisualStyleBackColor = true;
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // Weighbtn
            // 
            this.Weighbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Weighbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Weighbtn.FlatAppearance.BorderSize = 0;
            this.Weighbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Weighbtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weighbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.Weighbtn.IconChar = FontAwesome.Sharp.IconChar.Weight;
            this.Weighbtn.IconColor = System.Drawing.Color.Gainsboro;
            this.Weighbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Weighbtn.IconSize = 32;
            this.Weighbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Weighbtn.Location = new System.Drawing.Point(0, 140);
            this.Weighbtn.Name = "Weighbtn";
            this.Weighbtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Weighbtn.Size = new System.Drawing.Size(220, 60);
            this.Weighbtn.TabIndex = 1;
            this.Weighbtn.Text = "Weigh";
            this.Weighbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Weighbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Weighbtn.UseMnemonic = false;
            this.Weighbtn.UseVisualStyleBackColor = true;
            this.Weighbtn.Click += new System.EventHandler(this.Weighbtn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Homebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Homebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Homebtn.Image = global::equiscale.Properties.Resources.Logo_for_Software_removebg_preview;
            this.Homebtn.Location = new System.Drawing.Point(0, 0);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(220, 140);
            this.Homebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Homebtn.TabIndex = 0;
            this.Homebtn.TabStop = false;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(983, 636);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "DashBoard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Homebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton Weighbtn;
        private FontAwesome.Sharp.IconButton Housebtn;
        private FontAwesome.Sharp.IconButton Reportbtn;
        private FontAwesome.Sharp.IconButton Printbtn;
        private FontAwesome.Sharp.IconButton Settingbtn;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label TitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private FontAwesome.Sharp.IconButton MaximizeBtn;
        private FontAwesome.Sharp.IconButton MinimizeBtn;
        private FontAwesome.Sharp.IconButton LogOutBtn;
        private System.Windows.Forms.PictureBox Homebtn;
        private System.Windows.Forms.Label Address1;
        private System.Windows.Forms.Label Address2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}