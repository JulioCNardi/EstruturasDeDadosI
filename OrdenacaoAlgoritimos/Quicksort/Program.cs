using System;


// Ordena a lista com quick sort
namespace QuicksortClass
{
    public class Quicksort
    {
        static void Main (string[] args) 
        {
            int[] numbers = new int[] {1,4,6,8,9,3,7,2,5};
            // Imprime a lista desordenada
            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine($"A lista desordenada é: {numbers[i]}");
            }

            Sort(numbers, 0, numbers.Length-1);
            // Imprime a lista ordenada
            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine($"A lista ordenada é: {numbers[i]}");
            }
        }
        
        public static void Swap(int [] numbers, int i, int j){
            int troca = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = troca;
        }

        private static int Partition(int [] numbers, int l, int r) 
        {
            int ndx = l;
            int pivot = numbers[l];
            for (int i = l+1; i<=r; i++) 
            {
                if (numbers[i]<pivot)
                {
                    ndx++;
                    Swap(numbers, ndx, i);
                }
            }
            Swap(numbers, ndx, l);
            return ndx;
        }
        private static void Sort (int[] numbers, int l, int r) 
        {
            if (l<r) 
            {
                var part = Partition(numbers, l, r);
                Sort(numbers,l, part-1);
                Sort(numbers,part+1, r);
            }
        }
    }
}
