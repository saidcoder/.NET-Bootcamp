using static System.Console;
using System.Globalization;
//call class cars
using QuizOOP.Vehicles;

//call interface & Implementation
WriteLine("------------------Implementasi Interface--------------");
WriteLine("------------------------------------------------------");
ICars carIntf = new CarsImpl();

var listOfCars = carIntf.InitDataCars();
carIntf.ShowList(listOfCars);
WriteLine("------------------------------------------------------");
WriteLine("------------------Total Cars By Type------------------");
var type = carIntf.GetTotalCarsByType(listOfCars);
carIntf.ShowCountCarsByType(type);

WriteLine("------------------------------------------------------");
WriteLine("-----------------Total Revenue By Type-----------------");
var typeRevenue = carIntf.GetTotalRevenueByType(listOfCars);
carIntf.ShowTotalRevenueCarsByType(typeRevenue);

WriteLine("------------------------------------------------------");
WriteLine("-----------------Total Revenue By Range-----------------");
var carsRevenueRange = carIntf.FindRevenueRange(listOfCars, 500_000, 600_000);
carIntf.ShowList(carsRevenueRange);
Console.WriteLine();

ReadLine();