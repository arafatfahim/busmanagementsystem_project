using BusManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EO.Internal;

namespace BusManagement.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1 ,Name= "ARAFAT", From = Dept.Dhaka, To = Dept.Chhottogram, 
                    Email= "arafat@eamil.com"},
                new Employee() { Id = 2 ,Name= "Fahim", From = Dept.Khulna,To = Dept.Chhottogram, 
                    Email= "fahim@eamil.com"},
                new Employee() { Id = 3 ,Name= "Urmi", From = Dept.Chhottogram,To = Dept.Dhaka, 
                    Email= "urmi@eamil.com"},
                new Employee() { Id = 4 ,Name= "Tarikol", From = Dept.Dhaka,To = Dept.Chhottogram, 
                    Email= "tarikol@eamil.com"},
            };
        }

        public Employee Add(Employee newEmployee)
        {
            newEmployee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(newEmployee);
            return newEmployee;
        }

        public Employee Delete(int id)
        {
            Employee employeeToDelete = _employeeList.FirstOrDefault(e => e.Id == id);
            if(employeeToDelete!=null)
            {
                _employeeList.Remove(employeeToDelete);
            }
            return employeeToDelete;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee updatedEmployee)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == updatedEmployee.Id);
            if(employee != null)
            {
                
                employee.Name = updatedEmployee.Name;
                employee.Email = updatedEmployee.Email;
                employee.From = updatedEmployee.From;
                employee.To = updatedEmployee.To;
                employee.DT = updatedEmployee.DT;

            }
            return employee;
        }

        
    }
}
