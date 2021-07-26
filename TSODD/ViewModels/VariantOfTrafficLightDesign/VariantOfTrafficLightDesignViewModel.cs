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
    /// Represents the single VariantOfTrafficLightDesign object view model.
    /// </summary>
    public partial class VariantOfTrafficLightDesignViewModel : SingleObjectViewModel<VariantOfTrafficLightDesign, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VariantOfTrafficLightDesignViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VariantOfTrafficLightDesignViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VariantOfTrafficLightDesignViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VariantOfTrafficLightDesignViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VariantOfTrafficLightDesignViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VariantOfTrafficLightDesignViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.VariantOfTrafficLightDesign, x => x.NumberVariantOfTrafficLightDesign) {
                }



    }
}
