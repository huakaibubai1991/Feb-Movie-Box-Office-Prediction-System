using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datainput;
using System.IO;

namespace datainput
{
    public partial class FrmLogin : Form
    {

        //public List<ViewUserQuanxian> UserQuanxianList { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
            //comboBox1.Items.AddRange(new object[] { "管理员", "一般用户" });
            //comboBox1.SelectedIndex = 0;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void land_Click(object sender, EventArgs e)
        {
            string userName = user.Text;
            string passWord = password.Text;
            string quanXian = Convert.ToString(quanxian.SelectedItem);

            UserQuanxianManage uqm = new UserQuanxianManage();
            uqm.InitData();
            var uqname = uqm.UserQuanxianList.FirstOrDefault(q => q.User == userName);
            //var uqpassword = uqm.UserQuanxianList.FirstOrDefault(q => q.Password == passWord);
            //var uqquanxian = uqm.UserQuanxianList.FirstOrDefault(q => q.Quanxian == quanXian);

            FrmPointManagebtnnotshow fpmnotshow = new FrmPointManagebtnnotshow();
            FrmMain fm = new FrmMain();

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord) && !string.IsNullOrEmpty(quanXian))
            {

                if (uqname.User != userName || uqname.Password != passWord || uqname.Quanxian != quanXian)
                {
                    MessageBox.Show("错误的用户名或密码，请重新输入！");
                }
                else
                {
                    //var uqquanxian = uqm.UserQuanxianList.FirstOrDefault(q => q.Quanxian == quanXian);
                    //string uqquanxian0 = uqquanxian.Quanxian;
                    switch (uqname.Quanxian)
                    {

                        case "管理员":
                            MessageBox.Show("欢迎进入Feb电影票房预测系统！", "登陆成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();
                            this.Hide();
                            break;
                        case "一般用户":
                            MessageBox.Show("欢迎进入Feb电影票房预测系统！", "登陆成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmMain fmmain = new FrmMain();
                            fmmain.btnnotshow();
                            fmmain.Show();
                            this.Hide();
                            break;


                    }

                    //MessageBox.Show("欢迎进入Feb电影票房预测系统！", "登陆成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //FrmMain frmMain = new FrmMain();
                    //frmMain.Show();
                    //this.Hide();

                }



            }

            else
            {

                MessageBox.Show("用户名或密码或权限不能为空！");
            }
            

            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       
    }
}
