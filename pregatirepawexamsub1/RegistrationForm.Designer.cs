namespace pregatirepawexamsub1
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.NumericUpDown numPasses;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblPasses;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.numPasses = new System.Windows.Forms.NumericUpDown();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblPasses = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(12, 15);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(106, 17);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Company Name:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(124, 12);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(200, 22);
            this.txtCompany.TabIndex = 1;
            // 
            // lblPasses
            // 
            this.lblPasses.AutoSize = true;
            this.lblPasses.Location = new System.Drawing.Point(12, 51);
            this.lblPasses.Name = "lblPasses";
            this.lblPasses.Size = new System.Drawing.Size(58, 17);
            this.lblPasses.TabIndex = 2;
            this.lblPasses.Text = "Passes:";
            // 
            // numPasses
            // 
            this.numPasses.Location = new System.Drawing.Point(124, 49);
            this.numPasses.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numPasses.Name = "numPasses";
            this.numPasses.Size = new System.Drawing.Size(120, 22);
            this.numPasses.TabIndex = 3;
            this.numPasses.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(12, 87);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(64, 17);
            this.lblPackage.TabIndex = 4;
            this.lblPackage.Text = "Package:";
            // 
            // cmbPackage
            // 
            this.cmbPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(124, 84);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(200, 24);
            this.cmbPackage.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(124, 124);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 30);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(249, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(350, 170);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbPackage);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.numPasses);
            this.Controls.Add(this.lblPasses);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lblCompany);
            this.Name = "RegistrationForm";
            this.Text = "Add / Modify Registration";
            ((System.ComponentModel.ISupportInitialize)(this.numPasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}