using static System.Console;
//call class employee
using Day04.PartOne;
using Day04.PartTwo;
using System.Collections.Generic;
using System.Globalization;


/*//setiap create object instance, gunakan operator class
Employee emp1 = new Employee(1002, "Dyass", "Alx", DateTime.Now, 5_500_000, "Programmer");

//create object Employee with parameter constructor
Employee emp2 = new Employee(1001, "Said", "Farid", new DateTime(), 5_000_000);
emp2.Role = "Sales";

Employee emp3 = new Employee(1003, "Budi", "Setiawan", new DateTime(), 6_000_000, "QA");
*/
//gunakan encapsulation untuk manipulasi attribut object
/*emp1.firstName = "Said";
emp1.empId = 1001;*/

/*Console.WriteLine(emp1.ToString());
Console.WriteLine(emp2.ToString());
Console.WriteLine(emp3.ToString());
Console.WriteLine($"Total Employee : {Employee.totalEmployee}");
Console.WriteLine($"Total Basic Salary : {Employee.totalBasicSalary}");*/

//Console.WriteLine();
//create object programmer
/*Programmer prog1 = new Programmer(1004, "Bejo", "arianto",
    new DateTime(2021, 7, 12), 5_500_000, 500_000);*/
/*
//create object sales
Sales sale1 = new Sales(1006, "Hito", "nami",
    new DateTime(2020, 7, 18), 4_500_000, 500_000, 200_000);

QA q1 = new QA(1008, "Ellise", "Toon", new DateTime(2019, 8, 17), 4_500_000, 10_000);
*/
//store to list
/*List<Employee> empList = new List<Employee>() { emp1, emp2, emp3, prog1, sale1, q1 };
foreach (var item in empList)
{
    Console.WriteLine(item.ToString());
}*/
WriteLine("----------------------Implementasi Interface-----------");
//call interface & Implementation

IEmployee empinf = new EmployeeImpl();

var listOfEmps = empinf.InitDataEmployee();
empinf.ShowList(listOfEmps);

var emp = empinf.FindEmployeeById(listOfEmps, 1002);
WriteLine($"Found : {emp}");

var total = empinf.GetTotalSalary(ref listOfEmps);
WriteLine($"Total Salary : {total.ToString("C", new CultureInfo("id-ID"))}");

WriteLine("---------------------Salary range--------------------------");
var empsSalaryRange = empinf.FindSalaryRange(listOfEmps,3_000_000,5_000_000);
empinf.ShowList(empsSalaryRange);

ReadLine();