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
    /// Represents the single GroupFencing object view model.
    /// </summary>
    public partial class GroupFencingViewModel : SingleObjectViewModel<GroupFencing, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of GroupFencingViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static GroupFencingViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new GroupFencingViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the GroupFencingViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the GroupFencingViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected GroupFencingViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.GroupFencing, x => x.NameGroupFencing) {
                }



    }
}
