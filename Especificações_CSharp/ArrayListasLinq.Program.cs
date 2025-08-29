// namespace FundamentosCSharp.Console.ArrayListasLinq
// {
//   public class Student
//   {
//     public Student(int id, string name, string document, int grade)
//     {
//       Id = id;
//       Name = name;
//       Document = document;
//       Grade = grade;

//       PhoneNumbers = new List<string> { "2198765-4321", "2198765-4322", "2198765-4323" };
//     }

//     public int Id { get; set; }
//     public string Name { get; set; }
//     public string Document { get; set; }
//     public int Grade { get; set; }
//     public List<string> PhoneNumbers { get; set; }
//   }
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       var students = new List<Student>
//       {
//         new Student(1, "João", "12345678901", 10),
//         new Student(2, "Maria", "23456789012", 8),
//         new Student(3, "José", "34567890123", 6),
//         new Student(4, "Ana", "45678901234", 9),
//         new Student(5, "Pedro", "56789012345", 5),
//         new Student(6, "Lucas", "67890123456", 6)
//       };

//       var any = students.Any();
//       var any10 = students.Any(s => s.Grade == 10);
//       var allBelow6 = students.All(s => s.Grade < 6);

//       var single = students.Single(s => s.Id == 3);
//       var singleOrDefault = students.SingleOrDefault(s => s.Document == "45678901234");

//       var first = students.First(s => s.Grade == 6);
//       var firstOrDefault = students.FirstOrDefault(s => s.Grade == 2);

//       var orderByGrade = students.OrderBy(s => s.Grade);
//       var OrderByDescendingGrade = students.OrderByDescending(s => s.Grade);

//       var approvedStudents = students.Where(s => s.Grade >= 6);

//       var grades = students.Select(s => $"{s.Id}: {s.Name} - {s.Grade}"); // Vai retornar um conjunto de strings, formatadas de um conjunto de elementos do tipo Student
//       var PhoneNumbers = students.SelectMany(s => s.PhoneNumbers);

//       var sumGrades = students.Sum(s => s.Grade);
//       var averageGrade = students.Average(s => s.Grade);
//       var maxGrade = students.Max(s => s.Grade);
//       var minGrade = students.Min(s => s.Grade);
//     }
//   }
// }