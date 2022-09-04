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
    output = output.Substring(output.Length - 3);

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
    output = output.Substring(output.Length - 3);

    output.Should().Be("nay");
  }

  [Fact]
  public void main_given_user_input_string_prints_error()
  {
    var errorText = "please provide a number";
    using var reader = new StringReader("sometext");
    Console.SetIn(reader);
    using var writer = new StringWriter();
    Console.SetOut(writer);

    var program = Assembly.Load(nameof(LeapYear));
    program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

    var output = writer.GetStringBuilder().ToString().TrimEnd();
    output = output.Substring(output.Length - errorText.Length);

    output.Should().Be(errorText);
  }

  [Fact]
  public void main_given_empty_string_prints_error()
  {
    var errorText = "please provide a number";
    using var reader = new StringReader("");
    Console.SetIn(reader);
    using var writer = new StringWriter();
    Console.SetOut(writer);

    var program = Assembly.Load(nameof(LeapYear));
    program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

    var output = writer.GetStringBuilder().ToString().TrimEnd();
    output = output.Substring(output.Length - errorText.Length);

    output.Should().Be(errorText);
  }

  [Fact]
  public void main_given_user_input_1581_prints_error()
  {
    var errorText = "year has to be greater than or equal to 1582";
    using var reader = new StringReader("1581");
    Console.SetIn(reader);
    using var writer = new StringWriter();
    Console.SetOut(writer);

    var program = Assembly.Load(nameof(LeapYear));
    program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

    var output = writer.GetStringBuilder().ToString().TrimEnd();
    output = output.Substring(output.Length - errorText.Length);

    output.Should().Be(errorText);
  }
}
