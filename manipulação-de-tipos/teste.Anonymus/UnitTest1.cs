using tipos_avançados;
using FluentAssertions;
namespace teste.Anonymus;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
     var result = someClass.getAllContacts();
        var expected = new[]
            {
                new{name = "John", number = "1111-1111"},
                new{name = "Steve", number = "2222-2222"},
                new{name = "Clara", number = "3333-3333"},
                new{name = "Ana", number = "4444-4444"}
            };
     result.Should().BeEquivalentTo(expected);   

    }
}

public class UnitTest2
{
    [Fact(DisplayName = "Deve criar uma lista com tipo genérico.")]    
    public void TestCreateGenericList()
    {
        GenericList<int> list1 = new GenericList<int>();
        list1.GetType().Should().Be(typeof(GenericList<int>));

        GenericList<string> list2 = new GenericList<string>();
        list2.GetType().Should().Be(typeof(GenericList<string>));

        GenericList<someClass> list3 = new GenericList<someClass>();
        list3.GetType().Should().Be(typeof(GenericList<someClass>));
    }
}