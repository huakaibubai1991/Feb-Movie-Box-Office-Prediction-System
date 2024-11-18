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
    //数据管理代码
    public partial class FrmPointManage : Form
    {
        public FrmPointManage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 )//判断行索引是否大于零
            {
                //将后台的数据放入到dategridview中
                string buttonText = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();
                string name = dataGridView1.Rows[e.RowIndex].Cells["Column_Name"].Value.ToString();              
                string position = GetPosition();//定义职务类型选择的名称
                //判断职务类型和姓名是否为空
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(position))
                {
                    NamePointManage npm = new NamePointManage
                    {
                        Position = position
                    };//姓名和职务类型挂钩
                    npm.InitData();
                    var np = npm.NamePointList.FirstOrDefault(q => q.Name == name);

                    switch (buttonText)//dategridview中修改和删除按钮执行的功能
                    {
                        case "修改":
                            if (np != null)
                            {
                                txtName.Text = np.Name;//如果点击修改按钮则该数据显示在左侧的姓名和权重框中
                                nPoint.Value = np.Point;
                            }
                            break;

                        case "删除":
                            npm.NamePointList.Remove(np);//删除该条数据
                            npm.SaveChange();//将删除之后的数据重新排列保存
                            dataGridView1.DataSource = new List<ViewNamePoint>();//dategridview重新扫一遍更新之后的数据源
                            dataGridView1.DataSource = npm.NamePointList;
                            break;
                    }

                    
                }

                //dataGridView1.Rows[0].Frozen = true;


            
            }
           
        }




        
        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            BindGrid();//绑定数据
           
            
        }

        private void BindGrid()
        {
            string position = GetPosition();//得到选择的职务类型
            if (!string.IsNullOrEmpty(position))//判断职务类型是否为空
            {
                NamePointManage npm = new NamePointManage
                {
                    Position = position
                };//职务类型与姓名挂钩
                npm.InitData();//初始数据
                dataGridView1.DataSource = new List<ViewNamePoint>();
                dataGridView1.DataSource = npm.NamePointList;
            }
        }

       
        //寻找职务类型的位置
        private string GetPosition()
        {
            var p = cmbPosition.SelectedItem;
            if (p != null)
            {
                txtName.Enabled = true;
                nPoint.Enabled = true;
                btnSearch.Enabled = true;
                btnInsertOrUpdate.Enabled = true;
                return p.ToString();
            }
            else
            {
                txtName.Enabled = false;
                nPoint.Enabled = false;
                btnSearch.Enabled = false;
                btnInsertOrUpdate.Enabled = false;
                MessageBox.Show("职务类型未选择");
                return string.Empty;
            }
        }
        //插入或更新按钮代码
        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
            //初始化姓名，权重
            string name = txtName.Text;
            decimal point = nPoint.Value;
            string position = GetPosition();//初始化职务类型
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(position))
            {
                NamePointManage npm = new NamePointManage
                {
                    Position = position
                };
                if (npm.InitData())
                {
                    if (npm.InsertOrUpdate(name, point))
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
                MessageBox.Show("姓名或职位不能为空！");
            }
            BindGrid();

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(position))
            {
                TrainDataManage tdm = new TrainDataManage();
                NamePointManage npm = new NamePointManage
                {
                    Position = position
                };
                if (npm.InitDatatraininput())
                {
                    if (npm.InsertOrUpdatetraindata(name,point))
                    {
                        MessageBox.Show("更新输入数据成功！");
                    }
                    else
                    {
                        MessageBox.Show("更新输入数据失败！");
                    }
                }
            }
            else
            {
                MessageBox.Show("姓名或职位不能为空！");
            }



        }

       
        //搜索按钮代码
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;//初始化姓名
            string position = GetPosition();//初始化职务类型
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(position))
            {
                NamePointManage npm = new NamePointManage
                {
                    Position = position
                };
                if (npm.InitData())
                {
                    var np = npm.NamePointList.FirstOrDefault(q => q.Name == name);//在后台搜索输入的姓名
                    if (np != null)
                    {
                        nPoint.Value = np.Point;//将查找到的数据权重赋值
                    }
                    else
                    {
                        nPoint.Value = 0;
                        MessageBox.Show("未检索到：" + name);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("姓名或职位不能为空！");
            }
        }

        private void FrmPointManage_Load(object sender, EventArgs e)
        {

        }

    }
}