using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace datainput
{
   
    class BP
    {
        public int inNum;//输入节点数  
        int hideNum;//隐层节点数  
        public int outNum;//输出层节点数  
        public int sampleNum;//样本总数  

        Random R;
        double[] x;//输入节点的输入数据  
        double[] x1;//隐层节点的输出  
        double[] x2;//输出节点的输出  

        double[] o1;//隐层的输入  
        double[] o2;//输出层的输入  
        public double[,] w;//权值矩阵w  
        public double[,] v;//权值矩阵V  
        public double[,] dw;//权值矩阵w  
        public double[,] dv;//权值矩阵V  


        public double rate;//学习率  
        public double[] b1;//隐层阈值矩阵  
        public double[] b2;//输出层阈值矩阵  
        public double[] db1;//隐层阈值矩阵  
        public double[] db2;//输出层阈值矩阵  

        double[] pp;//输出层的误差  
        double[] qq;//隐层的误差  
        double[] yd;//输出层的教师数据  
        public double e;//均方误差  
        //double in_rate;//归一化比例系数  
        
        
       
        public BP(double[][] p, double[][] t)
        {

            string path = @"data\trainDatainputha.txt";
            string[] strings = File.ReadAllLines(path);
            int sampleNum = strings.Length;
            // 构造函数逻辑  
            R = new Random(); //加了一个参数，使产生的伪随机序列相同  

            //数组第二维大小为 输入节点数  
            this.inNum = 7;
            //输出节点数  
            this.outNum = 1;
            //隐藏节点数 
            this.hideNum = 5;
            
            //this.sampleNum = 388;

            x = new double[inNum];
            x1 = new double[hideNum];
            x2 = new double[sampleNum];

            o1 = new double[hideNum];
            o2 = new double[outNum];

            w = new double[inNum, hideNum];
            v = new double[hideNum, outNum];
            dw = new double[hideNum, inNum];
            dv = new double[hideNum, outNum];

            b1 = new double[hideNum];
            b2 = new double[outNum];
            db1 = new double[hideNum];
            db2 = new double[outNum];

            pp = new double[hideNum];
            qq = new double[outNum];
            yd = new double[outNum];

            //初始化w  
            for (int i = 0; i < inNum; i++)
            {
                for (int j = 0; j < hideNum; j++)
                {
                    w[i, j] = (R.NextDouble() * 2 - 1.0) / 2;
                }
            }

            //初始化v  
            for (int i = 0; i < hideNum; i++)
            {
                for (int j = 0; j < outNum; j++)
                {
                    v[i, j] = (R.NextDouble() * 2 - 1.0) / 2;
                }
            }

            //初始化b1
            for (int i = 0; i < hideNum; i++)
            {

                b1[i] = (R.NextDouble() * 2 - 1.0) / 2;

            }

            //初始化b2
            for (int j = 0; j < outNum; j++)
            {

                b2[j] = (R.NextDouble() * 2 - 1.0) / 2;

            }

            rate = 0.1;
            e = 0.0;
            //in_rate = 1.0;
        }

       

        //训练函数  
        public void train(double[,] p, double[,] t)
        {

            string path = @"data\trainDatainputha.txt";
            string[] strings = File.ReadAllLines(path);
            int sampleNum = strings.Length;
            
            e = 0.0;
            //求p，t中的最大值  
            double pMax = p[0, 0], tMax = t[0, 0], pMin = p[0, 0], tMin = t[0, 0];
            for (int isamp = 0; isamp < sampleNum; isamp++)
            {
                for (int i = 0; i < inNum; i++)
                {
                    if (Math.Abs(p[isamp, i]) > pMax)

                        pMax = Math.Abs(p[isamp, i]);

                    if (Math.Abs(p[isamp, i]) < pMin)

                        pMin = Math.Abs(p[isamp, i]);
                }

                for (int j = 0; j < outNum; j++)
                {
                    if (Math.Abs(t[isamp, j]) > tMax)

                        tMax = Math.Abs(t[isamp, j]);
                    if (Math.Abs(t[isamp, j]) < tMin)
                        tMin = Math.Abs(t[isamp, j]);
                }

                //in_rate = pMax;
            }//end isamp  

            //for (int i = 0; i < inNum; i++)
            //{
            //    for (int isamp = 0; isamp < sampleNum; isamp++)
            //    {
            //        x[isamp] = preminmax(p[i,isamp] , pMin ,pMax);
            //    }
            //}

            //for (int k = 0; k < outNum; k++)
            //{
            //    for (int isamp = 0; isamp < sampleNum; isamp++)
            //    {
            //        yd[isamp] = t[k, isamp];
            //    }

            //}

            for (int isamp = 0; isamp < sampleNum; isamp++)
            {
                //数据归一化  
                for (int i = 0; i < inNum; i++)
                {
                    //x[i] = p[isamp, i] / in_rate;
                    x[i] = p[isamp, i];
                }
                for (int i = 0; i < outNum; i++)
                {
                    //yd[i] = t[isamp, i] / in_rate;
                    yd[i] = t[isamp, i];
                }

                //计算隐层的输入和输出  

                for (int j = 0; j < hideNum; j++)
                {
                    o1[j] = 0.0;
                    for (int i = 0; i < inNum; i++)
                    {
                        o1[j] += w[i, j] * x[i];
                    }
                    x1[j] = 1.0 / (1.0 + Math.Exp(-o1[j] - b1[j]));
                }

                //计算输出层的输入和输出  
                for (int k = 0; k < outNum; k++)
                {
                    o2[k] = 0.0;
                    for (int j = 0; j < hideNum; j++)
                    {
                        o2[k] += v[j, k] * x1[j];
                    }
                    //x2[k] = 1.0 / (1.0 + Math.Exp(-o2[k] - b2[k]));
                    x2[k] = o2[k] + b2[k];
                }

                //计算输出层误差和均方差  

                for (int k = 0; k < outNum; k++)
                {
                    qq[k] = (yd[k] - x2[k]) * x2[k] * (1.0 - x2[k]);
                    //qq[k] = (yd[k] - x2[k]);
                    e += (yd[k] - x2[k]) * (yd[k] - x2[k]);
                    //更新V  
                    for (int j = 0; j < hideNum; j++)
                    {
                        v[j, k] += rate * qq[k] * x1[j];
                    }
                }

                //计算隐层误差  

                for (int j = 0; j < hideNum; j++)
                {
                    pp[j] = 0.0;
                    for (int k = 0; k < outNum; k++)
                    {
                        pp[j] += qq[k] * v[j, k];
                    }
                    pp[j] = pp[j] * x1[j] * (1 - x1[j]);

                    //更新W  

                    for (int i = 0; i < inNum; i++)
                    {
                        w[i, j] += rate * pp[j] * x[i];
                    }
                }

                //更新b2  
                for (int k = 0; k < outNum; k++)
                {
                    b2[k] += rate * qq[k];
                }

                //更新b1  
                for (int j = 0; j < hideNum; j++)
                {
                    b1[j] += rate * pp[j];
                }

            }//end isamp  
            e = Math.Sqrt(e);
            //      adjustWV(w,dw);  
            //      adjustWV(v,dv); 


        }//end train  

        public void adjustWV(double[,] w, double[,] dw)
        {
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {
                    w[i, j] += dw[i, j];
                }
            }

        }

        public void adjustWV(double[] w, double[] dw)
        {
            for (int i = 0; i < w.Length; i++)
            {

                w[i] += dw[i];

            }

        }

       

       

        //数据仿真函数  
        public double[] sim(double[] psim) //in_rate inNum HideNum outNum   
        {

            for (int i = 0; i < inNum; i++)
            {

                x[i] = psim[i];
            }


            for (int j = 0; j < hideNum; j++)
            {
                o1[j] = 0.0;
                for (int i = 0; i < inNum; i++)
                    o1[j] = o1[j] + w[i, j] * x[i];
                x1[j] = 1.0 / (1.0 + Math.Exp(-o1[j] - b1[j]));
            }
            for (int k = 0; k < outNum; k++)
            {
                o2[k] = 0.0;
                for (int j = 0; j < hideNum; j++)
                    o2[k] = o2[k] + v[j, k] * x1[j];
                //x2[k] = 1.0 / (1.0 + Math.Exp(-o2[k] - b2[k]));
                x2[k] = o2[k] + b2[k];


            }

            return x2;



        } //end sim  

        //数据仿真函数  
        public double[] sim0(double[,] psim) //in_rate inNum HideNum outNum   
        {

            string path = @"data\trainDatainputha.txt";
            string[] strings = File.ReadAllLines(path);
            int sampleNum = strings.Length;
            
            double[] x3 = new double[sampleNum];
            double[] x4 = new double[sampleNum];

            for (int i = 0; i < sampleNum; i++)
            {
                for (int j = 0; j < inNum; j++)
                {
                    x[j] = psim[i, j];
                }

                for (int j = 0; j < hideNum; j++)
                {
                    o1[j] = 0.0;
                    for (int m = 0; m < inNum; m++)
                    {
                        o1[j] = o1[j] + w[m, j] * x[m];
                    }
                    x1[j] = 1.0 / (1.0 + Math.Exp(-o1[j] - b1[j]));
                }
                for (int k = 0; k < outNum; k++)
                {
                    o2[k] = 0.0;
                    for (int j = 0; j < hideNum; j++)
                    {
                        o2[k] = o2[k] + v[j, k] * x1[j];
                    }
                    //x2[k] = 1.0 / (1.0 + Math.Exp(-o2[k] - b2[k]));

                    x2[i] = o2[k] + b2[k];


                }



            }


            return x2;

        } //end sim  






        //保存矩阵w,v  
        public void saveMatrix(double[,] w, string filename)
        {
            StreamWriter sw = File.CreateText(filename);
            //StreamWriter sw = File.AppendText(filename);
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {
                    sw.Write(w[i, j] + " ");
                }
                sw.WriteLine();
            }
            sw.Close();

        }

        //保存矩阵b1,b2  
        public void saveMatrix(double[] b, string filename)
        {
            StreamWriter sw = File.CreateText(filename);
            //StreamWriter sw = File.AppendText(filename);
            for (int i = 0; i < b.Length; i++)
            {
                sw.Write(b[i] + " ");
            }
            sw.Close();
        }

        //保存误差e
        public void saveMatrix(double e, string filename)
        {
            StreamWriter sw = File.CreateText(filename);
            //StreamWriter sw = File.AppendText(filename);
            sw.Write(e);
            sw.Close();

        }


        //读取矩阵W,V  
        public void readMatrixW(double[,] w, string filename)
        {

            StreamReader sr;
            try
            {

                sr = new StreamReader(filename, Encoding.GetEncoding("gb2312"));

                String line;
                int i = 0;

                while ((line = sr.ReadLine()) != null)
                {

                    string[] s1 = line.Trim().Split(' ');
                    for (int j = 0; j < s1.Length; j++)
                    {
                        w[i, j] = Convert.ToDouble(s1[j]);
                    }
                    i++;
                }
                sr.Close();

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.  
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }




        //读取矩阵b1,b2  
        public void readMatrixB(double[] b, string filename)
        {

            StreamReader sr;
            try
            {
                sr = new StreamReader(filename, Encoding.GetEncoding("gb2312"));

                String line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    b[i] = Convert.ToDouble(line);
                    i++;
                }
                sr.Close();

            }
            catch (Exception e)
            {
                // Let the user know what went wrong.  
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }  
  



    }
}
