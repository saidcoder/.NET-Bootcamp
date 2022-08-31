using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Vehicles
{
    internal class Cars
    {
        //Instance Variabel
        private string noPolisi;
        private int tahun;
        private string type;
        private decimal totalRevenue;

        public Cars(string noPolisi, int tahun)
        {
            this.noPolisi = noPolisi;
            this.tahun = tahun;
            this.totalRevenue = 0M;
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }

        public override string? ToString()
        {
            return $"{this.noPolisi} | {this.tahun} | {this.type}";
        }

      
    }
}
