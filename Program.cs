// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

    public static void Main(string[] args)
    {
        int [] M=new int [5]{1,2,3,4,5};
        int il=M.Length;
        PrintMas(M, il);
    }

void PrintMas(int[] arr, int il)
{
    il = il - 1;
    if (il > 0 || il == 0)
    {
        Console.Write(arr[il] + " ");
        PrintMas(arr, il);
    }
    
    
    return;
}


