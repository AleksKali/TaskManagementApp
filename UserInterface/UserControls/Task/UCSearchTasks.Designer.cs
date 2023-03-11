
namespace UserInterface.UserControls.Task
{
    partial class UCSearchTasks
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dgvSearchTasks = new System.Windows.Forms.DataGridView();
            this.tbTaskTitle = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(688, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 27);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetails.Location = new System.Drawing.Point(688, 133);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(108, 28);
            this.btnDetails.TabIndex = 23;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // dgvSearchTasks
            // 
            this.dgvSearchTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSearchTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchTasks.Location = new System.Drawing.Point(19, 107);
            this.dgvSearchTasks.Name = "dgvSearchTasks";
            this.dgvSearchTasks.RowHeadersWidth = 51;
            this.dgvSearchTasks.RowTemplate.Height = 24;
            this.dgvSearchTasks.Size = new System.Drawing.Size(653, 365);
            this.dgvSearchTasks.TabIndex = 22;
            // 
            // tbTaskTitle
            // 
            this.tbTaskTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTaskTitle.Location = new System.Drawing.Point(173, 66);
            this.tbTaskTitle.Name = "tbTaskTitle";
            this.tbTaskTitle.Size = new System.Drawing.Size(132, 22);
            this.tbTaskTitle.TabIndex = 21;
            this.tbTaskTitle.TextChanged += new System.EventHandler(this.tbTaskTitle_TextChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(73, 69);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(69, 17);
            this.lblEmployeeName.TabIndex = 20;
            this.lblEmployeeName.Text = "Task title:";
            // 
            // UCSearchTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dgvSearchTasks);
            this.Controls.Add(this.tbTaskTitle);
            this.Controls.Add(this.lblEmployeeName);
            this.Name = "UCSearchTasks";
            this.Size = new System.Drawing.Size(847, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView dgvSearchTasks;
        private System.Windows.Forms.TextBox tbTaskTitle;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}
