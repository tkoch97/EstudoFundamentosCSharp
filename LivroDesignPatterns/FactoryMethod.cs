namespace FundamentosCsharp
{
  public interface IPersonagem
  {
    void Escolhido();
  }

  public class LiuKang : IPersonagem
  {
    public void Escolhido()
    {
      Console.WriteLine("Liu Kan!");
    }
  }
  public class SubZero : IPersonagem
  {
    public void Escolhido()
    {
      Console.WriteLine("Sub Zero!");
    }
  }
  public class Scorpion : IPersonagem
  {
    public void Escolhido()
    {
      Console.WriteLine("Scorpion!");
    }
  }

  public class FactoryMethod
  {
    public IPersonagem Escolher_Personagem(string personagem)
    {
      switch (personagem)
      {
        case "Liu Kang": return new LiuKang();
        case "Sub Zero": return new SubZero();
        case "Scorpion": return new Scorpion();
        default: return null;
      }
    }

    class Program
    {
      static void Main(string[] args)
      {
        FactoryMethod fm = new FactoryMethod();

        Console.WriteLine("Persoanegm disponíveis: Liu Kang, Sub Zero e Scorpion.");
        Console.WriteLine("Escolha seu personagem.");
        string escolha = Console.ReadLine();
        Console.WriteLine();

        IPersonagem personagem = fm.Escolher_Personagem(escolha);
        Console.WriteLine("Você escolheu: ");
        personagem.Escolhido();
      }
    }
  }
}