using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;

namespace TSODD.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the TsoddContext data model.
    /// </summary>
    public partial class TsoddContextViewModel : DocumentsViewModel<TsoddContextModuleDescription, ITsoddContextUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of TsoddContextViewModel as a POCO view model.
        /// </summary>
        public static TsoddContextViewModel Create() {
            return ViewModelSource.Create(() => new TsoddContextViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the TsoddContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TsoddContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected TsoddContextViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override TsoddContextModuleDescription[] CreateModules() {
			return new TsoddContextModuleDescription[] {
                new TsoddContextModuleDescription( "Fencing", "FencingCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Fencing)),
                new TsoddContextModuleDescription( "Public Transport Stop", "PublicTransportStopCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PublicTransportStop)),
                new TsoddContextModuleDescription( "Road Sign", "RoadSignCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.RoadSign)),
                new TsoddContextModuleDescription( "Street Light", "StreetLightCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.StreetLight)),
                new TsoddContextModuleDescription( "Traffic Light", "TrafficLightCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.TrafficLight)),
			};
        }
                		protected override void OnActiveModuleChanged(TsoddContextModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class TsoddContextModuleDescription : ModuleDescription<TsoddContextModuleDescription> {
        public TsoddContextModuleDescription(string title, string documentType, string group, Func<TsoddContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}