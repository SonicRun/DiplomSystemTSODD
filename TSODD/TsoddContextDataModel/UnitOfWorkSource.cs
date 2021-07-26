using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections;
using System.Linq;
using TSODD;

namespace TSODD.TsoddContextDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<ITsoddContextUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<ITsoddContextUnitOfWork>(() => new TsoddContextUnitOfWork(() => new TsoddContext()));
        }
    }
}