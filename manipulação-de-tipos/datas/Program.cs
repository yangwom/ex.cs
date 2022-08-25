// See https://aka.ms/new-console-template for more informatio
using static System.Console;
public class DataUtil
{
    public static void Main(string[] args)
    {
//         Formato	Saída
// “d”	6/15/2008
// “D”	Sunday, June 15, 2008
// “f”	Sunday, June 15, 2008 9:15 PM
// “F”	Sunday, June 15, 2008 9:15:07 PM
// “g”	6/15/2008 9:15 PM
// “G”	6/15/2008 9:15:07 PM
// “m”	June 15
// “o”	2008-06-15T21:15:07.0000000
// “R”	Sun, 15 Jun 2008 21:15:07 GMT
// “s”	2008-06-15T21:15:07
// “t”	9:15 PM
// “T”	9:15:07 PM
// “u”	2008-06-15 21:15:07Z
// “U”	Monday, June 16, 2008 4:15:07 AM
// “y”	June, 2008
        var date = new DateTime(2022, 10, 2, 8, 35, 0);
        var dataOnly = date;
        WriteLine( "eu aqui " + dataOnly.ToString("T"));
        /*
        .DateTime.Now
        Essa propriedade obtém e retorna uma instância da classe DateTime com os campos configurados 
        para o momento de tempo exato em que a propriedade foi chamada, 
        e expressa como a hora local.
        Bora ver esse retorno?
        */
        var dataType = DateTime.Now;
        WriteLine(dataType.GetType());
        WriteLine(GetTimeNow());
    }
    public static string GetTimeNow()
    {
        /*
        A DateTime também oferece uma série de funções para ajudar a 
        manipular os objetos de momento de tempo, sendo as mais utilizadas:

.Add(TimeSpan value)
O método .Add() soma um TimeSpan, positivo ou negativo, à data que chamou o método.

TimeSpan representa um intervalo de tempo, você pode conferir a documentação completa.

Por exemplo, vamos criar um código que pega a data de hoje e soma 36 dias a ela:
        */
        var today = DateTime.Now;
        var duration = new TimeSpan(36, 0, 0, 0);
        var answer = today.Add(duration);

        WriteLine("Hoje é " + today.Day + "/" + today.Month + " - " + today.DayOfWeek);
        WriteLine("Daqui a 36 dias será " + answer.Day + "/" + answer.Month + " - " + answer.DayOfWeek);

        // Time span com numeros negativos para calcular dias anteriores
        /*
        Pergunta🧐: E se eu quiser adicionar especificamente e de forma mais
         legível uma quantidade de anos, meses, dias,
         horas, minutos, segundos ou até mesmo milissegundos?

Resposta🤩: A DateTime possui diversas métodos Add para valores específicos. Olha só:

.AddYears(int value): Adiciona uma quantidade de anos a uma data.
.AddMonths(int value): Adiciona uma quantidade de meses a uma data.
.AddDays(double value): Adiciona uma quantidade de dias a uma data.
.AddHours(double value): Adiciona uma quantidade de horas a uma data.
.AddMinutes(double value): Adiciona uma quantidade de minutos a uma data.
.AddSeconds(double value): Adiciona uma quantidade de segundos a uma data.
.AddMilliseconds(double value): Adiciona uma quantidade de milissegundos a uma data.
        */
        var today1 = DateTime.Now;
        var answer1 = today1.AddDays(-36);
        WriteLine("Hoje é " + today1.Day + "/" + today1.Month + " - " + today1.DayOfWeek);
        WriteLine("36 atrás era " + answer1.Day + "/" + answer1.Month + " - " + answer1.DayOfWeek);
        return "O momento de tempo atual é " + DateTime.Now;

    }

    public static string GetTimeToday()
    {
        return "A data  atual é " + DateTime.Today;
    }

    public static string GetTimeDay()
    {
        var date = new DateTime(2022, 10, 2, 8, 35, 0);
        return "representando o dia " + date.Day;
    }

    public static string GetTimeMonth()
    {
        var date = new DateTime(2022, 10, 2, 8, 35, 0);
        return "representando o mes " + date.Month;
    }


    public static string GetTimeYear()
    {
        var date = new DateTime(2022, 10, 2, 8, 35, 0);
        return "representando o ano " + date.Year;
    }

     public static void CompareDate()
    {
            DateTime date1 = new DateTime(2010, 9, 1, 5, 0, 0);
            DateTime date2 = new DateTime(2022, 8, 10, 12, 0, 0);

            int result = DateTime.Compare(date1, date2);
            string relationship;

            if (result < 0) relationship = "é anterior à";
            else if (result == 0) relationship = "è o mesmo que";
            else relationship = "è posterior à";

            Console.WriteLine("{0} {1} {2}", date1, relationship, date2);
    }
}

