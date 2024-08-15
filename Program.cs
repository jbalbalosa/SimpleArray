
using System.Runtime.InteropServices;

Console.WriteLine("Simple Array!");

int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;

//declare an array
int[] myIntArray = new int[5];

myIntArray[0] = 5;  
myIntArray[1] = 12;  
myIntArray[2] = 45;
myIntArray[3] = 98;
myIntArray[4] = 7;

Console.WriteLine($"{myIntArray[3]}");


Console.ReadKey();
