using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal abstract class Person
    {
        private int sosialNumber;
        private string firstName;
        private string lastName;
        private string email;
        private DateTime birthDay;
        private decimal totalIncome;
        private decimal totalRevenue;

        protected Person(string firstName, string lastName, string email, DateTime birthDay)
        {
            //this.sosialNumber = sosialNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.birthDay = birthDay;
            totalRevenue = 0;
        }

        public int SosialNumber { get => sosialNumber; set => sosialNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public decimal TotalIncome1 { get => totalIncome; set => totalIncome = value; }
        public decimal TotalRevenue { get => totalIncome; set => totalIncome = value; }

        public override string? ToString()
        {
            return $"SocialNumber : {this.sosialNumber} \n" +
                $"| FirstName     : {this.firstName} \n" +
                $"| LastName      : {this.lastName} \n" +
                $"| Email         : {this.email} \n" +
                $"| Birthday      : {this.birthDay} \n" +
                $"| Total Revenue : {this.TotalRevenue.ToString("C", new CultureInfo("id-ID"))}\n";
        }

        public abstract decimal TotalIncome(Dictionary<string, decimal> data);
    }
}
