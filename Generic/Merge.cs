using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Merge
    {
        public void MergeSortArray()
        {

            Console.WriteLine("Enter size of first Array");
            int size_one = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first Array");
            int[] arr_one = new int[size_one];
            for(int i = 0 ; i<size_one;i++)
            {
                arr_one[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Enter size of second Array");
            int size_two = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Array");
            int[] arr_two = new int[size_two];
            for (int i = 0; i < size_two; i++)
            {
                arr_two[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr_one);
            Array.Sort(arr_two);

            int[] mergeArray = new int[size_one+ size_two];
            int index_one = 0 , index_two =0 ;
            for (int i = 0 ;i<size_one+size_two;i++) 
            {
                if (index_one < size_one && (index_two >= size_two || arr_one[index_one] <= arr_two[index_two]))
                {
                    mergeArray[i] = arr_one[index_one];
                    index_one++;
                }
                else
                {
                    mergeArray[i] = arr_two[index_two];
                    index_two++;
                }
            }

            Console.WriteLine("Merged and Sorted array :");
            foreach(int num in mergeArray)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
