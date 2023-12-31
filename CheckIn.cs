using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelariaJ.Hotel
{
    internal class CheckIn 
    {
        public CheckIn()
        {
            Console.WriteLine("Quantidade de dias que deseja ficar: ");
            var dias = int.Parse(Console.ReadLine());

            if (dias < 5) 
            {
                Console.WriteLine("Sua estadia está confirmada!");
            } else
            {
                Console.WriteLine("Sua estadia passou dos dias disponiveis do Hotel!");
            }
        }
    }
}
