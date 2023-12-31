using HotelariaJ.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelariaJ.Hotel
{
    internal class Hospede : CheckIn
    {
        public void CadastroH()
        {
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();

            Console.WriteLine("Seja Bem-Vindo, " + nome);
            Console.WriteLine("Agora informe a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Ok, cadastro concluido!");
        }
    }
}
