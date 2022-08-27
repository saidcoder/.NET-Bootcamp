using static System.Console;
using QuizLogic02;

/*var myRandom = day02.RandomArray(6);
day02.DisplayArray(myRandom);

WriteLine();

var myRandomIndex = day02.RandomIndex(myRandom);
day02.DisplayArray(myRandomIndex);*/

//==============NO 2==================
var myArray = new int[] { 15, 2, 30, 12, 10, 5 };
//Console.WriteLine("Before Shifting");
/*day02.DisplayArray(myArray);
WriteLine();
Console.WriteLine("After Shifting");
day02.DisplayArray(day02.SwitchArray(myArray));*/
//======================================
Console.WriteLine();
//================No 3================
//day02.RotateArray(myArray);

//no.4
//day02.RotateRightArray(myArray);

//no 7
//day02.DisplayArray(day02.DuplicateArray());

//no 9
/*var myMatrixDiagonal = day02.MatrixDiagonalReverse(5, 5);
day02.DisplayMatrix(myMatrixDiagonal);*/

//no 10
/*var myMatrixDiagonal = day02.MatrixDiagonalSum(5, 5);
day02.DisplayMatrix(myMatrixDiagonal);*/

//no 11
/*var myMatrix = day02.MatrixSquare(6,6);
day02.DisplayMatrix(myMatrix);*/

//no 12
var myMatrix = day02.MatrixSumSquare(8, 8);
day02.DisplayMatrix(myMatrix);
WriteLine(); 

ReadLine();