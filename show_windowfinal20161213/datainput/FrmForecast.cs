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
    public partial class FrmForecast : Form
    {
        public FrmForecast()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string position = "男一号";
            string name = txtActor1Name000.Text;
            //string name = txtActor1Name.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(position + "：姓名不能为空");
                return;
            }
            NamePointManage npm = new NamePointManage { Position = position };
            npm.InitData();
            var np = npm.NamePointList.FirstOrDefault(q => q.Name == name);
            if (np != null)
            {
                nActor1Point.Value = np.Point;
            }
            else
            {
                FrmPointSet ps = new FrmPointSet
                {
                    Position = position,
                    PosName = txtActor1Name000.Text
                };
                ps.ClickEvent += new ClickDelegateHander(ps_Event);
                ps.Show();
                return;
            }

            position = "男二号";
            name = txtActor2Name.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(position + "：姓名不能为空");
                return;
            }
            npm = new NamePointManage { Position = position };
            npm.InitData();
            np = npm.NamePointList.FirstOrDefault(q => q.Name == name);
            if (np != null)
            {
                nActor2Point.Value = np.Point;
            }
            else
            {
                FrmPointSet ps = new FrmPointSet
                {
                    Position = position,
                    PosName = txtActor2Name.Text
                };
                ps.ClickEvent += new ClickDelegateHander(ps_Event);
                ps.Show();
                return;
            }

            position = "女一号";
            name = txtActress1Name.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(position + "：姓名不能为空");
                return;
            }
            npm = new NamePointManage { Position = position };
            npm.InitData();
            np = npm.NamePointList.FirstOrDefault(q => q.Name == name);
            if (np != null)
            {
                nActress1Point.Value = np.Point;
            }
            else
            {
                FrmPointSet ps = new FrmPointSet
                {
                    Position = position,
                    PosName = txtActress1Name.Text
                };
                ps.ClickEvent += new ClickDelegateHander(ps_Event);
                ps.Show();
                return;
            }

            position = "女二号";
            name = txtActress2Name.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(position + "：姓名不能为空");
                return;
            }
            npm = new NamePointManage { Position = position };
            npm.InitData();
            np = npm.NamePointList.FirstOrDefault(q => q.Name == name);
            if (np != null)
            {
                nActress2Point.Value = np.Point;
            }
            else
            {
                FrmPointSet ps = new FrmPointSet
                {
                    Position = position,
                    PosName = txtActress2Name.Text
                };
                ps.ClickEvent += new ClickDelegateHander(ps_Event);
                ps.Show();
                return;
            }

            position = "导演";
            name = txtDirectorName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(position + "：姓名不能为空");
                return;
            }
            npm = new NamePointManage { Position = position };
            npm.InitData();
            np = npm.NamePointList.FirstOrDefault(q => q.Name == name);
            if (np != null)
            {
                nDirectorPoint.Value = np.Point;
            }
            else
            {
                FrmPointSet ps = new FrmPointSet
                {
                    Position = position,
                    PosName = txtDirectorName.Text
                };
                ps.ClickEvent += new ClickDelegateHander(ps_Event);
                ps.Show();
                return;
            }
            position = "编剧";
            name = txtScreenwriterName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(position + "：姓名不能为空");
                return;
            }
            npm = new NamePointManage { Position = position };
            npm.InitData();
            np = npm.NamePointList.FirstOrDefault(q => q.Name == name);
            if (np != null)
            {
                nScreenwriterPoint.Value = np.Point;
            }
            else
            {
                FrmPointSet ps = new FrmPointSet
                {
                    Position = position,
                    PosName = txtScreenwriterName.Text
                };
                ps.ClickEvent += new ClickDelegateHander(ps_Event);
                ps.Show();
                return;
            }
            position = "制片人";
            name = txtProducerName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(position + "：姓名不能为空");
                return;
            }
            npm = new NamePointManage { Position = position };
            npm.InitData();
            np = npm.NamePointList.FirstOrDefault(q => q.Name == name);
            if (np != null)
            {
                nProducerPoint.Value = np.Point;
            }
            else
            {
                FrmPointSet ps = new FrmPointSet
                {
                    Position = position,
                    PosName = txtProducerName.Text
                };
                ps.ClickEvent += new ClickDelegateHander(ps_Event);
                ps.Show();
                return;
            }
            Train tr = new Train();
            double[] grossed = tr.GetsTrainData((double)nActor1Point.Value, (double)nActor2Point.Value, (double)nActress1Point.Value,
                    (double)nActress2Point.Value, (double)nDirectorPoint.Value, (double)nScreenwriterPoint.Value,
                    (double)nProducerPoint.Value);
            MessageBox.Show("预测票房：" + Math.Round(grossed[0]) +"万" +"-"+ Math.Round(grossed[1]) + "万");
        }
        void ps_Event(string text)
        {
            string[] strs = text.Split(':');
            switch (strs[0])
            {
                case "男一号":
                    nActor1Point.Text = strs[1];
                    break;

                case "男二号":
                    nActor2Point.Text = strs[1]; 
                    break;

                case "女一号":
                    nActress1Point.Text = strs[1];
                    break;

                case "女二号":
                    nActress2Point.Text = strs[1];
                    break;

                case "导演":
                    nDirectorPoint.Text = strs[1];
                    break;

                case "编剧":
                    nScreenwriterPoint.Text = strs[1];
                    break;

                case "制片人":
                    nProducerPoint.Text = strs[1];
                    break;
            }
            Search();
        }

        private void txtActor1Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmForecast_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void FrmForecast_Load(object sender, EventArgs e)
        {

           
        }

        private void nActor1Point_KeyDown(object sender, KeyEventArgs e)
        {

            
        }
       

    }
}