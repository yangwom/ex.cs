namespace variable.Test;
using FluentAssertions;
using variable;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
     var instance = new Class1();
     // ferificando se é uma string
     var isString = instance.someString is string;
     isString.Should().Be(true);
    }

}