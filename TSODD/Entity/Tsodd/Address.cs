using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Repository;

namespace TSODD.Entity
{
    public class Address : Entity
    {
        public string NameStreetOrRoad { get; set; }
        public string ReferencePoint { get; set; }
        public float KmANDmetr { get; set; }

        public override string ToString()
        {
            return NameStreetOrRoad + " " + KmANDmetr + "(" + ReferencePoint + ")";
        }
    }

}
