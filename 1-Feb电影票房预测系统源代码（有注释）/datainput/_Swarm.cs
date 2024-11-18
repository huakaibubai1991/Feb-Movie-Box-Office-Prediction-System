using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datainput
{
    class _Swarm
    {

        public _Paticle[] Paticles;
        public _Paticle[] GoodPaticles;
        public _Paticle BestPaticle;
        //public int Generation;

        public void CreatSwarm(ref _Swarm Swarm, int NumPosition, int NumPaticle)
        {
            Swarm.Paticles = new _Paticle[NumPaticle];
            Swarm.GoodPaticles = new _Paticle[NumPaticle];
            Swarm.BestPaticle = new _Paticle();
            for (int i = 0; i < NumPaticle; i++)
            {
                Swarm.Paticles[i] = new _Paticle();
                Swarm.Paticles[i].InitPaticle(ref Swarm.Paticles[i], NumPosition);
                Swarm.GoodPaticles[i] = new _Paticle();
                Swarm.GoodPaticles[i] = Swarm.GoodPaticles[i].Copy(Swarm.Paticles[i]);
            }

        }

        public void InitSwarm(ref _Swarm Swarm)
        {
            Random rd = new Random();
            //给粒子随机初始化赋值
            for (int i = 0; i < Swarm.Paticles.Length; i++)
            {
                for (int j = 0; j < Swarm.Paticles[i].X.Length; j++)
                {
                    Swarm.Paticles[i].X[j] = 5 * (rd.NextDouble() * 2 - 1);
                    Swarm.Paticles[i].Velocity[j] = rd.NextDouble() * 2 - 1;
                }
                Swarm.Paticles[i].Fitness.CalFitness(ref Swarm.Paticles[i]);
            }
            //复制个体最好粒子
            for (int i = 0; i < Swarm.Paticles.Length; i++)
            {
                Swarm.GoodPaticles[i] = Swarm.Paticles[i].Copy(Swarm.Paticles[i]);
            }
            //选择全局最好粒子
            Swarm.BestPaticle = Swarm.BestPaticle.Copy(Swarm.GoodPaticles[0]);
            for (int i = 0; i < Swarm.GoodPaticles.Length; i++)
            {
                if (Swarm.GoodPaticles[i].Fitness.FitError < Swarm.BestPaticle.Fitness.FitError)
                {
                    Swarm.BestPaticle = Swarm.BestPaticle.Copy(Swarm.GoodPaticles[i]);
                }
            }
        }

        public double[] UpdateSwarm(ref _Swarm Swarm)
        {
            Random rd = new Random();
            //计算适应度            
            for (int i = 0; i < Swarm.Paticles.Length; i++)
            {
                Swarm.Paticles[i].Fitness.CalFitness(ref Swarm.Paticles[i]);
            }
            //选择个体最好粒子
            for (int i = 0; i < Swarm.Paticles.Length; i++)
            {
                if (Swarm.Paticles[i].Fitness.FitError < Swarm.GoodPaticles[i].Fitness.FitError)
                {
                    Swarm.GoodPaticles[i] = Swarm.GoodPaticles[i].Copy(Swarm.Paticles[i]);
                }
            }
            //选择全局最好粒子
            _Paticle TempBest = new _Paticle();
            TempBest = TempBest.Copy(Swarm.GoodPaticles[0]);
            for (int i = 0; i < Swarm.GoodPaticles.Length; i++)
            {
                if (TempBest.Fitness.FitError > Swarm.GoodPaticles[i].Fitness.FitError)
                {
                    TempBest = TempBest.Copy(Swarm.GoodPaticles[i]);
                }
            }
            if (TempBest.Fitness.FitError < Swarm.BestPaticle.Fitness.FitError)
            {
                Swarm.BestPaticle = Swarm.BestPaticle.Copy(TempBest);
            }
            //更新速度与位置
            for (int i = 0; i < Swarm.Paticles.Length; i++)
            {
                for (int j = 0; j < Swarm.Paticles[i].X.Length; j++)
                {
                    Swarm.Paticles[i].Velocity[j] = 0.8 * Swarm.Paticles[i].Velocity[j] + 1.49445 * rd.NextDouble() * (Swarm.GoodPaticles[i].X[j] - Swarm.Paticles[i].X[j]) + 1.49445 * rd.NextDouble() * (Swarm.BestPaticle.X[j] - Swarm.Paticles[i].X[j]);
                    //if (Swarm.Paticles[i].Velocity[j]>2.48)
                    //{
                    //    Swarm.Paticles[i].Velocity[j] =2.48;
                    //}
                    //if (Swarm.Paticles[i].Velocity[j] <- 2.48)
                    //{
                    //    Swarm.Paticles[i].Velocity[j] =- 2.48;
                    //}
                    Swarm.Paticles[i].X[j] = Swarm.Paticles[i].X[j] + Swarm.Paticles[i].Velocity[j];
                    Swarm.Paticles[i].X[j] = 0.729 * Swarm.Paticles[i].X[j];
                }
            }

            return TempBest.X;
        }



    }
}
