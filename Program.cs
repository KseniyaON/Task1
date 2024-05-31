// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int M = 2;
int N = 3;
int acr;

acr = AccerMan(M, N);

int AccerMan(int M, int N)
{
    if (M == 0)
    {
        return N + 1;

    }
    else
    {
        if (M > 0 && N == 0)
        {
            return AccerMan(M - 1, 1);
        }
        else
        {
            if (M > 0 && N > 0)
            {
                return AccerMan(M - 1, AccerMan(M, N - 1));
            }
        }
    }
    return N + 1;

}

// void CalcAccer()
// {



Console.Write(acr);
//}

