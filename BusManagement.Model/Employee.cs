using System;
using System.Collections.Generic;
using System.Text;

namespace BusManagement.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public Dept? From{ get; set; }
        public Dept? To { get; set; }
        public string DT { get; set; }
    }
}
