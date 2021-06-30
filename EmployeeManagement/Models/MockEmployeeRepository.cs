using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>() {
            new Employee{ID=1,Name="Ram",Department="HR",Email="sth@gmail.com"},
            new Employee{ID=2,Name="Rama",Department="HR",Email="sth2@gmail.com"},
            new Employee{ID=3,Name="Radhe",Department="IT",Email="sth1@gmail.com"},
            new Employee{ID=4,Name="Raman",Department="IT",Email="sth22@gmail.com"},
            new Employee{ID=5,Name="Ramtori",Department="IT",Email="sth31@gmail.com"},
            };
            
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.ID == id);
        }
    }
}
