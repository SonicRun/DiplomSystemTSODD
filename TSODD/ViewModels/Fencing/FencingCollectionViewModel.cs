using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity;
using TSODD.Entity.Fencing;

namespace TSODD.ViewModels {

using Fencing = TSODD.Entity.Fencing.Fencing;
    /// <summary>
    /// Represents the Fencing collection view model.
    /// </summary>
    public partial class FencingCollectionViewModel : CollectionViewModel<Fencing, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FencingCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FencingCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FencingCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FencingCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FencingCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FencingCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Fencing) {
        }
    }
}