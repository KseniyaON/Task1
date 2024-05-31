// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

internal class Program
{
    private static void Main(string[] args)
    {

        int[] M = new int[5] { 1, 2, 3, 4, 5 };
        int il = M.Length;



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
        PrintMas(M, il);
    }
}