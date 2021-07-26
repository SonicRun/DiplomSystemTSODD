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
using TSODD.Entity.Lamp;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single StreetLight object view model.
    /// </summary>
    public partial class StreetLightViewModel : SingleObjectViewModel<StreetLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of StreetLightViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StreetLightViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new StreetLightViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StreetLightViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StreetLightViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StreetLightViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.StreetLight, x => x.Height) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Address for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Address> LookUpAddress {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StreetLightViewModel x) => x.LookUpAddress,
                    getRepositoryFunc: x => x.Address);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ConditionOfTheObject for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ConditionOfTheObject> LookUpConditionOfTheObject {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StreetLightViewModel x) => x.LookUpConditionOfTheObject,
                    getRepositoryFunc: x => x.ConditionOfTheObject);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of GeographicalPosition for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<GeographicalPosition> LookUpGeographicalPosition {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StreetLightViewModel x) => x.LookUpGeographicalPosition,
                    getRepositoryFunc: x => x.GeographicalPosition);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Photo for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Photo> LookUpPhoto {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StreetLightViewModel x) => x.LookUpPhoto,
                    getRepositoryFunc: x => x.Photo);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of TypeTSODD for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<TypeTSODD> LookUpTypeTSODD {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StreetLightViewModel x) => x.LookUpTypeTSODD,
                    getRepositoryFunc: x => x.TypeTSODD);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of LampType for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<LampType> LookUpLampType {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StreetLightViewModel x) => x.LookUpLampType,
                    getRepositoryFunc: x => x.LampType);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of LightingСlass for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<LightingСlass> LookUpLightingСlass {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StreetLightViewModel x) => x.LookUpLightingСlass,
                    getRepositoryFunc: x => x.LightingСlass);
            }
        }

    }
}
