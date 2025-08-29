// Console.WriteLine("Hello, what is your name?");
// var name = Console.ReadLine();
// double doubleValue = 3.14;
// float floatValue = 3.14f;
// decimal decimalValue = 3.14m;
// int intValue = 42;
// bool boolValue = true;
// char charValue = 'A';
// string stringValue = "Nice to meet you,";

// Console.WriteLine(
//   $"{stringValue} {name}!\nLook values of variables:\nDouble: {doubleValue},\nFloat: {floatValue},\nDecimal: {decimalValue},\nInt: {intValue},\nBool: {boolValue},\n Char: {charValue},"
// );

// #region Estruturas de condição - if, else if, else

// var nota = 6;

// if (nota >= 7)
// {
//   Console.WriteLine("Aluno aprovado!");
// }
// else if (nota >= 5)
// {
//   Console.WriteLine("Aluno em recuperação!");
// }
// else
// {
//   Console.WriteLine("Aluno reprovado!");
// }

// #endregion

// #region Estruturas de condição - switch

// // var dia = 5;

// // switch (dia)
// // {
// //   case 1:
// //     Console.WriteLine("Domingo");
// //     break;
// //   case 2:
// //     Console.WriteLine("Segunda-feira");
// //     break;
// //   case 3:
// //     Console.WriteLine("Terça-feira");
// //     break;
// //   case 4:
// //     Console.WriteLine("Quarta-feira");
// //     break;
// //   case 5:
// //     Console.WriteLine("Quinta-feira");
// //     break;
// //   case 6:
// //     Console.WriteLine("Sexta-feira");
// //     break;
// //   case 7:
// //     Console.WriteLine("Sábado");
// //     break;
// //   default:
// //     Console.WriteLine("Dia inválido");
// //     break;
// // }


// // switch (nota)
// // {
// //   case double n when n >= 7:
// //     Console.WriteLine("Aluno aprovado!");
// //     break;
// //   case double n when n >= 5:
// //     Console.WriteLine("Aluno em recuperação!");
// //     break;
// //   case double n when n < 5:
// //     Console.WriteLine("Aluno reprovado!");
// //     break;
// // }

// // var nota = 8.0;

// // string resultado = nota switch
// // {
// //   double n when n >= 7 => "Aluno aprovado!",
// //   double n when n >= 5 => "Aluno em recuperação!",
// //   double n when n < 5 => "Aluno reprovado!",
// //   _ => "Nota inválida!"
// // };
// // Console.WriteLine(resultado);

// #endregion

// #region Matrizes

// int[] matrizUnidimensional = { 1, 4, 3, 2, 5 };
// var matrizUniVazia = new int[5];

// var tamanhoMatriz = matrizUnidimensional.Length;
// var dimensaoMatriz = matrizUnidimensional.Rank;
// Console.WriteLine($"Tamanho da matriz unidimensional: {tamanhoMatriz}, Dimensão: {dimensaoMatriz}");

// Array.Sort(matrizUnidimensional);

// Array.Reverse(matrizUnidimensional);

// #endregion

// Console.ReadLine();