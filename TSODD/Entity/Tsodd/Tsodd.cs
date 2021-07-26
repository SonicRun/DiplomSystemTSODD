using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity
{
   public class Tsodd:Entity
    {        
        public DateTime InstallationDate { get; set; }
        public DateTime LastInventoryDate { get; set; }
        public DateTime DateOfLastService { get; set; }
        public DateTime DateOfEntryInTheDatabase { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Address Addres { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public ConditionOfTheObject ConditionOfTheObject { get; set; }
        public Photo Photo { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public TypeTSODD TypeTSODD { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public GeographicalPosition GeographicalPosition { get; set; }
    }
}
