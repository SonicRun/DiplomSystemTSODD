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
    /// Represents the GroupFencing collection view model.
    /// </summary>
    public partial class GroupFencingCollectionViewModel : CollectionViewModel<GroupFencing, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of GroupFencingCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static GroupFencingCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new GroupFencingCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the GroupFencingCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the GroupFencingCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected GroupFencingCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.GroupFencing) {
        }
    }
}