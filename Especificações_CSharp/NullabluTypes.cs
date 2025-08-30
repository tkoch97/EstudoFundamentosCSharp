// namespace FundamentosCSharp.NullableTypes
// {
//   public class Person
//   {
//     public int Age { get; set; }
//     public string Name { get; set; }

//     public Person(int age, string name)
//     {
//       Age = age;
//       Name = name;
//     }
//   }
//   public class Program
//   {
//     public static void Main(string[] args)
//     {
//       // Nulable comum "int?"
//       int? CarrosNaGaragem = null;

//       if (CarrosNaGaragem.HasValue)
//       {
//         Console.WriteLine($"{CarrosNaGaragem} carro(s) na garagem.");
//       }
//       else
//       {
//         Console.WriteLine("Nenhum carro na garagem");
//       }

//       // Null-conditional operator
//       Person? Pessoa1 = new Person(30, "Gérson");
//       Person? Pessoa2 = null;

//       Console.WriteLine($"A Primeira pessoa se chama {Pessoa1?.Name} e tem {Pessoa1?.Age} anos.");
//       Console.WriteLine($"A Segunda pessoa se chama {Pessoa2?.Name} e tem {Pessoa2?.Age} anos.");

//       // Null-coalescing operator
//       int? MaiorIdade = null;
//       int MaiorIdadeNoBrasil = MaiorIdade ?? 18;

//       Console.WriteLine($"Atualmente a maioridade no Brasil é considerada a partir dos {MaiorIdadeNoBrasil} anos.");

//       // Atribuição com coalescência nula
//       int? camasNoQuarto = null;
//       if (camasNoQuarto == null || camasNoQuarto <= 1)
//       {
//         camasNoQuarto ??= 1;
//         Console.WriteLine($"Temos {camasNoQuarto} cama no quarto");
//       }
//       else
//       {
//         Console.WriteLine($"Temos {camasNoQuarto} camas no quarto");
//       }
//     }
//   }
// }