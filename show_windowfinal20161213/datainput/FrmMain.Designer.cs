namespace datainput
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电影票房训练ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加训练数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始训练ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电影票房预测ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据管理ToolStripMenuItem,
            this.电影票房训练ToolStripMenuItem,
            this.电影票房预测ToolStripMenuItem,
            this.用户管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据管理ToolStripMenuItem
            // 
            this.数据管理ToolStripMenuItem.Name = "数据管理ToolStripMenuItem";
            this.数据管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据管理ToolStripMenuItem.Text = "数据管理";
            this.数据管理ToolStripMenuItem.Click += new System.EventHandler(this.数据管理ToolStripMenuItem_Click_1);
            // 
            // 电影票房训练ToolStripMenuItem
            // 
            this.电影票房训练ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加训练数据ToolStripMenuItem,
            this.开始训练ToolStripMenuItem});
            this.电影票房训练ToolStripMenuItem.Name = "电影票房训练ToolStripMenuItem";
            this.电影票房训练ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.电影票房训练ToolStripMenuItem.Text = "电影票房训练";
            this.电影票房训练ToolStripMenuItem.Click += new System.EventHandler(this.电影票房训练ToolStripMenuItem_Click);
            // 
            // 增加训练数据ToolStripMenuItem
            // 
            this.增加训练数据ToolStripMenuItem.Name = "增加训练数据ToolStripMenuItem";
            this.增加训练数据ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.增加训练数据ToolStripMenuItem.Text = "增加训练数据";
            this.增加训练数据ToolStripMenuItem.Click += new System.EventHandler(this.增加训练数据ToolStripMenuItem_Click);
            // 
            // 开始训练ToolStripMenuItem
            // 
            this.开始训练ToolStripMenuItem.Name = "开始训练ToolStripMenuItem";
            this.开始训练ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.开始训练ToolStripMenuItem.Text = "开始训练";
            this.开始训练ToolStripMenuItem.Click += new System.EventHandler(this.开始训练ToolStripMenuItem_Click);
            // 
            // 电影票房预测ToolStripMenuItem
            // 
            this.电影票房预测ToolStripMenuItem.Name = "电影票房预测ToolStripMenuItem";
            this.电影票房预测ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.电影票房预测ToolStripMenuItem.Text = "电影票房预测";
            this.电影票房预测ToolStripMenuItem.Click += new System.EventHandler(this.电影票房预测ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(619, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 535);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Feb电影票房预测系统主界面";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电影票房预测ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电影票房训练ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加训练数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始训练ToolStripMenuItem;
    }
}