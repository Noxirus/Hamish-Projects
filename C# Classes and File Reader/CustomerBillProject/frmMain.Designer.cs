namespace CustomerBillProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUseage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResidential = new System.Windows.Forms.RadioButton();
            this.btnCommercial = new System.Windows.Forms.RadioButton();
            this.btnIndustrial = new System.Windows.Forms.RadioButton();
            this.boxClientType = new System.Windows.Forms.GroupBox();
            this.pnlIndistrialSelect = new System.Windows.Forms.Panel();
            this.txtOffHours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlHoursDisplay = new System.Windows.Forms.Panel();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.lblClientCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotResCharges = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotComCharges = new System.Windows.Forms.Label();
            this.lblTotIndCharges = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.boxClientType.SuspendLayout();
            this.pnlIndistrialSelect.SuspendLayout();
            this.pnlHoursDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "KWH Useage: ";
            // 
            // txtUseage
            // 
            this.txtUseage.Location = new System.Drawing.Point(212, 337);
            this.txtUseage.Name = "txtUseage";
            this.txtUseage.Size = new System.Drawing.Size(140, 22);
            this.txtUseage.TabIndex = 15;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 441);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(139, 52);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "&Calculate Bill and Add";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(212, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 52);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(1033, 499);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(140, 52);
            this.btnQuit.TabIndex = 22;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Bill: ";
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.BackColor = System.Drawing.Color.Turquoise;
            this.lblBillTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotal.Location = new System.Drawing.Point(212, 394);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(140, 29);
            this.lblBillTotal.TabIndex = 16;
            this.lblBillTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(460, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnResidential
            // 
            this.btnResidential.AutoSize = true;
            this.btnResidential.Checked = true;
            this.btnResidential.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResidential.Location = new System.Drawing.Point(10, 44);
            this.btnResidential.Name = "btnResidential";
            this.btnResidential.Size = new System.Drawing.Size(155, 33);
            this.btnResidential.TabIndex = 12;
            this.btnResidential.TabStop = true;
            this.btnResidential.Text = "Residential";
            this.btnResidential.UseVisualStyleBackColor = true;
            // 
            // btnCommercial
            // 
            this.btnCommercial.AutoSize = true;
            this.btnCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommercial.Location = new System.Drawing.Point(10, 83);
            this.btnCommercial.Name = "btnCommercial";
            this.btnCommercial.Size = new System.Drawing.Size(164, 33);
            this.btnCommercial.TabIndex = 13;
            this.btnCommercial.Text = "Commercial";
            this.btnCommercial.UseVisualStyleBackColor = true;
            // 
            // btnIndustrial
            // 
            this.btnIndustrial.AutoSize = true;
            this.btnIndustrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndustrial.Location = new System.Drawing.Point(10, 122);
            this.btnIndustrial.Name = "btnIndustrial";
            this.btnIndustrial.Size = new System.Drawing.Size(131, 33);
            this.btnIndustrial.TabIndex = 14;
            this.btnIndustrial.Text = "Industrial";
            this.btnIndustrial.UseVisualStyleBackColor = true;
            this.btnIndustrial.CheckedChanged += new System.EventHandler(this.btnIndustrial_CheckedChanged);
            // 
            // boxClientType
            // 
            this.boxClientType.Controls.Add(this.btnResidential);
            this.boxClientType.Controls.Add(this.btnIndustrial);
            this.boxClientType.Controls.Add(this.btnCommercial);
            this.boxClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxClientType.Location = new System.Drawing.Point(12, 120);
            this.boxClientType.Name = "boxClientType";
            this.boxClientType.Size = new System.Drawing.Size(199, 169);
            this.boxClientType.TabIndex = 13;
            this.boxClientType.TabStop = false;
            this.boxClientType.Text = "Client Type";
            // 
            // pnlIndistrialSelect
            // 
            this.pnlIndistrialSelect.Controls.Add(this.txtOffHours);
            this.pnlIndistrialSelect.Location = new System.Drawing.Point(416, 320);
            this.pnlIndistrialSelect.Name = "pnlIndistrialSelect";
            this.pnlIndistrialSelect.Size = new System.Drawing.Size(164, 57);
            this.pnlIndistrialSelect.TabIndex = 16;
            this.pnlIndistrialSelect.Visible = false;
            // 
            // txtOffHours
            // 
            this.txtOffHours.Location = new System.Drawing.Point(12, 17);
            this.txtOffHours.Name = "txtOffHours";
            this.txtOffHours.Size = new System.Drawing.Size(140, 22);
            this.txtOffHours.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Peak Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Off Hours";
            // 
            // pnlHoursDisplay
            // 
            this.pnlHoursDisplay.Controls.Add(this.label6);
            this.pnlHoursDisplay.Controls.Add(this.label5);
            this.pnlHoursDisplay.Location = new System.Drawing.Point(212, 283);
            this.pnlHoursDisplay.Name = "pnlHoursDisplay";
            this.pnlHoursDisplay.Size = new System.Drawing.Size(368, 37);
            this.pnlHoursDisplay.TabIndex = 21;
            this.pnlHoursDisplay.Visible = false;
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.ItemHeight = 16;
            this.lstClients.Location = new System.Drawing.Point(803, 37);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(370, 276);
            this.lstClients.TabIndex = 20;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(212, 34);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(221, 22);
            this.txtClientName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Client Name:";
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(803, 499);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(139, 52);
            this.btnRemoveClient.TabIndex = 21;
            this.btnRemoveClient.Text = "&Remove Client";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Account Number:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(236, 78);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(89, 22);
            this.txtAccountNo.TabIndex = 11;
            // 
            // lblClientCount
            // 
            this.lblClientCount.BackColor = System.Drawing.Color.Turquoise;
            this.lblClientCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCount.Location = new System.Drawing.Point(613, 448);
            this.lblClientCount.Name = "lblClientCount";
            this.lblClientCount.Size = new System.Drawing.Size(140, 29);
            this.lblClientCount.TabIndex = 29;
            this.lblClientCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 29);
            this.label8.TabIndex = 30;
            this.label8.Text = "Total Customers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(798, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Total Charges:";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.BackColor = System.Drawing.Color.Turquoise;
            this.lblTotalCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCharges.Location = new System.Drawing.Point(1033, 449);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(140, 29);
            this.lblTotalCharges.TabIndex = 31;
            this.lblTotalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(799, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total Residential Charges:";
            // 
            // lblTotResCharges
            // 
            this.lblTotResCharges.BackColor = System.Drawing.Color.Turquoise;
            this.lblTotResCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotResCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotResCharges.Location = new System.Drawing.Point(1033, 316);
            this.lblTotResCharges.Name = "lblTotResCharges";
            this.lblTotResCharges.Size = new System.Drawing.Size(140, 25);
            this.lblTotResCharges.TabIndex = 33;
            this.lblTotResCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(799, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total Commercial Charges:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(799, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total Industrial Charges:";
            // 
            // lblTotComCharges
            // 
            this.lblTotComCharges.BackColor = System.Drawing.Color.Turquoise;
            this.lblTotComCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotComCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotComCharges.Location = new System.Drawing.Point(1033, 355);
            this.lblTotComCharges.Name = "lblTotComCharges";
            this.lblTotComCharges.Size = new System.Drawing.Size(140, 25);
            this.lblTotComCharges.TabIndex = 37;
            this.lblTotComCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotIndCharges
            // 
            this.lblTotIndCharges.BackColor = System.Drawing.Color.Turquoise;
            this.lblTotIndCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotIndCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotIndCharges.Location = new System.Drawing.Point(1033, 393);
            this.lblTotIndCharges.Name = "lblTotIndCharges";
            this.lblTotIndCharges.Size = new System.Drawing.Size(140, 25);
            this.lblTotIndCharges.TabIndex = 38;
            this.lblTotIndCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1185, 563);
            this.Controls.Add(this.lblTotIndCharges);
            this.Controls.Add(this.lblTotComCharges);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotResCharges);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblClientCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.btnRemoveClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.pnlHoursDisplay);
            this.Controls.Add(this.pnlIndistrialSelect);
            this.Controls.Add(this.boxClientType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBillTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtUseage);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Power Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.boxClientType.ResumeLayout(false);
            this.boxClientType.PerformLayout();
            this.pnlIndistrialSelect.ResumeLayout(false);
            this.pnlIndistrialSelect.PerformLayout();
            this.pnlHoursDisplay.ResumeLayout(false);
            this.pnlHoursDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUseage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBillTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton btnResidential;
        private System.Windows.Forms.RadioButton btnCommercial;
        private System.Windows.Forms.RadioButton btnIndustrial;
        private System.Windows.Forms.GroupBox boxClientType;
        private System.Windows.Forms.Panel pnlIndistrialSelect;
        private System.Windows.Forms.TextBox txtOffHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlHoursDisplay;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label lblClientCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotResCharges;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotComCharges;
        private System.Windows.Forms.Label lblTotIndCharges;
    }
}

