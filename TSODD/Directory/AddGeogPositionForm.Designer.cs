namespace TSODD.Directory
{
    partial class AddGeogPositionForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textLing = new DevExpress.XtraEditors.SpinEdit();
            this.textLong = new DevExpress.XtraEditors.SpinEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textLing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Долгота:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Широта:";
            // 
            // textLing
            // 
            this.textLing.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textLing.Location = new System.Drawing.Point(66, 27);
            this.textLing.Name = "textLing";
            this.textLing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textLing.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textLing.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.textLing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textLing.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textLing.Size = new System.Drawing.Size(206, 20);
            this.textLing.TabIndex = 1;
            // 
            // textLong
            // 
            this.textLong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textLong.Location = new System.Drawing.Point(66, 59);
            this.textLong.Name = "textLong";
            this.textLong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textLong.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textLong.Properties.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.textLong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textLong.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textLong.Size = new System.Drawing.Size(206, 20);
            this.textLong.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(198, 109);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Отмена";
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Location = new System.Drawing.Point(117, 109);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "ОК";
            // 
            // AddGeogPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textLing);
            this.Controls.Add(this.textLong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddGeogPositionForm";
            this.Text = "AddGeogPositionForm";
            ((System.ComponentModel.ISupportInitialize)(this.textLing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.SpinEdit textLing;
        public DevExpress.XtraEditors.SpinEdit textLong;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}