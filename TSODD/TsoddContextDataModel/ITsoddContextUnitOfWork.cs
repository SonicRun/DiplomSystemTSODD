using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using TSODD;
using TSODD.Entity;
using TSODD.Entity.Fencing;
using TSODD.Entity.Lamp;
using TSODD.Entity.Public_transport_stop;
using TSODD.Entity.Road_sign;
using TSODD.Entity.Traffic_light;

namespace TSODD.TsoddContextDataModel {

using Fencing = TSODD.Entity.Fencing.Fencing;
    /// <summary>
    /// ITsoddContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface ITsoddContextUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Address entities repository.
        /// </summary>
		IRepository<Address, int> Address { get; }
        
        /// <summary>
        /// The ConditionOfTheObject entities repository.
        /// </summary>
		IRepository<ConditionOfTheObject, int> ConditionOfTheObject { get; }
        
        /// <summary>
        /// The DegreeOfCapacityStops entities repository.
        /// </summary>
		IRepository<DegreeOfCapacityStops, int> DegreeOfCapacityStops { get; }
        
        /// <summary>
        /// The ExecutionOfTheTrafficLight entities repository.
        /// </summary>
		IRepository<ExecutionOfTheTrafficLight, int> ExecutionOfTheTrafficLight { get; }
        
        /// <summary>
        /// The Fencing entities repository.
        /// </summary>
		IRepository<Fencing, int> Fencing { get; }
        
        /// <summary>
        /// The FencingСlass entities repository.
        /// </summary>
		IRepository<FencingСlass, int> FencingСlass { get; }
        
        /// <summary>
        /// The GeographicalPosition entities repository.
        /// </summary>
		IRepository<GeographicalPosition, int> GeographicalPosition { get; }
        
        /// <summary>
        /// The GroupFencing entities repository.
        /// </summary>
		IRepository<GroupFencing, int> GroupFencing { get; }
        
        /// <summary>
        /// The Photo entities repository.
        /// </summary>
		IRepository<Photo, int> Photo { get; }
        
        /// <summary>
        /// The SubgroupFencing entities repository.
        /// </summary>
		IRepository<SubgroupFencing, int> SubgroupFencing { get; }
        
        /// <summary>
        /// The TypeFencing entities repository.
        /// </summary>
		IRepository<TypeFencing, int> TypeFencing { get; }
        
        /// <summary>
        /// The TypeTSODD entities repository.
        /// </summary>
		IRepository<TypeTSODD, int> TypeTSODD { get; }
        
        /// <summary>
        /// The FilmType entities repository.
        /// </summary>
		IRepository<FilmType, int> FilmType { get; }
        
        /// <summary>
        /// The GroupTrafficLight entities repository.
        /// </summary>
		IRepository<GroupTrafficLight, int> GroupTrafficLight { get; }
        
        /// <summary>
        /// The LampType entities repository.
        /// </summary>
		IRepository<LampType, int> LampType { get; }
        
        /// <summary>
        /// The LightingСlass entities repository.
        /// </summary>
		IRepository<LightingСlass, int> LightingСlass { get; }
        
        /// <summary>
        /// The PublicTransportStop entities repository.
        /// </summary>
		IRepository<PublicTransportStop, int> PublicTransportStop { get; }
        
        /// <summary>
        /// The TypeOfLayoutStop entities repository.
        /// </summary>
		IRepository<TypeOfLayoutStop, int> TypeOfLayoutStop { get; }
        
        /// <summary>
        /// The RoadSign entities repository.
        /// </summary>
		IRepository<RoadSign, int> RoadSign { get; }
        
        /// <summary>
        /// The TypeRoad entities repository.
        /// </summary>
		IRepository<TypeRoad, int> TypeRoad { get; }
        
        /// <summary>
        /// The StreetLight entities repository.
        /// </summary>
		IRepository<StreetLight, int> StreetLight { get; }
        
        /// <summary>
        /// The TrafficLight entities repository.
        /// </summary>
		IRepository<TrafficLight, int> TrafficLight { get; }
        
        /// <summary>
        /// The TypeTrafficLight entities repository.
        /// </summary>
		IRepository<TypeTrafficLight, int> TypeTrafficLight { get; }
        
        /// <summary>
        /// The VariantOfTrafficLightDesign entities repository.
        /// </summary>
		IRepository<VariantOfTrafficLightDesign, int> VariantOfTrafficLightDesign { get; }
        
        /// <summary>
        /// The Tsodd entities repository.
        /// </summary>
		IRepository<Tsodd, int> Tsodd { get; }
    }
}
