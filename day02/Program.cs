using day02;
using static System.Console;

//ArrayCase.IntroArray();

//call function
int[] n = { 10, 20, 30, 40 };
var myArray = ArrayCase.InitArrayInt(n);

ArrayCase.DisplayArrayInt(myArray);

var myRandom = ArrayCase.InitArrayRandom(10);
ArrayCase.DisplayArrayInt(myRandom);

WriteLine();
Console.WriteLine($"Total SUM Random {ArrayCase.SumAllElement(myRandom)}");
Console.WriteLine($"Max Number {ArrayCase.FindLargesElement(myRandom)}");

WriteLine();
//copy array dari myRandom to new array
int[] newArray = new int[myRandom.Length];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = myRandom[i];
}
ArrayCase.DisplayArrayInt(newArray);

WriteLine();
//sort array
Array.Sort (newArray);
ArrayCase.DisplayArrayInt(newArray);

//gunakan method
var randomArray = new int[myRandom.Length];
Array.Copy(newArray, 0, randomArray, 0, myRandom.Length);
Array.Reverse(randomArray);

ReadLine();