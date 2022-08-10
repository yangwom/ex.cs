namespace repetição.Test;
using FluentAssertions;

public class UnitTest1
{
    [Theory(DisplayName = "Deve realizar a contagem do valor passado como parâmetro.")]
    [InlineData(new int[]{1, 1, 1}, 1, 3)]
    [InlineData(new int[]{1, 2, 1}, 1, 2)]
    [InlineData(new int[]{1, 2, 3}, 1, 1)]
    public void TestCountOf(int[] entnumbers, int value, int countExpected)
    {        
        var count = Program.CountOf(entnumbers, value );
        count.Should().Be(countExpected);
    }


    public class TestNumbersTools
{
    [Theory(DisplayName = "Deve localizar a posição do número no vetor.")]
    [InlineData(new int[]{5, 6, 7}, 5, 0)]
    [InlineData(new int[]{8, 9, 10}, 9, 1)]
    [InlineData(new int[]{11, 12, 13}, 13, 2)]
    [InlineData(new int[]{11, 12, 13, 13}, 13, 2)]
    [InlineData(new int[]{11, 12, 13}, 10, -1)]
    public void TestIndexOf(int[] entnumbers, int value, int positionExpected)
    {        
        var position = Program.IndexOf(entnumbers, value);
        position.Should().Be(positionExpected);
    }
}
    }