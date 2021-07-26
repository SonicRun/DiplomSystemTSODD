using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity.Traffic_light
{
    public class TrafficLight :Tsodd
    {
      
        public ExecutionOfTheTrafficLight ExecutionOfTheTrafficLight { get; set; }
        public GroupTrafficLight GroupTrafficLight { get; set; }
        public TypeTrafficLight TypeTrafficLight { get;set;}
        public VariantOfTrafficLightDesign VariantOfTrafficLightDesign { get; set; }
    }
}
