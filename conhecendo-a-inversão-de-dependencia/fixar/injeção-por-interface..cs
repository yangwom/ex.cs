public interface ICarModelRepository
{
    IEnumerable<CarModel> Get();
    
}

public class CarModelRepository : ICarModelRepository
{
    public IEnumerable<CarModel> Get()
    {
        // Detalhes de implementação para pegar os modelos de carro no banco de dados
    }
}

