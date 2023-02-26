// See https://aka.ms/new-console-template for more information
using VogCodeChallenge.ConsoleApp;


Console.WriteLine("Question7");
var namesList = QuestionClass.NamesToAllCaps();
Console.WriteLine(string.Join(" ", namesList));
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Question8");
var sum = OddNumbers.SumOddNumbers();
Console.WriteLine(sum);
Console.WriteLine();
Console.WriteLine();

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