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
    /// Represents the single TypeTrafficLight object view model.
    /// </summary>
    public partial class TypeTrafficLightViewModel : SingleObjectViewModel<TypeTrafficLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TypeTrafficLightViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TypeTrafficLightViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TypeTrafficLightViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TypeTrafficLightViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TypeTrafficLightViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TypeTrafficLightViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.TypeTrafficLight, x => x.NameTypeTrafficLight) {
                }



    }
}
