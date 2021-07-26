namespace TSODD.Views.Address
{
    partial class XtraForm1
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
            this.addressCollectionView1 = new TSODD.Views.AddressCollectionView.AddressCollectionView();
            this.SuspendLayout();
            // 
            // addressCollectionView1
            // 
            this.addressCollectionView1.Location = new System.Drawing.Point(3, 2);
            this.addressCollectionView1.Name = "addressCollectionView1";
            this.addressCollectionView1.Size = new System.Drawing.Size(967, 671);
            this.addressCollectionView1.TabIndex = 0;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 676);
            this.Controls.Add(this.addressCollectionView1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private AddressCollectionView.AddressCollectionView addressCollectionView1;
    }
}