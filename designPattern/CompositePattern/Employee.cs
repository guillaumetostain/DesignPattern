using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.CompositePattern
{
    public class Employee
    {
        private string name;
        private string dept;
        private int salary;
        private List<Employee> subordinates;

        public Employee(string name, string dept, int sal)
        {
            this.name = name;
            this.dept = dept;
            this.salary = sal;
            subordinates = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            subordinates.Add(employee);
        }

        public void Remove(Employee employee)
        {
            subordinates.Remove(employee);
        }

        public List<Employee> GetSubordinates()
        {
            return subordinates;
        }

        public string Details()
        {
            return ("Employee :[ Name : " + name + ", dept : " + dept + ", salary :" + salary + " ]");
        }
    }
}
