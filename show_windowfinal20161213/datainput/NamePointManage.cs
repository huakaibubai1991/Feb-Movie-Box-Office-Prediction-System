using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace datainput
{
    public class NamePointManage
    {
        public string Position { get; set; }
        public List<ViewNamePoint> NamePointList { get; set; }
       
        TrainDataManage tdm = new TrainDataManage();

        

        public bool InitList(string fileName)
        {
            NamePointList = new List<ViewNamePoint>();
            try
            {
                fileName = @"data\" + fileName;
                if (!File.Exists(fileName))
                {
                    MessageBox.Show("数据文档不存在,请检查" + fileName);
                    return false;
                }
                using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
                {
                    int id = 1;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();
                        string[] strs = line.Split(',');
                        ViewNamePoint vnp = new ViewNamePoint
                        {
                            Id = id,
                            Name = strs[0].Trim(),
                            Point = Convert.ToDecimal(strs[1].Trim())
                        };
                        NamePointList.Add(vnp);
                        id++;
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
                using (StreamWriter sw = new StreamWriter(fileName, false))
                {
                    foreach (var namePoint in NamePointList.OrderByDescending(q => q.Point))
                    {
                        sw.WriteLine(namePoint.Name + "," + namePoint.Point);
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

        public bool ReWritetraininput(string fileName)
        {
            try
            {
                fileName = @"data\" + fileName;
                if (!File.Exists(fileName))
                {
                    MessageBox.Show("数据文档不存在,请检查" + fileName);
                    return false;
                }


                using (StreamWriter sw = new StreamWriter(fileName, false))
                {
                    
                    foreach (var Point in tdm.TrainDataList.OrderByDescending(q => q.Id))
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



        public bool InitData()
        {
            bool r = false;
          
            switch (Position)
            {
                case "男一号":
                    r = InitList(@"actor1.txt");
                   
                    break;

                case "男二号":
                    r = InitList(@"actor2.txt");
                   
                    break;

                case "女一号":
                    r = InitList(@"actress1.txt");
                   
                    break;

                case "女二号":
                    r = InitList(@"actress2.txt");
                    
                    break;

                case "导演":
                    r = InitList(@"director.txt");
                    
                    break;

                case "编剧":
                    r = InitList(@"screenwriter.txt");
                  
                    break;

                case "制片人":
                    r = InitList(@"producer.txt");
                 
                    break;
            }
            if (!r)
            {
                MessageBox.Show("数据初始化失败");
            }
            return r;
        }

        //绑定数据

        public bool InitDatatraininput()
        {
            bool r = false;

            switch (Position)
            {
                case "男一号":
                   
                    r = tdm.InitList(@"trainDatainputha.txt");
                    break;

                case "男二号":
                    
                    r = tdm.InitList(@"trainDatainputha.txt");
                    break;

                case "女一号":
                   
                    r = tdm.InitList(@"trainDatainputha.txt");
                    break;

                case "女二号":
                   
                    r = tdm.InitList(@"trainDatainputha.txt");
                    break;

                case "导演":
                    
                    r = tdm.InitList(@"trainDatainputha.txt");
                    break;

                case "编剧":
                   
                    r = tdm.InitList(@"trainDatainputha.txt");
                    break;

                case "制片人":
                   
                    r = tdm.InitList(@"trainDatainputha.txt");
                    break;
            }
            if (!r)
            {
                MessageBox.Show("数据初始化失败");
            }
            return r;
        }






        public bool SaveChange()
        {
            bool r = false;
           
            switch (Position)
            {
                case "男一号":
                    r = ReWrite(@"actor1.txt");
                   
                    break;

                case "男二号":
                    r = ReWrite(@"actor2.txt");
                    break;

                case "女一号":
                    r = ReWrite(@"actress1.txt");
                    break;

                case "女二号":
                    r = ReWrite(@"actress2.txt");
                    break;

                case "导演":
                    r = ReWrite(@"director.txt");
                    break;

                case "编剧":
                    r = ReWrite(@"screenwriter.txt");
                    break;

                case "制片人":
                    r = ReWrite(@"producer.txt");
                    break;
            }
            return r;

        }

        public bool SaveChangetraindata()
        {
            bool r = false;

            switch (Position)
            {
                case "男一号":
                    r = ReWritetraininput(@"trainDatainputha.txt"); 
                    break;

                case "男二号":
                    r = ReWritetraininput(@"trainDatainputha.txt"); 
                    break;

                case "女一号":
                    r = ReWritetraininput(@"trainDatainputha.txt"); 
                    break;

                case "女二号":
                    r = ReWritetraininput(@"trainDatainputha.txt"); 
                    break;

                case "导演":
                    r = ReWritetraininput(@"trainDatainputha.txt"); 
                    break;

                case "编剧":
                    r = ReWritetraininput(@"trainDatainputha.txt"); 
                    break;

                case "制片人":
                    r = ReWritetraininput(@"trainDatainputha.txt");   
                    break;
            }
            return r;

        }




        public bool InsertOrUpdate(string name, decimal point)
        {
            
            try
            {
                //bool r = false;
                //var np = NamePointList.FirstOrDefault(q => q.Name == name);
               
                //if (np != null)
                //{
                //    if (np.Point != point)
                //    {
                //        np.Point = point;
                //        r = SaveChange();
                //    }
                //}
                //else
                //{
                //    np = new ViewNamePoint
                //    {
                //        Name = name,
                //        Point = point
                //    };
                //    NamePointList.Add(np);
                //    r = SaveChange();
                //}
                //return r;

                bool exist = false;
                var npList = NamePointList.Where(q => q.Name == name).ToList();
                if (npList.Count > 0)
                {
                    foreach (var npp in npList)
                    {
                        if (npp.Point != point)
                        {
                            npp.Point = point;
                        }

                       
                        if (npp.Name == name)
                        {
                           
                            npp.Point = point;

                            exist = true;

                        }
                    }
                }

                if (!exist)
                {

                    var np = new ViewNamePoint
                    {
                        Name = name,
                        Point = point
                    };
                    NamePointList.Add(np);
                    //r = SaveChange();
                
                }

                SaveChange();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        //变量的首字母用该小写
        public bool InsertOrUpdatetraindata(string name, decimal point)
        {
            double pointha = Convert.ToDouble(point);
            try
            {
                bool exist = false;
                
                switch (Position)
                {
                    case "男一号":
                       var tdListActor1 = tdm.TrainDataList.Where(q => q.Actor1Name == name).ToList(); 
                        if (tdListActor1.Count > 0)
                        {
                            foreach (var td in tdListActor1)
                            {
                                if (td.Actor1Point != pointha)
                                {
                                    td.Actor1Point = pointha;
                                }

                                //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                                if (td.Actor1Name == name && td.Actor2Name == name && td.Actress1Name == name && td.Actress2Name == name && td.ScreenwriterName == name && td.DirectorName == name && td.ProducerName == name)
                                {
                                    td.Actor1Point = pointha;
                                    td.Actor2Point = pointha;

                                    td.Actress1Point = pointha;
                                    td.Actress2Point = pointha;

                                    td.ScreenwriterPoint = pointha;
                                    td.DirectorPoint = pointha;
                                    td.ProducerPoint = pointha;

                                    exist = true;

                                }
                            }
                        }

                        SaveChangetraindata();
                        break;

                    case "男二号":
                        var tdListActor2 = tdm.TrainDataList.Where(q => q.Actor2Name == name).ToList();
                        if (tdListActor2.Count > 0)
                        {
                            foreach (var td in tdListActor2)
                            {
                                if (td.Actor2Point != pointha)
                                {
                                    td.Actor2Point = pointha;
                                }

                                //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                                if (td.Actor1Name == name && td.Actor2Name == name && td.Actress1Name == name && td.Actress2Name == name && td.ScreenwriterName == name && td.DirectorName == name && td.ProducerName == name)
                                {
                                    td.Actor1Point = pointha;
                                    td.Actor2Point = pointha;

                                    td.Actress1Point = pointha;
                                    td.Actress2Point = pointha;

                                    td.ScreenwriterPoint = pointha;
                                    td.DirectorPoint = pointha;
                                    td.ProducerPoint = pointha;

                                    exist = true;

                                }
                            }
                        }

                        SaveChangetraindata();
                        break;

                    case "女一号":
                        //女一号更新数据
                        var tdListActress1 = tdm.TrainDataList.Where(q => q.Actress1Name == name).ToList();
                        if (tdListActress1.Count > 0)
                        {
                            foreach (var td in tdListActress1)
                            {
                                if (td.Actress1Point != pointha)
                                {
                                    td.Actress1Point = pointha;
                                }

                                //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                                if (td.Actor1Name == name && td.Actor2Name == name && td.Actress1Name == name && td.Actress2Name == name && td.ScreenwriterName == name && td.DirectorName == name && td.ProducerName == name)
                                {
                                    td.Actor1Point = pointha;
                                    td.Actor2Point = pointha;

                                    td.Actress1Point = pointha;
                                    td.Actress2Point = pointha;

                                    td.ScreenwriterPoint = pointha;
                                    td.DirectorPoint = pointha;
                                    td.ProducerPoint = pointha;

                                    exist = true;

                                }
                            }
                        }

                        SaveChangetraindata();
                        break;

                    case "女二号":
                        //女二号更新数据
                        var tdListActress2 = tdm.TrainDataList.Where(q => q.Actress2Name == name).ToList();
                        if (tdListActress2.Count > 0)
                        {
                            foreach (var td in tdListActress2)
                            {
                                if (td.Actress2Point != pointha)
                                {
                                    td.Actress2Point = pointha;
                                }

                                //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                                if (td.Actor1Name == name && td.Actor2Name == name && td.Actress1Name == name && td.Actress2Name == name && td.ScreenwriterName == name && td.DirectorName == name && td.ProducerName == name)
                                {
                                    td.Actor1Point = pointha;
                                    td.Actor2Point = pointha;

                                    td.Actress1Point = pointha;
                                    td.Actress2Point = pointha;

                                    td.ScreenwriterPoint = pointha;
                                    td.DirectorPoint = pointha;
                                    td.ProducerPoint = pointha;

                                    exist = true;

                                }
                            }
                        }

                        SaveChangetraindata();
                        break;

                    case "导演":
                        //导演更新数据
                        var tdListDirector = tdm.TrainDataList.Where(q => q.DirectorName == name).ToList();
                        if (tdListDirector.Count > 0)
                        {
                            foreach (var td in tdListDirector)
                            {
                                if (td.DirectorPoint != pointha)
                                {
                                    td.DirectorPoint = pointha;
                                }

                                //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                                if (td.Actor1Name == name && td.Actor2Name == name && td.Actress1Name == name && td.Actress2Name == name && td.ScreenwriterName == name && td.DirectorName == name && td.ProducerName == name)
                                {
                                    td.Actor1Point = pointha;
                                    td.Actor2Point = pointha;

                                    td.Actress1Point = pointha;
                                    td.Actress2Point = pointha;

                                    td.ScreenwriterPoint = pointha;
                                    td.DirectorPoint = pointha;
                                    td.ProducerPoint = pointha;

                                    exist = true;

                                }
                            }
                        }

                        SaveChangetraindata();
                        break;

                    case "编剧":
                        //编剧更新数据
                        var tdListScreenWriter = tdm.TrainDataList.Where(q => q.ScreenwriterName == name).ToList();
                        if (tdListScreenWriter.Count > 0)
                        {
                            foreach (var td in tdListScreenWriter)
                            {
                                if (td.ScreenwriterPoint != pointha)
                                {
                                    td.ScreenwriterPoint = pointha;
                                }

                                //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                                if (td.Actor1Name == name && td.Actor2Name == name && td.Actress1Name == name && td.Actress2Name == name && td.ScreenwriterName == name && td.DirectorName == name && td.ProducerName == name)
                                {
                                    td.Actor1Point = pointha;
                                    td.Actor2Point = pointha;

                                    td.Actress1Point = pointha;
                                    td.Actress2Point = pointha;

                                    td.ScreenwriterPoint = pointha;
                                    td.DirectorPoint = pointha;
                                    td.ProducerPoint = pointha;

                                    exist = true;

                                }
                            }
                        }


                        SaveChangetraindata();
                        break;

                    case "制片人":
                        //制片人更新数据
                        var tdListProducer = tdm.TrainDataList.Where(q => q.ProducerName == name).ToList();
                        if (tdListProducer.Count > 0)
                        {
                            foreach (var td in tdListProducer)
                            {
                                if (td.ProducerPoint != pointha)
                                {
                                    td.ProducerPoint = pointha;
                                }

                                //TODO 补全所有判断条件，存在所有名称一一对应时更新数据，标记已存在，并更新，否则添加
                                if (td.Actor1Name == name && td.Actor2Name == name && td.Actress1Name == name && td.Actress2Name == name && td.ScreenwriterName == name && td.DirectorName == name && td.ProducerName == name)
                                {
                                    td.Actor1Point = pointha;
                                    td.Actor2Point = pointha;

                                    td.Actress1Point = pointha;
                                    td.Actress2Point = pointha;

                                    td.ScreenwriterPoint = pointha;
                                    td.DirectorPoint = pointha;
                                    td.ProducerPoint = pointha;

                                    exist = true;

                                }
                            }
                        }


                        SaveChangetraindata();
                        break;




                }

                return true;             
                
            }
            catch (Exception)
            {

                return false;
            }

        }




    }
}