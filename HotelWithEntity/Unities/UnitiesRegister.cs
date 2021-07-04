using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace HotelWithEntity.Unities
{
    public class UnitiesRegister
    {
        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IEmployeeService, EmployeeService>();
            return currentContainer;
        }
    }
}
