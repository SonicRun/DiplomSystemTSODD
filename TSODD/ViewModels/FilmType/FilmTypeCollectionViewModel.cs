using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TSODD.TsoddContextDataModel;
using TSODD.Common;
using TSODD.Entity.Road_sign;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the FilmType collection view model.
    /// </summary>
    public partial class FilmTypeCollectionViewModel : CollectionViewModel<FilmType, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FilmTypeCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FilmTypeCollectionViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FilmTypeCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FilmTypeCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FilmTypeCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FilmTypeCollectionViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.FilmType) {
        }
    }
}