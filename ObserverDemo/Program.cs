using ObserverDemo.Models;
using System;
using System.Collections.Generic;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto laptop = new Producto("Dell", 10000);
            Cliente cliente1 = new Cliente("Jose");
            Cliente cliente2 = new Cliente("Juan");
            Correo correo  = new Correo(new List<string> { "jvelarde@up.edu.mx","jvicius@gmail.com"});

            laptop.Suscribir(cliente1);
            laptop.Suscribir(cliente2);
            laptop.Suscribir(correo);

            laptop.Precio = 8000;

            laptop.DesSuscribir(cliente2);

            laptop.Precio = 7000;


        }
    }
}
