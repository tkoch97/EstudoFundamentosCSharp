using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

namespace FundamentosCSharp.EstruturaDeDadosEAlgoritmos
{

  public class SlidingWindow
  {
    private string _s;
    public SlidingWindow(string s)
    {
      _s = s;
    }
    public int SearchSmallerSubstringWithTwoOccurrences()
    {
      int l = 0;
      int r = 0;
      int _max = 0;

      Dictionary<char, int> counter = new();

      counter[_s[0]] = 1;

      while (r < _s.Length - 1)
      {
        r++;
        if (counter.ContainsKey(_s[r]))
        {
          counter[_s[r]]++;
        }
        else
        {
          counter[_s[r]] = 1;
        }
        while (counter[_s[r]] == 3)
        {
          counter[_s[l]]--;
          l++;
        }
        _max = Math.Max(_max, (r - l) + 1);

      }
      return _max;

    }

  }

  public class Program
  {
    public static void Main(string[] args)
    {

      string letras1 = "abnnjnlfl";



      var slidingWindow = new SlidingWindow(letras1);

      int smallerSubstringResult = slidingWindow.SearchSmallerSubstringWithTwoOccurrences();

    }
  }
}