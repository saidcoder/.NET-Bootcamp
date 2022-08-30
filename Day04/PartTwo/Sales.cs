using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Sales : Employee
    {
        private Decimal bonus;
        private Decimal commission;

        public Sales(int empId, string firstName, string lastName, DateTime joinDate, decimal basicSalary, decimal bonus, decimal commission) : base(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.bonus = bonus;
            this.commission = commission;
            this.Role = "Sales";
            this.TotalSalary = basicSalary + bonus + commission;
        }

        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal Commission { get => commission; set => commission = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Bonus : {this.bonus.ToString("C", new CultureInfo("id-ID"))} | Commission : {this.commission.ToString("C", new CultureInfo("id-ID"))} | Total Salary = {this.TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
