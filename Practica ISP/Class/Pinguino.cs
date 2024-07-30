using Practica_ISP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ISP.Class
{
    internal class Pinguino : IAve, IAveNadadora
    {
        public void Cantar()
        {
            Console.WriteLine("Pinguino Canta");
        }

        public void Nadar()
        {
            Console.WriteLine("Pinguino Nada");
        }

        public void PonerHuevo()
        {
            Console.WriteLine("Pinguino pone huevo");
        }
    }
}
