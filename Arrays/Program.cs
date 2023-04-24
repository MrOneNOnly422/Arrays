using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Enter the elements of the array:");
            int[] array = new int[length];


            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] even = new int[length];
            int[] odd = new int[length];
            int evenCount = 0, 
            oddCount = 0;

            for (int i = 0; i < length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even[evenCount] = array[i];
                    evenCount++;
                }
                else
                {
                    odd[oddCount] = array[i];
                    oddCount++;
                }
            }

            Console.WriteLine("\n\nEven: ");
            PrintArray(even, evenCount);

            Console.WriteLine("\n\nOdd: ");
            PrintArray(odd, oddCount);

            Console.WriteLine("\n\nSum of all even: {0}", ComputeSumEven(even, evenCount));
            Console.WriteLine("\n\nSum of all odd: {0}", ComputeSumOdd(odd, oddCount));
        }

        static void PrintArray(int[] arr, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int ComputeSumEven(int[] arr, int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static int ComputeSumOdd(int[] arr, int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}

           
    

