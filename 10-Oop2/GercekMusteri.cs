using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Oop2
{
    //individual
    
    public class GercekMusteri : Musteri //miras - inheritance
                                         //müşteri sınıfında olan her şey oto burda da olur
                                         //ortakları müşteriye al ki hepsinde olsun
                                         //id ve müşteri no oto olacak burda zaten bir daha yazma
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
