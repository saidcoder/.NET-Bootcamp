using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Vehicles
{
    internal class Taxi : Cars
    {
        private int order;
        private decimal orderPerKM;
        private int totalKM;
        private decimal bonus;

        public Taxi(string noPolisi, int tahun, int order, decimal orderPerKM, int totalKM, decimal bonus) : base(noPolisi, tahun)
        {
            this.order = order;
            this.orderPerKM = orderPerKM;
            this.totalKM = totalKM;
            this.bonus = bonus;
            this.Type = "Taxi";
            TotalRevenue = (order * bonus) + (orderPerKM * totalKM);
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Order : {this.order} | {this.orderPerKM.ToString("C", new CultureInfo("id-ID"))} | TotalKM :{this.totalKM} | {this.bonus.ToString("C", new CultureInfo("id-ID"))} | Total Revenue = {this.TotalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }

        public int Order { get => order; set => order = value; }
        public decimal OrderPerKM { get => orderPerKM; set => orderPerKM = value; }
        public int TotalKM { get => totalKM; set => totalKM = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }
    }
}
