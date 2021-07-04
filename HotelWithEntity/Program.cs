using HotelWithEntity.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using HotelWithEntity.Unities;

namespace HotelWithEntity
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = UnitiesRegister.BuildUnityContainer();
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<fLogin>());


        }

       
    }
}
