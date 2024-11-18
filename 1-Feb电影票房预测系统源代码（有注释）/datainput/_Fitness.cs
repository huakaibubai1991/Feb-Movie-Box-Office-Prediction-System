using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace datainput
{
    //计算粒子的适应度
    class _Fitness
    {
        public double FitError = new double();

        public void CalFitness(ref _Paticle Paticle)
        {
            //开始神经网络
            string path = @"data\trainDatainputha.txt";
            string[] strings = File.ReadAllLines(path);
            int trainNum = strings.Length;

            //int trainNum = 388;
            int Num = 14;
            int inNum = 7;
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
            double[] testpreminmax = new double[inNum];

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
            BP bp = new BP(trainInputpreminmaxhuan, trainOutputpreminmaxhuan);

            //神经网络训练
            int study = 0;
            do
            {
                study++;
                bp.train(trainInputpreminmax, trainOutputpreminmax);


            } while (bp.e > 0.001 && study < 50000);
            //Console.Write("第 " + study + "次学习： ");
            //Console.WriteLine(" 均方差为 " + bp.e);
            
            //bp.saveMatrix(bp.w, "w.txt");
            //bp.saveMatrix(bp.v, "v.txt");
            //bp.saveMatrix(bp.b1, "b1.txt"); 
            //bp.saveMatrix(bp.b2, "b2.txt");

            // output = bp.sim(p21);
            double[] output = new double[trainNum];
            double[] outputerror = new double[trainNum];

            output = bp.sim0(trainInputpreminmax);



            //把训练的输出的归一化函数转置一下
            double[] trainOutputpreminmaxtransform = new double[trainNum];
            double[] outputxunhuan = new double[trainNum];
            for (int i = 0; i < trainNum; i++)
            {
                for (int j = 0; j < outNum; j++)
                {
                    trainOutputpreminmaxtransform[i] = trainOutputpreminmax[i, j];
                }

                outputxunhuan[i] = output[i];

                outputerror[i] = System.Math.Abs(outputxunhuan[i] - trainOutputpreminmaxtransform[i]);

            }


            double outputerrorsum = 0.0;
            for (int i = 0; i < trainNum; i++)
            {


                outputerrorsum = outputerrorsum + outputerror[i];

            }

            Paticle.Fitness.FitError = outputerrorsum;//适应度函数为输出误差的和
        }
       
    }
}
