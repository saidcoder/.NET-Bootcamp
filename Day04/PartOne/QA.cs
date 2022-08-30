using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class QA : Employee 
    {
        private decimal makan = 0M;

        public QA(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, decimal makan) : base(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.makan = makan;
            this.Role = "QA";
            //call method TotalSalary belong Employee
            this.TotalSalary = basicSalary + makan;
        }

        public decimal Makan { get => makan; set => makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Makan : {this.makan.ToString("C", new CultureInfo("id-ID"))} | Total Salary = {this.TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
