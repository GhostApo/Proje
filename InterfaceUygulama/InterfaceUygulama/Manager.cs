using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Manager:IWorker,ISalary,IEat
    {
        public void Work()
        {
            Console.WriteLine("Yönetici çalışır");
        }

        public void getSalary()
        {
            Console.WriteLine("Yönetici maaş alır");
        }

        public void Eat()
        {
            Console.WriteLine("Yemek yer");
        }
    }
}
