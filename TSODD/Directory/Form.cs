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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using TSODD.Entity.Fencing;
using TSODD.Entity.Road_sign;
using TSODD.Entity.Traffic_light;
using TSODD.Entity.Lamp;
using TSODD.Entity.Public_transport_stop;

namespace TSODD.Directory
{
    public partial class Form : DevExpress.XtraEditors.XtraForm
    {
        TSODD.TsoddContext dbContext = new TSODD.TsoddContext();
        public Form()
        {
            InitializeComponent();

           
        }
       
      
        //добавление
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            int tabPage = tabControl1.SelectedIndex;

            switch (tabPage)
            {
                //адрес
               case 0:
                    AddAddressForm addAddress = new AddAddressForm();
                    DialogResult result = addAddress.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    Address address = new Address();

                    address.NameStreetOrRoad = addAddress.textNameRoad.Text;
                    address.KmANDmetr = (float)addAddress.textKMandMetr.Value;
                    address.ReferencePoint = addAddress.textReferencePoint.Text;

                    dbContext.Address.Add(address);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                    //состояние
                case 1:
                    AddSostForm addSostForm = new AddSostForm();
                    DialogResult result1 = addSostForm.ShowDialog(this);

                    if (result1 == DialogResult.Cancel)
                        return;

                    ConditionOfTheObject condition = new ConditionOfTheObject();

                    condition.ConditionOfTheObjectName = addSostForm.textEdit1.Text;

                    dbContext.ConditionOfTheObject.Add(condition);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;

                case 2:
                    AddTypeTSODDForm addTypeTSODDForm = new AddTypeTSODDForm();
                    DialogResult result2 = addTypeTSODDForm.ShowDialog(this);

                    if (result2 == DialogResult.Cancel)
                        return;

                    TypeTSODD typeTSODD = new TypeTSODD();

                    typeTSODD.NameTypeTDSDD = addTypeTSODDForm.textEdit1.Text;

                    dbContext.TypeTSODD.Add(typeTSODD);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                    //Географическое положение
                case 3:
                    AddGeogPositionForm addGeogPositionForm = new AddGeogPositionForm();
                    DialogResult result3 = addGeogPositionForm.ShowDialog(this);

                    if (result3 == DialogResult.Cancel)
                        return;


                    GeographicalPosition geographicalPosition = new GeographicalPosition();

                    geographicalPosition.Latitude = (float)addGeogPositionForm.textLing.Value;
                    geographicalPosition.Longitude = (float)addGeogPositionForm.textLong.Value;

                    dbContext.GeographicalPosition.Add(geographicalPosition);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                    //фото
                case 4:

                    AddPhotoForm addPhotoForm = new AddPhotoForm();
                    DialogResult result4 = addPhotoForm.ShowDialog(this);

                    if (result4 == DialogResult.Cancel)
                        return;

                    Photo photo = new Photo();
                    photo.ThePathToTheFile = addPhotoForm.textPath.Text;
                    photo.Description = addPhotoForm.textDescription.Text;
                    photo.DataTimeShooting = addPhotoForm.dateEdit1.DateTime;
                    

                    dbContext.Photo.Add(photo);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                    //класс ограждения
                case 5:
                    AddFenchingClassForm addFenchingClass = new AddFenchingClassForm();
                    DialogResult result5 = addFenchingClass.ShowDialog(this);

                    if (result5 == DialogResult.Cancel)
                        return;

                    FencingСlass fencing = new FencingСlass();

                    fencing.NameFencingClass = addFenchingClass.textEdit1.Text;

                    
                    dbContext.FencingСlass.Add(fencing);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                    //тип ограждения
                case 6:
                    AddTypeOfFenchingForm addTypeOfFenching = new AddTypeOfFenchingForm();
                    
                    DialogResult result6 = addTypeOfFenching.ShowDialog(this);

                    if (result6 == DialogResult.Cancel)
                        return;

                    TypeFencing typeFencing = new TypeFencing();

                    typeFencing.NameTypeFencing = addTypeOfFenching.textEdit1.Text;
                    dbContext.TypeFencing.Add(typeFencing);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                    //группа ограждения
                case 7:

                    AddGroupFenchingForm addGroupFenching = new AddGroupFenchingForm();

                    DialogResult result7 = addGroupFenching.ShowDialog(this);

                    if (result7 == DialogResult.Cancel)
                        return;
                    GroupFencing groupFencing = new GroupFencing();

                    groupFencing.NameGroupFencing = addGroupFenching.textEdit1.Text;

                    dbContext.GroupFencing.Add(groupFencing);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                    //подгруппа ограждения
                case 8:
                    AddSubgroupGenchingForm addSubgroupGenching = new AddSubgroupGenchingForm();

                    DialogResult result8 = addSubgroupGenching.ShowDialog(this);

                    if (result8 == DialogResult.Cancel)
                        return;

                    SubgroupFencing subgroupFencing = new SubgroupFencing();

                    subgroupFencing.NameSubgroupFencing = (int)addSubgroupGenching.textEdit1.Value;

                    dbContext.SubgroupFencing.Add(subgroupFencing);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;

                case 9:
                   
                    AddTypeRoadForm addTypeRoad = new AddTypeRoadForm();
                    DialogResult result9 = addTypeRoad.ShowDialog(this);

                    if (result9 == DialogResult.Cancel)
                        return;
                    TypeRoad typeRoad = new TypeRoad();

                    typeRoad.NameRoad = addTypeRoad.textNameRoad.Text;
                    typeRoad.NumberAccordingToGOST = (float)addTypeRoad.popupGOST.Value;

                   
                    dbContext.TypeRoad.Add(typeRoad);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case 10:
                    AddFilmTypeForm addFilmType = new AddFilmTypeForm();
                    
                    DialogResult result10 = addFilmType.ShowDialog(this);

                    if (result10 == DialogResult.Cancel)
                        return;

                    FilmType filmType = new FilmType();
                    filmType.NameFilm = addFilmType.textEdit1.Text;


                    dbContext.FilmType.Add(filmType);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;

                case 11:
                   
                    AddGroupTrafficLightForm addGroupTrafficLight = new AddGroupTrafficLightForm();
                    DialogResult result11 = addGroupTrafficLight.ShowDialog(this);

                    if (result11 == DialogResult.Cancel)
                        return;

                    GroupTrafficLight groupTraffic = new GroupTrafficLight();

                    groupTraffic.NameGroupTrafficLight = addGroupTrafficLight.textEdit1.Text;
                  


                    dbContext.GroupTrafficLight.Add(groupTraffic);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case 12:
                    AddTypeTrafficLightForm addTypeTrafficLight = new AddTypeTrafficLightForm();

                    DialogResult result12 = addTypeTrafficLight.ShowDialog(this);

                    if (result12 == DialogResult.Cancel)
                        return;


                    TypeTrafficLight typeTrafficLight = new TypeTrafficLight();

                    typeTrafficLight.NameTypeTrafficLight = addTypeTrafficLight.textEdit1.Text;
                                       
                    dbContext.TypeTrafficLight.Add(typeTrafficLight);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case 13:
                    AddExecutionOfTheTrafficLightForm addExecutionOfTheTrafficLight = new AddExecutionOfTheTrafficLightForm();

                    DialogResult result13 = addExecutionOfTheTrafficLight.ShowDialog(this);

                    if (result13 == DialogResult.Cancel)
                        return;

                    ExecutionOfTheTrafficLight executionOfTheTrafficLight = new ExecutionOfTheTrafficLight();

                    executionOfTheTrafficLight.NameExecutionOfTheTrafficLight = addExecutionOfTheTrafficLight.textEdit1.Text;

                   
                    dbContext.ExecutionOfTheTrafficLight.Add(executionOfTheTrafficLight);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case 14:
                     AddVariantOfTrafficLightDesignForm addVariantOfTrafficLightDesign = new AddVariantOfTrafficLightDesignForm();
                    DialogResult result14 = addVariantOfTrafficLightDesign.ShowDialog(this);

                    if (result14 == DialogResult.Cancel)
                        return;
                    VariantOfTrafficLightDesign variantOfTrafficLightDesign = new VariantOfTrafficLightDesign();
                    variantOfTrafficLightDesign.NumberVariantOfTrafficLightDesign = (float)addVariantOfTrafficLightDesign.Number.Value;
                  
                    dbContext.VariantOfTrafficLightDesign.Add(variantOfTrafficLightDesign);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;

                //тип лампы
                case 15:
                    AddLampTypeForm addLampType = new AddLampTypeForm();
                    DialogResult result15 = addLampType.ShowDialog(this);

                    if (result15 == DialogResult.Cancel)
                        return;
                    LampType lampType = new LampType();

                    lampType.LampPower = (float)addLampType.Power.Value;
                    lampType.LightFlow = (float)addLampType.Flow.Value;
                   

                    dbContext.LampType.Add(lampType);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                    //класс объекта по освещению
                case 16:
                    AddLightingСlassForm addLightingСlass = new AddLightingСlassForm();
                  
                    DialogResult result16 = addLightingСlass.ShowDialog(this);

                    if (result16 == DialogResult.Cancel)
                        return;

                    LightingСlass lightingСlass = new LightingСlass();
                    lightingСlass.NameLightingСlass = addLightingСlass.textEdit1.Text;



                    dbContext.LightingСlass.Add(lightingСlass);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                    //Тип коспановки остановки
                case 17:
                    AddTypeOfLayoutStopForm addTypeOfLayout = new AddTypeOfLayoutStopForm();
                    DialogResult result17 = addTypeOfLayout.ShowDialog(this);

                    if (result17 == DialogResult.Cancel)
                        return;
                    TypeOfLayoutStop typeOfLoyoutStop = new TypeOfLayoutStop();

                    typeOfLoyoutStop.NameTypeOfLayoutStop = addTypeOfLayout.textEdit1.Text;

                    dbContext.TypeOfLayoutStop.Add(typeOfLoyoutStop);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;
                case 18:
                    AddDegreeOfCapacityStopsForm addDegreeOfCapacity = new AddDegreeOfCapacityStopsForm();
                   

                    DialogResult result18 = addDegreeOfCapacity.ShowDialog(this);

                    if (result18 == DialogResult.Cancel)
                        return;
                    DegreeOfCapacityStops degreeOfCapacityStops = new DegreeOfCapacityStops();
                    degreeOfCapacityStops.NameDegreeOfCapacityStops = addDegreeOfCapacity.textEdit1.Text;             


                    dbContext.DegreeOfCapacityStops.Add(degreeOfCapacityStops);
                    dbContext.SaveChanges();
                    MessageBox.Show("Новый объект добавлен");
                    break;

            }           

         

        }
        //редактирование
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int tabPage1 = tabControl1.SelectedIndex;

            switch (tabPage1)
            {
                //адрес
                case 0:
                    var addresses = gridControl1.DataSource as List<Address>;
                    var id = (int)gridView1.GetFocusedRowCellValue("Id");
                    var currentAddress = addresses.Single(x => x.Id == id);

                    AddAddressForm addAddress = new AddAddressForm();

                    addAddress.textNameRoad.Text = currentAddress.NameStreetOrRoad;
                    addAddress.textKMandMetr.Value = Convert.ToDecimal(currentAddress.KmANDmetr);
                    addAddress.textReferencePoint.Text = currentAddress.ReferencePoint;

                    DialogResult result = addAddress.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;
                    currentAddress.NameStreetOrRoad = addAddress.textNameRoad.Text;
                    currentAddress.KmANDmetr = (float)addAddress.textKMandMetr.Value;
                    currentAddress.ReferencePoint = addAddress.textReferencePoint.Text;


                    dbContext.SaveChanges();
                    gridControl1.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");
                    break;

                //cостояния
                case 1:
                    var condition = gridControl2.DataSource as List<ConditionOfTheObject>;
                    var id1 = (int)gridView2.GetFocusedRowCellValue("Id");
                    var currentCondition = condition.Single(x => x.Id == id1);


                    AddSostForm addSostForm = new AddSostForm();

                    addSostForm.textEdit1.Text = currentCondition.ConditionOfTheObjectName;
                    DialogResult result1 = addSostForm.ShowDialog(this);

                    if (result1 == DialogResult.Cancel)
                        return;
                    currentCondition.ConditionOfTheObjectName = addSostForm.textEdit1.Text;


                    dbContext.SaveChanges();
                    gridControl2.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");
                    break;
                //Тип ТСОДД
                case 2:
                    var typeTsodd = gridControl3.DataSource as List<TypeTSODD>;
                    var id2 = (int)gridView3.GetFocusedRowCellValue("Id");
                    var currentTypeTSODD = typeTsodd.Single(x => x.Id == id2);

                    AddTypeTSODDForm addTypeTSODDForm = new AddTypeTSODDForm();

                    addTypeTSODDForm.textEdit1.Text = currentTypeTSODD.NameTypeTDSDD;
                    DialogResult result2 = addTypeTSODDForm.ShowDialog(this);

                    if (result2 == DialogResult.Cancel)
                        return;

                    currentTypeTSODD.NameTypeTDSDD = addTypeTSODDForm.textEdit1.Text;


                    dbContext.SaveChanges();
                    gridControl3.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");
                    break;
                //географическое положение
                case 3:
                    var geogPosition = gridControl4.DataSource as List<GeographicalPosition>;
                    var id3 = (int)gridView4.GetFocusedRowCellValue("Id");
                    var currentGeogPosition = geogPosition.Single(x => x.Id == id3);

                    AddGeogPositionForm addGeogPositionForm = new AddGeogPositionForm();

                    addGeogPositionForm.textLong.Value = (decimal)currentGeogPosition.Longitude;
                    addGeogPositionForm.textLing.Value = (decimal)currentGeogPosition.Latitude;

                    DialogResult result3 = addGeogPositionForm.ShowDialog(this);

                    if (result3 == DialogResult.Cancel)
                        return;

                    currentGeogPosition.Latitude = (float)addGeogPositionForm.textLing.Value;
                    currentGeogPosition.Longitude = (float)addGeogPositionForm.textLong.Value;



                    dbContext.SaveChanges();
                    gridControl4.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");
                    break;
                //фотография
                case 4:
                    var photo = gridControl5.DataSource as List<Photo>;
                    var id5 = (int)gridView5.GetFocusedRowCellValue("Id");
                    var currentPhoto = photo.Single(x => x.Id == id5);

                    AddPhotoForm addPhotoForm = new AddPhotoForm();

             

                    addPhotoForm.textDescription.Text = currentPhoto.Description;
                    addPhotoForm.textPath.Text = currentPhoto.ThePathToTheFile;
                    addPhotoForm.dateEdit1.DateTime = currentPhoto.DataTimeShooting;

                    DialogResult result4 = addPhotoForm.ShowDialog(this);

                    if (result4 == DialogResult.Cancel)
                        return;

                    currentPhoto.ThePathToTheFile = addPhotoForm.textPath.Text;
                    currentPhoto.Description = addPhotoForm.textDescription.Text;
                    currentPhoto.DataTimeShooting = addPhotoForm.dateEdit1.DateTime;

                    


                    dbContext.SaveChanges();
                    gridControl5.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");
                    break;
                //класс ограждения
                case 5:
                    var FenchingClass = gridControl6.DataSource as List<FencingСlass>;
                    var id6 = (int)gridView8.GetFocusedRowCellValue("Id");
                    var currentCLass = FenchingClass.Single(x => x.Id == id6);

                    AddFenchingClassForm addFenchingClass = new AddFenchingClassForm();

                    addFenchingClass.textEdit1.Text = currentCLass.NameFencingClass;

                    DialogResult result5 = addFenchingClass.ShowDialog(this);

                    if (result5 == DialogResult.Cancel)
                        return;

                    currentCLass.NameFencingClass = addFenchingClass.textEdit1.Text;


                    dbContext.SaveChanges();
                    gridControl6.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");
                    break;
                  
                //Тип ограждения
                case 6:

                    var typeFencings = gridControl7.DataSource as List<TypeFencing>;
                    var id7 = (int)gridView9.GetFocusedRowCellValue("Id");
                    var currentType = typeFencings.Single(x => x.Id == id7);


                    AddTypeOfFenchingForm addTypeOfFenching = new AddTypeOfFenchingForm();


                    addTypeOfFenching.textEdit1.Text = currentType.NameTypeFencing;

                    DialogResult result6 = addTypeOfFenching.ShowDialog(this);

                    if (result6 == DialogResult.Cancel)
                        return;

                    currentType.NameTypeFencing = addTypeOfFenching.textEdit1.Text; 


                    dbContext.SaveChanges();
                    gridControl7.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");                   
                    
                    break;
                //группа ограждения
                case 7:
                    var groupFencings = gridControl8.DataSource as List<GroupFencing>;
                    var id8 = (int)gridView10.GetFocusedRowCellValue("Id");
                    var currentGroup = groupFencings.Single(x => x.Id == id8);

                    AddGroupFenchingForm addGroupFenching = new AddGroupFenchingForm();
                    addGroupFenching.textEdit1.Text = currentGroup.NameGroupFencing;

                    DialogResult result7 = addGroupFenching.ShowDialog(this);
                    if (result7 == DialogResult.Cancel)
                        return;                  

                    currentGroup.NameGroupFencing = addGroupFenching.textEdit1.Text;

                    dbContext.SaveChanges();
                    gridControl8.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");                   

                    break;
                //подгруппа ограждения
                case 8:
                    var subgroupFencings = gridControl9.DataSource as List<SubgroupFencing>;
                    var id9 = (int)gridView11.GetFocusedRowCellValue("Id");
                    var currentSubGroup = subgroupFencings.Single(x => x.Id == id9);


                    AddSubgroupGenchingForm addSubgroupGenching = new AddSubgroupGenchingForm();
                    addSubgroupGenching.textEdit1.Value = (decimal)currentSubGroup.NameSubgroupFencing;

                    DialogResult result8 = addSubgroupGenching.ShowDialog(this);

                    if (result8 == DialogResult.Cancel)
                        return;

                    currentSubGroup.NameSubgroupFencing = (int)addSubgroupGenching.textEdit1.Value;

                    dbContext.SaveChanges();
                    gridControl9.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");

                    break;
                //Тип знака
                case 9:
                    var typeRoads = gridControl10.DataSource as List<TypeRoad>;
                    var i9 = (int)gridView12.GetFocusedRowCellValue("Id");
                    var currenttypeRoads = typeRoads.Single(x => x.Id == i9);


                    AddTypeRoadForm addTypeRoad = new AddTypeRoadForm();
                    addTypeRoad.textNameRoad.Text = currenttypeRoads.NameRoad;
                   addTypeRoad.popupGOST.Value=(decimal)currenttypeRoads.NumberAccordingToGOST;

                    DialogResult result9 = addTypeRoad.ShowDialog(this);

                    if (result9 == DialogResult.Cancel)
                        return;

                    currenttypeRoads.NameRoad = addTypeRoad.textNameRoad.Text;
                    currenttypeRoads.NumberAccordingToGOST = (float)addTypeRoad.popupGOST.Value;

                    dbContext.SaveChanges();
                    gridControl10.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");
                    break;
                //Тип плёнки
                case 10:
                    var filmTypes = gridControl11.DataSource as List<FilmType>;
                    var id10 = (int)gridView13.GetFocusedRowCellValue("Id");
                    var currentfilmType = filmTypes.Single(x => x.Id == id10);


                    AddFilmTypeForm addFilmType = new AddFilmTypeForm();
                    addFilmType.textEdit1.Text = currentfilmType.NameFilm;
                    DialogResult result10 = addFilmType.ShowDialog(this);

                    if (result10 == DialogResult.Cancel)
                        return;

                    currentfilmType.NameFilm = addFilmType.textEdit1.Text;

                    dbContext.SaveChanges();
                    gridControl11.Refresh(); // обновляем грид
                    MessageBox.Show("Объект обновлен");
                    break;
                //группа светофора
                case 11:
                    var groupTrafficLights = gridControl12.DataSource as List<GroupTrafficLight>;
                    var id11 = (int)gridView14.GetFocusedRowCellValue("Id");
                    var currentfilmTypes = groupTrafficLights.Single(x => x.Id == id11);


                    AddGroupTrafficLightForm addGroupTrafficLight = new AddGroupTrafficLightForm();
                    addGroupTrafficLight.textEdit1.Text = currentfilmTypes.NameGroupTrafficLight;

                    DialogResult result11 = addGroupTrafficLight.ShowDialog(this);

                    if (result11 == DialogResult.Cancel)
                        return;

                    currentfilmTypes.NameGroupTrafficLight = addGroupTrafficLight.textEdit1.Text;


                    dbContext.SaveChanges();
                    gridControl12.Refresh(); // обновляем грид
                    break;
                //тип светофора
                case 12:
                    var typeTrafficLights = gridControl13.DataSource as List<TypeTrafficLight>;
                    var id12 = (int)gridView15.GetFocusedRowCellValue("Id");
                    var currentTypeLight = typeTrafficLights.Single(x => x.Id == id12);


                    AddTypeTrafficLightForm addTypeTrafficLight = new AddTypeTrafficLightForm();
                    addTypeTrafficLight.textEdit1.Text = currentTypeLight.NameTypeTrafficLight;
                    DialogResult result12 = addTypeTrafficLight.ShowDialog(this);

                    if (result12 == DialogResult.Cancel)
                        return;

                    currentTypeLight.NameTypeTrafficLight = addTypeTrafficLight.textEdit1.Text;

                    dbContext.SaveChanges();
                    gridControl13.Refresh(); // обновляем грид
                    
                    break;
                //bисполнение светофора
                case 13:
                    var executionOfTheTrafficLights = gridControl14.DataSource as List<ExecutionOfTheTrafficLight>;
                    var id13 = (int)gridView16.GetFocusedRowCellValue("Id");
                    var currentexecutionOfTheTrafficLight = executionOfTheTrafficLights.Single(x => x.Id == id13);

                    AddExecutionOfTheTrafficLightForm addExecutionOfTheTrafficLight = new AddExecutionOfTheTrafficLightForm();

                    addExecutionOfTheTrafficLight.textEdit1.Text = currentexecutionOfTheTrafficLight.NameExecutionOfTheTrafficLight;

                    DialogResult result13 = addExecutionOfTheTrafficLight.ShowDialog(this);

                    if (result13 == DialogResult.Cancel)
                        return;

                    currentexecutionOfTheTrafficLight.NameExecutionOfTheTrafficLight = addExecutionOfTheTrafficLight.textEdit1.Text;

                    dbContext.SaveChanges();
                    gridControl14.Refresh(); // обновляем грид
                    break;
                //вариант конструкции светоеофра
                case 14:
                    var variantOfTrafficLightDesigns = gridControl15.DataSource as List<VariantOfTrafficLightDesign>;
                    var id14 = (int)gridView17.GetFocusedRowCellValue("Id");
                    var currentexevariantOfTrafficLightDesigns = variantOfTrafficLightDesigns.Single(x => x.Id == id14);

                    AddVariantOfTrafficLightDesignForm addVariantOfTrafficLightDesign = new AddVariantOfTrafficLightDesignForm();
                    addVariantOfTrafficLightDesign.Number.Value =(decimal) currentexevariantOfTrafficLightDesigns.NumberVariantOfTrafficLightDesign;
                    DialogResult result14 = addVariantOfTrafficLightDesign.ShowDialog(this);

                    if (result14 == DialogResult.Cancel)
                        return;
                   
                    currentexevariantOfTrafficLightDesigns.NumberVariantOfTrafficLightDesign = (float)addVariantOfTrafficLightDesign.Number.Value;

                   
                    dbContext.SaveChanges();
                    gridControl15.Refresh(); // обновляем грид
                    break;
                //тип лампы 
                case 15:
                    var lampTypes = gridControl16.DataSource as List<LampType>;
                    var id15 = (int)gridView18.GetFocusedRowCellValue("Id");
                    var currentLampType = lampTypes.Single(x => x.Id == id15);

                    AddLampTypeForm addLampType = new AddLampTypeForm();
                    addLampType.Power.Value = (decimal)currentLampType.LampPower;
                        addLampType.Flow.Value = (decimal)currentLampType.LightFlow;
                    DialogResult result15 = addLampType.ShowDialog(this);

                    if (result15 == DialogResult.Cancel)
                        return;

                    currentLampType.LampPower = (float)addLampType.Power.Value;
                    currentLampType.LightFlow = (float)addLampType.Flow.Value;

                    dbContext.SaveChanges();
                    gridControl16.Refresh(); // обновляем грид
                    break;
                //класс объекта по освещению
                case 16:
                    var lightingСlasses = gridControl17.DataSource as List<LightingСlass>;
                    var id16 = (int)gridView19.GetFocusedRowCellValue("Id");
                    var currentlightingСlass = lightingСlasses.Single(x => x.Id == id16);

                    AddLightingСlassForm addLightingСlass = new AddLightingСlassForm();
                    addLightingСlass.textEdit1.Text = currentlightingСlass.NameLightingСlass;
                    DialogResult result16 = addLightingСlass.ShowDialog(this);

                    if (result16 == DialogResult.Cancel)
                        return;

                    currentlightingСlass.NameLightingСlass = addLightingСlass.textEdit1.Text;

                    dbContext.SaveChanges();
                    gridControl17.Refresh(); // обновляем грид
                    break;
                //тип компановки остановки
                case 17:
                    var typeOfLayouts = gridControl18.DataSource as List<TypeOfLayoutStop>;
                    var id17 = (int)gridView20.GetFocusedRowCellValue("Id");
                    var currentTypeOfLayoutStop = typeOfLayouts.Single(x => x.Id == id17);

                    AddTypeOfLayoutStopForm addTypeOfLayout = new AddTypeOfLayoutStopForm();
                    addTypeOfLayout.textEdit1.Text = currentTypeOfLayoutStop.NameTypeOfLayoutStop;
                    DialogResult result17 = addTypeOfLayout.ShowDialog(this);

                    if (result17 == DialogResult.Cancel)
                        return;

                    currentTypeOfLayoutStop.NameTypeOfLayoutStop = addTypeOfLayout.textEdit1.Text;

                    dbContext.SaveChanges();
                    gridControl18.Refresh(); // обновляем грид
                    break;
                //степень вместимости остановки
                case 18:
                    var degreeOfCapacities = gridControl19.DataSource as List<DegreeOfCapacityStops>;
                    var id18 = (int)gridView21.GetFocusedRowCellValue("Id");
                    var currentDegreeOfCapacityStops = degreeOfCapacities.Single(x => x.Id == id18);

                    AddDegreeOfCapacityStopsForm addDegreeOfCapacity = new AddDegreeOfCapacityStopsForm();

                    addDegreeOfCapacity.textEdit1.Text = currentDegreeOfCapacityStops.NameDegreeOfCapacityStops;
                    DialogResult result18 = addDegreeOfCapacity.ShowDialog(this);

                    if (result18 == DialogResult.Cancel)
                        return;

                    currentDegreeOfCapacityStops.NameDegreeOfCapacityStops = addDegreeOfCapacity.textEdit1.Text;


                    dbContext.SaveChanges();
                    gridControl19.Refresh(); // обновляем грид
                    break;
            }
            }
        //удаление
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int tabPage1 = tabControl1.SelectedIndex;

            switch (tabPage1)
            {
                //адрес
                case 0:

                    DialogResult result = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var addresses = gridControl1.DataSource as List<Address>;
                        var id = (int)gridView1.GetFocusedRowCellValue("Id");
                        var currentAddress = addresses.Single(x => x.Id == id);


                        dbContext.Address.Remove(currentAddress);
                        dbContext.SaveChanges();


                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //cостояния
                case 1:
                    DialogResult result1 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        var condition = gridControl2.DataSource as List<ConditionOfTheObject>;
                    var id1 = (int)gridView2.GetFocusedRowCellValue("Id");
                    var currentCondition = condition.Single(x => x.Id == id1);


                    dbContext.ConditionOfTheObject.Remove(currentCondition);
                    dbContext.SaveChanges();


                    MessageBox.Show("Объект удален");
                    }
                    break;
                    //Тип ТСОДД
                case 2:
                    DialogResult result2 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        var typeTsodd = gridControl3.DataSource as List<TypeTSODD>;
                        var id2 = (int)gridView3.GetFocusedRowCellValue("Id");
                        var currentTypeTSODD = typeTsodd.Single(x => x.Id == id2);

                        dbContext.TypeTSODD.Remove(currentTypeTSODD);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }

                        break;
                    //географическое положение
                case 3:
                    DialogResult result3 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result3 == DialogResult.Yes)
                    {
                        var geogPosition = gridControl4.DataSource as List<GeographicalPosition>;
                        var id3 = (int)gridView4.GetFocusedRowCellValue("Id");
                        var currentGeogPosition = geogPosition.Single(x => x.Id == id3);

                        dbContext.GeographicalPosition.Remove(currentGeogPosition);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                case 4:
                    //фотография
                    DialogResult result4 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result4 == DialogResult.Yes)
                    {
                        var photo = gridControl5.DataSource as List<Photo>;
                        var id5 = (int)gridView5.GetFocusedRowCellValue("Id");
                        var currentPhoto = photo.Single(x => x.Id == id5);

                        dbContext.Photo.Remove(currentPhoto);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                case 5:
                    //класс ограждения
                    DialogResult result5 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result5 == DialogResult.Yes)
                    {
                        var FenchingClass = gridControl6.DataSource as List<FencingСlass>;
                        var id5 = (int)gridView8.GetFocusedRowCellValue("Id");
                        var currentCLass = FenchingClass.Single(x => x.Id == id5);

                        dbContext.FencingСlass.Remove(currentCLass);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //Тип ограждения
                case 6:
                    DialogResult result6 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result6 == DialogResult.Yes)
                    {
                        var typeFencings = gridControl7.DataSource as List<TypeFencing>;
                        var id6 = (int)gridView9.GetFocusedRowCellValue("Id");
                        var currentType = typeFencings.Single(x => x.Id == id6);

                        dbContext.TypeFencing.Remove(currentType);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //группа ограждения
                case 7:
                    DialogResult result7 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result7 == DialogResult.Yes)
                    {
                        var groupFencings = gridControl8.DataSource as List<GroupFencing>;
                        var id7 = (int)gridView10.GetFocusedRowCellValue("Id");
                        var currentGroup = groupFencings.Single(x => x.Id == id7);

                        dbContext.GroupFencing.Remove(currentGroup);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");

                    }
                    break;
                    //подгруппа ограждения
                case 8:
                    DialogResult result8 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result8 == DialogResult.Yes)
                    {
                        var subgroupFencings = gridControl9.DataSource as List<SubgroupFencing>;
                        var id8 = (int)gridView11.GetFocusedRowCellValue("Id");
                        var currentSubGroup = subgroupFencings.Single(x => x.Id == id8);

                        dbContext.SubgroupFencing.Remove(currentSubGroup);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //Тип знака
                case 9:
                    DialogResult result9 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result9 == DialogResult.Yes)
                    {
                        var typeRoads = gridControl10.DataSource as List<TypeRoad>;
                        var id9 = (int)gridView12.GetFocusedRowCellValue("Id");
                        var currenttypeRoads = typeRoads.Single(x => x.Id == id9);

                        dbContext.TypeRoad.Remove(currenttypeRoads);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //Тип плёнки
                case 10:
                    DialogResult result10 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result10 == DialogResult.Yes)
                    {
                        var filmTypes = gridControl11.DataSource as List<FilmType>;
                        var id10 = (int)gridView13.GetFocusedRowCellValue("Id");
                        var currentfilmType = filmTypes.Single(x => x.Id == id10);

                        dbContext.FilmType.Remove(currentfilmType);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //группа светофора
                case 11:
                    DialogResult result11 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result11 == DialogResult.Yes)
                    {

                        var groupTrafficLights = gridControl12.DataSource as List<GroupTrafficLight>;
                        var id11 = (int)gridView14.GetFocusedRowCellValue("Id");
                        var currentfilmType = groupTrafficLights.Single(x => x.Id == id11);

                        dbContext.GroupTrafficLight.Remove(currentfilmType);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //тип светофора
                case 12:
                    DialogResult result12 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result12 == DialogResult.Yes)
                    {
                        var typeTrafficLights = gridControl13.DataSource as List<TypeTrafficLight>;
                        var id12 = (int)gridView15.GetFocusedRowCellValue("Id");
                        var currentTypeLight = typeTrafficLights.Single(x => x.Id == id12);

                        dbContext.TypeTrafficLight.Remove(currentTypeLight);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //bисполнение светофора
                case 13:
                    DialogResult result13 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result13 == DialogResult.Yes)
                    {
                        var executionOfTheTrafficLights = gridControl14.DataSource as List<ExecutionOfTheTrafficLight>;
                        var id13 = (int)gridView16.GetFocusedRowCellValue("Id");
                        var currentexecutionOfTheTrafficLight = executionOfTheTrafficLights.Single(x => x.Id == id13);

                        dbContext.ExecutionOfTheTrafficLight.Remove(currentexecutionOfTheTrafficLight);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //вариант конструкции светоеофра
                case 14:
                    DialogResult result14 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result14 == DialogResult.Yes)
                    {
                        var variantOfTrafficLightDesigns = gridControl15.DataSource as List<VariantOfTrafficLightDesign>;
                        var id14 = (int)gridView17.GetFocusedRowCellValue("Id");
                        var currentexevariantOfTrafficLightDesigns = variantOfTrafficLightDesigns.Single(x => x.Id == id14);

                        dbContext.VariantOfTrafficLightDesign.Remove(currentexevariantOfTrafficLightDesigns);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //тип лампы 
                case 15:
                    DialogResult result15 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result15 == DialogResult.Yes)
                    {
                        var lampTypes = gridControl16.DataSource as List<LampType>;
                        var id15 = (int)gridView18.GetFocusedRowCellValue("Id");
                        var currentLampType = lampTypes.Single(x => x.Id == id15);

                        dbContext.LampType.Remove(currentLampType);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //класс объекта по освещению
                case 16:
                    DialogResult result16 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result16 == DialogResult.Yes)
                    {
                        var lightingСlasses = gridControl17.DataSource as List<LightingСlass>;
                        var id16 = (int)gridView19.GetFocusedRowCellValue("Id");
                        var currentlightingСlass= lightingСlasses.Single(x => x.Id == id16);

                        dbContext.LightingСlass.Remove(currentlightingСlass);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }

                    break;
                    //тип компановки остановки
                case 17:
                    DialogResult result17 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result17 == DialogResult.Yes)
                    {
                        var typeOfLayouts = gridControl18.DataSource as List<TypeOfLayoutStop>;
                        var id17 = (int)gridView20.GetFocusedRowCellValue("Id");
                        var currentTypeOfLayoutStop = typeOfLayouts.Single(x => x.Id == id17);

                        dbContext.TypeOfLayoutStop.Remove(currentTypeOfLayoutStop);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;
                    //степень вместимости остановки
                case 18:
                    DialogResult result18 = MessageBox.Show("Удалить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result18 == DialogResult.Yes)
                    {
                        var degreeOfCapacities = gridControl19.DataSource as List<DegreeOfCapacityStops>;
                        var id18 = (int)gridView21.GetFocusedRowCellValue("Id");
                        var currentDegreeOfCapacityStops = degreeOfCapacities.Single(x => x.Id == id18);

                        dbContext.DegreeOfCapacityStops.Remove(currentDegreeOfCapacityStops);
                        dbContext.SaveChanges();

                        MessageBox.Show("Объект удален");
                    }
                    break;

            }

        }

        private void Form_Load(object sender, EventArgs e)
        {
          
                gridControl1.DataSource = dbContext.Address.ToList();
            gridView1.OptionsBehavior.ReadOnly = true;
                gridView1.OptionsBehavior.Editable = false;
          


          

                gridControl2.DataSource = dbContext.ConditionOfTheObject.ToList();
                gridView2.OptionsBehavior.ReadOnly = true;
                gridView2.OptionsBehavior.Editable = false;
           



         
                gridControl3.DataSource = dbContext.TypeTSODD.ToList();
            gridView3.OptionsBehavior.ReadOnly = true;
                gridView3.OptionsBehavior.Editable = false;
           

            
                gridControl4.DataSource = dbContext.GeographicalPosition.ToList();
            gridView4.OptionsBehavior.ReadOnly = true;
                gridView4.OptionsBehavior.Editable = false;
           



          
           
                gridControl5.DataSource = dbContext.Photo.ToList();
                gridView5.OptionsBehavior.ReadOnly = true;
                gridView5.OptionsBehavior.Editable = false;
          
                gridControl6.DataSource = dbContext.FencingСlass.ToList();
            gridView8.OptionsBehavior.ReadOnly = true;
                gridView8.OptionsBehavior.Editable = false;
           
        
                gridControl7.DataSource = dbContext.TypeFencing.ToList();
            gridView9.OptionsBehavior.ReadOnly = true;
                gridView9.OptionsBehavior.Editable = false;
          
                gridControl8.DataSource = dbContext.GroupFencing.ToList();
            gridView10.OptionsBehavior.ReadOnly = true;
                gridView10.OptionsBehavior.Editable = false;
          

                gridControl9.DataSource = dbContext.SubgroupFencing.ToList();
            gridView11.OptionsBehavior.ReadOnly = true;
                gridView11.OptionsBehavior.Editable = false;

           
                gridControl10.DataSource = dbContext.TypeRoad.ToList();
            gridView12.OptionsBehavior.ReadOnly = true;
                gridView12.OptionsBehavior.Editable = false;
           
                gridControl11.DataSource = dbContext.FilmType.ToList();
            gridView13.OptionsBehavior.ReadOnly = true;
                gridView13.OptionsBehavior.Editable = false;
         
                gridControl12.DataSource = dbContext.GroupTrafficLight.ToList();
            gridView14.OptionsBehavior.ReadOnly = true;
                gridView14.OptionsBehavior.Editable = false;
        
                gridControl13.DataSource = dbContext.TypeTrafficLight.ToList();
            gridView15.OptionsBehavior.ReadOnly = true;
                gridView15.OptionsBehavior.Editable = false;
         
                gridControl14.DataSource = dbContext.ExecutionOfTheTrafficLight.ToList();
            gridView16.OptionsBehavior.ReadOnly = true;
                gridView16.OptionsBehavior.Editable = false;
           
               

                gridControl15.DataSource = dbContext.VariantOfTrafficLightDesign.ToList();
            gridView17.OptionsBehavior.ReadOnly = true;
                gridView17.OptionsBehavior.Editable = false;
         


                gridControl16.DataSource = dbContext.LampType.ToList();
            gridView18.OptionsBehavior.ReadOnly = true;
                gridView18.OptionsBehavior.Editable = false;
         

                gridControl17.DataSource = dbContext.LightingСlass.ToList();
            gridView19.OptionsBehavior.ReadOnly = true;
                gridView19.OptionsBehavior.Editable = false;
           
                gridControl18.DataSource = dbContext.TypeOfLayoutStop.ToList();
            gridView20.OptionsBehavior.ReadOnly = true;
                gridView20.OptionsBehavior.Editable = false;
         

                gridControl19.DataSource = dbContext.DegreeOfCapacityStops.ToList();
            gridView21.OptionsBehavior.ReadOnly = true;
                gridView21.OptionsBehavior.Editable = false;
        }
    }
}
 