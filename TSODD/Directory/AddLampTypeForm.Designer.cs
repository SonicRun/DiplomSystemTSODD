namespace TSODD.Directory
{
    partial class AddLampTypeForm
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
            this.Power = new DevExpress.XtraEditors.SpinEdit();
            this.Flow = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Power.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Power
            // 
            this.Power.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Power.Location = new System.Drawing.Point(124, 26);
            this.Power.Name = "Power";
            this.Power.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Power.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.Power.Properties.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Power.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.Power.Properties.MaxValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Power.Size = new System.Drawing.Size(148, 20);
            this.Power.TabIndex = 0;
            // 
            // Flow
            // 
            this.Flow.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Flow.Location = new System.Drawing.Point(124, 62);
            this.Flow.Name = "Flow";
            this.Flow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Flow.Properties.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Flow.Size = new System.Drawing.Size(148, 20);
            this.Flow.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Мощность лампы:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(37, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Световой поток:";
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(197, 97);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "Отмена";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Location = new System.Drawing.Point(116, 97);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "ОК";
            // 
            // AddLampTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Flow);
            this.Controls.Add(this.Power);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddLampTypeForm";
            this.Text = "AddLampTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.Power.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.SpinEdit Power;
        public DevExpress.XtraEditors.SpinEdit Flow;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}