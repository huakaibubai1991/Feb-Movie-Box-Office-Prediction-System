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
    public delegate void ClickDelegateHander(string message); //声明一个委托

    public partial class FrmPointSet : Form
    {
        public event ClickDelegateHander ClickEvent; //声明一个事件

        public string Position { get; set; }
        public string PosName { get; set; }
        private List<ViewNamePoint> NpList { get; set; }

        public FrmPointSet()
        {
            InitializeComponent();
            NpList = new List<ViewNamePoint>();
        }

        private void FrmPointSet_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Position))
            {
                MessageBox.Show("职务类型未获取");
                this.Close();
            }
            this.Text = Position + "权重设定";
            NamePointManage npm = new NamePointManage { Position = Position };
            npm.InitData();
            dataGridView1.DataSource = npm.NamePointList;
            if (npm.NamePointList.Any())
            {
                nMax.Value = npm.NamePointList.Max(q => q.Point);
                nMin.Value = npm.NamePointList.Min(q => q.Point);
                nAvg.Value = npm.NamePointList.Average(q => q.Point);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string buttonText = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();
                if (buttonText == "选择")
                {
                    int id = (int)dataGridView1.Rows[e.RowIndex].Cells["Column_Id"].Value;
                    string name = dataGridView1.Rows[e.RowIndex].Cells["Column_Name"].Value.ToString();
                    decimal point = (decimal)dataGridView1.Rows[e.RowIndex].Cells["Column_Point"].Value;

                    var npTmp = NpList.FirstOrDefault(q => q.Name == name);
                    if (npTmp == null)
                    {
                        NpList.Add(new ViewNamePoint()
                        {
                            Id = id,
                            Name = name,
                            Point = point
                        });
                    }
                    dataGridView2.DataSource = new List<ViewNamePoint>();
                    dataGridView2.DataSource = NpList.OrderBy(q => q.Id).ToList();
                    nAvgSelect.Value = NpList.Any() ? NpList.Average(q => q.Point) : 0;
                }
            }
           

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string buttonText = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();
                if (buttonText == "取消")
                {
                    string name = dataGridView2.Rows[e.RowIndex].Cells["Column_Name2"].Value.ToString();
                    var npTmp = NpList.FirstOrDefault(q => q.Name == name);
                    if (npTmp != null)
                    {
                        NpList.Remove(npTmp);
                    }
                    dataGridView2.DataSource = new List<ViewNamePoint>();
                    dataGridView2.DataSource = NpList.OrderBy(q => q.Id).ToList();
                    nAvgSelect.Value = NpList.Any() ? NpList.Average(q => q.Point) : 0;
                }
            
            }
            
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            lbPoint.Text = nMax.Text;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            lbPoint.Text = nMin.Text;
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            lbPoint.Text = nAvg.Text;
        }

        private void btnAvgSelect_Click(object sender, EventArgs e)
        {
            lbPoint.Text = nAvgSelect.Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NamePointManage npm = new NamePointManage { Position = Position };
            if (npm.InitData())
            {
                if (npm.InsertOrUpdate(PosName, Convert.ToDecimal(lbPoint.Text)))
                {
                    //判断事件是否被注册
                    if (ClickEvent != null)
                    {
                        ClickEvent(Position + ":" + lbPoint.Text);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加或更新失败！");
                }
            }
        }
    }
}
