using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
using System.Numerics;

namespace MyApp
{

    class Program
    {

        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa("João", "Silva", new DateTime(1990, 1, 1), "12345678900");
            p1.Peso = 120;
            p1.Altura = 1.78;
            p1.MostrarDados();
            p1.Comer(2.5);
            p1.Comer(3800);
            p1.Correr(7, 30);
            p1.MostrarDados();
            p1.AvaliarIMC();

        }


    }
}