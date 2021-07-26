using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity;
using TSODD.Entity.Public_transport_stop;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the PublicTransportStop collection view model.
    /// </summary>
    public partial class PublicTransportStopCollectionViewModel : CollectionViewModel<PublicTransportStop, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PublicTransportStopCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PublicTransportStopCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PublicTransportStopCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PublicTransportStopCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PublicTransportStopCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PublicTransportStopCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PublicTransportStop) {
        }
    }
}