// See https://aka.ms/new-console-template for more information
var leapYearChecker = new LeapYear.LeapYearChecker();
Console.WriteLine("enter year: ");
Console.Out.Flush();
int input = int.Parse(Console.ReadLine()!);

if (leapYearChecker.isLeapYear(input))
{
  Console.WriteLine("yay");
}
else
{
  Console.WriteLine("nay");
}
