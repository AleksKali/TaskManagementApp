
namespace UserInterface.UserControls.Employee
{
    partial class UCTopEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTopEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Top 5 employees in the past month (resolved the largest number of tasks):";
            // 
            // dgvTopEmployees
            // 
            this.dgvTopEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopEmployees.Location = new System.Drawing.Point(90, 97);
            this.dgvTopEmployees.Name = "dgvTopEmployees";
            this.dgvTopEmployees.RowHeadersWidth = 51;
            this.dgvTopEmployees.RowTemplate.Height = 24;
            this.dgvTopEmployees.Size = new System.Drawing.Size(866, 301);
            this.dgvTopEmployees.TabIndex = 5;
            // 
            // UCTopEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTopEmployees);
            this.Name = "UCTopEmployees";
            this.Size = new System.Drawing.Size(995, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTopEmployees;
    }
}
