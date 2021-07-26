using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity.Fencing;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the SubgroupFencing collection view model.
    /// </summary>
    public partial class SubgroupFencingCollectionViewModel : CollectionViewModel<SubgroupFencing, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SubgroupFencingCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SubgroupFencingCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SubgroupFencingCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SubgroupFencingCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SubgroupFencingCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SubgroupFencingCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SubgroupFencing) {
        }
    }
}