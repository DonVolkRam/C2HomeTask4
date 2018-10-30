using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Ex2
{
    static class Program
    {
        /// <summary>
        /// Обобщеный расширяющий метод подсчета количества каждого 
        /// элемента встречающийся в обобщенной коллекции.
        /// Принимает в качестве параметра обощеную коллекцию
        /// </summary>
        /// <typeparam name="T">тип коллекции</typeparam>
        /// <param name="self">имя колекции</param>
        /// <returns>возвращает частотный массив</returns>
        public static Dictionary<T, int> CountElements<T>(this List<T> self)
        {
            Dictionary<T, int> elements = new Dictionary<T, int>();
            elements.Add(self[0], 1);
            for (int i = 1; i < self?.Count; i++)
            {
                if (elements.ContainsKey(self[i]))
                    elements[self[i]]++;
                else
                    elements.Add(self[i], 1);
            }
            return elements;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            #region для целочисленной коллекции 
            //List<int> elements = new List<int>();
            //for (int i = 0; i < 100; i++)
            //    elements.Add(rnd.Next(0, 10));

            //foreach (var a in elements)
            //    Console.WriteLine(a);
            //Console.WriteLine("==============================================");
            //Console.WriteLine("элемент  количество");
            //foreach (var b in elements.CountElements())
            //    Console.WriteLine($"{b.Key,5} {b.Value,10}");
            #endregion
            #region для коллекции с плаваюoей точкой            
            //List<double> elements = new List<double>();
            //for (int i = 0; i < 100; i++)
            //    elements.Add(rnd.NextDouble());

            //foreach (var a in elements)
            //    Console.WriteLine(a);
            //Console.WriteLine("==============================================");
            //Console.WriteLine("элемент          количество");
            //foreach (var b in elements.CountElements())
            //    Console.WriteLine($"{b.Key,5} {b.Value,10}");
            #endregion

            #region используя Linq
            List<int> LinqEl = new List<int>();
            for (int i = 0; i < 100; i++)
                LinqEl.Add(rnd.Next(0, 10));    //создаем случайные
            foreach (var a in LinqEl)
                Console.WriteLine(a);   //выводим элементы

            var LinqCount = LinqEl.GroupBy(elem => elem).Select(g => new
            {
                gKey = g.Key,
                gСountEl = g.Count()
            });
            Console.WriteLine("==============================================");
            Console.WriteLine("элемент  количество");
            foreach (var a in LinqCount)
                Console.WriteLine($"{a.gKey,5}{a.gСountEl,10}");
            #endregion
            Console.Read();

        }
    }
}
