namespace fixar.Test;
using fixar;
using FluentAssertions;
public class UnitTest1
{
    [Theory]
    [InlineData(10,20)]
    public void Test1(int xEntry, int yEntry)
    {
    var point = new Point(xEntry, yEntry);
    point.x.Should().Be(xEntry);
    point.y.Should().Be(yEntry);
    }
}

public class testGame

{
[Theory(DisplayName = "Deve conter um valor para o tipo de jogo")]
[InlineData(GameType.Action)]
[InlineData(GameType.Adventure)]
[InlineData(GameType.Sports)]
[InlineData(GameType.Other)]
public void ShouldContainGameType(GameType gameType)
{
    Game game = new Game(gameType);
    game.Type.Should().Be(gameType);
    game.Type.ToString().Should().BeEquivalentTo(gameType.ToString());
}
}

public class testeGame2 
{
    [Theory(DisplayName = "Deve conter um valor para o tipo de jogo")]
[InlineData(0)]
[InlineData(1)]
[InlineData(2)]
public void ShouldContainGameType(int gameTypeValue)
{
    // Aqui utilizamos o valor inteiro gameTypeValue
    // para instanciar um novo valor de GameType a partir dele
    var gameType = (GameType)gameTypeValue;
    // Agora a variável gameType tem um valor do tipo GameType
    // E pode ser utilizada em qualquer trecho do código normalmente

    Game game = new Game(gameType);
    game.Type.Should().Be(gameType);
    game.Type.Should().Be((GameType)gameTypeValue);
    game.Type.ToString().Should().BeEquivalentTo(gameType.ToString());
}
}
