using Microsoft.VisualBasic;

namespace FundamentosCsharp.IComparable
{
  public class Person : IComparable<Person>
  {
    public required string Name { get; set; }
    public int Age { get; set; }

    public double Height { get; set; }

    public int CompareTo(Person? other)
    {
      if (other == null) return 1;

      int result = this.Age.CompareTo(other.Age);

      if (result == 0)
      {
        result = this.Name.CompareTo(other.Name);
      }

      return result;
    }
  }

  public class PersonHeightComparer : IComparer<Person>
  {
    public int Compare(Person a, Person b)
    {
      if (a == null && b == null) return 0;
      if (a == null) return -1;
      if (b == null) return 1;

      return a.Height.CompareTo(b.Height);
    }
  }

  public class Program
  {
    static void Main(string[] args)
    {
      var people = new List<Person>
      {
        new Person { Name = "Thiago", Age = 28, Height = 1.68 },
        new Person { Name = "Nícolas", Age = 28, Height = 1.85},
        new Person { Name = "Gabriel", Age = 26, Height = 1.68},
        new Person { Name = "Miguel", Age = 27, Height = 1.75},
        new Person { Name = "Ário", Age = 27, Height = 1.72 },
        new Person { Name = "Luana", Age = 22, Height = 1.75 },
        new Person { Name = "Maria Eduarda", Age = 19, Height = 1.60 },
      };

      Console.WriteLine("Ordenando por idade:");
      people.Sort();
      foreach (var p in people)
      {
        Console.WriteLine($"{p.Name} - {p.Age} - {p.Height}");
      }

      Console.WriteLine("Ordenando por estatura:");
      people.Sort(new PersonHeightComparer());
      foreach (var p in people)
      {
        Console.WriteLine($"{p.Name} - {p.Age} - {p.Height}m");
      }
    }
  }
}