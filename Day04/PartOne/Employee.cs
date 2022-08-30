using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class Employee
    {
        //instacance variabel
        private int empId;
        private string firstName;
        private string lastName;
        private DateTime joinDate;
        private Decimal basicSalary;
        private string role;
        private Decimal totalSalary;
        //static variable
        public static int totalEmployee = 0;
        public static Decimal totalBasicSalary = 0M;
        //Empty/default constructor
        /*public Employee()
        {
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
        }*/

        //Constructor Parameter
        public Employee(int empId, string firstName, string lastName, 
            DateTime joinDate, decimal basicSalary)
        {
            this.empId = empId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            totalEmployee++;
            totalBasicSalary += this.BasicSalary;
            this.totalSalary = this.BasicSalary;
        }

        //overloading Constructor Parameter
        public Employee(int empId, string firstName, 
            string lastName, DateTime joinDate, decimal basicSalary, 
            string role) : this(empId, firstName, lastName, joinDate, basicSalary)
        {
            this.role = role;
        }

        public override string? ToString()
        {
            return $"Employe = {this.empId} | {this.firstName} | {this.lastName} | Basic Salary {this.basicSalary.ToString("C", new CultureInfo("id-ID"))} | {this.role}";
        }

        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary { get => basicSalary; 
            set { 
                basicSalary = value;
                totalSalary = basicSalary;
            } }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalary { get => totalSalary; set => totalSalary = value; }
    }
}
