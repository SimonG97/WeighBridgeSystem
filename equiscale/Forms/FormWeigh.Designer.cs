
namespace equiscale.Forms
{
    partial class FormWeigh
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
            this.ScaleDisplay = new System.Windows.Forms.TextBox();
            this.RadioAuto = new System.Windows.Forms.RadioButton();
            this.ManualRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstRadio = new System.Windows.Forms.RadioButton();
            this.SecondRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TareRadio = new System.Windows.Forms.RadioButton();
            this.GrossRadio = new System.Windows.Forms.RadioButton();
            this.VehicleTextBox = new System.Windows.Forms.TextBox();
            this.SlipNoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VehicleTypeTextBox = new System.Windows.Forms.TextBox();
            this.SupplierTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MaterialTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ChargesTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.WeightTypePanel = new System.Windows.Forms.Panel();
            this.WeightPanel = new System.Windows.Forms.Panel();
            this.ClearBtn = new FontAwesome.Sharp.IconButton();
            this.SaveBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.WeightTypePanel.SuspendLayout();
            this.WeightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScaleDisplay
            // 
            this.ScaleDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ScaleDisplay.BackColor = System.Drawing.Color.Black;
            this.ScaleDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScaleDisplay.Font = new System.Drawing.Font("Digital-7", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleDisplay.ForeColor = System.Drawing.Color.Red;
            this.ScaleDisplay.Location = new System.Drawing.Point(231, 3);
            this.ScaleDisplay.Name = "ScaleDisplay";
            this.ScaleDisplay.ReadOnly = true;
            this.ScaleDisplay.Size = new System.Drawing.Size(232, 71);
            this.ScaleDisplay.TabIndex = 0;
            this.ScaleDisplay.Text = "0";
            this.ScaleDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ScaleDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScaleDisplay_KeyPress);
            // 
            // RadioAuto
            // 
            this.RadioAuto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RadioAuto.AutoSize = true;
            this.RadioAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioAuto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAuto.ForeColor = System.Drawing.Color.Gainsboro;
            this.RadioAuto.Location = new System.Drawing.Point(469, 12);
            this.RadioAuto.Name = "RadioAuto";
            this.RadioAuto.Size = new System.Drawing.Size(50, 19);
            this.RadioAuto.TabIndex = 1;
            this.RadioAuto.Text = "Auto";
            this.RadioAuto.UseVisualStyleBackColor = true;
            this.RadioAuto.CheckedChanged += new System.EventHandler(this.RadioAuto_CheckedChanged);
            // 
            // ManualRadio
            // 
            this.ManualRadio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManualRadio.AutoSize = true;
            this.ManualRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManualRadio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualRadio.ForeColor = System.Drawing.Color.Gainsboro;
            this.ManualRadio.Location = new System.Drawing.Point(525, 12);
            this.ManualRadio.Name = "ManualRadio";
            this.ManualRadio.Size = new System.Drawing.Size(66, 19);
            this.ManualRadio.TabIndex = 2;
            this.ManualRadio.Text = "Manual";
            this.ManualRadio.UseVisualStyleBackColor = true;
            this.ManualRadio.CheckedChanged += new System.EventHandler(this.ManualRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(264, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Slip No:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(184, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehicle Regn. No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weight:";
            // 
            // FirstRadio
            // 
            this.FirstRadio.AutoSize = true;
            this.FirstRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstRadio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstRadio.ForeColor = System.Drawing.Color.Gainsboro;
            this.FirstRadio.Location = new System.Drawing.Point(85, 17);
            this.FirstRadio.Name = "FirstRadio";
            this.FirstRadio.Size = new System.Drawing.Size(51, 20);
            this.FirstRadio.TabIndex = 7;
            this.FirstRadio.Text = "First";
            this.FirstRadio.UseVisualStyleBackColor = true;
            // 
            // SecondRadio
            // 
            this.SecondRadio.AutoSize = true;
            this.SecondRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondRadio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondRadio.ForeColor = System.Drawing.Color.Gainsboro;
            this.SecondRadio.Location = new System.Drawing.Point(142, 18);
            this.SecondRadio.Name = "SecondRadio";
            this.SecondRadio.Size = new System.Drawing.Size(74, 20);
            this.SecondRadio.TabIndex = 8;
            this.SecondRadio.Text = "Second";
            this.SecondRadio.UseVisualStyleBackColor = true;
            this.SecondRadio.CheckedChanged += new System.EventHandler(this.SecondRadio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(34, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight-Type:";
            // 
            // TareRadio
            // 
            this.TareRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TareRadio.AutoSize = true;
            this.TareRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TareRadio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TareRadio.ForeColor = System.Drawing.Color.Gainsboro;
            this.TareRadio.Location = new System.Drawing.Point(150, 15);
            this.TareRadio.Name = "TareRadio";
            this.TareRadio.Size = new System.Drawing.Size(54, 20);
            this.TareRadio.TabIndex = 10;
            this.TareRadio.Text = "Tare";
            this.TareRadio.UseVisualStyleBackColor = true;
            // 
            // GrossRadio
            // 
            this.GrossRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrossRadio.AutoSize = true;
            this.GrossRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrossRadio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossRadio.ForeColor = System.Drawing.Color.Gainsboro;
            this.GrossRadio.Location = new System.Drawing.Point(207, 15);
            this.GrossRadio.Name = "GrossRadio";
            this.GrossRadio.Size = new System.Drawing.Size(62, 20);
            this.GrossRadio.TabIndex = 11;
            this.GrossRadio.Text = "Gross";
            this.GrossRadio.UseVisualStyleBackColor = true;
            // 
            // VehicleTextBox
            // 
            this.VehicleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VehicleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTextBox.Location = new System.Drawing.Point(329, 177);
            this.VehicleTextBox.Name = "VehicleTextBox";
            this.VehicleTextBox.Size = new System.Drawing.Size(169, 22);
            this.VehicleTextBox.TabIndex = 14;
            // 
            // SlipNoTextBox
            // 
            this.SlipNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SlipNoTextBox.Enabled = false;
            this.SlipNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlipNoTextBox.Location = new System.Drawing.Point(329, 149);
            this.SlipNoTextBox.Name = "SlipNoTextBox";
            this.SlipNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.SlipNoTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(217, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Vehicle Type:";
            // 
            // VehicleTypeTextBox
            // 
            this.VehicleTypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VehicleTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeTextBox.Location = new System.Drawing.Point(329, 205);
            this.VehicleTypeTextBox.Name = "VehicleTypeTextBox";
            this.VehicleTypeTextBox.Size = new System.Drawing.Size(169, 22);
            this.VehicleTypeTextBox.TabIndex = 17;
            // 
            // SupplierTextBox
            // 
            this.SupplierTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SupplierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierTextBox.Location = new System.Drawing.Point(329, 233);
            this.SupplierTextBox.Name = "SupplierTextBox";
            this.SupplierTextBox.Size = new System.Drawing.Size(300, 22);
            this.SupplierTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(254, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Supplier:";
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CustomerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTextBox.Location = new System.Drawing.Point(329, 261);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.Size = new System.Drawing.Size(300, 22);
            this.CustomerTextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(244, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Customer:";
            // 
            // MaterialTextBox
            // 
            this.MaterialTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MaterialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialTextBox.Location = new System.Drawing.Point(329, 289);
            this.MaterialTextBox.Name = "MaterialTextBox";
            this.MaterialTextBox.Size = new System.Drawing.Size(169, 22);
            this.MaterialTextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(254, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Material:";
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RemarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarkTextBox.Location = new System.Drawing.Point(329, 317);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(300, 22);
            this.RemarkTextBox.TabIndex = 29;
            this.RemarkTextBox.Text = "-Na-";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(250, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Remarks:";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTextBox.Enabled = false;
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextBox.Location = new System.Drawing.Point(329, 345);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(120, 22);
            this.DateTextBox.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(280, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "Date:";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeTextBox.Enabled = false;
            this.TimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTextBox.Location = new System.Drawing.Point(329, 373);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(120, 22);
            this.TimeTextBox.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(280, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 19);
            this.label13.TabIndex = 32;
            this.label13.Text = "Time:";
            // 
            // ChargesTextBox
            // 
            this.ChargesTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChargesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargesTextBox.Location = new System.Drawing.Point(329, 401);
            this.ChargesTextBox.Name = "ChargesTextBox";
            this.ChargesTextBox.Size = new System.Drawing.Size(120, 22);
            this.ChargesTextBox.TabIndex = 35;
            this.ChargesTextBox.Text = "0.0";
            this.ChargesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChargesTextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(250, 401);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 19);
            this.label14.TabIndex = 34;
            this.label14.Text = "Charges:";
            // 
            // WeightTypePanel
            // 
            this.WeightTypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTypePanel.Controls.Add(this.TareRadio);
            this.WeightTypePanel.Controls.Add(this.label4);
            this.WeightTypePanel.Controls.Add(this.GrossRadio);
            this.WeightTypePanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.WeightTypePanel.Location = new System.Drawing.Point(409, 92);
            this.WeightTypePanel.Name = "WeightTypePanel";
            this.WeightTypePanel.Size = new System.Drawing.Size(288, 38);
            this.WeightTypePanel.TabIndex = 13;
            // 
            // WeightPanel
            // 
            this.WeightPanel.Controls.Add(this.label3);
            this.WeightPanel.Controls.Add(this.FirstRadio);
            this.WeightPanel.Controls.Add(this.SecondRadio);
            this.WeightPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.WeightPanel.Location = new System.Drawing.Point(80, 92);
            this.WeightPanel.Name = "WeightPanel";
            this.WeightPanel.Size = new System.Drawing.Size(240, 38);
            this.WeightPanel.TabIndex = 12;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ClearBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.ClearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClearBtn.IconSize = 40;
            this.ClearBtn.Location = new System.Drawing.Point(506, 466);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(107, 38);
            this.ClearBtn.TabIndex = 38;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SaveBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.SaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveBtn.IconSize = 40;
            this.SaveBtn.Location = new System.Drawing.Point(231, 466);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(107, 38);
            this.SaveBtn.TabIndex = 37;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(464, 43);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(127, 23);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Capture Weight";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(174, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "*";
            // 
            // FormWeigh
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(747, 532);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ChargesTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RemarkTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MaterialTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustomerTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SupplierTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VehicleTypeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SlipNoTextBox);
            this.Controls.Add(this.VehicleTextBox);
            this.Controls.Add(this.WeightTypePanel);
            this.Controls.Add(this.WeightPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ManualRadio);
            this.Controls.Add(this.RadioAuto);
            this.Controls.Add(this.ScaleDisplay);
            this.Name = "FormWeigh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weigh";
            this.WeightTypePanel.ResumeLayout(false);
            this.WeightTypePanel.PerformLayout();
            this.WeightPanel.ResumeLayout(false);
            this.WeightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScaleDisplay;
        private System.Windows.Forms.RadioButton RadioAuto;
        private System.Windows.Forms.RadioButton ManualRadio;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton FirstRadio;
        private System.Windows.Forms.RadioButton SecondRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton TareRadio;
        private System.Windows.Forms.RadioButton GrossRadio;
        private System.Windows.Forms.TextBox VehicleTextBox;
        private System.Windows.Forms.TextBox SlipNoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VehicleTypeTextBox;
        private System.Windows.Forms.TextBox SupplierTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaterialTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RemarkTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ChargesTextBox;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton SaveBtn;
        private FontAwesome.Sharp.IconButton ClearBtn;
        private System.Windows.Forms.Panel WeightTypePanel;
        private System.Windows.Forms.Panel WeightPanel;
        private System.Windows.Forms.Label label9;
    }
}