using Practica_ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ISP.Class
{
    public class Loro:IAve,IAveVoladora
    {
        public void Cantar()
        {
            Console.WriteLine("Loro, Canta");
        }
        public void PonerHuevo()
        {
            Console.WriteLine("Loro, Pone huevos");
        }
        public void Volar()
        {
            Console.WriteLine("Loro, Vuela");
        }
    }
}
