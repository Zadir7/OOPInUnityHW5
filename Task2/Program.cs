using System;
using System.Linq;

namespace OopInUnity5
{
    /// <summary>
    /// Реализовать метод расширения для поиска количества символов в строке.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку и символ для поиска");
            string stringToCount = Console.ReadLine();
            char charToCount = Console.ReadLine().First();
            Console.WriteLine($"Введенный символ: {charToCount}. В строке {stringToCount.CountSymbols(charToCount)} таких символов.");
        }
    }
    public static class StringCounter
    {
        public static int CountSymbols(this string str, char symbol)
        {
            return str.Where(x => x == symbol).Count();
        }
    }
}
