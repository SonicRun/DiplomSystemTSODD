namespace TSODD
{
    partial class AddAddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNameRoad = new DevExpress.XtraEditors.TextEdit();
            this.textKMandMetr = new DevExpress.XtraEditors.SpinEdit();
            this.textReferencePoint = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textNameRoad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKMandMetr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReferencePoint.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textNameRoad
            // 
            this.textNameRoad.Location = new System.Drawing.Point(159, 32);
            this.textNameRoad.Name = "textNameRoad";
            this.textNameRoad.Size = new System.Drawing.Size(100, 20);
            this.textNameRoad.TabIndex = 2;
            // 
            // textKMandMetr
            // 
            this.textKMandMetr.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textKMandMetr.Location = new System.Drawing.Point(159, 70);
            this.textKMandMetr.Name = "textKMandMetr";
            this.textKMandMetr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textKMandMetr.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textKMandMetr.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.textKMandMetr.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textKMandMetr.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textKMandMetr.Size = new System.Drawing.Size(100, 20);
            this.textKMandMetr.TabIndex = 3;
            // 
            // textReferencePoint
            // 
            this.textReferencePoint.Location = new System.Drawing.Point(73, 108);
            this.textReferencePoint.Name = "textReferencePoint";
            this.textReferencePoint.Size = new System.Drawing.Size(186, 20);
            this.textReferencePoint.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Название улицы:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Километр дороги:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Ореинтр:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Location = new System.Drawing.Point(113, 167);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "ОК";
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(194, 167);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Отмена";
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 202);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textReferencePoint);
            this.Controls.Add(this.textNameRoad);
            this.Controls.Add(this.textKMandMetr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAddressForm";
            this.Text = "Добавление/редактирование адреса";
            ((System.ComponentModel.ISupportInitialize)(this.textNameRoad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKMandMetr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textReferencePoint.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit textNameRoad;
        public DevExpress.XtraEditors.SpinEdit textKMandMetr;
        public DevExpress.XtraEditors.TextEdit textReferencePoint;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}