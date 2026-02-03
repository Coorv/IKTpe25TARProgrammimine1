namespace MinMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List numbrites");

            int[] numbers = new int[10] { 1, 3, 14, 17, 6, 2, 8, 12, 24, 69 };
            //max
            Console.WriteLine(numbers.Max());
            //min
            Console.WriteLine(numbers.Min());
            //sum
            Console.WriteLine(numbers.Sum());
            //average
            Console.WriteLine(numbers.Average());

            Console.WriteLine("---------------");
            Console.WriteLine("Sorteerib numbrid alates väiksemast suuremani.");

            //Peate kasutama Array ja Sort ning foreach
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Sorteerib numbrid alates suuremast väiksemani.");

            //sorteerib numbrid alates suuremast väiksemani
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
