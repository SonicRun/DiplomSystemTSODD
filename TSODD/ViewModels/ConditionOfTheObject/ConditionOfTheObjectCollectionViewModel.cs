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
    /// Represents the ConditionOfTheObject collection view model.
    /// </summary>
    public partial class ConditionOfTheObjectCollectionViewModel : CollectionViewModel<ConditionOfTheObject, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ConditionOfTheObjectCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ConditionOfTheObjectCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ConditionOfTheObjectCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ConditionOfTheObjectCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ConditionOfTheObjectCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ConditionOfTheObjectCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ConditionOfTheObject) {
        }
    }
}