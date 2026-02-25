using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Models
{
    public class Tabuada
    {
        public void Mostrar(int numero)
        {
            for (int contador = 0; contador <=10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }

    }
}