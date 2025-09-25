// namespace FundamentosCsharp
// {
//   public sealed class ListaDePresençaSingleton
//   {
//     private static ListaDePresençaSingleton instancia;

//     private ListaDePresençaSingleton()
//     {
//       Console.WriteLine("Lista de presença criada.");
//     }

//     public static ListaDePresençaSingleton GetInstancia
//     {
//       get
//       {
//         if (instancia == null)
//         {
//           instancia = new ListaDePresençaSingleton();
//         }
//         return instancia;
//       }
//     }
//     private readonly List<string> assinaturas = new();
//     public void Assinar(string nome)
//     {
//       assinaturas.Add(nome);
//       Console.WriteLine($"{nome} assinou a lista de presença.");
//     }
//     public void Verificar()
//     {
//       Console.WriteLine("Nomes assinados na lista:");
//       foreach (var a in assinaturas)
//       {
//         Console.WriteLine(a);
//       }
//     }
//   }

//   public class Aluno
//   {
//     public string Nome { get; set; }

//     public Aluno(string nome) => Nome = nome;
//     public void AssinarListaPresença()
//     {
//       ListaDePresençaSingleton.GetInstancia.Assinar(Nome);
//     }
//   }
//   public class Professor
//   {
//     public string Nome { get; set; }

//     public Professor(string nome) => Nome = nome;
//     public void VerificarListaPresença()
//     {
//       Console.WriteLine($"Professor(a) {Nome} verifica a lista.");
//       ListaDePresençaSingleton.GetInstancia.Verificar();
//     }
//   }

//   public class Program
//   {
//     public static void Main(string[] args)
//     {
//       Aluno Nícolas = new("Nícolas");
//       Aluno Thiago = new("Thiago");
//       Aluno JoãoPedro = new("João Pedro");
//       Professor Clíssia = new("Clíssia");

//       Nícolas.AssinarListaPresença();
//       Thiago.AssinarListaPresença();
//       JoãoPedro.AssinarListaPresença();
//       Clíssia.VerificarListaPresença();
//     }
//   }
// }