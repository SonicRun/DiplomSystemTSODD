using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSODD.Entity;
using TSODD.Entity.Fencing;
using TSODD.Entity.Lamp;
using TSODD.Entity.Public_transport_stop;
using TSODD.Entity.Road_sign;
using TSODD.Entity.Traffic_light;

namespace TSODD
{
    public class TsoddContext : DbContext
    {
        public TsoddContext()
            : base("Default")
        {
            Database.SetInitializer<TsoddContext>(null);
        }
       
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ConditionOfTheObject> ConditionOfTheObject { get; set; }
        public virtual DbSet<GeographicalPosition> GeographicalPosition { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<TypeTSODD> TypeTSODD { get; set; }
        public virtual DbSet<Tsodd> Tsodd { get; set; }

        public virtual DbSet<TypeFencing> TypeFencing { get; set; }
        public virtual DbSet<SubgroupFencing> SubgroupFencing { get; set; }
        public virtual DbSet<GroupFencing> GroupFencing { get; set; }
        public virtual DbSet<FencingСlass> FencingСlass { get; set; }
        public virtual DbSet<Fencing> Fencing { get; set; }


        public virtual DbSet<TypeOfLayoutStop> TypeOfLayoutStop { get; set; }
        public virtual DbSet<DegreeOfCapacityStops> DegreeOfCapacityStops { get; set; }
        public virtual DbSet<PublicTransportStop> PublicTransportStop { get; set; }


        public virtual DbSet<FilmType> FilmType { get; set; }
        public virtual DbSet<TypeRoad> TypeRoad { get; set; }
        public virtual DbSet<RoadSign> RoadSign { get; set; }


        public virtual DbSet<LightingСlass> LightingСlass { get; set; }
        public virtual DbSet<LampType> LampType { get; set; }
        public virtual DbSet<StreetLight> StreetLight { get; set; }

        public virtual DbSet<ExecutionOfTheTrafficLight> ExecutionOfTheTrafficLight { get; set; }
        public virtual DbSet<GroupTrafficLight> GroupTrafficLight { get; set; }
        public virtual DbSet<TypeTrafficLight> TypeTrafficLight { get; set; }
        public virtual DbSet<VariantOfTrafficLightDesign> VariantOfTrafficLightDesign { get; set; }
        public virtual DbSet<TrafficLight> TrafficLight { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
