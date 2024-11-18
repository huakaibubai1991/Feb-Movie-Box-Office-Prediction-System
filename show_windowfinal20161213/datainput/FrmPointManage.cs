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
    public partial class FrmPointManage : Form
    {
        public FrmPointManage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 )
            {
                string buttonText = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();
                string name = dataGridView1.Rows[e.RowIndex].Cells["Column_Name"].Value.ToString();
                string position = GetPosition();
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(position))
                {
                    NamePointManage npm = new NamePointManage
                    {
                        Position = position
                    };
                    npm.InitData();
                    var np = npm.NamePointList.FirstOrDefault(q => q.Name == name);

                    switch (buttonText)
                    {
                        case "修改":
                            if (np != null)
                            {
                                txtName.Text = np.Name;
                                nPoint.Value = np.Point;
                            }
                            break;

                        case "删除":
                            npm.NamePointList.Remove(np);
                            npm.SaveChange();
                            dataGridView1.DataSource = new List<ViewNamePoint>();
                            dataGridView1.DataSource = npm.NamePointList;
                            break;
                    }

                    
                }

                //dataGridView1.Rows[0].Frozen = true;


            
            }
           
        }





        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            BindGrid();
           
            
        }

        private void BindGrid()
        {
            string position = GetPosition();
            if (!string.IsNullOrEmpty(position))
            {
                NamePointManage npm = new NamePointManage
                {
                    Position = position
                };
                npm.InitData();
                dataGridView1.DataSource = new List<ViewNamePoint>();
                dataGridView1.DataSource = npm.NamePointList;
            }
        }

       

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

        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
           
            string name = txtName.Text;
            decimal point = nPoint.Value;
            string position = GetPosition();
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

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string position = GetPosition();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(position))
            {
                NamePointManage npm = new NamePointManage
                {
                    Position = position
                };
                if (npm.InitData())
                {
                    var np = npm.NamePointList.FirstOrDefault(q => q.Name == name);
                    if (np != null)
                    {
                        nPoint.Value = np.Point;
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