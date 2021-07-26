using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity.Fencing
{
    public class Fencing :Tsodd
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public FencingСlass FencingСlass { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public GroupFencing GroupFencing { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public SubgroupFencing SubgroupFencing { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public TypeFencing TypeFencing { get; set; }
        public float Height { get; set; }
        public float RetentionRate { get; set; }
        public float DeflectionFencing { get; set; }
    }
}
