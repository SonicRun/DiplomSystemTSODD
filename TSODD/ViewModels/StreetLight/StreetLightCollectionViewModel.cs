using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity;
using TSODD.Entity.Lamp;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the StreetLight collection view model.
    /// </summary>
    public partial class StreetLightCollectionViewModel : CollectionViewModel<StreetLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of StreetLightCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StreetLightCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new StreetLightCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StreetLightCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StreetLightCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StreetLightCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.StreetLight) {
        }
    }
}