using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = { "Adelson", "Alayoson", "Allyson", "Abebel", "Allylson", "Edson" };
            Console.WriteLine("Digite um número de 0 a 6: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("O nome selecionado foi: " + nome[i]);

            Console.ReadKey();
        }
    }
}
