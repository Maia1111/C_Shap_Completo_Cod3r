using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisConstantes
    {
        public static void Executar() {

            const double PI = 3.14;

            double raio = 5.5;

            double area = raio * raio * PI;

            Console.WriteLine(area);

            Console.WriteLine("Area: " + area.ToString("F2",CultureInfo.InvariantCulture));


            bool estaChovendo = true;

            byte idade = 45;
            sbyte saldoGols = sbyte.MinValue;

            Console.WriteLine("Esta chovendo: "+estaChovendo);
            Console.WriteLine("Idade: "+idade);
            Console.WriteLine("Mostro o maxímo que sbyte pode armazenar: "+saldoGols+" saldo de gols");



        }
    }
}
