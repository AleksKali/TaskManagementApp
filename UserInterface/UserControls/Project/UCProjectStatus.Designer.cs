
namespace UserInterface.UserControls.Project
{
    partial class UCProjectStatus
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
            this.dgvProjectStatus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjectStatus
            // 
            this.dgvProjectStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectStatus.Location = new System.Drawing.Point(248, 118);
            this.dgvProjectStatus.Name = "dgvProjectStatus";
            this.dgvProjectStatus.RowHeadersWidth = 51;
            this.dgvProjectStatus.RowTemplate.Height = 24;
            this.dgvProjectStatus.Size = new System.Drawing.Size(459, 362);
            this.dgvProjectStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table below displays the percentage of completed tasks for every project. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Projects are ordered by the percentage of completed tasks in descending order.";
            // 
            // UCProjectStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProjectStatus);
            this.Name = "UCProjectStatus";
            this.Size = new System.Drawing.Size(972, 580);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjectStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
