using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
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
    /// A TsoddContextUnitOfWork instance that represents the run-time implementation of the ITsoddContextUnitOfWork interface.
    /// </summary>
    public class TsoddContextUnitOfWork : DbUnitOfWork<TsoddContext>, ITsoddContextUnitOfWork {

        public TsoddContextUnitOfWork(Func<TsoddContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Address, int> ITsoddContextUnitOfWork.Address {
            get { return GetRepository(x => x.Set<Address>(), (Address x) => x.Id); }
        }

        IRepository<ConditionOfTheObject, int> ITsoddContextUnitOfWork.ConditionOfTheObject {
            get { return GetRepository(x => x.Set<ConditionOfTheObject>(), (ConditionOfTheObject x) => x.Id); }
        }

        IRepository<DegreeOfCapacityStops, int> ITsoddContextUnitOfWork.DegreeOfCapacityStops {
            get { return GetRepository(x => x.Set<DegreeOfCapacityStops>(), (DegreeOfCapacityStops x) => x.Id); }
        }

        IRepository<ExecutionOfTheTrafficLight, int> ITsoddContextUnitOfWork.ExecutionOfTheTrafficLight {
            get { return GetRepository(x => x.Set<ExecutionOfTheTrafficLight>(), (ExecutionOfTheTrafficLight x) => x.Id); }
        }

        IRepository<Fencing, int> ITsoddContextUnitOfWork.Fencing {
            get { return GetRepository(x => x.Set<Fencing>(), (Fencing x) => x.Id); }
        }

        IRepository<FencingСlass, int> ITsoddContextUnitOfWork.FencingСlass {
            get { return GetRepository(x => x.Set<FencingСlass>(), (FencingСlass x) => x.Id); }
        }

        IRepository<GeographicalPosition, int> ITsoddContextUnitOfWork.GeographicalPosition {
            get { return GetRepository(x => x.Set<GeographicalPosition>(), (GeographicalPosition x) => x.Id); }
        }

        IRepository<GroupFencing, int> ITsoddContextUnitOfWork.GroupFencing {
            get { return GetRepository(x => x.Set<GroupFencing>(), (GroupFencing x) => x.Id); }
        }

        IRepository<Photo, int> ITsoddContextUnitOfWork.Photo {
            get { return GetRepository(x => x.Set<Photo>(), (Photo x) => x.Id); }
        }

        IRepository<SubgroupFencing, int> ITsoddContextUnitOfWork.SubgroupFencing {
            get { return GetRepository(x => x.Set<SubgroupFencing>(), (SubgroupFencing x) => x.Id); }
        }

        IRepository<TypeFencing, int> ITsoddContextUnitOfWork.TypeFencing {
            get { return GetRepository(x => x.Set<TypeFencing>(), (TypeFencing x) => x.Id); }
        }

        IRepository<TypeTSODD, int> ITsoddContextUnitOfWork.TypeTSODD {
            get { return GetRepository(x => x.Set<TypeTSODD>(), (TypeTSODD x) => x.Id); }
        }

        IRepository<FilmType, int> ITsoddContextUnitOfWork.FilmType {
            get { return GetRepository(x => x.Set<FilmType>(), (FilmType x) => x.Id); }
        }

        IRepository<GroupTrafficLight, int> ITsoddContextUnitOfWork.GroupTrafficLight {
            get { return GetRepository(x => x.Set<GroupTrafficLight>(), (GroupTrafficLight x) => x.Id); }
        }

        IRepository<LampType, int> ITsoddContextUnitOfWork.LampType {
            get { return GetRepository(x => x.Set<LampType>(), (LampType x) => x.Id); }
        }

        IRepository<LightingСlass, int> ITsoddContextUnitOfWork.LightingСlass {
            get { return GetRepository(x => x.Set<LightingСlass>(), (LightingСlass x) => x.Id); }
        }

        IRepository<PublicTransportStop, int> ITsoddContextUnitOfWork.PublicTransportStop {
            get { return GetRepository(x => x.Set<PublicTransportStop>(), (PublicTransportStop x) => x.Id); }
        }

        IRepository<TypeOfLayoutStop, int> ITsoddContextUnitOfWork.TypeOfLayoutStop {
            get { return GetRepository(x => x.Set<TypeOfLayoutStop>(), (TypeOfLayoutStop x) => x.Id); }
        }

        IRepository<RoadSign, int> ITsoddContextUnitOfWork.RoadSign {
            get { return GetRepository(x => x.Set<RoadSign>(), (RoadSign x) => x.Id); }
        }

        IRepository<TypeRoad, int> ITsoddContextUnitOfWork.TypeRoad {
            get { return GetRepository(x => x.Set<TypeRoad>(), (TypeRoad x) => x.Id); }
        }

        IRepository<StreetLight, int> ITsoddContextUnitOfWork.StreetLight {
            get { return GetRepository(x => x.Set<StreetLight>(), (StreetLight x) => x.Id); }
        }

        IRepository<TrafficLight, int> ITsoddContextUnitOfWork.TrafficLight {
            get { return GetRepository(x => x.Set<TrafficLight>(), (TrafficLight x) => x.Id); }
        }

        IRepository<TypeTrafficLight, int> ITsoddContextUnitOfWork.TypeTrafficLight {
            get { return GetRepository(x => x.Set<TypeTrafficLight>(), (TypeTrafficLight x) => x.Id); }
        }

        IRepository<VariantOfTrafficLightDesign, int> ITsoddContextUnitOfWork.VariantOfTrafficLightDesign {
            get { return GetRepository(x => x.Set<VariantOfTrafficLightDesign>(), (VariantOfTrafficLightDesign x) => x.Id); }
        }

        IRepository<Tsodd, int> ITsoddContextUnitOfWork.Tsodd {
            get { return GetRepository(x => x.Set<Tsodd>(), (Tsodd x) => x.Id); }
        }
    }
}
