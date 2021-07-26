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
using TSODD.Entity.Lamp;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single LampType object view model.
    /// </summary>
    public partial class LampTypeViewModel : SingleObjectViewModel<LampType, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of LampTypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static LampTypeViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new LampTypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the LampTypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the LampTypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected LampTypeViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.LampType, x => x.LampPower) {
                }



    }
}
