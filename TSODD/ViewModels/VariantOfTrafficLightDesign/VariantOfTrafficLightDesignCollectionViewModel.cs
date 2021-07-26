using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity.Traffic_light;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the VariantOfTrafficLightDesign collection view model.
    /// </summary>
    public partial class VariantOfTrafficLightDesignCollectionViewModel : CollectionViewModel<VariantOfTrafficLightDesign, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of VariantOfTrafficLightDesignCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static VariantOfTrafficLightDesignCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new VariantOfTrafficLightDesignCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the VariantOfTrafficLightDesignCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the VariantOfTrafficLightDesignCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected VariantOfTrafficLightDesignCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.VariantOfTrafficLightDesign) {
        }
    }
}