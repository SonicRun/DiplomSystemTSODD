using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity.Road_sign
{
   public  class RoadSign:Tsodd
    {
       
        public FilmType FilmType { get; set; }
        public TypeRoad TypeRoad { get; set; }
        public float TheHeightOfTheCapitalLetterOnTheSign { get; set; }
        public float StandardSizeMark { get; set; }
    }
}
