using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datainput
{
    class TrainDataPoint
    {
      //属性的手指母用该大写，如Id,Actor1Name

        public int Id { get; set; }
        public string Actor1Name { get; set; }
        public string Actor2Name { get; set; }
        public string Actress1Name { get; set; }
        public string Actress2Name { get; set; }
        public string ScreenwriterName { get; set; }
        public string DirectorName { get; set; }
        public string ProducerName { get; set; }


        public double Actor1Point { get; set; }
        public double Actor2Point { get; set; }
        public double Actress1Point { get; set; }
        public double Actress2Point { get; set; }
        public double ScreenwriterPoint { get; set; }
        public double DirectorPoint { get; set; }
        public double ProducerPoint { get; set; }

        public double MoviePoint {get; set; }


    }

   
}
