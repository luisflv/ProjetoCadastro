using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public double Quilometragem { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Modelo: {Modelo}  | Marca: {Marca} | Cor: {Cor} | Ano: {Ano} | Quilometragem: {Quilometragem}";
        }
    }
}
