using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {       
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                { "four" , 4 },
                { "two" , 2 },
                { "one" , 1 },
                { "three" , 3 },
            };
            //необходимо раскоментарить для проверки
            //Задача 3
            //Исхожный текст
            //var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; });

            //задание 3.а
            //var d = dict.OrderBy(pair => pair.Value);

            //задание 3.b
            int GetValue(KeyValuePair<string, int> D) { return D.Value; }
            var d = dict.OrderBy(GetValue);

            foreach (var pair in d)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }

            Console.Read();
        }
    }
}
