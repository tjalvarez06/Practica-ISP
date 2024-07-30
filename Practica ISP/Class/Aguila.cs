using Practica_ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ISP.Class
{
    internal class Aguila : IAve, IAveVoladora, IAveCazadora
    {
        public void Cantar()
        {
            Console.WriteLine("Aguila Canta");
        }

        public void Cazar()
        {
            Console.WriteLine("Aguila Caza");
        }

        public void PonerHuevo()
        {
            Console.WriteLine("Aguila pone huevo");
        }

        public void Volar()
        {
            Console.WriteLine("Aguila Vuela");
        }
    }
}
