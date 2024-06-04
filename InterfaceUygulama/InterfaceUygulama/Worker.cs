using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Worker:IWorker,ISalary,IEat
    {
        public void Work()
        {
            Console.WriteLine("Worker çalışıyor");
        }

        public void Eat()
        {
            Console.WriteLine("Yemek yer");
        }

        public void getSalary()
        {
            Console.WriteLine("Worker maaş alır");
        }
    }
}
