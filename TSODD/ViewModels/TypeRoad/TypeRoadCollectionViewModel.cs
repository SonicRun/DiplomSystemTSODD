using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity.Road_sign;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the TypeRoad collection view model.
    /// </summary>
    public partial class TypeRoadCollectionViewModel : CollectionViewModel<TypeRoad, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TypeRoadCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TypeRoadCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TypeRoadCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TypeRoadCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TypeRoadCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TypeRoadCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.TypeRoad) {
        }
    }
}