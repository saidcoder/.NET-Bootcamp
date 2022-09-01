using FinalTest;

//No 1
Console.WriteLine("-----------No 1-------------");
Test.KatakLompat();

//No 2
Console.WriteLine("-----------No 2-------------");
Console.WriteLine($" 8! = {Test.CountFactorial()}");

//No 3
Console.WriteLine("-----------No 3-------------");
Console.WriteLine($" SUM 8 = {Test.SumNumber()}");

//No 4
Console.WriteLine("-----------No 4-------------");
Console.WriteLine($" Fibonacci 8 = {Test.Fibonacci()}");

//No 5
Console.WriteLine("-----------No 5-------------");
Test.AllFibonacci();
Console.WriteLine();

//No 6
Console.WriteLine("-----------No 6-------------");
Console.WriteLine($" input : kurawal = {Test.CheckKurawal()}");

//No 7
Console.WriteLine("-----------No 7-------------");
Console.WriteLine($" Hello == Heoll : {Test.IsAnagram()}");

//No 8
Console.WriteLine("-----------No 8-------------");
var myMatrix = Test.Matrix(5, 5);
Test.DisplayMatrix(myMatrix);



Console.ReadLine();