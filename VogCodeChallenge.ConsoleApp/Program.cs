// See https://aka.ms/new-console-template for more information
using System.Reflection;
using VogCodeChallenge.ConsoleApp;

//Queation 7 - Names to Uppercase without using a foreach loop
Console.WriteLine("Question7");
var namesList = QuestionClass.NamesToAllCaps();
Console.WriteLine(string.Join(" ", namesList));
Console.WriteLine();
Console.WriteLine();


//Question 8 - add all odd numbers from 0 to 100
Console.WriteLine("Question8");
var sum = OddNumbers.SumOddNumbers();
Console.WriteLine(sum);
Console.WriteLine();
Console.WriteLine();

//Question9 - switch case with different value types
Console.WriteLine("Question9");
Console.WriteLine("A input of 3 returns " + SWITCHModules.SWITCHModule(3));
Console.WriteLine("A input of 5 returns " + SWITCHModules.SWITCHModule(5));
try
{
    var negativeInt = SWITCHModules.SWITCHModule(-1);
}
catch (Exception ex)
{
    Console.WriteLine("A input of -1 returns " + ex.Message);
}
Console.WriteLine("A input of 1.0f returns " + SWITCHModules.SWITCHModule(1.0f));
Console.WriteLine("A input of mystring returns " + SWITCHModules.SWITCHModule("mystring"));
Console.WriteLine("An input of 1.0m returns  " + SWITCHModules.SWITCHModule(1.0m));
Console.WriteLine();
Console.WriteLine();

//Quetsion 12 - sealed class circle
Console.WriteLine("Question12");
var myCircle = new Circle();

// Use reflection to get an object that represents the radius
FieldInfo radiusField = typeof(Circle).GetField("radius", BindingFlags.NonPublic | BindingFlags.Instance);

if (radiusField == null) throw new ArgumentNullException();
int radius = 5;
// Use reflection to set the value of the radius
radiusField.SetValue(myCircle, 5);

double diameter = myCircle.CalculateDiameter(r => r * 2);

Console.WriteLine($"The diameter of a Circle with the radius of {radius} is {diameter}", radius, diameter);
Console.WriteLine();