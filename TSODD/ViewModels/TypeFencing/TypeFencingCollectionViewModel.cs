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
    /// Represents the TypeFencing collection view model.
    /// </summary>
    public partial class TypeFencingCollectionViewModel : CollectionViewModel<TypeFencing, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TypeFencingCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TypeFencingCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TypeFencingCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TypeFencingCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TypeFencingCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TypeFencingCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.TypeFencing) {
        }
    }
}