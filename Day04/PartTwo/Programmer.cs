using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Programmer : Employee
    {
        private Decimal transportasi;

        public Programmer(int empId, string firstName,
            string lastName, DateTime joinDate,
            decimal basicSalary, decimal transportasi) : base(
                empId, firstName, lastName, joinDate, basicSalary)
        {
            this.transportasi = transportasi;
            this.Role = "Programmer";
            this.TotalSalary = basicSalary + transportasi;
        }

        public decimal Transportasi { get => transportasi; set => transportasi = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | TjTransportasi = {this.transportasi.ToString("C", new CultureInfo("id-ID"))} | Total Salary = {this.TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }

    //WriteLine("==========================");
}
