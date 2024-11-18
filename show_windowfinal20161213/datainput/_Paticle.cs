using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datainput
{
    class _Paticle
    {
        public double[] X;
        public double[] Velocity;
        public _Fitness Fitness = new _Fitness();

        public void InitPaticle(ref _Paticle Paticle, int NumPosition)
        {
            Paticle.X = new double[NumPosition];
            Paticle.Velocity = new double[NumPosition];
        }

        public _Paticle Copy(_Paticle P)
        {
            _Paticle PCopy = new _Paticle();
            PCopy.InitPaticle(ref PCopy, P.X.Length);
            for (int i = 0; i < P.X.Length; i++)
            {
                PCopy.X[i] = P.X[i];
                PCopy.Velocity[i] = P.Velocity[i];
            }
            PCopy.Fitness = P.Fitness;
            return PCopy;
        }
    }
}
