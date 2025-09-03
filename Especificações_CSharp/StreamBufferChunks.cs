// using System.Text;

// namespace FundamentosCSharp.StreamBufferChunks
// {
//   // Exercitar tipos de Stream
//   public class FileObject
//   {
//     public string? Path { get; set; }
//     public string? TextContent { get; set; }
//   }

//   class Program
//   {
//     public static void Main(string[] args)
//     {
//       var TextFile = new FileObject
//       {
//         Path = "FileStreamExample.txt",
//         TextContent = "Hello From FileStream"
//       };

//       //Usar o FileStrem - fluxo de escrita e leitura de arquivos.

//       //Escrever Arquivo
//       using (FileStream fs = new FileStream(TextFile.Path, FileMode.Create, FileAccess.Write))
//       {
//         var buffer = Encoding.UTF8.GetBytes(TextFile.TextContent);
//         fs.Write(buffer, 0, buffer.Length);
//       }

//       //Ler o arquivo
//       using (FileStream fs = new FileStream(TextFile.Path, FileMode.Open, FileAccess.Read))
//       {
//         var buffer = new byte[fs.Length];
//         fs.Read(buffer, 0, buffer.Length);
//         var result = Encoding.UTF8.GetString(buffer);
//         Console.WriteLine(result);
//       }
//     }
//   }
// }