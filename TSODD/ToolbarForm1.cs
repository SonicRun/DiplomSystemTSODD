using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.Entity;
using DevExpress.XtraEditors;
using TSODD.Entity;
using TSODD.Directory;
using TSODD.Entity.Fencing;
using TSODD.Views.AddressCollectionView;
using TSODD.Views.Address;

namespace TSODD
{
    public partial class ToolbarForm1 : DevExpress.XtraEditors.XtraForm
    {
        TSODD.TsoddContext dbContext = new TSODD.TsoddContext();
       
        public ToolbarForm1()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
         //   gridControl1.ContextMenu = true;
            repositoryItemLookUpEdit1.DataSource = dbContext.Address.ToDictionary(x=>x.Id, x=>x.ToString());
            repositoryItemLookUpEdit2.DataSource = dbContext.Photo.ToDictionary(x => x.Id, x => x.ToString());
            repositoryItemLookUpEdit3.DataSource = dbContext.ConditionOfTheObject.ToDictionary(x => x.Id, x => x.ToString());
            repositoryItemLookUpEdit4.DataSource = dbContext.GeographicalPosition.ToDictionary(x => x.Id, x => x.ToString());
            repositoryItemLookUpEdit5.DataSource = dbContext.FencingСlass.ToDictionary(x => x.Id, x => x.ToString());
            repositoryItemLookUpEdit6.DataSource = dbContext.TypeFencing.ToDictionary(x => x.Id, x => x.ToString());
            repositoryItemLookUpEdit7.DataSource = dbContext.GroupFencing.ToDictionary(x => x.Id, x => x.ToString());
            repositoryItemLookUpEdit8.DataSource = dbContext.SubgroupFencing.ToDictionary(x => x.Id, x => x.ToString());
           
            gridControl1.DataSource = dbContext.Fencing.ToList();
          
               gridControl2.DataSource = dbContext.TrafficLight.ToList();

               //gridControl3.DataSource = dbContext.RoadSign.ToList();

                 gridControl4.DataSource = dbContext.StreetLight.ToList();

               gridControl5.DataSource = dbContext.PublicTransportStop.ToList();
    
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            /*   XtraForm addAddressForm = new XtraForm();
               DialogResult result = addAddressForm.ShowDialog(this);

               if (result == DialogResult.Cancel)
                   return;

               Address address = new Address();
               */
            //   address.KmANDmetr = addAddressForm.t



        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void адресToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void справочникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Directory.Form form = new Directory.Form();
            form.ShowDialog();

        }
        //добавление
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int tabPage = tabControl1.SelectedIndex;

            switch (tabPage)
            {
                //барьерное ограждение
                case 0:
                    AddFencingForm addFencing = new AddFencingForm();
                    DialogResult result = addFencing.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;

                    Fencing fencing = new Fencing();

                    fencing.InstallationDate = addFencing.dateInstalation.DateTime;
                    fencing.LastInventoryDate = addFencing.dateInvetarization.DateTime;
                    fencing.DateOfLastService = addFencing.dateLastService.DateTime;
                    fencing.DateOfEntryInTheDatabase = addFencing.dateReadBD.DateTime;

                    Address newAddress = dbContext.Address.Single(x => x.Id == addFencing.Address.Id);
                    fencing.Addres = newAddress;

                    TypeTSODD typeTSODD = dbContext.TypeTSODD.Single(x => x.Id == addFencing.TypeTSODD.Id);
                    fencing.TypeTSODD = typeTSODD;

                    Photo photo = dbContext.Photo.Single(x => x.Id == addFencing.Photo.Id);
                    fencing.Photo = photo;

                    ConditionOfTheObject conditionOfTheObject = dbContext.ConditionOfTheObject.Single(x => x.Id == addFencing.ConditionOfTheObject.Id);
                    fencing.ConditionOfTheObject = conditionOfTheObject;

                    GeographicalPosition geographicalPosition = dbContext.GeographicalPosition.Single(x => x.Id == addFencing.GeographicalPosition.Id);
                    fencing.GeographicalPosition = geographicalPosition;

                    FencingСlass fencingСlass = dbContext.FencingСlass.Single(x => x.Id == addFencing.FencingСlass.Id);
                    fencing.FencingСlass = fencingСlass;

                    TypeFencing typeFenching = dbContext.TypeFencing.Single(x => x.Id == addFencing.TypeFencing.Id);
                    fencing.TypeFencing = typeFenching;

                    GroupFencing groupFencing = dbContext.GroupFencing.Single(x => x.Id == addFencing.GroupFencing.Id);
                    fencing.GroupFencing = groupFencing;

                    SubgroupFencing subgroupFencing = dbContext.SubgroupFencing.Single(x => x.Id == addFencing.SubgroupFencing.Id);
                    fencing.SubgroupFencing = subgroupFencing;
                    
                    fencing.Height = (float)addFencing.spinEditHight.Value;
                    fencing.RetentionRate= (float)addFencing.spinEditDJ.Value;
                    fencing.DeflectionFencing = (float)addFencing.spinEditProgib.Value;
                    
                    dbContext.Fencing.Add(fencing);
                    dbContext.SaveChanges();
                    this.Refresh();
                    gridControl1.Refresh();
                    MessageBox.Show("Новый объект добавлен");
                    gridControl1.Refresh();


                    break;
                case 2:

                    break;
            }
            
        }

        private void адресToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            XtraForm1 address = new XtraForm1();
            address.ShowDialog();
           
        }

        private void ToolbarForm1_Load(object sender, EventArgs e)
        {


        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           // gridControl1.PrintDialog();
            gridControl1.ShowPrintPreview();
        }
    }
}
 