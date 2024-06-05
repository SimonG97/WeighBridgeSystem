
namespace equiscale
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.logInBox = new System.Windows.Forms.GroupBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.userFeild = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.equiscalePicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.logInBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiscalePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.equiscalePicture, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.logInBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(383, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 444);
            this.panel1.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Image = global::equiscale.Properties.Resources.Equiscale;
            this.logo.Location = new System.Drawing.Point(124, 55);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(125, 41);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // logInBox
            // 
            this.logInBox.Controls.Add(this.passwordField);
            this.logInBox.Controls.Add(this.userFeild);
            this.logInBox.Controls.Add(this.logInButton);
            this.logInBox.Controls.Add(this.panel4);
            this.logInBox.Controls.Add(this.panel3);
            this.logInBox.Controls.Add(this.panel2);
            this.logInBox.Controls.Add(this.pictureBox2);
            this.logInBox.Controls.Add(this.pictureBox1);
            this.logInBox.Controls.Add(this.label2);
            this.logInBox.Controls.Add(this.label1);
            this.logInBox.Location = new System.Drawing.Point(32, 91);
            this.logInBox.Name = "logInBox";
            this.logInBox.Size = new System.Drawing.Size(318, 311);
            this.logInBox.TabIndex = 1;
            this.logInBox.TabStop = false;
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(103, 162);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(154, 19);
            this.passwordField.TabIndex = 6;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // userFeild
            // 
            this.userFeild.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userFeild.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFeild.Location = new System.Drawing.Point(103, 108);
            this.userFeild.Name = "userFeild";
            this.userFeild.Size = new System.Drawing.Size(154, 19);
            this.userFeild.TabIndex = 6;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.SteelBlue;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logInButton.Location = new System.Drawing.Point(69, 221);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(188, 33);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Login";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(92, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(92, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 1);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(175, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::equiscale.Properties.Resources.lock_login_key_password_protected_safe_security_icon_login_password_11553447634eebadko8fe;
            this.pictureBox2.Location = new System.Drawing.Point(69, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::equiscale.Properties.Resources.username_icon_3;
            this.pictureBox1.Location = new System.Drawing.Point(69, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login with User ID and Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG IN";
            // 
            // equiscalePicture
            // 
            this.equiscalePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equiscalePicture.Image = global::equiscale.Properties.Resources.EI_Solutions_;
            this.equiscalePicture.Location = new System.Drawing.Point(3, 3);
            this.equiscalePicture.Name = "equiscalePicture";
            this.equiscalePicture.Size = new System.Drawing.Size(374, 444);
            this.equiscalePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equiscalePicture.TabIndex = 2;
            this.equiscalePicture.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.logInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EQUISCALE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.logInBox.ResumeLayout(false);
            this.logInBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiscalePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox logInBox;
        private System.Windows.Forms.PictureBox equiscalePicture;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox userFeild;
        private System.Windows.Forms.TextBox passwordField;
    }
}

