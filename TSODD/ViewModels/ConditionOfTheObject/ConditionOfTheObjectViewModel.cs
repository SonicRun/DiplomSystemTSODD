using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single ConditionOfTheObject object view model.
    /// </summary>
    public partial class ConditionOfTheObjectViewModel : SingleObjectViewModel<ConditionOfTheObject, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ConditionOfTheObjectViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ConditionOfTheObjectViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ConditionOfTheObjectViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ConditionOfTheObjectViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ConditionOfTheObjectViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ConditionOfTheObjectViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ConditionOfTheObject, x => x.ConditionOfTheObjectName) {
                }



    }
}
