using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Vehicles
{
    internal class CarsImpl : ICars
    {

        public List<Cars> InitDataCars()
        {
            //Create Object Cars with parameter constructor
            Suv suv1 = new Suv("D 1001 UM", 2015, 500_000, 100_000);
            Suv suv2 = new Suv("D 1002 UM", 2019, 500_000, 100_000);

            Taxi tax1 = new Taxi("D 88 UK", 2018, 5, 4500, 40, 10_000);
            Taxi tax2 = new Taxi("D 87 UK", 2018, 10, 4500, 100, 10_000);

            Angkot ang1 = new Angkot("D 55 UJ", 2016, 4500, 35);
            Angkot ang2 = new Angkot("D 56 UJ", 2015, 4500, 40);

            return new List<Cars>() { suv1, suv2, tax1, tax2, ang1, ang2 };
        }

        public Dictionary<string, int> GetTotalCarsByType(List<Cars> list)
        {
            var data = new Dictionary<string, int>();
            int suv = 0;
            int taxi = 0;
            int angkot = 0;

            foreach (var item in list)
            {
                if (item.Type == "SUV")
                {
                    suv ++;
                }
                else if (item.Type == "Taxi")
                {
                    taxi++;
                }
                else
                {
                    angkot++;
                }
            }
            data.Add("SUV", suv);
            data.Add("Taxi", taxi);
            data.Add("Angkot", angkot);

            return data;
        }

        public Dictionary<string, decimal> GetTotalRevenueByType(List<Cars> list)
        {
            var data = new Dictionary<string, decimal>();
            decimal totalRevenueSuv = 0M;
            decimal totalRevenueTaxi = 0M;
            decimal totalRevenueAngkot = 0M;
            foreach (var item in list)
            {
                if (item.Type == "SUV")
                {
                    totalRevenueSuv += item.TotalRevenue;
                }
                else if (item.Type == "Taxi")
                {
                    totalRevenueTaxi += item.TotalRevenue;
                }
                else
                {
                    totalRevenueAngkot += item.TotalRevenue;
                }
            }
            data.Add("SUV", totalRevenueSuv);
            data.Add("Taxi", totalRevenueTaxi);
            data.Add("Angkot", totalRevenueAngkot);
            return data;
        }

        public void ShowList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void ShowCountCarsByType(Dictionary<string, int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Type : {item.Key} | Total : {item.Value}");
            }
        }

        public void ShowTotalRevenueCarsByType(Dictionary<string, decimal> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Type : {item.Key} | Total Revenue : {item.Value.ToString("C", new CultureInfo("id-ID"))}");
            }
        }

        public List<Cars> FindRevenueRange(List<Cars> list, decimal startFrom, decimal endTo)
        {
            var carRange = new List<Cars>();

            foreach (var item in list)
            {
                if (item.TotalRevenue >= startFrom && item.TotalRevenue <= endTo)
                {
                    carRange.Add(item);
                }
            }

            return carRange;
        }
    }
}
