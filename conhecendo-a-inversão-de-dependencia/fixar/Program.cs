// See https://aka.ms/new-console-template for more information
namespace legal;
public class Pedal
{

    static void Main()
    {
        Freios freio = new Freios();
         Pedal pedal = new Pedal(freio);
    }
    // injeção por constructor
    private IDispositivo _dispositivo;
    public Pedal(IDispositivo dispositivo)
    {
        _dispositivo = dispositivo;
    }

    public void Pisar()
    {
        _dispositivo.Acionar();
    }
    public void Soltar()
    {
        _dispositivo.Desacionar();
    }
}

public interface IDispositivo
{
    void Acionar();
    void Desacionar();
}

// injeção por meio de interface
public class Freios : IDispositivo
{
    public void Acionar()
    {
        // Frear
    }
    public void Desacionar()
    {
        // Parar de frear
    }
}

public class Motor : IDispositivo
{
    public void Acionar()
    {
        // Acelerar
    }
    public void Desacionar()
    {
        // Parar de acelerar
    }
}

public class Embreagem : IDispositivo
{
    public void Acionar()
    {
        // Desacoplar
    }
    public void Desacionar()
    {
        // Acoplar
    }
}
