using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    public class Diak
    {
        public String Név { get; set; }
        public int Életkor { get; set; }
        public int Magasság { get; set; }
        public int Súly { get; set; }

        public Diak(string név, int életkor, int magasság, int súly)
        {
            Név = név;
            Életkor = életkor;
            Magasság = magasság;
            Súly = súly;
        }

        public override string? ToString()
        {
            return $"Név: {Név}, Életkor: {Életkor}, Magasság: {Magasság} cm, Súly: {Súly} kg";
        }
    }
}
