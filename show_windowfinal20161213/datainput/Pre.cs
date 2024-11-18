using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datainput
{
    internal class Pre
    {
        public double[,] Preminmax(double[,] num)
        {
            var row = num.GetLength(0);             //120
            var col = num.GetLength(1);     //7
            double[] maxArr = new double[col];
            double[] minArr = new double[col];
            for (int i = 0; i < col; i++)
            {
                double max = num[0, i];
                double min = num[0, i];
                for (int j = 0; j < row; j++)
                {
                    var tmp = num[j, i];
                    if (tmp > max)
                    {
                        max = tmp;
                    }

                    if (tmp < min)
                    {
                        min = tmp;
                    }
                }
                maxArr[i] = max;
                minArr[i] = min;
            }
            var num1 = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //num1[j, i] = 2 * (num[j, i] - minArr[j]) / (maxArr[j] - minArr[j]) - 1;
                    num1[i, j] = 2 * (num[i, j] - minArr[j]) / (maxArr[j] - minArr[j]) - 1;
                }
            }
            return num1;
        }

        public double Preminmaxfan(double[,] num, double[] output)
        {
            var row = num.GetLength(0);             //120
            var col = num.GetLength(1);     //7
            double[] maxArr = new double[col];
            double[] minArr = new double[col];
            for (int i = 0; i < col; i++)
            {
                double max = num[0, i];
                double min = num[0, i];
                for (int j = 0; j < row; j++)
                {
                    var tmp = num[j, i];
                    if (tmp > max)
                    {
                        max = tmp;
                    }

                    if (tmp < min)
                    {
                        min = tmp;
                    }
                }
                maxArr[i] = max;
                minArr[i] = min;
            }
            double num1 = new double();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //num1 = 2 * (num[i][j] - minArr[j]) / (maxArr[j] - minArr[j]) - 1;)
                    num1 = 0.5 * (output[0] + 1) * (maxArr[j] - minArr[j]) + minArr[j];
                }
            }
            return num1;
        }

        public double[,] PreminmaxfanInput(double[,] num, double[] output)
        {
            var row = num.GetLength(0);             //120
            var col = num.GetLength(1);     //7
            double[] maxArr = new double[col];
            double[] minArr = new double[col];
            for (int i = 0; i < col; i++)
            {
                double max = num[0, i];
                double min = num[0, i];
                for (int j = 0; j < row; j++)
                {
                    var tmp = num[j, i];
                    if (tmp > max)
                    {
                        max = tmp;
                    }

                    if (tmp < min)
                    {
                        min = tmp;
                    }
                }
                maxArr[i] = max;
                minArr[i] = min;
            }
            //double num1 = new double();
            var num1 = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //num1 = 2 * (num[i][j] - minArr[j]) / (maxArr[j] - minArr[j]) - 1;)
                    //num1 = 0.5 * (output[0] + 1) * (maxArr[j] - minArr[j]) + minArr[j];
                    num1[i,j] = 0.5 * (output[i] + 1) * (maxArr[j] - minArr[j]) + minArr[j];
                }
            }
            return num1;
        }

        public double[] PreminmaxtestInput(double[,] num, double[] test)
        {
            var row = num.GetLength(0);      //1
            var col = num.GetLength(1);     //7
            double[] maxArr = new double[col];
            double[] minArr = new double[col];
            for (int i = 0; i < col; i++)
            {
                double max = num[0, i];
                double min = num[0, i];
                for (int j = 0; j < row; j++)
                {
                    var tmp = num[j, i];
                    if (tmp > max)
                    {
                        max = tmp;
                    }

                    if (tmp < min)
                    {
                        min = tmp;
                    }
                }
                maxArr[i] = max;
                minArr[i] = min;
            }
            var num1 = new double[col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //num1[j, i] = 2 * (num[j, i] - minArr[j]) / (maxArr[j] - minArr[j]) - 1;
                    num1[j] = 2 * (test[j] - minArr[j]) / (maxArr[j] - minArr[j]) - 1;
                }
            }
            return num1;
        }
    }
}