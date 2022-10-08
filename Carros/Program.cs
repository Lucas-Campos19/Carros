using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciamento do objeto
            Veiculo golf = new Veiculo();

            Console.Write("Digite a marca:");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo:");
            string modelo = Console.ReadLine();
            Console.Write("Digite a placa:");
            string placa = Console.ReadLine();
            Console.Write("DIgite o ano de fabricação");
            int ano = int.Parse(Console.ReadLine());

            // objeto chamando o método atribuir 
            golf.atribuir(marca, modelo, placa, ano);
            Console.Write(golf.retorna());

            Console.ReadKey();

        }
    }
}
