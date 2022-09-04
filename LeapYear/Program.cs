// See https://aka.ms/new-console-template for more information
var leapYearChecker = new LeapYear.LeapYearChecker();

Console.WriteLine("enter year: ");
var input = Console.ReadLine();

if (input is null)
{
  Console.WriteLine("please provide a number");
  return;
}

try
{
  int number = int.Parse(input);
  if (leapYearChecker.isLeapYear(number))
  {
    Console.WriteLine("yay");
  }
  else
  {
    Console.WriteLine("nay");
  }
}
catch (System.FormatException)
{
  Console.WriteLine("please provide a number");
}
catch (System.ArgumentException e)
{
  Console.WriteLine(e.Message);
}
