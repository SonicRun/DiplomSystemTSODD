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
using TSODD.Entity.Traffic_light;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single ExecutionOfTheTrafficLight object view model.
    /// </summary>
    public partial class ExecutionOfTheTrafficLightViewModel : SingleObjectViewModel<ExecutionOfTheTrafficLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ExecutionOfTheTrafficLightViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ExecutionOfTheTrafficLightViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ExecutionOfTheTrafficLightViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ExecutionOfTheTrafficLightViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ExecutionOfTheTrafficLightViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ExecutionOfTheTrafficLightViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ExecutionOfTheTrafficLight, x => x.NameExecutionOfTheTrafficLight) {
                }



    }
}
