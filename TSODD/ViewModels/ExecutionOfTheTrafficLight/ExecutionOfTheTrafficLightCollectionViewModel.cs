using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity.Traffic_light;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the ExecutionOfTheTrafficLight collection view model.
    /// </summary>
    public partial class ExecutionOfTheTrafficLightCollectionViewModel : CollectionViewModel<ExecutionOfTheTrafficLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ExecutionOfTheTrafficLightCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ExecutionOfTheTrafficLightCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ExecutionOfTheTrafficLightCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ExecutionOfTheTrafficLightCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ExecutionOfTheTrafficLightCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ExecutionOfTheTrafficLightCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ExecutionOfTheTrafficLight) {
        }
    }
}