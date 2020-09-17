using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFesta
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1, x1, y1, z1, w2, x2, y2, z2, w, x, y, z, resto;

            string[] valores = Console.ReadLine().Split(' ');

            
            w1 =  int.Parse(valores[0]);

            valores = Console.ReadLine().Split(' ');

            x1 = int.Parse(valores[0]);
            y1 = int.Parse(valores[1]);
            z1 = int.Parse(valores[2]);

            valores = Console.ReadLine().Split(' ');

            w2 = int.Parse(valores[0]);

            valores = Console.ReadLine().Split(' ');

            x2 = int.Parse(valores[0]);
            y2 = int.Parse(valores[1]);
            z2 = int.Parse(valores[2]);

            TimeSpan inicio = new TimeSpan(w1, x1, y1, z1);
           // inicio = (w1 - 1) * 24 * 60 * 60 + x1 * 60 * 60 + y1 * 60 + z1;
            //fim = (w2 - 1) * 24 * 60 * 60 + x2 * 60 * 60 + y2 * 60 + z2;
            TimeSpan fim = new TimeSpan(w2, x2, y2, z2);


            TimeSpan duracao = inicio.Subtract(fim);

            Console.WriteLine(duracao);
            Console.ReadLine();
            //duracao = inicio - fim;
            //w = duracao / (24 * 60 * 60);
            // = duracao % (24 * 60 * 60);
            //x = resto / (60 * 60);
            //resto = resto % (60 * 60);
            //y = resto / 60;
            //z = resto % 60;

            //Console.WriteLine(w + " Dia(S)");
            //Console.WriteLine(x + " Hora(S)");
            //Console.WriteLine(y + " Minuto(S)");
            //Console.WriteLine(z + " Segundo(S)");
            //Console.ReadLine();














        }
    }
}
