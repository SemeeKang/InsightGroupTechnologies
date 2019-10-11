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
            this.rbSupplierPointPick = new System.Windows.Forms.RadioButton();
            this.rbSupplierPointRandom = new System.Windows.Forms.RadioButton();
            this.tbSupplierPoint = new System.Windows.Forms.TextBox();
            this.gbCustomerPoint = new System.Windows.Forms.GroupBox();
            this.lblNCustomerPint = new System.Windows.Forms.Label();
            this.rbCustomerPointPick = new System.Windows.Forms.RadioButton();
            this.tbCustomerPoint = new System.Windows.Forms.TextBox();
            this.rbCustomerPointRandom = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbSupplierPoint.SuspendLayout();
            this.gbCustomerPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSupplierPoint
            // 
            this.gbSupplierPoint.Controls.Add(this.lblNSuppierPoint);
            this.gbSupplierPoint.Controls.Add(this.rbSupplierPointPick);
            this.gbSupplierPoint.Controls.Add(this.rbSupplierPointRandom);
            this.gbSupplierPoint.Controls.Add(this.tbSupplierPoint);
            this.gbSupplierPoint.Location = new System.Drawing.Point(18, 18);
            this.gbSupplierPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSupplierPoint.Name = "gbSupplierPoint";
            this.gbSupplierPoint.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSupplierPoint.Size = new System.Drawing.Size(375, 178);
            this.gbSupplierPoint.TabIndex = 0;
            this.gbSupplierPoint.TabStop = false;
            this.gbSupplierPoint.Text = "Supplier Point";
            // 
            // lblNSuppierPoint
            // 
            this.lblNSuppierPoint.AutoSize = true;
            this.lblNSuppierPoint.Location = new System.Drawing.Point(32, 49);
            this.lblNSuppierPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNSuppierPoint.Name = "lblNSuppierPoint";
            this.lblNSuppierPoint.Size = new System.Drawing.Size(123, 20);
            this.lblNSuppierPoint.TabIndex = 3;
            this.lblNSuppierPoint.Text = "Number of Point";
            // 
            // rbSupplierPointPick
            // 
            this.rbSupplierPointPick.AutoSize = true;
            this.rbSupplierPointPick.Location = new System.Drawing.Point(200, 118);
            this.rbSupplierPointPick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSupplierPointPick.Name = "rbSupplierPointPick";
            this.rbSupplierPointPick.Size = new System.Drawing.Size(128, 24);
            this.rbSupplierPointPick.TabIndex = 2;
            this.rbSupplierPointPick.Text = "Pick on Chart";
            this.rbSupplierPointPick.UseVisualStyleBackColor = true;
            // 
            // rbSupplierPointRandom
            // 
            this.rbSupplierPointRandom.AutoSize = true;
            this.rbSupplierPointRandom.Checked = true;
            this.rbSupplierPointRandom.Location = new System.Drawing.Point(36, 118);
            this.rbSupplierPointRandom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSupplierPointRandom.Name = "rbSupplierPointRandom";
            this.rbSupplierPointRandom.Size = new System.Drawing.Size(95, 24);
            this.rbSupplierPointRandom.TabIndex = 1;
            this.rbSupplierPointRandom.TabStop = true;
            this.rbSupplierPointRandom.Text = "Random";
            this.rbSupplierPointRandom.UseVisualStyleBackColor = true;
            // 
            // tbSupplierPoint
            // 
            this.tbSupplierPoint.Location = new System.Drawing.Point(200, 45);
            this.tbSupplierPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSupplierPoint.MaxLength = 2;
            this.tbSupplierPoint.Name = "tbSupplierPoint";
            this.tbSupplierPoint.Size = new System.Drawing.Size(148, 26);
            this.tbSupplierPoint.TabIndex = 0;
            this.tbSupplierPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSupplierPoint_KeyPress);
            // 
            // gbCustomerPoint
            // 
            this.gbCustomerPoint.Controls.Add(this.lblNCustomerPint);
            this.gbCustomerPoint.Controls.Add(this.rbCustomerPointPick);
            this.gbCustomerPoint.Controls.Add(this.tbCustomerPoint);
            this.gbCustomerPoint.Controls.Add(this.rbCustomerPointRandom);
            this.gbCustomerPoint.Location = new System.Drawing.Point(20, 206);
            this.gbCustomerPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCustomerPoint.Name = "gbCustomerPoint";
            this.gbCustomerPoint.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCustomerPoint.Size = new System.Drawing.Size(374, 177);
            this.gbCustomerPoint.TabIndex = 1;
            this.gbCustomerPoint.TabStop = false;
            this.gbCustomerPoint.Text = "Customer Point";
            // 
            // lblNCustomerPint
            // 
            this.lblNCustomerPint.AutoSize = true;
            this.lblNCustomerPint.Location = new System.Drawing.Point(30, 57);
            this.lblNCustomerPint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNCustomerPint.Name = "lblNCustomerPint";
            this.lblNCustomerPint.Size = new System.Drawing.Size(123, 20);
            this.lblNCustomerPint.TabIndex = 4;
            this.lblNCustomerPint.Text = "Number of Point";
            // 
            // rbCustomerPointPick
            // 
            this.rbCustomerPointPick.AutoSize = true;
            this.rbCustomerPointPick.Location = new System.Drawing.Point(198, 126);
            this.rbCustomerPointPick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCustomerPointPick.Name = "rbCustomerPointPick";
            this.rbCustomerPointPick.Size = new System.Drawing.Size(128, 24);
            this.rbCustomerPointPick.TabIndex = 5;
            this.rbCustomerPointPick.Text = "Pick on Chart";
            this.rbCustomerPointPick.UseVisualStyleBackColor = true;
            // 
            // tbCustomerPoint
            // 
            this.tbCustomerPoint.Location = new System.Drawing.Point(198, 52);
            this.tbCustomerPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustomerPoint.MaxLength = 4;
            this.tbCustomerPoint.Name = "tbCustomerPoint";
            this.tbCustomerPoint.Size = new System.Drawing.Size(148, 26);
            this.tbCustomerPoint.TabIndex = 3;
            this.tbCustomerPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustomerPoint_KeyPress);
            // 
            // rbCustomerPointRandom
            // 
            this.rbCustomerPointRandom.AutoSize = true;
            this.rbCustomerPointRandom.Checked = true;
            this.rbCustomerPointRandom.Location = new System.Drawing.Point(34, 126);
            this.rbCustomerPointRandom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCustomerPointRandom.Name = "rbCustomerPointRandom";
            this.rbCustomerPointRandom.Size = new System.Drawing.Size(95, 24);
            this.rbCustomerPointRandom.TabIndex = 4;
            this.rbCustomerPointRandom.TabStop = true;
            this.rbCustomerPointRandom.Text = "Random";
            this.rbCustomerPointRandom.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(201, 395);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(192, 66);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create Chart";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormNumberData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 480);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbCustomerPoint);
            this.Controls.Add(this.gbSupplierPoint);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNumberData";
            this.Text = "FormNumberData";
            this.gbSupplierPoint.ResumeLayout(false);
            this.gbSupplierPoint.PerformLayout();
            this.gbCustomerPoint.ResumeLayout(false);
            this.gbCustomerPoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSupplierPoint;
        private System.Windows.Forms.RadioButton rbSupplierPointPick;
        private System.Windows.Forms.RadioButton rbSupplierPointRandom;
        private System.Windows.Forms.TextBox tbSupplierPoint;
        private System.Windows.Forms.GroupBox gbCustomerPoint;
        private System.Windows.Forms.RadioButton rbCustomerPointPick;
        private System.Windows.Forms.TextBox tbCustomerPoint;
        private System.Windows.Forms.RadioButton rbCustomerPointRandom;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblNSuppierPoint;
        private System.Windows.Forms.Label lblNCustomerPint;
    }
}