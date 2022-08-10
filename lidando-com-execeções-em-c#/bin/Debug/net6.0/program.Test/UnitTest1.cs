namespace program.Test;

public class UnitTest1
{

[Theory(DisplayName = "Teste para lançamento de exceção em divisão entre dois números inteiros.")]
[InlineData(2013, 0)]
[InlineData(5, 4)]
[InlineData(5, 0)]
[InlineData(10, 2)]
public void TestDivideNumbersException(int numberOne, int numberTwo)
{
  var mathOperations = Pro;

  Action act = () =>  mathOperations.DivideNumbers(numberOne, numberTwo);

  act.Should().Throw<DivideByZeroException>().WithMessage("Não pode dividir um número por zero!");
}
}