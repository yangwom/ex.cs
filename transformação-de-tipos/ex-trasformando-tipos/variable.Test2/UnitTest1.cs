namespace variable.Test2;
using FluentAssertions;
public class UnitTest1
{
     [Fact]
    public void TestVariableConversion()
    {
        Class1 instance = new();
        // primeiro verifica se int Entry é 42
        instance.intEntry.Should().Be(42);
        // verifica se é do tipo int
        var intTypeCheck = instance.intEntry is int;
        // se o retorno é true;
        intTypeCheck.Should().Be(true);
        // verifica se  a função Transform  convert para double
        instance.Transform();
        // testa o retorno
        instance.doubleResponse.Should().Be(42.0);
        // testa se é um double
        var floatTypeCheck = instance.doubleResponse is double;
        // se é true
        floatTypeCheck.Should().Be(true);
    }
}