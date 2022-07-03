using SimplewebApi.Model;
using SimplewebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplewebApi.Services
{
    public class EmployeeServices:IEmployeeServices
    {
        private readonly IEmployeeRepositoy _iEmployeeRepo;
        // Injecition of Dependancy using constructor
        public EmployeeServices(IEmployeeRepositoy iEmployeeRepo)
        {
            _iEmployeeRepo = iEmployeeRepo;
        }
        public int AddEmployee(Employee emp)
        {
            return _iEmployeeRepo.AddEmployee(emp);
        }
        public int DeleteEmployee(int id)
        {
            return _iEmployeeRepo.DeleteEmployee(id);
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _iEmployeeRepo.GetAllEmployee();
        }
        public int ModifyEmployee(Employee emp)
        {
            return _iEmployeeRepo.ModifyEmployee(emp);
        }
    }
}

