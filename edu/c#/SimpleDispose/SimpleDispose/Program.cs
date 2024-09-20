using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Dispose *****\n");
            // Использовать список с разделителями-запятыми для объявления
            // нескольких объектов, подлежащих освобождению,
            using (MyResourceWrapper rw = new MyResourceWrapper(),
            rw2 = new MyResourceWrapper())
            {
                // Работать с объектами rw и rw2.
            }              
            Console.ReadLine();
        }
    }
    // Реализация интерфейса IDisposable.
    class MyResourceWrapper : IDisposable
    {
        // После окончания работы с объектом пользователь
        // объекта должен вызывать этот метод,
        public void Dispose()
        {
            // Очистить неуправляемые ресурсы...
            // Освободить другие освобождаемые объекты, содержащиеся внутри.
            // Только для целей тестирования.
            Console.WriteLine("***** in Dispose! *****");
        }
    }
}
