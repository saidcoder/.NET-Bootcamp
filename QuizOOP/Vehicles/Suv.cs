using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Vehicles
{
    internal class Suv : Cars
    {
        private decimal sewa;
        private decimal supir;

        public Suv(string noPolisi, int tahun, decimal sewa, decimal supir) : base(noPolisi, tahun)
        {
            this.sewa = sewa;
            this.Type = "SUV";
            this.supir = supir;
            TotalRevenue = sewa + supir;
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Supir { get => supir; set => supir = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Sewa : {this.Sewa.ToString("C", new CultureInfo("id-ID"))} | Supir : {this.supir.ToString("C", new CultureInfo("id-ID"))} | Total Revenue = {this.TotalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
