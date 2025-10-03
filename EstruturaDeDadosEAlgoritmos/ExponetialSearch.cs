namespace FundamentosCSharp.EstruturaDeDadosEAlgoritmos
{
  public class BinarySearch
  {
    private int[] _arr;
    private int _itenToSearch;

    private int _lowPointer;
    private int _highPointer;

    public BinarySearch(int[] arr, int itenToSearch, int lowPointer = 0, int highPointer = 0)
    {
      _arr = arr;
      _itenToSearch = itenToSearch;
      _lowPointer = lowPointer;
      if (highPointer == 0)
      {
        _highPointer = _arr.Length - 1;
      }
      else
      {
        _highPointer = highPointer;
      }
    }

    public int Search()
    {

      while (_lowPointer <= _highPointer)
      {
        int mid = _lowPointer + ((_highPointer - _lowPointer) / 2);
        if (_arr[mid] == _itenToSearch)
        {
          return mid;
        }
        else if (_arr[mid] < _itenToSearch)
        {
          _lowPointer = mid + 1;
        }
        else
        {
          _highPointer = mid - 1;
        }
      }
      return -1;
    }

  };

  public class ExponentialSearch
  {

    private int[] _arr;
    private int _itenToSearch;

    public ExponentialSearch(int[] arr, int itenToSearch)
    {
      _arr = arr;
      _itenToSearch = itenToSearch;
    }

    public int Search()
    {
      if (_arr[0] == _itenToSearch)
      {
        return 0;
      }

      int arrLenght = _arr.Length;
      int arrIndex = 1;

      while (arrIndex < arrLenght && _arr[arrIndex] < _itenToSearch)
      {
        arrIndex *= 2;
      }

      if (arrIndex < arrLenght && _arr[arrIndex] == _itenToSearch)
      {
        return arrIndex;
      }

      BinarySearch bs = new BinarySearch(_arr, _itenToSearch, arrIndex / 2, Math.Min(arrIndex, arrLenght - 1));

      return bs.Search();

    }

  }



  public class Program
  {
    public static void Main(string[] args)
    {
      int[] numberArr = [21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50];
      int numberToFind = 47;
      var es = new ExponentialSearch(numberArr, numberToFind);
      int numberFindedIndex = es.Search();

      Console.WriteLine($"Número {numberToFind} encontrado no índice {numberFindedIndex}");
    }
  }
}
