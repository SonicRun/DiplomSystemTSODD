using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity;
using TSODD.Entity.Traffic_light;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the TrafficLight collection view model.
    /// </summary>
    public partial class TrafficLightCollectionViewModel : CollectionViewModel<TrafficLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TrafficLightCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TrafficLightCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TrafficLightCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TrafficLightCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TrafficLightCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TrafficLightCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.TrafficLight) {
        }
    }
}