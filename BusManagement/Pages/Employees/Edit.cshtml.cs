using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusManagement.Model;
using BusManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BusManagement
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;
        public IEnumerable<Employee> Employees { get; set; }
        public Employee Employee { get; private set; }

        public EditModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
       
        public IActionResult OnGet(int? id)

        {
            if(id.HasValue)
            {
                Employee = employeeRepository.GetEmployee(id.Value);
            }
            else
            {
                Employee = new Employee();
            }
           

            if(Employee == null)
            {
                return RedirectToPage("/Notfound");
            }
            return Page();
        }
        public IActionResult OnPost(Employee employee)
        {
          
            Employee = employeeRepository.Update(employee);


            Employee = employeeRepository.Add(employee);



            return RedirectToPage("/Employees/Index");
        }
    }
}