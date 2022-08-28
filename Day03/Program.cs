using Day03;

//MyCollections.InitList();
//MyCollections.InitStack();
//MyCollections.InitDictionary();
//MyCollections.InitHastSet();
//MyCollections.InitQueue();

//declare List<T>
var list = new List<string>() { "Asep", "Budi", "Charlie" };
var student = MyCollections.GetStudent(ref list);

foreach (var item in student)
{
    Console.WriteLine(item);
}

var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
var myNumbers = MyCollections.GetStudent(ref numbers);
foreach (var item in myNumbers)
{
    Console.WriteLine($"{item}");
}