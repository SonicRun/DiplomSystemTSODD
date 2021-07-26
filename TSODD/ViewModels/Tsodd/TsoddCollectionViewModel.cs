using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the Tsodd collection view model.
    /// </summary>
    public partial class TsoddCollectionViewModel : CollectionViewModel<Tsodd, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TsoddCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TsoddCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TsoddCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TsoddCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TsoddCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TsoddCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Tsodd) {
        }
    }
}