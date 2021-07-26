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
using TSODD.Entity;

namespace TSODD.ViewModels {

    /// <summary>
    /// Represents the single TypeTSODD object view model.
    /// </summary>
    public partial class TypeTSODDViewModel : SingleObjectViewModel<TypeTSODD, int, ITsoddContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TypeTSODDViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TypeTSODDViewModel Create(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TypeTSODDViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TypeTSODDViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TypeTSODDViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TypeTSODDViewModel(IUnitOfWorkFactory<ITsoddContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.TypeTSODD, x => x.NameTypeTDSDD) {
                }



    }
}
