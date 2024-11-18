using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace datainput
{
    //训练数据管理代码
    class TrainDataManage
    {

        public List<TrainDataPoint> TrainDataList { get; set; }

        public bool InitList(string fileName)//绑定后台的数据
        {
            TrainDataList = new List<TrainDataPoint>();

            //int id = 1;
            fileName = @"data\" + fileName;
            if (!File.Exists(fileName))//判断数据文档是否存在
            {
                MessageBox.Show("数据文档不存在,请检查" + fileName);
                //return false;
            }

            using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
            {
                int id = 1;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    string[] strs = line.Split(',');//将每行数据用逗号隔开
                    TrainDataPoint tdp = new TrainDataPoint
                    {
                        Id = id,
                        Actor1Name = strs[0].Trim(),
                        Actor1Point = Convert.ToDouble(strs[1].Trim()),
                        Actor2Name = strs[2].Trim(),
                        Actor2Point = Convert.ToDouble(strs[3].Trim()),
                        Actress1Name = strs[4].Trim(),
                        Actress1Point = Convert.ToDouble(strs[5].Trim()),
                        Actress2Name = strs[6].Trim(),
                        Actress2Point = Convert.ToDouble(strs[7].Trim()),
                        ScreenwriterName = strs[8].Trim(),
                        ScreenwriterPoint = Convert.ToDouble(strs[9].Trim()),
                        DirectorName = strs[10].Trim(),
                        DirectorPoint = Convert.ToDouble(strs[11].Trim()),
                        ProducerName = strs[12].Trim(),
                        ProducerPoint = Convert.ToDouble(strs[13].Trim())

                    };
                    TrainDataList.Add(tdp);
                    id++;//id自动加1
                }
                return true;



            }


        }

        //训练数据票房绑定列表

        public bool InitListtrainoutput(string fileName)
        {
            TrainDataList = new List<TrainDataPoint>();

            int id = 1;
            fileName = @"data\" + fileName;
            if (!File.Exists(fileName))
            {
                MessageBox.Show("数据文档不存在,请检查" + fileName);
                //return false;
            }


            using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
            {
                //int id = 1;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    string[] strs = line.Split('\t');

                    bool a = String.IsNullOrEmpty(strs[0]);
                    if (! a)
                    {
                        TrainDataPoint tdp = new TrainDataPoint
                        {
                            Id = id,
                            MoviePoint = Convert.ToDouble(strs[0].Trim())

                            //MoviePoint = Convert.ToDouble("2222")
                        };
                        TrainDataList.Add(tdp);
                        id++;
                    
                    }
                   
                }
                return true;



            }


        }






        public bool ReWrite(string fileName)
        {
            try
            {
                fileName = @"data\" + fileName;
                if (!File.Exists(fileName))
                {
                    MessageBox.Show("数据文档不存在,请检查" + fileName);
                    return false;
                }


                using (StreamWriter sw = new StreamWriter(fileName))
                {
                   
                    foreach (var Point in TrainDataList.OrderBy(q => q.Id)) 
                    {
                        sw.WriteLine(Point.Actor1Name + "," + Point.Actor1Point + "," + Point.Actor2Name + "," + Point.Actor2Point + "," + Point.Actress1Name + "," + Point.Actress1Point + "," + Point.Actress2Name + "," + Point.Actress2Point + "," + Point.ScreenwriterName + "," + Point.ScreenwriterPoint + "," + Point.DirectorName + "," + Point.DirectorPoint + "," + Point.ProducerName + "," + Point.ProducerPoint);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        //训练数据票房重新写数据

        public bool ReWritetrainoutput(string fileName)
        {
            try
            {
                fileName = @"data\" + fileName;
                if (!File.Exists(fileName))
                {
                    MessageBox.Show("数据文档不存在,请检查" + fileName);
                    return false;
                }
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    
                    foreach (var Point in TrainDataList.OrderBy(q => q.Id))
                    {
                        sw.WriteLine(Point.MoviePoint);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }



        public bool InitData()
        {
            bool r = false;

            r = InitList(@"trainDatainputha.txt");


            if (!r)
            {
                MessageBox.Show("数据初始化失败");
            }
            return r;
        }


        //训练数据票房绑定数据

        public bool InitDatatrainoutput()
        {
            bool r = false;

            r = InitListtrainoutput(@"trainDataoutputha.txt");


            if (!r)
            {
                MessageBox.Show("数据初始化失败");
            }
            return r;
        }




        public bool SaveChange()
        {
            bool r = false;

            r = ReWrite(@"trainDatainputha.txt");

            return r;

        }

        //训练数据票房保存数据


        public bool SaveChangetrainoutput()
        {
            bool r = false;

            r = ReWritetrainoutput(@"trainDataoutputha.txt");

            return r;

        }


        //变量的首字母用该小写
        public bool InsertOrUpdate(string actor1name, double actor1point, string actor2name, double actor2point, string actress1name, double actress1point, string actress2name, double actress2point, string screenwritername, double screenwriterpoint, string directorname, double directorpoint, string producername, double producerpoint)
        {

            try
            {
                bool exist = false;
                var tdListActor1 = TrainDataList.Where(q => q.Actor1Name == actor1name).ToList();
                if (tdListActor1.Count > 0)
                {
                    foreach (var td in tdListActor1)
                    {
                        if (td.Actor1Point != actor1point)
                        {
                            td.Actor1Point = actor1point;
                        }
                        
                        //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                        if (td.Actor1Name == actor1name && td.Actor2Name == actor2name && td.Actress1Name == actress1name && td.Actress2Name == actress2name && td.ScreenwriterName == screenwritername && td.DirectorName == directorname && td.ProducerName == producername)
                        {
                            td.Actor1Point = actor1point;
                            td.Actor2Point = actor2point;

                            td.Actress1Point = actress1point;
                            td.Actress2Point = actress2point;

                            td.ScreenwriterPoint = screenwriterpoint;
                            td.DirectorPoint = directorpoint;
                            td.ProducerPoint = producerpoint;
                            
                            exist = true;

                        }
                    }
                }


                var tdListActor2 = TrainDataList.Where(q => q.Actor2Name == actor2name).ToList();
                if (tdListActor2.Count > 0)
                {
                    foreach (var td in tdListActor2)
                    {
                        if (td.Actor2Point != actor2point)
                        {
                            td.Actor2Point = actor2point;
                        }

                        //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                        if (td.Actor1Name == actor1name && td.Actor2Name == actor2name && td.Actress1Name == actress1name && td.Actress2Name == actress2name && td.ScreenwriterName == screenwritername && td.DirectorName == directorname && td.ProducerName == producername)
                        {
                            td.Actor1Point = actor1point;
                            td.Actor2Point = actor2point;

                            td.Actress1Point = actress1point;
                            td.Actress2Point = actress2point;

                            td.ScreenwriterPoint = screenwriterpoint;
                            td.DirectorPoint = directorpoint;
                            td.ProducerPoint = producerpoint;

                            exist = true;

                        }
                    }
                }

                //女一号更新数据
                var tdListActress1 = TrainDataList.Where(q => q.Actress1Name == actress1name).ToList();
                if (tdListActress1.Count > 0)
                {
                    foreach (var td in tdListActress1)
                    {
                        if (td.Actress1Point != actress1point)
                        {
                            td.Actress1Point = actress1point;
                        }

                        //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                        if (td.Actor1Name == actor1name && td.Actor2Name == actor2name && td.Actress1Name == actress1name && td.Actress2Name == actress2name && td.ScreenwriterName == screenwritername && td.DirectorName == directorname && td.ProducerName == producername)
                        {
                            td.Actor1Point = actor1point;
                            td.Actor2Point = actor2point;

                            td.Actress1Point = actress1point;
                            td.Actress2Point = actress2point;

                            td.ScreenwriterPoint = screenwriterpoint;
                            td.DirectorPoint = directorpoint;
                            td.ProducerPoint = producerpoint;

                            exist = true;

                        }
                    }
                }

                //女二号更新数据
                var tdListActress2 = TrainDataList.Where(q => q.Actress2Name == actress2name).ToList();
                if (tdListActress2.Count > 0)
                {
                    foreach (var td in tdListActress2)
                    {
                        if (td.Actress2Point != actress2point)
                        {
                            td.Actress2Point = actress2point;
                        }

                        //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                        if (td.Actor1Name == actor1name && td.Actor2Name == actor2name && td.Actress1Name == actress1name && td.Actress2Name == actress2name && td.ScreenwriterName == screenwritername && td.DirectorName == directorname && td.ProducerName == producername)
                        {
                            td.Actor1Point = actor1point;
                            td.Actor2Point = actor2point;

                            td.Actress1Point = actress1point;
                            td.Actress2Point = actress2point;

                            td.ScreenwriterPoint = screenwriterpoint;
                            td.DirectorPoint = directorpoint;
                            td.ProducerPoint = producerpoint;

                            exist = true;

                        }
                    }
                }

                //编剧更新数据
                var tdListScreenWriter = TrainDataList.Where(q => q.ScreenwriterName == screenwritername).ToList();
                if (tdListScreenWriter.Count > 0)
                {
                    foreach (var td in tdListScreenWriter)
                    {
                        if (td.ScreenwriterPoint != screenwriterpoint)
                        {
                            td.ScreenwriterPoint = screenwriterpoint;
                        }

                        //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                        if (td.Actor1Name == actor1name && td.Actor2Name == actor2name && td.Actress1Name == actress1name && td.Actress2Name == actress2name && td.ScreenwriterName == screenwritername && td.DirectorName == directorname && td.ProducerName == producername)
                        {
                            td.Actor1Point = actor1point;
                            td.Actor2Point = actor2point;

                            td.Actress1Point = actress1point;
                            td.Actress2Point = actress2point;

                            td.ScreenwriterPoint = screenwriterpoint;
                            td.DirectorPoint = directorpoint;
                            td.ProducerPoint = producerpoint;

                            exist = true;

                        }
                    }
                }

                //导演更新数据
                var tdListDirector = TrainDataList.Where(q => q.DirectorName == directorname).ToList();
                if (tdListDirector.Count > 0)
                {
                    foreach (var td in tdListDirector)
                    {
                        if (td.DirectorPoint != directorpoint)
                        {
                            td.DirectorPoint = directorpoint;
                        }

                        //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                        if (td.Actor1Name == actor1name && td.Actor2Name == actor2name && td.Actress1Name == actress1name && td.Actress2Name == actress2name && td.ScreenwriterName == screenwritername && td.DirectorName == directorname && td.ProducerName == producername)
                        {
                            td.Actor1Point = actor1point;
                            td.Actor2Point = actor2point;

                            td.Actress1Point = actress1point;
                            td.Actress2Point = actress2point;

                            td.ScreenwriterPoint = screenwriterpoint;
                            td.DirectorPoint = directorpoint;
                            td.ProducerPoint = producerpoint;

                            exist = true;

                        }
                    }
                }

                //制片人更新数据
                var tdListProducer = TrainDataList.Where(q => q.ProducerName == producername).ToList();
                if (tdListProducer.Count > 0)
                {
                    foreach (var td in tdListProducer)
                    {
                        if (td.ProducerPoint != producerpoint)
                        {
                            td.ProducerPoint = producerpoint;
                        }

                        //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                        if (td.Actor1Name == actor1name && td.Actor2Name == actor2name && td.Actress1Name == actress1name && td.Actress2Name == actress2name && td.ScreenwriterName == screenwritername && td.DirectorName == directorname && td.ProducerName == producername)
                        {
                            td.Actor1Point = actor1point;
                            td.Actor2Point = actor2point;

                            td.Actress1Point = actress1point;
                            td.Actress2Point = actress2point;

                            td.ScreenwriterPoint = screenwriterpoint;
                            td.DirectorPoint = directorpoint;
                            td.ProducerPoint = producerpoint;

                            exist = true;

                        }
                    }
                }



                if (!exist)
                {
                    var td = new TrainDataPoint
                         {
                             Actor1Name = actor1name,
                             Actor1Point = actor1point,
                             Actor2Name = actor2name,
                             Actor2Point = actor2point,
                             Actress1Name = actress1name,
                             Actress1Point = actress1point,
                             Actress2Name = actress2name,
                             Actress2Point = actress2point,
                             ScreenwriterName = screenwritername,
                             ScreenwriterPoint = screenwriterpoint,
                             DirectorName = directorname,
                             DirectorPoint = directorpoint,
                             ProducerName = producername,
                             ProducerPoint = producerpoint

                         };
                    TrainDataList.Add(td);
                }
                SaveChange();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        //训练数据插入数据
        public bool InsertOrUpdatetrainoutput(double moviepoint)
        {

            try
            {
                //bool exist = false;
                bool r = false;
                var td = TrainDataList.FirstOrDefault(q => q.MoviePoint == moviepoint);
                //if (td != null)
                //{
                //    if (td.MoviePoint != moviepoint)
                //    {
                //        td.MoviePoint = moviepoint;
                //        r = SaveChangetrainoutput();
                       

                //    }
                 

                //}


                //else
                //{
                //    td = new TrainDataPoint
                //    {

                //        MoviePoint = moviepoint

                //    };
                //    TrainDataList.Add(td);
                //    r = SaveChangetrainoutput();
                //}
                //return r;

                if (td == null)
                {

                    td = new TrainDataPoint
                    {

                        MoviePoint = moviepoint

                    };
                    TrainDataList.Add(td);
                    r = SaveChangetrainoutput();
                }
                return r;

            }
            catch (Exception)
            {

                return false;
            }

        }






    }
}
