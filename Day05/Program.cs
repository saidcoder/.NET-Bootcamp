using static System.Console;
using Day05;

Person yuli = new Customer("Yuli", "Ayu", "yuli@gmail.com", new DateTime(1998, 4, 24), "24-41998");
Customer widi = new Customer("Widi", "Amalia", "widi@gmail.com", new DateTime(1999, 9, 30), "30-91999");
Customer rini = new Customer("Rini", "Marlina", "rini@gmail.com", new DateTime(1999, 8, 4), "48-1999");

var listOfCustomer = new List<Person> { yuli, widi, rini };

var incomeYuli = new Dictionary<string, decimal>
{
    { "Kontrakan", 10_000_000},
    { "Toko", 100_000_000}
};

yuli.TotalIncome(incomeYuli);
yuli.TotalRevenue = yuli.TotalIncome(incomeYuli);

var incomeWidi = new Dictionary<string, decimal>
{
    { "Kosan", 20_000_000},
    { "Jual Online", 100_000_000}
};

widi.TotalIncome(incomeWidi);
widi.TotalRevenue = widi.TotalIncome(incomeWidi);

var incomeRini = new Dictionary<string, decimal>
{
    { "Supermatket", 50_000_000},
    { "Rental Mobil", 40_000_000}
};

rini.TotalIncome(incomeRini);
rini.TotalRevenue = rini.TotalIncome(incomeRini);

foreach (var item in listOfCustomer)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("--------------Revenue Highest------------");
var Highest = listOfCustomer.Where(c => c.TotalRevenue >= 94_000_000).ToList();
foreach (var item in Highest)
{
    Console.WriteLine(item.ToString()); 
}

var listMinimun = listOfCustomer.Min(x => x.TotalRevenue);
Console.WriteLine($" Cust Min Revenue : {listMinimun} ");

var listMaximun = listOfCustomer.Max(x => x.TotalRevenue);
Console.WriteLine($" Cust Max Revenue : {listMaximun} ");

var listLessSthanMax = listOfCustomer.Where(x => x.TotalRevenue < listMaximun);
Console.WriteLine("-------------Revenue less then Highest-------------");
foreach (var item in listLessSthanMax)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("------------------------ Select ---------------------------");
var query = listOfCustomer.Select(cust => new
{ 
    FullName = cust.FirstName+ " " + cust.LastName,
    Email = cust.Email,
    TotalRevenue = cust.TotalRevenue
}
);

foreach (var item in query)
{
    Console.WriteLine(item);
}

/*Console.WriteLine("-----------LinQ-------------");
LinQ.IntroLinq();*/

ReadLine();