
namespace UserInterface.UserControls.Employee
{
    partial class UCSearchEmployees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dgvSearchEmployees = new System.Windows.Forms.DataGridView();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(824, 171);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(108, 27);
            this.btnDeleteEmployee.TabIndex = 19;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetails.Location = new System.Drawing.Point(824, 121);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(108, 28);
            this.btnDetails.TabIndex = 18;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // dgvSearchEmployees
            // 
            this.dgvSearchEmployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSearchEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchEmployees.Location = new System.Drawing.Point(63, 94);
            this.dgvSearchEmployees.Name = "dgvSearchEmployees";
            this.dgvSearchEmployees.RowHeadersWidth = 51;
            this.dgvSearchEmployees.RowTemplate.Height = 24;
            this.dgvSearchEmployees.Size = new System.Drawing.Size(735, 430);
            this.dgvSearchEmployees.TabIndex = 17;
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmployeeName.Location = new System.Drawing.Point(243, 43);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(132, 22);
            this.tbEmployeeName.TabIndex = 16;
            this.tbEmployeeName.TextChanged += new System.EventHandler(this.tbEmployeeName_TextChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(143, 46);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(75, 17);
            this.lblEmployeeName.TabIndex = 15;
            this.lblEmployeeName.Text = "Full Name:";
            // 
            // UCSearchEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dgvSearchEmployees);
            this.Controls.Add(this.tbEmployeeName);
            this.Controls.Add(this.lblEmployeeName);
            this.Name = "UCSearchEmployees";
            this.Size = new System.Drawing.Size(970, 586);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView dgvSearchEmployees;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}
