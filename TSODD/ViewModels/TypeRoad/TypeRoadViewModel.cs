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
using TSODD.Entity.Road_sign;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single TypeRoad object view model.
    /// </summary>
    public partial class TypeRoadViewModel : SingleObjectViewModel<TypeRoad, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TypeRoadViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TypeRoadViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TypeRoadViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TypeRoadViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TypeRoadViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TypeRoadViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.TypeRoad, x => x.NameRoad) {
                }



    }
}
