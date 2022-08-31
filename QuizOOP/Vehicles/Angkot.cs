using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Vehicles
{
    internal class Angkot : Cars
    {
        private decimal hargaTiket;
        private int totalPenumpang;

        public Angkot(string noPolisi, int tahun, decimal hargaTiket, int totalPenumpang) : base(noPolisi, tahun)
        {
            this.hargaTiket = hargaTiket;
            this.Type = "Angkot";
            this.totalPenumpang = totalPenumpang;
            TotalRevenue = hargaTiket * totalPenumpang;
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Harga Tiket :  {this.hargaTiket.ToString("C", new CultureInfo("id-ID"))} | Total Penumpang : {this.totalPenumpang} | Total Revenue = {this.TotalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }

        public decimal HargaTiket { get => hargaTiket; set => hargaTiket = value; }
        public int TotalPenumpang { get => totalPenumpang; set => totalPenumpang = value; }
    }
}
