using SimplewebApi.Entities;
using SimplewebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplewebApi.Repositories
{
    public class EmployeeRepositoy:IEmployeeRepositoy
    {
        RepositoriesContext context;
        public EmployeeRepositoy(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddEmployee(Employee emp)
        {
            context.employees.Add(emp);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteEmployee(int id)
        {
            var emp = context.employees.Where(e => e.Id == id).SingleOrDefault();
            if (emp != null)
            {
                context.employees.Remove(emp);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.employees.ToList();
        }

        public int ModifyEmployee(Employee emp)
        {
            
            var employee = context.employees.Where(e => e.Id == emp.Id).SingleOrDefault();
            if (employee != null)
            {
                employee.Name = emp.Name;
                employee.Salary = emp.Salary;
                employee.Department = emp.Department;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}

