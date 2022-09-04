namespace LeapYear.Tests;

public class ProgramTests
{
  [Fact]
  public void main_given_user_input_1996_prints_yay()
  {
    using var reader = new StringReader("1996");
    Console.SetIn(reader);
    using var writer = new StringWriter();
    Console.SetOut(writer);

    var program = Assembly.Load(nameof(LeapYear));
    program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

    var output = writer.GetStringBuilder().ToString().TrimEnd();

    // Substring is used to make sure we only test the last part of the output
    output = output.Substring(output.Length - 3, 3);

    output.Should().Be("yay");
  }

  [Fact]
  public void main_given_user_input_1990_prints_nay()
  {
    using var reader = new StringReader("1990");
    Console.SetIn(reader);
    using var writer = new StringWriter();
    Console.SetOut(writer);

    var program = Assembly.Load(nameof(LeapYear));
    program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

    var output = writer.GetStringBuilder().ToString().TrimEnd();
    output = output.Substring(output.Length - 3, 3);

    output.Should().Be("nay");
  }
}
