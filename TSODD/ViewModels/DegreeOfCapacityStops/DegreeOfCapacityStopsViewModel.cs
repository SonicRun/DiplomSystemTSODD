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
using TSODD.Entity.Public_transport_stop;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single DegreeOfCapacityStops object view model.
    /// </summary>
    public partial class DegreeOfCapacityStopsViewModel : SingleObjectViewModel<DegreeOfCapacityStops, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of DegreeOfCapacityStopsViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static DegreeOfCapacityStopsViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new DegreeOfCapacityStopsViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the DegreeOfCapacityStopsViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the DegreeOfCapacityStopsViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected DegreeOfCapacityStopsViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.DegreeOfCapacityStops, x => x.NameDegreeOfCapacityStops) {
                }



    }
}
