using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity.Public_transport_stop;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the DegreeOfCapacityStops collection view model.
    /// </summary>
    public partial class DegreeOfCapacityStopsCollectionViewModel : CollectionViewModel<DegreeOfCapacityStops, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DegreeOfCapacityStopsCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DegreeOfCapacityStopsCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DegreeOfCapacityStopsCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DegreeOfCapacityStopsCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DegreeOfCapacityStopsCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DegreeOfCapacityStopsCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.DegreeOfCapacityStops) {
        }
    }
}