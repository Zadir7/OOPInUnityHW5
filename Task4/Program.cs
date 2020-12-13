using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        /// <summary>
        /// Преобразовать код с использованием linq-выражения
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>()
                {
                    { "four" , 4 },
                    { "two" , 2 },
                    { "one" , 1 },
                    { "three" , 3 } ,
                }.OrderBy(pair => pair.Value);
            foreach (var pair in dict)
            {
                Console.WriteLine($"{ pair.Key } - { pair.Value }");
            }
        }
    }
}
