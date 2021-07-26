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
using TSODD.Entity.Fencing;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single SubgroupFencing object view model.
    /// </summary>
    public partial class SubgroupFencingViewModel : SingleObjectViewModel<SubgroupFencing, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SubgroupFencingViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SubgroupFencingViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SubgroupFencingViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SubgroupFencingViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SubgroupFencingViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SubgroupFencingViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SubgroupFencing, x => x.NameSubgroupFencing) {
                }



    }
}
