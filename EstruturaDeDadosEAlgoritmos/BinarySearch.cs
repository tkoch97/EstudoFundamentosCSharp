// using System.Globalization;
// using System.Runtime.InteropServices.Marshalling;

// namespace FundamentosCSharp.EstruturaDeDadosEAlgoritmos
// {

//   public class BinarySearch
//   {
//     private int[] _numbers;
//     private int _number;
//     public int Steps { get; private set; }
//     public BinarySearch(int[] Numbers, int Number)
//     {
//       _numbers = Numbers;
//       _number = Number;
//       Steps = 0;
//     }

//     public int Search()
//     {
//       int low = 0;
//       int high = _numbers.Length - 1;

//       while (low <= high)
//       {
//         Steps++;
//         int mid = low + ((high - low) / 2);

//         if (_numbers[mid] == _number)
//         {
//           return mid;
//         }
//         else if (_numbers[mid] > _number)
//         {
//           high = mid - 1;
//         }
//         else
//         {
//           low = mid + 1;
//         }

//       }
//       return -1;
//     }

//   }

//   public class Program
//   {
//     public static void Main(string[] args)
//     {
//       int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//       BinarySearch Number2InArr = new BinarySearch(arr, 2);
//       int index = Number2InArr.Search();

//       Console.WriteLine("Procurando número 2 no array...");
//       Console.WriteLine($"Número 2 encontrado no index {index} em {Number2InArr.Steps} etapas");

//     }
//   }
// }