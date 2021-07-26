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

namespace TSODD
{
    public partial class AftorizationForm : DevExpress.XtraEditors.XtraForm
    {
        public AftorizationForm()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e) => Application.Exit();

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ToolbarForm1 toolbarForm1 = new ToolbarForm1();
            toolbarForm1.ShowDialog();
            this.Hide();
        }
    }
}