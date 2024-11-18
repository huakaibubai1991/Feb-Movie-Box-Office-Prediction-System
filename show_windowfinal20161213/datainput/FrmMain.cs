using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace datainput
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
        }

        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    FrmPointManage pm=new FrmPointManage();
        //    pm.Show();
        //}

        //private void btn2_Click(object sender, EventArgs e)
        //{
        //    FrmForecast f=new FrmForecast();
        //    f.Show();
        //}
       
        public void 数据管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPointManage pm = new FrmPointManage();
            pm.Show();
        }

        private void 电影票房预测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForecast f = new FrmForecast();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            this.statusStrip1.Text = System.DateTime.Now.ToString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //this.skinEngine1.SkinFile = Application.StartupPath + "//office2007.ssk";
            //Sunisoft.IrisSkin.SkinEngine se = null;
            //se = new Sunisoft.IrisSkin.SkinEngine();
            //se.SkinAllForm = true;
            //this.数据ToolStripMenuItem.Enabled = false;
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageUser fmu = new FrmManageUser();
            fmu.Show();
        }

        public void btnnotshow()
        {
            //this.数据管理ToolStripMenuItem_Click_1.Enabled = false;
            //this.数据管理ToolStripMenuItem.Enabled = false;
            //数据管理ToolStripMenuItem.Enabled = false;
            用户管理ToolStripMenuItem.Enabled = false;
        }

        private void 数据管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPointManage pm = new FrmPointManage();
            pm.Show();
        }

        private void 电影票房训练ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void 开始训练ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrain ft = new FrmTrain();
            ft.Show();
        }

        private void 增加训练数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddTraindata fat = new FrmAddTraindata();
            fat.Show();
        }

      
      
    }
}
