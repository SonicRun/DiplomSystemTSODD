﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity
{
   public  class GeographicalPosition:Entity
    {
      
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public override string ToString()
        {
            return Latitude+" " +Longitude;
        }
    }
}
