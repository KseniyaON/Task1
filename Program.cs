using System;
using Microsoft.VisualBasic;

class Program
{
 
  static void Main(string[] args)
  {
    string letterA = "M";
    string letterB = "N";
    int m = 0;
    int n = 0;
    Program p = new Program();

    m = p.CheckInput(letterA);
    n = p.CheckInput(letterB);

    if (m == n)
    {
      Console.WriteLine("числа " + m + " " + n + "равны");
    }
    else
    {
      if (m > n)
      {
        p.NatureNumbers(n, m);
      }
      else
      {
        if (m < n)
        {
          p.NatureNumbers(m, n);
        }
      }
    }
  }

  int CheckInput(string pL)
  {
    int n;
    double m = 0;
    string? Am;
    do
    {
      Console.WriteLine("введите число " + pL);
      Am = Console.ReadLine();
      if (int.TryParse(Am, out n) || double.TryParse(Am, out m))
      {
        if (n > 0)
        {
          return n;
        }
        else
        {
          if (m > 0 & m < 1)
          {
            //n = 1;
            n = 1;
            return n;

          }
          else
          {
            if (m > 1)
            {
              n = (int)m;
              return n;

            }
          }
        }
      }

    }
    while (n <= 0);
    return n;
  }

   int NatureNumbers(int M, int N)
  {

    if (M <= 0)
    {
      NatureNumbers(M + 1, N);
      return M;
    }
    else
    {
      if (M == N)
      {
        Console.WriteLine(M + " ");
        return M;
      }

    }

    Console.Write(M + " ");
    NatureNumbers(M + 1, N);

    return M;
  }

}