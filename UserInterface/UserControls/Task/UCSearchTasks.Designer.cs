
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
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(856, 127);
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
            this.btnDetails.Location = new System.Drawing.Point(856, 77);
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
            this.dgvSearchTasks.Location = new System.Drawing.Point(3, 53);
            this.dgvSearchTasks.Name = "dgvSearchTasks";
            this.dgvSearchTasks.RowHeadersWidth = 51;
            this.dgvSearchTasks.RowTemplate.Height = 24;
            this.dgvSearchTasks.Size = new System.Drawing.Size(843, 482);
            this.dgvSearchTasks.TabIndex = 22;
            // 
            // tbTaskTitle
            // 
            this.tbTaskTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTaskTitle.Location = new System.Drawing.Point(174, 17);
            this.tbTaskTitle.Name = "tbTaskTitle";
            this.tbTaskTitle.Size = new System.Drawing.Size(157, 22);
            this.tbTaskTitle.TabIndex = 21;
            this.tbTaskTitle.Click += new System.EventHandler(this.tbTaskTitle_Click);
            this.tbTaskTitle.TextChanged += new System.EventHandler(this.tbTaskTitle_TextChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(36, 17);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(132, 17);
            this.lblEmployeeName.TabIndex = 20;
            this.lblEmployeeName.Text = "Search by task title:";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmployeeName.Location = new System.Drawing.Point(611, 17);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(157, 22);
            this.tbEmployeeName.TabIndex = 26;
            this.tbEmployeeName.Click += new System.EventHandler(this.tbEmployeeName_Click);
            this.tbEmployeeName.TextChanged += new System.EventHandler(this.tbEmployeeName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search by employee name:";
            // 
            // UCSearchTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbEmployeeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dgvSearchTasks);
            this.Controls.Add(this.tbTaskTitle);
            this.Controls.Add(this.lblEmployeeName);
            this.Name = "UCSearchTasks";
            this.Size = new System.Drawing.Size(977, 538);
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
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label label1;
    }
}
