using System;
using System.Collections.Generic;
using System.Text;

namespace C__12oop
{
    public class ArrayHelper
    {
        
        public static void PrintReverse<T>(T[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        
        public static T GetFirstElement<T>(T[] array)
        {
            return array[0];
        }

        
        public static T GetLastElement<T>(T[] array)
        {
            return array[array.Length - 1];
        }

        
        public static bool ContainsElement<T>(T[] array, T value)
        {
            foreach (T item in array)
            {
                if (Equals(item, value))
                {
                    return true;
                }
            }

            return false;
        }

        
        public static int CountElements<T>(T[] array)
        {
            int count = 0;

            foreach (T item in array)
            {
                count++;
            }

            return count;
        }

        
        public static int FindIndex<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Equals(array[i], value))
                {
                    return i;
                }
            }

            return -1;
        }

        
        public static void Swap<T>(T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
