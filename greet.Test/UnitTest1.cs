using Xunit;
using FluentAssertions;

namespace greet.Test;

public class UnitTest1
{
[Theory(DisplayName = "deve retornar as somas dos numeros")]
[InlineData(1,1,2)]
[InlineData(10,10, 20)]
[InlineData(50,80, 130)]
public void TestGreet(int number, int number2, int expected)
{
    var result = Ola.Greet(number, number2);
    result.Should().Be(expected);

}


}