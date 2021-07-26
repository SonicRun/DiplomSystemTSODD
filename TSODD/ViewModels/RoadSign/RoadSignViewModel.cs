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
using TSODD.Entity.Road_sign;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single RoadSign object view model.
    /// </summary>
    public partial class RoadSignViewModel : SingleObjectViewModel<RoadSign, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RoadSignViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RoadSignViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RoadSignViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RoadSignViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RoadSignViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RoadSignViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.RoadSign, x => x.TheHeightOfTheCapitalLetterOnTheSign) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Address for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Address> LookUpAddress {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RoadSignViewModel x) => x.LookUpAddress,
                    getRepositoryFunc: x => x.Address);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ConditionOfTheObject for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ConditionOfTheObject> LookUpConditionOfTheObject {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RoadSignViewModel x) => x.LookUpConditionOfTheObject,
                    getRepositoryFunc: x => x.ConditionOfTheObject);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of GeographicalPosition for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<GeographicalPosition> LookUpGeographicalPosition {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RoadSignViewModel x) => x.LookUpGeographicalPosition,
                    getRepositoryFunc: x => x.GeographicalPosition);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Photo for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Photo> LookUpPhoto {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RoadSignViewModel x) => x.LookUpPhoto,
                    getRepositoryFunc: x => x.Photo);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of TypeTSODD for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<TypeTSODD> LookUpTypeTSODD {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RoadSignViewModel x) => x.LookUpTypeTSODD,
                    getRepositoryFunc: x => x.TypeTSODD);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of FilmType for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<FilmType> LookUpFilmType {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RoadSignViewModel x) => x.LookUpFilmType,
                    getRepositoryFunc: x => x.FilmType);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of TypeRoad for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<TypeRoad> LookUpTypeRoad {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RoadSignViewModel x) => x.LookUpTypeRoad,
                    getRepositoryFunc: x => x.TypeRoad);
            }
        }

    }
}
