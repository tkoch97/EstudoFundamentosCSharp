using Microsoft.VisualBasic;

namespace FundamentosCsharp.IComparable
{
  public class Person : IComparable<Person>
  {
    public string? Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person? other)
    {
      if (other == null)
      {
        return 1;
      }

      return this.Age.CompareTo(other.Age);
    }
  }

  public class Program
  {
    static void Main(string[] args)
    {
      var people = new List<Person>
      {
        new Person { Name = "Thiago", Age = 28 },
        new Person { Name = "Nícolas", Age = 28 },
        new Person { Name = "Gabriel", Age = 26 },
        new Person { Name = "Ário", Age = 27 },
        new Person { Name = "Miguel", Age = 27 },
        new Person { Name = "Luana", Age = 22 },
        new Person { Name = "Maria Eduarda", Age = 19 },
      };

      people.Sort();

      foreach (var p in people)
      {
        Console.WriteLine($"{p.Name} - {p.Age}");
      }
    }
  }
}