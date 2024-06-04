using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceHayvanUygulaması
{
    class Kopek : IHayvan , IBeslen
    {
        public void Beslen()
        {
            Console.WriteLine("Köpek Et Yedi");
        }

        public void SesCikar()
        {
            Console.WriteLine("Köpek : hav hav");
        }
    }
}
