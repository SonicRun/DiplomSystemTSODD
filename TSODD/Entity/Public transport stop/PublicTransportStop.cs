using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity.Public_transport_stop
{
    public class PublicTransportStop:Tsodd
    {
                public DegreeOfCapacityStops DegreeOfCapacityStops { get; set; }
        public TypeOfLayoutStop TypeOfLayoutStop { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public string MaterialName { get; set; }
    }
}
