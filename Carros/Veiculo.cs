using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    internal class Veiculo
    {
        // declaração de atributos
        string marca;
        string modelo;
        string placa;
        int ano;
        // método para atribuir valores
        public void atribuir(string ma, string mo, string pl, int a)
        {
            this.ano = a;
            this.marca = ma;
            this.modelo = mo;
            this.placa = pl;
        }
        public string retorna()
        {
            return "\nMarca =" + this.marca +
                   "\nModelo =" + this.modelo +
                   "\nAno de fabricação =" + this.ano +
                   "\nPlaca =" + this.placa;
        }




    }
}
