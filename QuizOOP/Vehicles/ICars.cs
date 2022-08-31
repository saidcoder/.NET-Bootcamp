using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Vehicles
{
    internal interface ICars
    {
        public List<Cars> InitDataCars();

        public void ShowList<T>(List<T> list);

        public Dictionary<string, int> GetTotalCarsByType(List<Cars> list);

        public void ShowCountCarsByType(Dictionary<string, int> list);

        public Dictionary<string, decimal> GetTotalRevenueByType(List<Cars> list);
        public void ShowTotalRevenueCarsByType(Dictionary<string, decimal> list);

        public List<Cars> FindRevenueRange(List<Cars> list, decimal startFrom, decimal endTo);
    }
}
