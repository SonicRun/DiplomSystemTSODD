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
    /// Represents the single GroupTrafficLight object view model.
    /// </summary>
    public partial class GroupTrafficLightViewModel : SingleObjectViewModel<GroupTrafficLight, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of GroupTrafficLightViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static GroupTrafficLightViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new GroupTrafficLightViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the GroupTrafficLightViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the GroupTrafficLightViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected GroupTrafficLightViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.GroupTrafficLight, x => x.NameGroupTrafficLight) {
                }



    }
}
