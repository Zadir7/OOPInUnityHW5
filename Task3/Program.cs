using System;
using System.Collections.Generic;

namespace Task3
{
    /// <summary>
    /// Дана коллекция List<T>. Требуется подсчитать сколько раз каждый элемент встречается в коллекции.
    /// </summary>
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            List<int> listToSearch = new List<int>();
            for (int i = 0; i < r.Next(15, 25); i++)
            {
                listToSearch.Add(r.Next(9));
            }
            Console.WriteLine("Исходный List<int>:");
            foreach (var item in listToSearch)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("\nЧастотный словарь:");
            foreach (var pair in listToSearch.ListCount())
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }

        
    }
    public static class CountHelper
    {
        public static Dictionary<T, int> ListCount<T>(this List<T> list)
        {
            Dictionary<T, int> result = new Dictionary<T, int>();
            foreach (T item in list)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result.Add(item, 1);
                }
            }
            return result;
        }
    }
}
