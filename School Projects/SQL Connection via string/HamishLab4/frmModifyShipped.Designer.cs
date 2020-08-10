namespace HamishLab4
{
    partial class frmModifyShipped
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBoxNullShip = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.btnAcceptShipping = new System.Windows.Forms.Button();
            this.dtpShip = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Shipped Date:";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(174, 259);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(167, 22);
            this.txtRequiredDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Required Date:";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(172, 117);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(169, 22);
            this.txtOrderDate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order Date:";
            // 
            // chkBoxNullShip
            // 
            this.chkBoxNullShip.AutoSize = true;
            this.chkBoxNullShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxNullShip.Location = new System.Drawing.Point(666, 180);
            this.chkBoxNullShip.Name = "chkBoxNullShip";
            this.chkBoxNullShip.Size = new System.Drawing.Size(150, 29);
            this.chkBoxNullShip.TabIndex = 17;
            this.chkBoxNullShip.Text = "No Ship Date";
            this.chkBoxNullShip.UseVisualStyleBackColor = true;
            this.chkBoxNullShip.CheckedChanged += new System.EventHandler(this.chkBoxNullShip_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 60);
            this.label1.TabIndex = 18;
            this.label1.Text = "Change Ship Date";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(172, 182);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(169, 22);
            this.txtShippedDate.TabIndex = 19;
            // 
            // btnAcceptShipping
            // 
            this.btnAcceptShipping.Location = new System.Drawing.Point(17, 331);
            this.btnAcceptShipping.Name = "btnAcceptShipping";
            this.btnAcceptShipping.Size = new System.Drawing.Size(197, 90);
            this.btnAcceptShipping.TabIndex = 20;
            this.btnAcceptShipping.Text = "&Accept shipping Date";
            this.btnAcceptShipping.UseVisualStyleBackColor = true;
            this.btnAcceptShipping.Click += new System.EventHandler(this.btnAcceptShipping_Click);
            // 
            // dtpShip
            // 
            this.dtpShip.Location = new System.Drawing.Point(370, 182);
            this.dtpShip.Name = "dtpShip";
            this.dtpShip.Size = new System.Drawing.Size(274, 22);
            this.dtpShip.TabIndex = 21;
            this.dtpShip.ValueChanged += new System.EventHandler(this.dtpShip_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(636, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(197, 90);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmModifyShipped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 478);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpShip);
            this.Controls.Add(this.btnAcceptShipping);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBoxNullShip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.label4);
            this.Name = "frmModifyShipped";
            this.Text = "ModifyShipped";
            this.Load += new System.EventHandler(this.frmModifyShipped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBoxNullShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.Button btnAcceptShipping;
        private System.Windows.Forms.DateTimePicker dtpShip;
        private System.Windows.Forms.Button btnCancel;
    }
}