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
        //登录界面代码
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
            //登录按钮点击事件
            //新建用户名、密码、权限名称
            string userName = user.Text;
            string passWord = password.Text;
            string quanXian = Convert.ToString(quanxian.SelectedItem);
            //新建一个用户管理权限，并引用其中的InitData方法调用数据
            UserQuanxianManage uqm = new UserQuanxianManage();
            uqm.InitData();
            //查找输入的用户名在后台数据中有没有
            var uqname = uqm.UserQuanxianList.FirstOrDefault(q => q.User == userName);
            //var uqpassword = uqm.UserQuanxianList.FirstOrDefault(q => q.Password == passWord);
            //var uqquanxian = uqm.UserQuanxianList.FirstOrDefault(q => q.Quanxian == quanXian);

            FrmPointManagebtnnotshow fpmnotshow = new FrmPointManagebtnnotshow();//新建一般用户的登录界面（用户管理功能为灰色）
            FrmMain fm = new FrmMain();//新建主界面
            //判断用户名、密码和权限不为空
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord) && !string.IsNullOrEmpty(quanXian))
            {
                //判断如果输入的用户名在后台没有数据
                if (uqname.User != userName || uqname.Password != passWord || uqname.Quanxian != quanXian)
                {
                    MessageBox.Show("错误的用户名或密码，请重新输入！");
                }
                else
                {
                    //如果后台有用户名和密码权限数据就执行下面的操作
                    //var uqquanxian = uqm.UserQuanxianList.FirstOrDefault(q => q.Quanxian == quanXian);
                    //string uqquanxian0 = uqquanxian.Quanxian;
                    switch (uqname.Quanxian)
                    {
                        //不同的权限看到界面的功能不同，一般用户不能用用户管理这个功能
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
            this.Close();//取消按钮功能，点击就关闭界面
        }

        
       
    }
}
