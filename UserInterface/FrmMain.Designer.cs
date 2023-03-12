
namespace UserInterface
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmpoyeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.employeeKPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.taskToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmployeeToolStripMenuItem,
            this.searchEmpoyeesToolStripMenuItem,
            this.employeeStatisticsToolStripMenuItem,
            this.employeeKPIToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // createEmployeeToolStripMenuItem
            // 
            this.createEmployeeToolStripMenuItem.Name = "createEmployeeToolStripMenuItem";
            this.createEmployeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createEmployeeToolStripMenuItem.Text = "Create employee";
            this.createEmployeeToolStripMenuItem.Click += new System.EventHandler(this.createEmployeeToolStripMenuItem_Click);
            // 
            // searchEmpoyeesToolStripMenuItem
            // 
            this.searchEmpoyeesToolStripMenuItem.Name = "searchEmpoyeesToolStripMenuItem";
            this.searchEmpoyeesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchEmpoyeesToolStripMenuItem.Text = "Search employees";
            this.searchEmpoyeesToolStripMenuItem.Click += new System.EventHandler(this.searchEmpoyeesToolStripMenuItem_Click);
            // 
            // employeeStatisticsToolStripMenuItem
            // 
            this.employeeStatisticsToolStripMenuItem.Name = "employeeStatisticsToolStripMenuItem";
            this.employeeStatisticsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.employeeStatisticsToolStripMenuItem.Text = "Employee statistics";
            this.employeeStatisticsToolStripMenuItem.Click += new System.EventHandler(this.employeeStatisticsToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTaskToolStripMenuItem,
            this.searchTasksToolStripMenuItem});
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // createTaskToolStripMenuItem
            // 
            this.createTaskToolStripMenuItem.Name = "createTaskToolStripMenuItem";
            this.createTaskToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.createTaskToolStripMenuItem.Text = "Create Task";
            this.createTaskToolStripMenuItem.Click += new System.EventHandler(this.createTaskToolStripMenuItem_Click);
            // 
            // searchTasksToolStripMenuItem
            // 
            this.searchTasksToolStripMenuItem.Name = "searchTasksToolStripMenuItem";
            this.searchTasksToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.searchTasksToolStripMenuItem.Text = "Search Tasks";
            this.searchTasksToolStripMenuItem.Click += new System.EventHandler(this.searchTasksToolStripMenuItem_Click_1);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectSizeToolStripMenuItem,
            this.projectStatusToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // projectSizeToolStripMenuItem
            // 
            this.projectSizeToolStripMenuItem.Name = "projectSizeToolStripMenuItem";
            this.projectSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.projectSizeToolStripMenuItem.Text = "Project size";
            this.projectSizeToolStripMenuItem.Click += new System.EventHandler(this.projectSizeToolStripMenuItem_Click);
            // 
            // projectStatusToolStripMenuItem
            // 
            this.projectStatusToolStripMenuItem.Name = "projectStatusToolStripMenuItem";
            this.projectStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.projectStatusToolStripMenuItem.Text = "Project status";
            this.projectStatusToolStripMenuItem.Click += new System.EventHandler(this.projectStatusToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1012, 543);
            this.pnlMain.TabIndex = 1;
            // 
            // employeeKPIToolStripMenuItem
            // 
            this.employeeKPIToolStripMenuItem.Name = "employeeKPIToolStripMenuItem";
            this.employeeKPIToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.employeeKPIToolStripMenuItem.Text = "Employee KPI";
            this.employeeKPIToolStripMenuItem.Click += new System.EventHandler(this.employeeKPIToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 571);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEmpoyeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchTasksToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeKPIToolStripMenuItem;
    }
}

