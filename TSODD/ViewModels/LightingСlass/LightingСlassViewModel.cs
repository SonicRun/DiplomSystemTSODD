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
    /// Represents the single LightingСlass object view model.
    /// </summary>
    public partial class LightingСlassViewModel : SingleObjectViewModel<LightingСlass, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of LightingСlassViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static LightingСlassViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new LightingСlassViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the LightingСlassViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the LightingСlassViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected LightingСlassViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.LightingСlass, x => x.NameLightingСlass) {
                }



    }
}
