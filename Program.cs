using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort_algorithm {
    class Program {

        public static int amount_printed_indices_swaps = 0;
        static void Main(string[] args) {
            //take user input for quicksort algorithm
            Console.WriteLine("Enter the number of elements in the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //call the quicksort function
            Quicksort(arr, 0, n - 1);
            Console.ReadLine();
        }

        public static void Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(arr, left, right);
                if(p>1)
                    Quicksort(arr, left, p - 1);
                if (p + 1 < right)
                    Quicksort(arr, p + 1, right);
            }
        }

        //partition function that will return the index of the pivot
        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true){

                while (arr[left] < pivot){
                    left++;
                }

                while (arr[right] > pivot){
                    right--;
                }

                if (left < right){
                    if (arr[left] == arr[right])
                        return right;
                    Swap(arr, left, right);
                }else{
                    return right;
                }
            }
        }

        //swap function that will swap the elements and print the indices of the elements swapped
        public static void Swap(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            if (amount_printed_indices_swaps < 3)
            {
                Console.WriteLine("Swap at index " + left + "(" + arr[right] + ") and " + right + "(" + arr[left] + ")");
                amount_printed_indices_swaps++;
            }
        }
    }
}
