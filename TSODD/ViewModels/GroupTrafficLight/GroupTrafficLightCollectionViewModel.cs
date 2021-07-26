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
    /// Represents the GroupTrafficLight collection view model.
    /// </summary>
    public partial class GroupTrafficLightCollectionViewModel : CollectionViewModel<GroupTrafficLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of GroupTrafficLightCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static GroupTrafficLightCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new GroupTrafficLightCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the GroupTrafficLightCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the GroupTrafficLightCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected GroupTrafficLightCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.GroupTrafficLight) {
        }
    }
}