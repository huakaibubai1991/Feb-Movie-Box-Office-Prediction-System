using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace datainput
{
    public class Train
    {
       
        
        public double[] GetsTrainData(double a1, double a2, double as1, double as2, double dir, double scr, double pr)
        {
            //开始神经网络
            string path = @"data\trainDatainputha.txt";
            string[] strings = File.ReadAllLines(path);
            int trainNum = strings.Length;

            //int trainNum = 388;
            int inNum = 7;
            int Num = 14;
            int outNum = 1;
            //int hiddenNum = 5;
            string[,] trainInputduo = new string[trainNum, Num];
            double[,] trainInput = new double[trainNum, inNum];
            double[,] trainOutput = new double[trainNum, outNum];
            double[,] trainInputpreminmax = new double[trainNum, inNum];
            double[,] trainOutputpreminmax = new double[trainNum, outNum];
            //double[,] testInputpreminmax = new double[testNum,inNum];
            double[][] trainInputhuan = new double[trainNum][];
            double[][] trainOutputhuan = new double[trainNum][];



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

                }

            }


            //训练数据归一化
            Pre pre = new Pre();

            trainInputpreminmax = pre.Preminmax(trainInput);

            trainOutputpreminmax = pre.Preminmax(trainOutput);



            ////输入数据矩阵转化
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

            //训练网络
            // create multi-layer neural network
            // 创建一个多层神经网络，采用S形激活函数，各层分别有7,5,1个神经元
            //(其中7是输入个数，1是输出个数，5是中间层结点个数)
            //ActivationNetwork network = new ActivationNetwork(new SigmoidFunction(3), 7, 5, 1);
            //// create teacher
            //BackPropagationLearning teacher = new BackPropagationLearning(network);
            //// set learning rate and momentum
            //teacher.LearningRate = 0.1;
            //teacher.Momentum = 0;

            //int iteration = 1;

            //double dError = 0;

            //while (iteration < 10000 && dError > 0.000001)
            //{
            //    dError = teacher.RunEpoch(trainInputpreminmaxhuan, trainOutputpreminmaxhuan);

            //    ++iteration;
            //}

            //BP bp = new BP(trainInputpreminmaxhuan, trainOutputpreminmaxhuan);

            ////加入粒子群算法啊啊

            //int NumPaticle = 20;
            //int NumPosition = inNum * hiddenNum + hiddenNum + hiddenNum * outNum + outNum; ;

            //_Swarm MySwarm = new _Swarm();

            //MySwarm.CreatSwarm(ref MySwarm, NumPosition, NumPaticle);
            //MySwarm.InitSwarm(ref MySwarm);
            ////MySwarm.UpdateSwarm(ref MySwarm);

            ////把最好的例子中的位置赋给W V B1 B2
            //double[] BestSwarm = new double[NumPosition];
            //double[] WW = new double[NumPosition];
            //double[] VV = new double[NumPosition];
            //double[] bb1 = new double[NumPosition];
            //double[] bb2 = new double[NumPosition];


            //double[,] w = new double[inNum, hiddenNum];
            //double[,] v = new double[hiddenNum, outNum];
            //double[,] dw = new double[hiddenNum, inNum];
            //double[,] dv = new double[hiddenNum, outNum];

            //double[] b1 = new double[hiddenNum];
            //double[] b2 = new double[outNum];

            //BestSwarm = MySwarm.UpdateSwarm(ref MySwarm);

            //for (int k = 0; k < inNum * hiddenNum; k++)
            //{
            //    WW[k] = BestSwarm[k];


            //}

            ////初始化粒子群之后的W
            //for (int i = 0; i < inNum; i++)
            //{
            //    for (int j = 0; j < hiddenNum; j++)
            //    {

            //        w[i, j] = WW[i * hiddenNum + j];



            //    }
            //}

            //for (int k = inNum * hiddenNum; k < inNum * hiddenNum + hiddenNum; k++)
            //{
            //    VV[k] = BestSwarm[k];

            //}


            ////初始化粒子群之后的V
            //for (int i = 0; i < hiddenNum; i++)
            //{

            //    for (int j = 0; j < outNum; j++)
            //    {
            //        v[i, j] = VV[i * outNum + inNum * hiddenNum + j];
            //    }

            //}


            //for (int k = inNum * hiddenNum + hiddenNum; k < inNum * hiddenNum + hiddenNum + hiddenNum * outNum; k++)
            //{
            //    bb1[k] = BestSwarm[k];
            //    //初始化粒子群之后的b1
            //    for (int i = 0; i < hiddenNum; i++)
            //    {

            //        b1[i] = bb1[inNum * hiddenNum + hiddenNum + i];

            //    }


            //}

            //for (int k = inNum * hiddenNum + hiddenNum + hiddenNum * outNum; k < inNum * hiddenNum + hiddenNum + hiddenNum * outNum + outNum; k++)
            //{
            //    bb2[k] = BestSwarm[k];
            //    //初始化立足群之后的b2
            //    for (int j = 0; j < outNum; j++)
            //    {

            //        b2[j] = bb2[inNum * hiddenNum + hiddenNum + hiddenNum * outNum + j];

            //    }
            //}

            ////神经网络训练
            //int study = 0;
            //do
            //{
            //    study++;
            //    bp.train(trainInputpreminmax, trainOutputpreminmax);


            //} while (bp.e > 0.001 && study < 50000);
            ////Console.Write("第 " + study + "次学习： ");
            ////Console.WriteLine(" 均方差为 " + bp.e);
            //bp.saveMatrix(bp.w, "w.txt");
            //bp.saveMatrix(bp.v, "v.txt");
            //bp.saveMatrix(bp.b1, "b1.txt");
            //bp.saveMatrix(bp.b2, "b2.txt");



            //BP bp = new BP(trainInputpreminmaxhuan, trainOutputpreminmaxhuan);

            //输入测试数据
            double[] testInput = new double[] { a1, a2, as1, as2, dir, scr, pr };

            double[] testInputpreminmax = new double[inNum];

            testInputpreminmax = pre.PreminmaxtestInput(trainInput, testInput);


            double[] testInputpreminmaxhao = new double[inNum];
            double[] output = new double[50];
            double[] outputfinal = new double[50];

            for (int i = 0; i < inNum; i++)
            {
                testInputpreminmaxhao[i] = testInputpreminmax[i];
            }

            //开始预测50次取80%

            double[] e = new double[50];

            double[] error = new double[50];

            

            //int num = 0;

            //for(int i= 0;i<50;i++)
            //{

            //    //StreamReader sr;

            //    //sr = new StreamReader("e" + i + ".txt", Encoding.GetEncoding("gb2312"));

            //    String line;

            //    using (StreamReader sr = new StreamReader("e" + i + ".txt", Encoding.GetEncoding("gb2312")))
            //    {

            //        while ((line = sr.ReadLine()) != null)
            //        {


            //            //data += line;
            //            //e = Convert.ToDouble(line);

            //            e[i] = Convert.ToDouble(line);

            //        }

            //        sr.Close();

            //    }

            //    error = e;

                

               
            
            //}

            //double minerror = error[0];

            //for (int i = 0; i < 50; i++)
            //{
            //    if (error[i] < minerror)
            //    {
            //        minerror = error[i];

            //        num = i;

            //    }
            
            //}

            for (int i = 0; i < 50; i++)
            {
                BP bp = new BP(trainInputpreminmaxhuan, trainOutputpreminmaxhuan);

               //原来读取矩阵放在这里

                bp.readMatrixW(bp.w, "w" + i + ".txt");
                bp.readMatrixW(bp.v, "v" + i + ".txt");
                bp.readMatrixB(bp.b1, "b1" + i + ".txt");
                bp.readMatrixB(bp.b2, "b2" + i + ".txt");


                output = bp.sim(testInputpreminmaxhao);

                outputfinal[i] = pre.Preminmaxfan(trainOutput, output);
           
            }//end for 50

            
            for (int i = 0; i < outputfinal.Length - 1; i++)
            {
                for (int j = 0; j < outputfinal.Length - 1 - i; j++)
                {
                    if (outputfinal[j] > outputfinal[j + 1])
                    {
                        double b = outputfinal[j];
                        outputfinal[j] = outputfinal[j + 1];
                        outputfinal[j + 1] = b;

                    }

                }
            }

            //求80%的结果
            if (outputfinal.Length < 50)
            {
                throw new Exception("索引太小");
            }
            //double ee = d.Length*80/100;
            //int f = (int)ee;
            double temp = 0;
            for (int i = 5; i < 45; i++)
            {
                temp += outputfinal[i];
            }

            double[] outputfinalhao = new double[2];

            outputfinalhao[0] = temp / (outputfinal.Length * 80 / 100);

            //求均值的结果

           
            double temp50 = 0;
            for (int i = 0; i < 50; i++)
            {
                temp50 += outputfinal[i];
            }

            outputfinalhao[1] = temp50 / 50;



            //返回预测值
            return outputfinalhao;

            

        }

    }
}
