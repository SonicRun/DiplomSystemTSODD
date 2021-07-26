using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using TSODD.Entity;
using TSODD.Entity.Fencing;

namespace TSODD
{
    public partial class AddFencingForm : DevExpress.XtraEditors.XtraForm
    {
        TsoddContext dbContext = new TsoddContext();
        public AddFencingForm()
        {
            InitializeComponent();


            gridLookAddres.Properties.DataSource = dbContext.Address.ToList();
          
                gridLookTypeTSODD.Properties.DataSource = dbContext.TypeTSODD.ToList();


            gridLookPhoto.Properties.DataSource = dbContext.Photo.ToList();


            gridLookState.Properties.DataSource = dbContext.ConditionOfTheObject.ToList();



            gridLookGeogPosition.Properties.DataSource = dbContext.GeographicalPosition.ToList();

            gridLookClassFenching.Properties.DataSource = dbContext.FencingСlass.ToList();

            gridLookTypeFenching.Properties.DataSource = dbContext.TypeFencing.ToList();


            gridLookGroupFenching.Properties.DataSource = dbContext.GroupFencing.ToList();

            gridLookSubGroupFenching.Properties.DataSource = dbContext.SubgroupFencing.ToList();


        }

        private void AddFencingForm_Load(object sender, EventArgs e)
        {

        }

        public Address Address { get {

                var id = (int)gridLookAddres.EditValue;
                return ((List<Address>)gridLookAddres.Properties.DataSource).FirstOrDefault(x => x.Id == id);
                 }
        }
        public TypeTSODD TypeTSODD
        {
            get
            {

                var id = (int)gridLookTypeTSODD.EditValue;
                return ((List<TypeTSODD>)gridLookTypeTSODD.Properties.DataSource).FirstOrDefault(x => x.Id == id);
            }
        }
        public Photo Photo
        {
            get
            {

                var id = (int)gridLookPhoto.EditValue;
                return ((List<Photo>)gridLookPhoto.Properties.DataSource).FirstOrDefault(x => x.Id == id);
            }
        }
        public ConditionOfTheObject ConditionOfTheObject
        {
            get
            {

                var id = (int)gridLookState.EditValue;
                return ((List<ConditionOfTheObject>)gridLookState.Properties.DataSource).FirstOrDefault(x => x.Id == id);
            }
        }
        public GeographicalPosition GeographicalPosition
        {
            get
            {

                var id = (int)gridLookGeogPosition.EditValue;
                return ((List<GeographicalPosition>)gridLookGeogPosition.Properties.DataSource).FirstOrDefault(x => x.Id == id);
            }
        }
        public FencingСlass FencingСlass
        {
            get
            {

                var id = (int)gridLookClassFenching.EditValue;
                return ((List<FencingСlass>)gridLookClassFenching.Properties.DataSource).FirstOrDefault(x => x.Id == id);
            }
        }
        public TypeFencing TypeFencing
        {
            get
            {

                var id = (int)gridLookTypeFenching.EditValue;
                return ((List<TypeFencing>)gridLookTypeFenching.Properties.DataSource).FirstOrDefault(x => x.Id == id);
            }
        }
        
        public GroupFencing GroupFencing
        {
            get
            {

                var id = (int)gridLookGroupFenching.EditValue;
                return ((List<GroupFencing>)gridLookGroupFenching.Properties.DataSource).FirstOrDefault(x => x.Id == id);
            }
        }
        public SubgroupFencing SubgroupFencing
        {
            get
            {

                var id = (int)gridLookSubGroupFenching.EditValue;
                return ((List<SubgroupFencing>)gridLookSubGroupFenching.Properties.DataSource).FirstOrDefault(x => x.Id == id);
            }
        }
    }
}