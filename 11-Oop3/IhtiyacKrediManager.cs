using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Oop3
{
    public class IhtiyacKrediManager : IKrediManager
    {
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");
        }
    }
}
