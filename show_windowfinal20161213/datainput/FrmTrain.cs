using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace datainput
{
    public partial class FrmTrain : Form
    {
        public FrmTrain()
        {
            InitializeComponent();
        }


        private void btnTrain_Click(object sender, EventArgs e)
        {
            this.btnTrain.Enabled = false;

            Thread threadTrain = new Thread(Train);

            threadTrain.Start();

            Thread theardProbar = new Thread(ProBar);

            theardProbar.Start();

            this.btnTrain.Enabled = true;

        }


        public void ProBar()
        {

            progressBar1.Minimum = 0;

            progressBar1.Maximum = 99900000;

            for (int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value++;

            }


        }

        public void Train()
        {

            //开始神经网络
            string path = @"data\trainDatainputha.txt";
            string[] strings = File.ReadAllLines(path);
            int trainNum = strings.Length;

            //int trainNum = 388;
            int Num = 14;
            int inNum = 7;
            int outNum = 1;
            int hiddenNum = 5;
            string[,] trainInputduo = new string[trainNum, Num];
            double[,] trainInput = new double[trainNum, inNum];
            double[,] trainOutput = new double[trainNum, outNum];
            double[,] trainInputpreminmax = new double[trainNum, inNum];
            double[,] trainOutputpreminmax = new double[trainNum, outNum];
            //double[,] testInputpreminmax = new double[testNum,inNum];
            double[][] trainInputhuan = new double[trainNum][];
            double[][] trainOutputhuan = new double[trainNum][];
            double[] trainOutputha = new double[trainNum];


            // 读取训练数据
            StreamReader readertraininput = new StreamReader(@"data\trainDatainputha.txt", Encoding.UTF8);
            StreamReader readertrainoutput = new StreamReader(@"data\trainDataoutputha.txt", Encoding.UTF8);

            for (int i = 0; i < trainNum; i++)
            {
                string valuetraininput = readertraininput.ReadLine();
                string valuetrainoutput = readertrainoutput.ReadLine();

                string[] temptraininput = valuetraininput.Split(',');


                string[] temptrainoutput = valuetrainoutput.Split('\t');



                for (int j = 0; j < Num; j++)
                {
                    trainInputduo[i, j] = temptraininput[j];

                }


                trainInput[i, 0] = double.Parse(trainInputduo[i, 1]);
                trainInput[i, 1] = double.Parse(trainInputduo[i, 3]);
                trainInput[i, 2] = double.Parse(trainInputduo[i, 5]);
                trainInput[i, 3] = double.Parse(trainInputduo[i, 7]);
                trainInput[i, 4] = double.Parse(trainInputduo[i, 9]);
                trainInput[i, 5] = double.Parse(trainInputduo[i, 11]);
                trainInput[i, 6] = double.Parse(trainInputduo[i, 13]);





                for (int j = 0; j < outNum; j++)
                {
                    trainOutput[i, j] = double.Parse(temptrainoutput[j]);

                    //trainOutput[i, j] = Math.Log10(trainOutput[i, j]);
                    trainOutputha[i] = trainOutput[i, j];

                }


            }


            //训练数据归一化
            Pre pre = new Pre();

            trainInputpreminmax = pre.Preminmax(trainInput);

            trainOutputpreminmax = pre.Preminmax(trainOutput);



            //输入数据矩阵转化
            double[][] trainInputpreminmaxhuan = new double[trainNum][];
            double[][] trainOutputpreminmaxhuan = new double[trainNum][];

            for (int i = 0; i < trainNum; i++)
            {
                trainInputpreminmaxhuan[i] = new double[7];
                trainOutputpreminmaxhuan[i] = new double[7];

                for (int j = 0; j < 7; j++)
                {

                    trainInputpreminmaxhuan[i][j] = trainInputpreminmax[i, j];
                }

                for (int j = 0; j < 1; j++)
                {
                    trainOutputpreminmaxhuan[i][j] = trainOutputpreminmax[i, j];

                }

            }

            //创建网络


            BP bp = new BP(trainInputpreminmaxhuan, trainOutputpreminmaxhuan);

            //加入粒子群算法啊啊

            int NumPaticle = 20;
            int NumPosition = inNum * hiddenNum + hiddenNum + hiddenNum * outNum + outNum; ;

            _Swarm MySwarm = new _Swarm();

            MySwarm.CreatSwarm(ref MySwarm, NumPosition, NumPaticle);
            MySwarm.InitSwarm(ref MySwarm);
            //MySwarm.UpdateSwarm(ref MySwarm);

            //把最好的例子中的位置赋给W V B1 B2
            double[] BestSwarm = new double[NumPosition];
            double[] WW = new double[NumPosition];
            double[] VV = new double[NumPosition];
            double[] bb1 = new double[NumPosition];
            double[] bb2 = new double[NumPosition];


            double[,] w = new double[inNum, hiddenNum];
            double[,] v = new double[hiddenNum, outNum];
            double[,] dw = new double[hiddenNum, inNum];
            double[,] dv = new double[hiddenNum, outNum];

            double[] b1 = new double[hiddenNum];
            double[] b2 = new double[outNum];

            BestSwarm = MySwarm.UpdateSwarm(ref MySwarm);

            for (int k = 0; k < inNum * hiddenNum; k++)
            {
                WW[k] = BestSwarm[k];


            }

            //初始化粒子群之后的W
            for (int i = 0; i < inNum; i++)
            {
                for (int j = 0; j < hiddenNum; j++)
                {

                    w[i, j] = WW[i * hiddenNum + j];



                }
            }

            for (int k = inNum * hiddenNum; k < inNum * hiddenNum + hiddenNum; k++)
            {
                VV[k] = BestSwarm[k];

            }


            //初始化粒子群之后的V
            for (int i = 0; i < hiddenNum; i++)
            {

                for (int j = 0; j < outNum; j++)
                {
                    v[i, j] = VV[i * outNum + inNum * hiddenNum + j];
                }

            }


            for (int k = inNum * hiddenNum + hiddenNum; k < inNum * hiddenNum + hiddenNum + hiddenNum * outNum; k++)
            {
                bb1[k] = BestSwarm[k];
                //初始化粒子群之后的b1
                for (int i = 0; i < hiddenNum; i++)
                {

                    b1[i] = bb1[inNum * hiddenNum + hiddenNum + i];

                }


            }

            for (int k = inNum * hiddenNum + hiddenNum + hiddenNum * outNum; k < inNum * hiddenNum + hiddenNum + hiddenNum * outNum + outNum; k++)
            {
                bb2[k] = BestSwarm[k];
                //初始化立足群之后的b2
                for (int j = 0; j < outNum; j++)
                {

                    b2[j] = bb2[inNum * hiddenNum + hiddenNum + hiddenNum * outNum + j];

                }
            }

            //神经网络训练
            int study = 0;


            do
            {
                study++;
                bp.train(trainInputpreminmax, trainOutputpreminmax);



            } while (bp.e > 18.3 && study < 5000);
            //Console.Write("第 " + study + "次学习： ");
            //Console.WriteLine(" 均方差为 " + bp.e);
            double error;

            error = bp.e;

            //bp.saveMatrix(bp.w, "w.txt");
            //bp.saveMatrix(bp.v, "v.txt");
            //bp.saveMatrix(bp.b1, "b1.txt");
            //bp.saveMatrix(bp.b2, "b2.txt");

            //bp.saveMatrix(bp.e, "e00.txt");

            //开始导入之前训练好的50个e

            double[] e = new double[50];

            int num = 0;

            double[] error50 = new double[50];

            for (int i = 0; i < 50; i++)
            {


                String line;

                using (StreamReader sr = new StreamReader("e" + i + ".txt", Encoding.UTF8))
                {

                    while ((line = sr.ReadLine()) != null)
                    {

                        //e = Convert.ToDouble(line);

                        e[i] = Convert.ToDouble(line);

                    }

                    sr.Close();

                }

                error50 = e;

            }


            double maxerror = error50[0];

            for (int i = 0; i < 50; i++)
            {
                if (error50[i] > maxerror)
                {
                    maxerror = error50[i];

                    num = i;

                }


            }


            if (error < maxerror)
            {

                maxerror = error;


            }



            //保存矩阵w


            StreamWriter sw_w = File.CreateText("w" + num + ".txt");
            //StreamWriter sw = File.AppendText(filename);
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {
                    sw_w.Write(w[i, j] + " ");
                }
                sw_w.WriteLine();
            }
            sw_w.Close();

            //保存矩阵 v

            StreamWriter sw_v = File.CreateText("v" + num + ".txt");
            //StreamWriter sw = File.AppendText(filename);
            for (int i = 0; i < v.GetLength(0); i++)
            {
                for (int j = 0; j < v.GetLength(1); j++)
                {
                    sw_v.Write(v[i, j] + " ");
                }
                sw_v.WriteLine();
            }
            sw_v.Close();

            //保存矩阵b1

            StreamWriter sw_b1 = File.CreateText("b1" + num + ".txt");
            //StreamWriter sw = File.AppendText(filename);
            for (int i = 0; i < b1.Length; i++)
            {
                sw_b1.Write(b1[i] + " ");
            }
            sw_b1.Close();

            //保存矩阵b2

            StreamWriter sw_b2 = File.CreateText("b2" + num + ".txt");
            //StreamWriter sw = File.AppendText(filename);
            for (int i = 0; i < b2.Length; i++)
            {
                sw_b2.Write(b2[i] + " ");
            }
            sw_b2.Close();

            //保存e

            StreamWriter sw_e = File.CreateText("e" + num + ".txt");
            //StreamWriter sw = File.AppendText(filename);
            sw_e.Write(bp.e);
            sw_e.Close();
            //File.Delete("e" + num + ".txt");


            DialogResult dr = MessageBox.Show("训练完成", "", MessageBoxButtons.OK);

            if (dr == DialogResult.OK)
            {
                //点确定的代码 
                //FrmTrain ft = new FrmTrain();
                this.Hide();
            }

            readertraininput.Close();
            readertrainoutput.Close();
            // 所有打开的都要调用Close
        }//end train




        public void Train50()
        {
            //开始神经网络
            int trainNum = 388;
            //int testNum = 1;
            int inNum = 7;
            int outNum = 1;
            int hiddenNum = 5;
            double[,] trainInput = new double[trainNum, inNum];
            double[,] trainOutput = new double[trainNum, outNum];
            double[,] trainInputpreminmax = new double[trainNum, inNum];
            double[,] trainOutputpreminmax = new double[trainNum, outNum];
            //double[,] testInputpreminmax = new double[testNum,inNum];
            double[][] trainInputhuan = new double[trainNum][];
            double[][] trainOutputhuan = new double[trainNum][];
            double[] trainOutputha = new double[trainNum];


            // 读取训练数据
            StreamReader readertraininput = new StreamReader(@"data\trainDatainput.txt");
            StreamReader readertrainoutput = new StreamReader(@"data\trainDataoutput.txt");


            for (int i = 0; i < trainNum; i++)
            {
                string valuetraininput = readertraininput.ReadLine();
                string valuetrainoutput = readertrainoutput.ReadLine();

                string[] temptraininput = valuetraininput.Split('\t');
                string[] temptrainoutput = valuetrainoutput.Split('\t');



                for (int j = 0; j < inNum; j++)
                {
                    trainInput[i, j] = double.Parse(temptraininput[j]);

                }
                for (int j = 0; j < outNum; j++)
                {
                    trainOutput[i, j] = double.Parse(temptrainoutput[j]);

                    //trainOutput[i, j] = Math.Log10(trainOutput[i, j]);
                    trainOutputha[i] = trainOutput[i, j];

                }


            }


            //训练数据归一化
            Pre pre = new Pre();

            trainInputpreminmax = pre.Preminmax(trainInput);

            trainOutputpreminmax = pre.Preminmax(trainOutput);



            //输入数据矩阵转化
            double[][] trainInputpreminmaxhuan = new double[trainNum][];
            double[][] trainOutputpreminmaxhuan = new double[trainNum][];

            for (int i = 0; i < trainNum; i++)
            {
                trainInputpreminmaxhuan[i] = new double[7];
                trainOutputpreminmaxhuan[i] = new double[7];

                for (int j = 0; j < 7; j++)
                {

                    trainInputpreminmaxhuan[i][j] = trainInputpreminmax[i, j];
                }

                for (int j = 0; j < 1; j++)
                {
                    trainOutputpreminmaxhuan[i][j] = trainOutputpreminmax[i, j];

                }

            }

            //创建网络
            for (int m = 0; m < 50; m++)
            {

                BP bp = new BP(trainInputpreminmaxhuan, trainOutputpreminmaxhuan);

                //加入粒子群算法啊啊

                int NumPaticle = 20;
                int NumPosition = inNum * hiddenNum + hiddenNum + hiddenNum * outNum + outNum; ;

                _Swarm MySwarm = new _Swarm();

                MySwarm.CreatSwarm(ref MySwarm, NumPosition, NumPaticle);
                MySwarm.InitSwarm(ref MySwarm);
                //MySwarm.UpdateSwarm(ref MySwarm);

                //把最好的例子中的位置赋给W V B1 B2
                double[] BestSwarm = new double[NumPosition];
                double[] WW = new double[NumPosition];
                double[] VV = new double[NumPosition];
                double[] bb1 = new double[NumPosition];
                double[] bb2 = new double[NumPosition];


                double[,] w = new double[inNum, hiddenNum];
                double[,] v = new double[hiddenNum, outNum];
                double[,] dw = new double[hiddenNum, inNum];
                double[,] dv = new double[hiddenNum, outNum];

                double[] b1 = new double[hiddenNum];
                double[] b2 = new double[outNum];

                BestSwarm = MySwarm.UpdateSwarm(ref MySwarm);

                for (int k = 0; k < inNum * hiddenNum; k++)
                {
                    WW[k] = BestSwarm[k];


                }

                //初始化粒子群之后的W
                for (int i = 0; i < inNum; i++)
                {
                    for (int j = 0; j < hiddenNum; j++)
                    {

                        w[i, j] = WW[i * hiddenNum + j];



                    }
                }

                for (int k = inNum * hiddenNum; k < inNum * hiddenNum + hiddenNum; k++)
                {
                    VV[k] = BestSwarm[k];

                }


                //初始化粒子群之后的V
                for (int i = 0; i < hiddenNum; i++)
                {

                    for (int j = 0; j < outNum; j++)
                    {
                        v[i, j] = VV[i * outNum + inNum * hiddenNum + j];
                    }

                }


                for (int k = inNum * hiddenNum + hiddenNum; k < inNum * hiddenNum + hiddenNum + hiddenNum * outNum; k++)
                {
                    bb1[k] = BestSwarm[k];
                    //初始化粒子群之后的b1
                    for (int i = 0; i < hiddenNum; i++)
                    {

                        b1[i] = bb1[inNum * hiddenNum + hiddenNum + i];

                    }


                }

                for (int k = inNum * hiddenNum + hiddenNum + hiddenNum * outNum; k < inNum * hiddenNum + hiddenNum + hiddenNum * outNum + outNum; k++)
                {
                    bb2[k] = BestSwarm[k];
                    //初始化立足群之后的b2
                    for (int j = 0; j < outNum; j++)
                    {

                        b2[j] = bb2[inNum * hiddenNum + hiddenNum + hiddenNum * outNum + j];

                    }
                }

                //神经网络训练
                int study = 0;


                do
                {
                    study++;
                    bp.train(trainInputpreminmax, trainOutputpreminmax);



                } while (bp.e > 18.3 && study < 5000);
                //Console.Write("第 " + study + "次学习： ");
                //Console.WriteLine(" 均方差为 " + bp.e);
                double[] error = new double[50];

                error[m] = bp.e;

                //bp.saveMatrix(bp.w, "w.txt");
                //bp.saveMatrix(bp.v, "v.txt");
                //bp.saveMatrix(bp.b1, "b1.txt");
                //bp.saveMatrix(bp.b2, "b2.txt");
                bp.saveMatrix(bp.e, "e.txt");



                //保存矩阵w

                StreamWriter sw_w = File.CreateText("w" + m + ".txt");
                //StreamWriter sw = File.AppendText(filename);
                for (int i = 0; i < w.GetLength(0); i++)
                {
                    for (int j = 0; j < w.GetLength(1); j++)
                    {
                        sw_w.Write(w[i, j] + " ");
                    }
                    sw_w.WriteLine();
                }
                sw_w.Close();

                //保存矩阵 v

                StreamWriter sw_v = File.CreateText("v" + m + ".txt");
                //StreamWriter sw = File.AppendText(filename);
                for (int i = 0; i < v.GetLength(0); i++)
                {
                    for (int j = 0; j < v.GetLength(1); j++)
                    {
                        sw_v.Write(v[i, j] + " ");
                    }
                    sw_v.WriteLine();
                }
                sw_v.Close();

                //保存矩阵b1

                StreamWriter sw_b1 = File.CreateText("b1" + m + ".txt");
                //StreamWriter sw = File.AppendText(filename);
                for (int i = 0; i < b1.Length; i++)
                {
                    sw_b1.Write(b1[i] + " ");
                }
                sw_b1.Close();

                //保存矩阵b2

                StreamWriter sw_b2 = File.CreateText("b2" + m + ".txt");
                //StreamWriter sw = File.AppendText(filename);
                for (int i = 0; i < b2.Length; i++)
                {
                    sw_b2.Write(b2[i] + " ");
                }
                sw_b2.Close();

                //保存e
                StreamWriter sw_e = File.CreateText("e" + m + ".txt");
                //StreamWriter sw = File.AppendText(filename);
                sw_e.Write(bp.e);
                sw_e.Close();


            }
            MessageBox.Show("训练完成");

        }//end train50





        private void FrmTrain_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

        }


    }



}
