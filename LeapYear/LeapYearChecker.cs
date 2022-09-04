namespace LeapYear;

public class LeapYearChecker
{
  public bool isLeapYear(int year)
  {
    if (year < 1582)
    {
      throw new ArgumentException("year has to be greater than or equal to 1582");
    }
    return (!(year % 100 == 0 && !(year % 400 == 0)) && year % 4 == 0);
  }
}
