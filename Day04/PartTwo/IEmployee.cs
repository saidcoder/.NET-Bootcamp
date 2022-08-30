using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();

        public void ShowList<T>(List<T> list);

        public Employee FindEmployeeById(List<Employee> list, int id);

        //method return with generic datatype <T>
        public Decimal GetTotalSalary<T>(ref List<T> list);

        public List<Employee> FindSalaryRange(List<Employee> list,decimal startFrom, decimal endTo);

        //aggregate summary employee
        public Dictionary<String, int> GetTotalEmployeeByRole(List<Employee> list);
    }
}
