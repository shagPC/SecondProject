using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    public class Brigade
    {
        public Employee Brigadier { get; set; }
        public int NumBrigade { get; private set; }
        public List<Employee> employees = new List<Employee>
        {
            new Employee("Alex", 23, 80000), new Employee("Serg", 34, 120000), new Employee("Mary", 31, 100000)
        };
        public IEnumerator<Employee> GetEnumerator()
        {
            foreach (var item in employees)
                yield return item;
        }
        public override string ToString()
        {
            return $"{NumBrigade} , {Brigadier} {employees.Count}";
        }

        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }
            set
            {
                employees[index] = value;
            }
        }
        public void Add(Employee emp)
        {
            employees.Add(emp);
        }
        public void AddRange(params Employee [] emps)
        {
            //foreach(var item in emps)
            employees.AddRange(emps);
        }
    }
}
