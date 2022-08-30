using Day04.PartOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public Employee FindEmployeeById(List<Employee> list, int id)
        {
            Employee? emps = null;
            foreach (var item in list)
            {
                if (item.EmpId == id)
                {
                    emps = item;
                }
            }
            return emps;
        }

        public List<Employee> FindSalaryRange(List<Employee> list, decimal startFrom, decimal endTo)
        {
            var empRange = new List<Employee>();

            foreach (var item in list)
            {
                if (item.TotalSalary >= startFrom && item.TotalSalary <= endTo)
                {
                    empRange.Add(item);
                }
            }

            return empRange;
        }

        public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            var total = 0M;
            foreach (var item in list.OfType<Employee>())
            {
                total += item.TotalSalary;
            }
            return total;
        }

        public List<Employee> InitDataEmployee()
        {
            //create bussines logic
            //setiap create object instance, gunakan operator class
            Employee emp1 = new Employee(1002, "Dyass", "Alx", DateTime.Now, 3_000_000, "Programmer");

            //create object Employee with parameter constructor
            Employee emp2 = new Employee(1001, "Said", "Farid", new DateTime(), 5_000_000, "Sales");

            Employee emp3 = new Employee(1003, "Budi", "Setiawan", new DateTime(), 4_000_000, "QA");

            Programmer prog1 = new Programmer(1004, "Bejo", "arianto", new DateTime(2021, 7, 12), 5_500_000, 500_000);

            //create object sales
            Sales sale1 = new Sales(1006, "Hito", "nami",
                new DateTime(2020, 7, 18), 4_500_000, 500_000, 200_000);

            QA q1 = new QA(1008, "Ellise", "Toon", new DateTime(2019, 8, 17), 4_500_000, 10_000);

            List<Employee> list = new List<Employee>() { emp1, emp2, emp3, prog1, sale1, q1 };
            return list;
            //throw new NotImplementasiException();

        }

        public void ShowList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            
            //throw new NotImplementedException();
        }
    }
}
