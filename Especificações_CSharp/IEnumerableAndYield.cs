namespace FundamentosCSharp.IEnumerableAndYield
{

  public class Car
  {
    public Guid Id { get; init; }
    public int SerialNumber { get; set; }

    public Car(Guid id, int serialNumber)
    {
      Id = id;
      SerialNumber = serialNumber;
      Console.WriteLine($"Novo Carro gerado! Número de Série: {serialNumber}");
    }
    public override string ToString()
    {
      return $"Carro Id: {Id} e Número de série: {SerialNumber}.";
    }
  }

  public class Program
  {
    public static IEnumerable<Car> CarGenerator()
    {
      Console.WriteLine("Iniciando o Gerador de Carros.");
      for (int i = 1; i <= 100; i++)
      {
        yield return new Car(Guid.NewGuid(), i);
      }
    }

    public static void Main(string[] args)
    {

      IEnumerable<Car> cars = CarGenerator();

      foreach (var car in cars)
      {
        if (car.SerialNumber == 5)
        {
          break;
        }

        Console.WriteLine(car);
      }

    }
  }
}