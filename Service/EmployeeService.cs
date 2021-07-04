using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern;

namespace Service
{
 
    public interface IEmployeeService
    {
        List<Employee> GetEmployee();
        bool CheckLogin(int id, string pass);
    }

    public class EmployeeService:IEmployeeService
    {
        private readonly GenericUnitOfWork _unitOfWork;
        public EmployeeService(GenericUnitOfWork repositoryContext)
        {
            this._unitOfWork = repositoryContext;
        }
        public List<Employee> GetEmployee()
        {
            return this._unitOfWork.GetRepositoryInstance<Employee>().GetAllRecords().ToList();
        }

        public bool CheckLogin(int id, string pass)
        {
            if (_unitOfWork.GetRepositoryInstance<Employee>().GetAllRecords().Where(x=>x.ID==id && x.Password==pass).Count()>0)
            {
                return true;
            }

            return false;
        }
    }
}
