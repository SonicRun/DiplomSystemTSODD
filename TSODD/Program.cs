using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSODD
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          /*  using (var db = new TsoddContext())
            {
               // db.Database.Create();
                var list = db.Address.Where(x=> x.NameStreetOrRoad == "");
            }*/

            Application.Run(new AftorizationForm());
        }
    }
}
