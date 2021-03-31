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
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;
        public IEnumerable<Employee> Employees { get; set; }
        public Employee Employee { get; private set; }

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IActionResult OnGet(int id)
        {

            Employee = employeeRepository.GetEmployee(id);

            if (Employee == null)
            {
                return RedirectToPage("/Notfound");
            }
            return Page();
        }
        
    }
}