using System;
using Microsoft.VisualBasic;

class Program
{
  int Nature_Numbers(int M, int N)
  {

    if (M <= 0)
    {
      Nature_Numbers(M + 1, N);
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
    Nature_Numbers(M + 1, N);

    return M;
  }

  static void Main(string[] args)
  {
    string letter_A = "M";
    string letter_B = "N";
    int m = 0;
    int n = 0;
    Program p = new Program();

    m = p.Check_Input(letter_A);
    n = p.Check_Input(letter_B);

    if (m == n)
    {
      Console.WriteLine("числа " + m + " " + n + "равны");
    }
    else
    {
      if (m > n)
      {
        p.Nature_Numbers(n, m);
      }
      else
      {
        if (m < n)
        {
          p.Nature_Numbers(m, n);
        }
      }
    }
  }

  int Check_Input(string pL)
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
}