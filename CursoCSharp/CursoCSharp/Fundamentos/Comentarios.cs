using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Comentarios    {

       //Ao dar 3 barras o editor cria um sumario de código
      /// <summary>
      /// 
      /// </summary>
      
        public static void Executar() {

            //Cuidado com os comentários desnecessários            
            Console.WriteLine("Codigo claro é sempre melhor");

            Console.WriteLine("O C# tem so XML coments");

            /*Comentários 
             *Esse comentários de multiplas linhas
             *
             */

            Console.WriteLine("O comando CTRL+K+C com o código Selecionado ele comenta");
            Console.WriteLine("O comando CTRL+K+U com o código Selecionado ele descomenta");
          

        }
    }
}
