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
    /// Represents the single FencingСlass object view model.
    /// </summary>
    public partial class FencingСlassViewModel : SingleObjectViewModel<FencingСlass, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FencingСlassViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FencingСlassViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FencingСlassViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FencingСlassViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FencingСlassViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FencingСlassViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.FencingСlass, x => x.NameFencingClass) {
                }



    }
}
