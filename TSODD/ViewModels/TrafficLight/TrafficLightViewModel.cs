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
using TSODD.Entity.Traffic_light;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single TrafficLight object view model.
    /// </summary>
    public partial class TrafficLightViewModel : SingleObjectViewModel<TrafficLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TrafficLightViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TrafficLightViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TrafficLightViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TrafficLightViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TrafficLightViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TrafficLightViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.TrafficLight, x => x.InstallationDate) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Address for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Address> LookUpAddress {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TrafficLightViewModel x) => x.LookUpAddress,
                    getRepositoryFunc: x => x.Address);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ConditionOfTheObject for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ConditionOfTheObject> LookUpConditionOfTheObject {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TrafficLightViewModel x) => x.LookUpConditionOfTheObject,
                    getRepositoryFunc: x => x.ConditionOfTheObject);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of GeographicalPosition for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<GeographicalPosition> LookUpGeographicalPosition {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TrafficLightViewModel x) => x.LookUpGeographicalPosition,
                    getRepositoryFunc: x => x.GeographicalPosition);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Photo for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Photo> LookUpPhoto {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TrafficLightViewModel x) => x.LookUpPhoto,
                    getRepositoryFunc: x => x.Photo);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of TypeTSODD for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<TypeTSODD> LookUpTypeTSODD {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TrafficLightViewModel x) => x.LookUpTypeTSODD,
                    getRepositoryFunc: x => x.TypeTSODD);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ExecutionOfTheTrafficLight for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ExecutionOfTheTrafficLight> LookUpExecutionOfTheTrafficLight {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TrafficLightViewModel x) => x.LookUpExecutionOfTheTrafficLight,
                    getRepositoryFunc: x => x.ExecutionOfTheTrafficLight);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of GroupTrafficLight for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<GroupTrafficLight> LookUpGroupTrafficLight {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TrafficLightViewModel x) => x.LookUpGroupTrafficLight,
                    getRepositoryFunc: x => x.GroupTrafficLight);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of TypeTrafficLight for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<TypeTrafficLight> LookUpTypeTrafficLight {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TrafficLightViewModel x) => x.LookUpTypeTrafficLight,
                    getRepositoryFunc: x => x.TypeTrafficLight);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of VariantOfTrafficLightDesign for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<VariantOfTrafficLightDesign> LookUpVariantOfTrafficLightDesign {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TrafficLightViewModel x) => x.LookUpVariantOfTrafficLightDesign,
                    getRepositoryFunc: x => x.VariantOfTrafficLightDesign);
            }
        }

    }
}
