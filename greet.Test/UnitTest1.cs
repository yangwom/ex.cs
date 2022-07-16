using Xunit;
using FluentAssertions;

namespace greet.Test;

public class UnitTest1
{
[Theory(DisplayName = "Deve retornar \"Olá\"")]
[InlineData("Olá")]
public void TestGreet(string expected)
{
    var result = Ola.Greet();
    result.Should().Be(expected);
}
}