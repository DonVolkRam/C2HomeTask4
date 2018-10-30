using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;

namespace Ex2
{
    static class Program
    {
        public static Dictionary<T, int> CountElements<T>(this List<T> self)
        {
            Dictionary<T, int> elements = new Dictionary<T, int>();
            elements.Add(self[0], 1);
            for (int i = 1; i < self?.Count; i++)
            {               
                for (int j = 0; j < elements?.Count; j++)
                {
                    if (elements[j].)
                }
            }
            return elements;
        }

        static void Main(string[] args)
        {
            List<int> elements = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                elements.Add(rnd.Next(0, 11));
            }
        }
    }
}
