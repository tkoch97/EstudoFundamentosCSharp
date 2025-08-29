// using System.Dynamic;

// namespace FundamentosCSharp.ValueTypesVsReferenceTypes
// {
//   public struct PersonStruct
//   {
//     public string Name;
//   }

//   public class PersonClass
//   {
//     public string Name;
//   }

//   public class Program
//   {
//     public static void Main(string[] args)
//     {
//       // Exemplo Reference Type
//       PersonClass Pc1 = new PersonClass { Name = "Nícolas" };
//       PersonClass Pc2 = Pc1;
//       Console.WriteLine($"Valor de Pc1: {Pc1.Name}");
//       Pc2.Name = "Aderbal";
//       Console.WriteLine($"Valor de Pc2: {Pc2.Name}");
//       Console.WriteLine($"Valor de Pc1 de novo: {Pc1.Name}");
//       Pc1.Name = "Severino";
//       Console.WriteLine($"Valor de Pc1 mudado: {Pc1.Name}");
//       Console.WriteLine($"Valor de Pc2 mudado: {Pc2.Name}");

//       //Exemplo Value Type
//       PersonStruct Ps1 = new PersonStruct { Name = "Thiago" };
//       PersonStruct Ps2 = Ps1;
//       Console.WriteLine($"Valor de Ps1: {Ps1.Name}");
//       Ps2.Name = "Lorival";
//       Console.WriteLine($"Valor de Ps2: {Ps2.Name}");
//       Console.WriteLine($"Valor de Ps1 de novo: {Ps1.Name}");

//     }
//   }
// }