using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity;
using TSODD.Entity.Public_transport_stop;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single PublicTransportStop object view model.
    /// </summary>
    public partial class PublicTransportStopViewModel : SingleObjectViewModel<PublicTransportStop, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PublicTransportStopViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PublicTransportStopViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PublicTransportStopViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PublicTransportStopViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PublicTransportStopViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PublicTransportStopViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PublicTransportStop, x => x.MaterialName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Address for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Address> LookUpAddress {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PublicTransportStopViewModel x) => x.LookUpAddress,
                    getRepositoryFunc: x => x.Address);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ConditionOfTheObject for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ConditionOfTheObject> LookUpConditionOfTheObject {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PublicTransportStopViewModel x) => x.LookUpConditionOfTheObject,
                    getRepositoryFunc: x => x.ConditionOfTheObject);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of GeographicalPosition for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<GeographicalPosition> LookUpGeographicalPosition {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PublicTransportStopViewModel x) => x.LookUpGeographicalPosition,
                    getRepositoryFunc: x => x.GeographicalPosition);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Photo for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Photo> LookUpPhoto {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PublicTransportStopViewModel x) => x.LookUpPhoto,
                    getRepositoryFunc: x => x.Photo);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of TypeTSODD for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<TypeTSODD> LookUpTypeTSODD {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PublicTransportStopViewModel x) => x.LookUpTypeTSODD,
                    getRepositoryFunc: x => x.TypeTSODD);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of DegreeOfCapacityStops for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<DegreeOfCapacityStops> LookUpDegreeOfCapacityStops {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PublicTransportStopViewModel x) => x.LookUpDegreeOfCapacityStops,
                    getRepositoryFunc: x => x.DegreeOfCapacityStops);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of TypeOfLayoutStop for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<TypeOfLayoutStop> LookUpTypeOfLayoutStop {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PublicTransportStopViewModel x) => x.LookUpTypeOfLayoutStop,
                    getRepositoryFunc: x => x.TypeOfLayoutStop);
            }
        }

    }
}
