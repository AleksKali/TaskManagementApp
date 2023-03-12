
namespace UserInterface.UserControls.Project
{
    partial class UCProjectSize
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
            this.rbSmallProjects = new System.Windows.Forms.RadioButton();
            this.rbMediumProjects = new System.Windows.Forms.RadioButton();
            this.rbLargeProjects = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProjectsSize = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectsSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSmallProjects
            // 
            this.rbSmallProjects.AutoSize = true;
            this.rbSmallProjects.Checked = true;
            this.rbSmallProjects.Location = new System.Drawing.Point(231, 18);
            this.rbSmallProjects.Name = "rbSmallProjects";
            this.rbSmallProjects.Size = new System.Drawing.Size(61, 21);
            this.rbSmallProjects.TabIndex = 0;
            this.rbSmallProjects.TabStop = true;
            this.rbSmallProjects.Text = "small";
            this.rbSmallProjects.UseVisualStyleBackColor = true;
            this.rbSmallProjects.CheckedChanged += new System.EventHandler(this.rbSmallProjects_CheckedChanged);
            // 
            // rbMediumProjects
            // 
            this.rbMediumProjects.AutoSize = true;
            this.rbMediumProjects.Location = new System.Drawing.Point(231, 54);
            this.rbMediumProjects.Name = "rbMediumProjects";
            this.rbMediumProjects.Size = new System.Drawing.Size(78, 21);
            this.rbMediumProjects.TabIndex = 1;
            this.rbMediumProjects.Text = "medium";
            this.rbMediumProjects.UseVisualStyleBackColor = true;
            this.rbMediumProjects.CheckedChanged += new System.EventHandler(this.rbMediumProjects_CheckedChanged);
            // 
            // rbLargeProjects
            // 
            this.rbLargeProjects.AutoSize = true;
            this.rbLargeProjects.Location = new System.Drawing.Point(231, 91);
            this.rbLargeProjects.Name = "rbLargeProjects";
            this.rbLargeProjects.Size = new System.Drawing.Size(61, 21);
            this.rbLargeProjects.TabIndex = 2;
            this.rbLargeProjects.Text = "large";
            this.rbLargeProjects.UseVisualStyleBackColor = true;
            this.rbLargeProjects.CheckedChanged += new System.EventHandler(this.rbLargeProjects_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose the project size:";
            // 
            // dgvProjectsSize
            // 
            this.dgvProjectsSize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectsSize.Location = new System.Drawing.Point(239, 174);
            this.dgvProjectsSize.Name = "dgvProjectsSize";
            this.dgvProjectsSize.RowHeadersWidth = 51;
            this.dgvProjectsSize.RowTemplate.Height = 24;
            this.dgvProjectsSize.Size = new System.Drawing.Size(469, 292);
            this.dgvProjectsSize.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(336, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "(up to 3 people on projects)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(336, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "(more than 10 people on project)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(336, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "(4 to 10 people on project)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMediumProjects);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbSmallProjects);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbLargeProjects);
            this.groupBox1.Location = new System.Drawing.Point(168, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(248, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Number of people working on a project was used to estimate the size of it.";
            // 
            // UCProjectSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProjectsSize);
            this.Name = "UCProjectSize";
            this.Size = new System.Drawing.Size(937, 576);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectsSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSmallProjects;
        private System.Windows.Forms.RadioButton rbMediumProjects;
        private System.Windows.Forms.RadioButton rbLargeProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProjectsSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}
