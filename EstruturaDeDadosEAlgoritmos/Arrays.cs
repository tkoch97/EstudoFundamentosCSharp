// using System;
// using System.Runtime.InteropServices;

// namespace FundamentosCsharp
// {
//   public class Program
//   {
//     static void Main(string[] args)
//     {
//       int[] arrInt = { 42, 255 };

//       Console.WriteLine("Visualizando o array de interios:");
//       for (int i = 0; i < arrInt.Length; i++)
//       {
//         Console.WriteLine($"int[{i}] = {arrInt[i]} -> {Convert.ToString(arrInt[i], 2).PadLeft(32, '0')} (32 bits - cada dígito = 1 bit)");

//         // Iteramos sobre cada inteiro.

//         // Convert.ToString(arrInt[i], 2) converte o número para binário.

//         // PadLeft(32, '0') garante que sempre mostremos 32 bits, mesmo que o número seja pequeno.

//         // Isso mostra como cada int é armazenado bit a bit.
//       }
//       ;

//       Span<int> spanInt = arrInt.AsSpan(); // AsSpan() cria um Span<int>, que é basicamente uma “janela” de memória sobre o array.
//       Span<byte> spanByte = MemoryMarshal.Cast<int, byte>(spanInt); //MemoryMarshal.Cast<int, byte> reinterpretar os mesmos bits como bytes.

//       Console.WriteLine("\nMesmos bits interpretados como byte[]:");
//       for (int i = 0; i < spanByte.Length; i++)
//       {
//         Console.WriteLine($"byte[{i}] = {spanByte[i]} -> {Convert.ToString(spanByte[i], 2).PadLeft(8, '0')} (8 bits - cada dígito = 1 bit)");
//       }
//     }
//   }
// }