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
    //增加训练数据代码
    public partial class FrmAddTraindata : Form
    {
        public FrmAddTraindata()
        {
            InitializeComponent();
        }
        //更新或插入按钮代码
        //如果某个演员更新了权重，可以用该代码在后台对其权重进行更新
        //训练数据分成输入和输出数据，输入数据就是演职人员和其权重，输出数据就是电影票房
        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
           
            //初始化演员、编剧、导演、制片人
            string actor1name = txtActor1Name.Text;
            string actor2name = txtActor2Name.Text;
            string actress1name = txtActress1Name.Text;
            string actress2name = txtActress2Name.Text;
            string screenwritername = txtScreenwriterName.Text;
            string directorname = txtDirectorName.Text;
            string producername = txtProducerName.Text;


            //double actor1point = Convert.ToDouble(nActor1Point.Text);
            //double actor2point = Convert.ToDouble(nActor2Point.Text);
            //double actress1point = Convert.ToDouble(nActress1Point.Text);
            //double actress2point = Convert.ToDouble(nActress2Point.Text);
            //double screenwriterpoint = Convert.ToDouble(nScreenwriterPoint.Text);
            //double directorpoint = Convert.ToDouble(nDirectorPoint.Text);
            //double producerpoint = Convert.ToDouble(nProducerPoint.Text);

            //double moviepoint = Convert.ToDouble(nmoviePoint.Text);

            //if (actor1name.Length == 0 && nActor1Point.Text.Length == 0 && actor2name.Length == 0 && nActor2Point.Text.Length == 0 && actress1name.Length == 0 && nActress1Point.Text.Length == 0 && actress2name.Length == 0 && nActress2Point.Text.Length == 0 && screenwritername.Length == 0 && nScreenwriterPoint.Text.Length == 0 && directorname.Length == 0 && nDirectorPoint.Text.Length == 0 && producername.Length == 0 && nProducerPoint.Text.Length == 0)
            //{

            //    btnInsertOrUpdate.Enabled = false;
            //    btnSearch.Enabled = false;

            //}
            //else
            //{
            //    btnInsertOrUpdate.Enabled = true ;
            //    btnSearch.Enabled = true;
            //}

           
            //if (actor1name!= null && actor1point!= 0 && actor2name != null && actor2point!= 0 && actress1name != null && actress1point!= 0 && actress2name != null && actress2point!= 0 && screenwritername != null && screenwriterpoint!= 0 && directorname != null && directorpoint!= 0 && producername != null && producerpoint!= 0 )
            //判断各个框是否都输入了数据
            if (actor1name.Length != 0 && nActor1Point.Text.Length != 0 && actor2name.Length != 0 && nActor2Point.Text.Length != 0 && actress1name.Length != 0 && nActress1Point.Text.Length != 0 && actress2name.Length != 0 && nActress2Point.Text.Length != 0 && screenwritername.Length != 0 && nScreenwriterPoint.Text.Length != 0 && directorname.Length != 0 && nDirectorPoint.Text.Length != 0 && producername.Length != 0 && nProducerPoint.Text.Length != 0)
            {
                        
                TrainDataManage tdm = new TrainDataManage();
                if (tdm.InitData())//判断是否绑定了数据
                {
                    double actor1point = Convert.ToDouble(nActor1Point.Text);
                    double actor2point = Convert.ToDouble(nActor2Point.Text);
                    double actress1point = Convert.ToDouble(nActress1Point.Text);
                    double actress2point = Convert.ToDouble(nActress2Point.Text);
                    double screenwriterpoint = Convert.ToDouble(nScreenwriterPoint.Text);
                    double directorpoint = Convert.ToDouble(nDirectorPoint.Text);
                    double producerpoint = Convert.ToDouble(nProducerPoint.Text);

                    
                    if (tdm.InsertOrUpdate(actor1name,actor1point,actor2name, actor2point,actress1name,actress1point,actress2name,actress2point,screenwritername,screenwriterpoint,directorname,directorpoint,producername,producerpoint))
                    {
                        MessageBox.Show("添加或更新输入数据成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加或更新输入数据失败！");
                    }
                }

               
            }
            else
            {
               
                MessageBox.Show("姓名或职位不能为空！");
            }

            //if (moviepoint != 0)
            if (nmoviePoint.Text.Length != 0)//判断票房文本框是否为零
            {
                TrainDataManage tdm = new TrainDataManage();
                if (tdm.InitDatatrainoutput())
                {
                    double moviepoint = Convert.ToDouble(nmoviePoint.Text);
                    
                    if (tdm.InsertOrUpdatetrainoutput(moviepoint))//插入并更新票房数据（输出数据）
                    {
                        MessageBox.Show("添加或更新输出数据成功！");
                    }
                    else
                    {
                        MessageBox.Show("添加或更新输出数据失败！");
                    }
                   
                }

               
            
            }

            else
            {
               
                MessageBox.Show("票房不能为空！");
            }

        }


        //查询按钮代码
        private void btnSearch_Click(object sender, EventArgs e)
        {

            //double actor1point = Convert.ToDouble(nActor1Point.Text);
            //double actor2point = Convert.ToDouble(nActor2Point.Text);
            //double actress1point = Convert.ToDouble(nActress1Point.Text);
            //double actress2point = Convert.ToDouble(nActress2Point.Text);
            //double screenwriterpoint = Convert.ToDouble(nScreenwriterPoint.Text);
            //double directorpoint = Convert.ToDouble(nDirectorPoint.Text);
            //double producerpoint = Convert.ToDouble(nProducerPoint.Text);
            //初始化要查询的演员编剧导演的名称
            string actor1name = txtActor1Name.Text;
            string actor2name = txtActor2Name.Text;
            string actress1name = txtActress1Name.Text;
            string actress2name = txtActress2Name.Text;
            string screenwritername = txtScreenwriterName.Text;
            string directorname = txtDirectorName.Text;
            string producername = txtProducerName.Text;
            //判断各个名称是否为空
            if (!string.IsNullOrEmpty(actor1name) && !string.IsNullOrEmpty(actor2name) && !string.IsNullOrEmpty(actress1name) && !string.IsNullOrEmpty(actress2name) && !string.IsNullOrEmpty(screenwritername) && !string.IsNullOrEmpty(directorname) && !string.IsNullOrEmpty(producername))
            {
                TrainDataManage tdm = new TrainDataManage();

                if (tdm.InitData())
                {
                    //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
                    var td = tdm.TrainDataList.FirstOrDefault(q => q.Actor1Name == actor1name);//寻找输入的男一号的权重
                    if (td != null)
                    {

                        nActor1Point.Text = Convert.ToString(td.Actor1Point);//将查找到的男一号权重数据显示出来

                    }
                    else
                    {
                        //actor1point = 0.0;
                        MessageBox.Show("未检索到：" + actor1name);
                    }
                }

                if (tdm.InitData())
                {
                    //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
                    var td = tdm.TrainDataList.FirstOrDefault(q => q.Actor2Name == actor2name);
                    if (td != null)
                    {

                        nActor2Point.Text = Convert.ToString(td.Actor2Point);

                    }
                    else
                    {
                        //actor2point = 0.0;
                        MessageBox.Show("未检索到：" + actor2name);
                    }
                }

                if (tdm.InitData())
                {
                    //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
                    var td = tdm.TrainDataList.FirstOrDefault(q => q.Actress1Name == actress1name);
                    if (td != null)
                    {

                        nActress1Point.Text = Convert.ToString(td.Actress1Point);

                    }
                    else
                    {
                        //actress1point = 0.0;
                        MessageBox.Show("未检索到：" + actress1name);
                    }
                }

                if (tdm.InitData())
                {
                    //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
                    var td = tdm.TrainDataList.FirstOrDefault(q => q.Actress2Name == actress2name);
                    if (td != null)
                    {

                        nActress2Point.Text = Convert.ToString(td.Actress2Point);

                    }
                    else
                    {
                        //actress2point = 0.0;
                        MessageBox.Show("未检索到：" + actress2name);
                    }
                }

                if (tdm.InitData())
                {
                    //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
                    var td = tdm.TrainDataList.FirstOrDefault(q => q.ScreenwriterName == screenwritername);
                    if (td != null)
                    {

                        nScreenwriterPoint.Text = Convert.ToString(td.ScreenwriterPoint);

                    }
                    else
                    {
                        //screenwriterpoint = 0.0;
                        MessageBox.Show("未检索到：" + screenwritername);
                    }
                }

                if (tdm.InitData())
                {
                    //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
                    var td = tdm.TrainDataList.FirstOrDefault(q => q.DirectorName == directorname);
                    if (td != null)
                    {

                        nDirectorPoint.Text = Convert.ToString(td.DirectorPoint);

                    }
                    else
                    {
                        //directorpoint = 0.0;
                        MessageBox.Show("未检索到：" + directorname);
                    }
                }

                if (tdm.InitData())
                {
                    //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
                    var td = tdm.TrainDataList.FirstOrDefault(q => q.ProducerName == producername);
                    if (td != null)
                    {

                        nProducerPoint.Text = Convert.ToString(td.ProducerPoint);

                    }
                    else
                    {
                        //producerpoint = 0.0;
                        MessageBox.Show("未检索到：" + producername);
                    }
                }


            }
            else
            {

                MessageBox.Show("姓名或职位不能为空！");
            
            }

            
            //if (!string.IsNullOrEmpty(actor1name))
            //{
            //    TrainDataManage tdm = new TrainDataManage();

            //    if (tdm.InitData())
            //    {
            //        //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
            //        var td = tdm.TrainDataList.FirstOrDefault(q => q.Actor1Name == actor1name);
            //        if (td != null)
            //        {
                       
            //            nActor1Point.Text = Convert.ToString( td.Actor1Point );

            //        }
            //        else
            //        {
            //            //actor1point = 0.0;
            //            MessageBox.Show("未检索到：" + actor1name);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("男一号数据不能为空！");
            //}

            //if (!string.IsNullOrEmpty(actor2name))
            //{
            //    TrainDataManage tdm = new TrainDataManage();

            //    if (tdm.InitData())
            //    {
            //        //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
            //        var td = tdm.TrainDataList.FirstOrDefault(q => q.Actor2Name == actor2name);
            //        if (td != null)
            //        {

            //            nActor2Point.Text = Convert.ToString(td.Actor2Point);

            //        }
            //        else
            //        {
            //            //actor2point = 0.0;
            //            MessageBox.Show("未检索到：" + actor2name);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("男二号数据不能为空！");
            //}

            //if (!string.IsNullOrEmpty(actress1name))
            //{
            //    TrainDataManage tdm = new TrainDataManage();

            //    if (tdm.InitData())
            //    {
            //        //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
            //        var td = tdm.TrainDataList.FirstOrDefault(q => q.Actress1Name == actress1name);
            //        if (td != null)
            //        {

            //            nActress1Point.Text = Convert.ToString(td.Actress1Point);

            //        }
            //        else
            //        {
            //            //actress1point = 0.0;
            //            MessageBox.Show("未检索到：" + actress1name);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("女一号数据不能为空！");
            //}


            //if (!string.IsNullOrEmpty(actress2name))
            //{
            //    TrainDataManage tdm = new TrainDataManage();

            //    if (tdm.InitData())
            //    {
            //        //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
            //        var td = tdm.TrainDataList.FirstOrDefault(q => q.Actress2Name == actress2name);
            //        if (td != null)
            //        {

            //            nActress2Point.Text = Convert.ToString(td.Actress2Point);

            //        }
            //        else
            //        {
            //            //actress2point = 0.0;
            //            MessageBox.Show("未检索到：" + actress2name);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("女二号数据不能为空！");
            //}


            //if (!string.IsNullOrEmpty(screenwritername))
            //{
            //    TrainDataManage tdm = new TrainDataManage();

            //    if (tdm.InitData())
            //    {
            //        //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
            //        var td = tdm.TrainDataList.FirstOrDefault(q => q.ScreenwriterName == screenwritername);
            //        if (td != null)
            //        {

            //            nScreenwriterPoint.Text = Convert.ToString(td.ScreenwriterPoint);

            //        }
            //        else
            //        {
            //            //screenwriterpoint = 0.0;
            //            MessageBox.Show("未检索到：" + screenwritername);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("编剧数据不能为空！");
            //}


            //if (!string.IsNullOrEmpty(directorname))
            //{
            //    TrainDataManage tdm = new TrainDataManage();

            //    if (tdm.InitData())
            //    {
            //        //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
            //        var td = tdm.TrainDataList.FirstOrDefault(q => q.DirectorName == directorname);
            //        if (td != null)
            //        {

            //            nDirectorPoint.Text = Convert.ToString(td.DirectorPoint);

            //        }
            //        else
            //        {
            //            //directorpoint = 0.0;
            //            MessageBox.Show("未检索到：" + directorname);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("导演数据不能为空！");
            //}

            //if (!string.IsNullOrEmpty(producername))
            //{
            //    TrainDataManage tdm = new TrainDataManage();

            //    if (tdm.InitData())
            //    {
            //        //var td = tdm.NamePointList.FirstOrDefault(q => q.Name == name);
            //        var td = tdm.TrainDataList.FirstOrDefault(q => q.ProducerName == producername);
            //        if (td != null)
            //        {

            //            nProducerPoint.Text = Convert.ToString(td.ProducerPoint);

            //        }
            //        else
            //        {
            //            //producerpoint = 0.0;
            //            MessageBox.Show("未检索到：" + producername);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("制片人数据不能为空！");
            //}




        }





    }
}
