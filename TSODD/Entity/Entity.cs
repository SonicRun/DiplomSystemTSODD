using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity
{
    public abstract class Entity
    {

        //  [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Key]
        public int Id { get; set; }
    }
}
