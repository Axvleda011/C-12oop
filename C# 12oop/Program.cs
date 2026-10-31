namespace C__12oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Reverse:");
            ArrayHelper.PrintReverse(numbers);

            Console.WriteLine("First Element: " +
                ArrayHelper.GetFirstElement(numbers));

            Console.WriteLine("Last Element: " +
                ArrayHelper.GetLastElement(numbers));

            Console.WriteLine("Contains 30: " +
                ArrayHelper.ContainsElement(numbers, 30));

            Console.WriteLine("Count: " +
                ArrayHelper.CountElements(numbers));

            Console.WriteLine("Index of 40: " +
                ArrayHelper.FindIndex(numbers, 40));

            ArrayHelper.Swap(numbers, 0, 4);

            Console.WriteLine("After Swap:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

        }
    }
}
