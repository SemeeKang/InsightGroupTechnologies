namespace InsightGroup
{
    partial class FormNumberData
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
            this.gbSupplierPoint = new System.Windows.Forms.GroupBox();
            this.lblNSuppierPoint = new System.Windows.Forms.Label();
            this.tbSupplierPoint = new System.Windows.Forms.TextBox();
            this.gbCustomerPoint = new System.Windows.Forms.GroupBox();
            this.lblNCustomerPint = new System.Windows.Forms.Label();
            this.tbCustomerPoint = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbSupplierPoint.SuspendLayout();
            this.gbCustomerPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSupplierPoint
            // 
            this.gbSupplierPoint.Controls.Add(this.lblNSuppierPoint);
            this.gbSupplierPoint.Controls.Add(this.tbSupplierPoint);
            this.gbSupplierPoint.Location = new System.Drawing.Point(12, 12);
            this.gbSupplierPoint.Name = "gbSupplierPoint";
            this.gbSupplierPoint.Size = new System.Drawing.Size(250, 67);
            this.gbSupplierPoint.TabIndex = 0;
            this.gbSupplierPoint.TabStop = false;
            this.gbSupplierPoint.Text = "Supplier Point";
            // 
            // lblNSuppierPoint
            // 
            this.lblNSuppierPoint.AutoSize = true;
            this.lblNSuppierPoint.Location = new System.Drawing.Point(21, 32);
            this.lblNSuppierPoint.Name = "lblNSuppierPoint";
            this.lblNSuppierPoint.Size = new System.Drawing.Size(83, 13);
            this.lblNSuppierPoint.TabIndex = 3;
            this.lblNSuppierPoint.Text = "Number of Point";
            // 
            // tbSupplierPoint
            // 
            this.tbSupplierPoint.Location = new System.Drawing.Point(133, 29);
            this.tbSupplierPoint.MaxLength = 2;
            this.tbSupplierPoint.Name = "tbSupplierPoint";
            this.tbSupplierPoint.Size = new System.Drawing.Size(100, 20);
            this.tbSupplierPoint.TabIndex = 0;
            this.tbSupplierPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSupplierPoint_KeyPress);
            // 
            // gbCustomerPoint
            // 
            this.gbCustomerPoint.Controls.Add(this.lblNCustomerPint);
            this.gbCustomerPoint.Controls.Add(this.tbCustomerPoint);
            this.gbCustomerPoint.Location = new System.Drawing.Point(13, 94);
            this.gbCustomerPoint.Name = "gbCustomerPoint";
            this.gbCustomerPoint.Size = new System.Drawing.Size(249, 70);
            this.gbCustomerPoint.TabIndex = 1;
            this.gbCustomerPoint.TabStop = false;
            this.gbCustomerPoint.Text = "Customer Point";
            // 
            // lblNCustomerPint
            // 
            this.lblNCustomerPint.AutoSize = true;
            this.lblNCustomerPint.Location = new System.Drawing.Point(20, 37);
            this.lblNCustomerPint.Name = "lblNCustomerPint";
            this.lblNCustomerPint.Size = new System.Drawing.Size(83, 13);
            this.lblNCustomerPint.TabIndex = 4;
            this.lblNCustomerPint.Text = "Number of Point";
            // 
            // tbCustomerPoint
            // 
            this.tbCustomerPoint.Location = new System.Drawing.Point(132, 34);
            this.tbCustomerPoint.MaxLength = 4;
            this.tbCustomerPoint.Name = "tbCustomerPoint";
            this.tbCustomerPoint.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerPoint.TabIndex = 3;
            this.tbCustomerPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustomerPoint_KeyPress);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(134, 179);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 43);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Chart";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormNumberData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 236);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbCustomerPoint);
            this.Controls.Add(this.gbSupplierPoint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNumberData";
            this.Text = "Number of Point";
            this.gbSupplierPoint.ResumeLayout(false);
            this.gbSupplierPoint.PerformLayout();
            this.gbCustomerPoint.ResumeLayout(false);
            this.gbCustomerPoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSupplierPoint;
        private System.Windows.Forms.TextBox tbSupplierPoint;
        private System.Windows.Forms.GroupBox gbCustomerPoint;
        private System.Windows.Forms.TextBox tbCustomerPoint;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblNSuppierPoint;
        private System.Windows.Forms.Label lblNCustomerPint;
    }
}