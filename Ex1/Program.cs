using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    /// <summary>
    /// Создан тут исключительно для этого задания
    /// </summary>
    class Asteroid
    {       
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Asteroid> asteroids = new List<Asteroid>();
            //создание коллекции элементов
            for (int i = 0; i < 10; i++)            
                asteroids.Add(new Asteroid());
            //фиксация количества элементов
            int size = asteroids.Count;
            //эмитация случайного удаления элементов 
            while ( asteroids.Count!=0)
            asteroids.RemoveAt(0);
            //созднание прежднего количества элементов плюс один
            for (int i = 0; i < size+1; i++)
                asteroids.Add(new Asteroid());
            //проверка что больше на 1 прежднего
            int chk = asteroids.Count;
        }
    }
}
