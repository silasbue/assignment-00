namespace LeapYear.Tests;

public class LeapYearTests
{
  [Fact]
  public void isLeapYear_given_1884_returns_true()
  {
    var leapYearChecker = new LeapYearChecker();

    var result = leapYearChecker.isLeapYear(1884);

    result.Should().Be(true);
  }


  [Fact]
  public void isLeapYear_given_2001_returns_false()
  {
    var leapYearChecker = new LeapYearChecker();

    var result = leapYearChecker.isLeapYear(1884);

    result.Should().Be(true);
  }

  // if year is divisble by 4 and 100 and not 400 it is not a leap year
  [Fact]
  public void isLeapYear_given_1700_returns_false()
  {
    var leapYearChecker = new LeapYearChecker();

    var result = leapYearChecker.isLeapYear(1700);

    result.Should().Be(false);
  }

  // if year is divislbe by 400 it is a leap year
  [Fact]
  public void isLeapYear_given_2000_returns_true()
  {
    var leapYearChecker = new LeapYearChecker();

    var result = leapYearChecker.isLeapYear(2000);

    result.Should().Be(true);
  }
}
