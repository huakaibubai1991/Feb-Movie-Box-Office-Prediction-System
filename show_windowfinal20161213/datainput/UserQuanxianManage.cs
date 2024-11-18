using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace datainput
{
    class UserQuanxianManage
    {
        public string Position { get; set; }
        public List<ViewUserQuanxian> UserQuanxianList { get; set; }
        private bool InitList(string fileName)
        {
            UserQuanxianList = new List<ViewUserQuanxian>();
            try
            {
                fileName = @"data\" + fileName;
                if (!File.Exists(fileName))
                {
                    MessageBox.Show("数据文档不存在,请检查" + fileName);
                    return false;
                }
                using (StreamReader sr = new StreamReader(fileName))
                {
                    int id = 1;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Trim();
                        string[] strs = line.Split(',');
                        ViewUserQuanxian vuq = new ViewUserQuanxian
                        {
                            Id = id,
                            User = strs[0].Trim(),
                            Password = strs[1].Trim(),
                            Quanxian = strs[2].ToString()
                        };
                        UserQuanxianList.Add(vuq);
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

        private bool ReWrite(string fileName)
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
                    foreach (var namePoint in UserQuanxianList.OrderBy(q => q.User))
                    {
                        sw.WriteLine(namePoint.User + "," + namePoint.Password + "," + namePoint.Quanxian);
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

            r = InitList(@"user.txt");


            if (!r)
            {
                MessageBox.Show("数据初始化失败");
            }
            return r;
        }


        public bool SaveChange()
        {
            bool r = false;

            r = ReWrite(@"user.txt");

            return r;

        }

        public bool InsertOrUpdate(string user, string password, string quanxian)
        {

            try
            {
                bool r = false;
                var uq = UserQuanxianList.FirstOrDefault(q => q.User == user);
                if (uq != null)
                {
                    //if (uq.Password != password || uq.Quanxian != quanxian)
                    //{
                    //    uq.Password = password;
                    //    uq.Quanxian = quanxian;
                    //    r = SaveChange();
                    //}
                    
                    
                }
                else
                {
                    uq = new ViewUserQuanxian
                    {
                        User = user,
                        Password = password,
                        Quanxian = quanxian
                    };
                    UserQuanxianList.Add(uq);
                    r = SaveChange();
                }
                return r;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(string user, string password, string quanxian)
        {

            try
            {
               bool r = false;
               var uq = UserQuanxianList.FirstOrDefault(q => q.User == user);

               uq = new ViewUserQuanxian
               {
                    User = user,
                    Password = password,
                    Quanxian = quanxian
                };
                UserQuanxianList.Remove(uq);
                r = SaveChange();
                
                return r;
            }
            catch (Exception)
            {

                return false;
            }


        }


    }
}
