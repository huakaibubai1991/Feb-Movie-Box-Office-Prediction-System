using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace datainput
{
    public partial class FrmManageUser : Form
    {
        public FrmManageUser()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                string buttonText = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();
                string user = dataGridView1.Rows[e.RowIndex].Cells["User"].Value.ToString();
                string password = dataGridView1.Rows[e.RowIndex].Cells["Password0"].Value.ToString();

                if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
                {
                    UserQuanxianManage uqm = new UserQuanxianManage();
                    uqm.InitData();
                    var uq = uqm.UserQuanxianList.FirstOrDefault(q => q.User == user);
                    switch (buttonText)
                    {

                        case "删除":
                            uqm.UserQuanxianList.Remove(uq);
                            uqm.SaveChange();
                            dataGridView1.DataSource = new List<ViewUserQuanxian>();
                            dataGridView1.DataSource = uqm.UserQuanxianList;
                            break;
                    }


                }
            
            }
           



        }

        private void readdata_Click(object sender, EventArgs e)
        {
            
                UserQuanxianManage uqm = new UserQuanxianManage();
                uqm.InitData();
                dataGridView1.DataSource = new List<ViewUserQuanxian>();
                dataGridView1.DataSource = uqm.UserQuanxianList;
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            string mu = manageuser.Text;
            string pw = password.Text;
            string qx = Convert.ToString(quanxian.SelectedItem);
            
            if (!string.IsNullOrEmpty(mu) && !string.IsNullOrEmpty(pw) && !string.IsNullOrEmpty(qx) )
            {
                UserQuanxianManage uqm = new UserQuanxianManage();
                
             
                if (uqm.InitData())
                {
                    if (uqm.InsertOrUpdate(mu, pw ,qx))
                    {
                        MessageBox.Show("添加或更新成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加或更新失败！");
                    }
                }
            }
            else
            {
                MessageBox.Show("用户名或密码或权限不能为空！");
            }
            BindGrid();
        }

        private void BindGrid()
        {

            UserQuanxianManage uqm = new UserQuanxianManage();
            uqm.InitData();
            dataGridView1.DataSource = new List<ViewUserQuanxian>();
            dataGridView1.DataSource = uqm.UserQuanxianList;
            
        }

      

        private void manageuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        //private void deleteuser_Click(object sender, EventArgs e)
        //{
        //    string mu = manageuser.Text;
        //    string pw = password.Text;
        //    string qx = Convert.ToString(quanxian.SelectedItem);

            
            
        //        UserQuanxianManage uqm = new UserQuanxianManage();


        //        if (uqm.InitData())
        //        {
        //            if (uqm.Delete(mu, pw, qx))
        //            {
                        
        //                MessageBox.Show("删除成功！");
        //            }
        //            else
        //            {
        //                MessageBox.Show("删除失败！");
        //            }
        //        }
            
            
        //    BindGrid();
        //    //UserQuanxianManage uqm = new UserQuanxianManage();
        //    //string user = dataGridView1.Rows[e.RowIndex].Cells["用户名"].Value.ToString();
        //    //string user = dataGridView1.Rows[0].Cells["User"].Value.ToString();
        //    //var uq = uqm.UserQuanxianList.FirstOrDefault(q => q.User == user);
            
        //    //uqm.UserQuanxianList.Remove(uq);
        //    //uqm.SaveChange();
        //    //dataGridView1.DataSource = new List<ViewUserQuanxian>();
        //    //dataGridView1.DataSource = uqm.UserQuanxianList;

        //}

       

    }
}
