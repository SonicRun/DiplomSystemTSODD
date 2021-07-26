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
using TSODD.Entity.Fencing;

namespace TSODD.ViewModels {

using Fencing = TSODD.Entity.Fencing.Fencing;
    /// <summary>
    /// Represents the single Fencing object view model.
    /// </summary>
    public partial class FencingViewModel : SingleObjectViewModel<Fencing, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FencingViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FencingViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FencingViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FencingViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FencingViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FencingViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Fencing, x => x.Height) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Address for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Address> LookUpAddress {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FencingViewModel x) => x.LookUpAddress,
                    getRepositoryFunc: x => x.Address);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ConditionOfTheObject for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ConditionOfTheObject> LookUpConditionOfTheObject {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FencingViewModel x) => x.LookUpConditionOfTheObject,
                    getRepositoryFunc: x => x.ConditionOfTheObject);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of GeographicalPosition for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<GeographicalPosition> LookUpGeographicalPosition {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FencingViewModel x) => x.LookUpGeographicalPosition,
                    getRepositoryFunc: x => x.GeographicalPosition);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Photo for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Photo> LookUpPhoto {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FencingViewModel x) => x.LookUpPhoto,
                    getRepositoryFunc: x => x.Photo);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of TypeTSODD for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<TypeTSODD> LookUpTypeTSODD {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FencingViewModel x) => x.LookUpTypeTSODD,
                    getRepositoryFunc: x => x.TypeTSODD);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of FencingСlass for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<FencingСlass> LookUpFencingСlass {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FencingViewModel x) => x.LookUpFencingСlass,
                    getRepositoryFunc: x => x.FencingСlass);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of GroupFencing for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<GroupFencing> LookUpGroupFencing {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FencingViewModel x) => x.LookUpGroupFencing,
                    getRepositoryFunc: x => x.GroupFencing);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of SubgroupFencing for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<SubgroupFencing> LookUpSubgroupFencing {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FencingViewModel x) => x.LookUpSubgroupFencing,
                    getRepositoryFunc: x => x.SubgroupFencing);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of TypeFencing for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<TypeFencing> LookUpTypeFencing {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FencingViewModel x) => x.LookUpTypeFencing,
                    getRepositoryFunc: x => x.TypeFencing);
            }
        }

    }
}
