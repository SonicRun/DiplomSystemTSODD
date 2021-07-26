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
    /// Represents the TypeTrafficLight collection view model.
    /// </summary>
    public partial class TypeTrafficLightCollectionViewModel : CollectionViewModel<TypeTrafficLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TypeTrafficLightCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TypeTrafficLightCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TypeTrafficLightCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TypeTrafficLightCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TypeTrafficLightCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TypeTrafficLightCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.TypeTrafficLight) {
        }
    }
}