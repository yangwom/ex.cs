namespace condicionais.Test;

using FluentAssertions;
using condicionais;
public class UnitTest1
{
    [Theory(DisplayName = "Deve classificar um polígono.")]
    [InlineData(2,"Não é um polígono")]
    [InlineData(3,"Triângulo")]
    [InlineData(4,"Quadrado")]
    [InlineData(5,"Pentágono")]
    [InlineData(6,"Polígono não identificado")]
    public void TestIdentifyPolygon(int sideCount, string name)
    {
        var instace =  Program.IdentifyPolygon(sideCount);

        

        instace.Should().Be(name);
    }
}