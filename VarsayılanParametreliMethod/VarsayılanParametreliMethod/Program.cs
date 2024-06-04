using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarsayılanParametreliMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Sinif s = new Sinif();
            s.Selamla();
            s.Selamla("Deniz");
            Console.ReadLine();
        }
    }
}
