using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroVeiculo
{
    public class ListaVeiculos
    {

        public List<Veiculo> listaVeiculos = new List<Veiculo>();

        public void Adicionar(Veiculo veiculo)
        {
            listaVeiculos.Add(veiculo);
            veiculo.Id = listaVeiculos.Count;
        }

        public List<Veiculo> Consultar()
        {
            return listaVeiculos;   
        }

        public void Atualizar(int id, Veiculo veiculo)
        {
            foreach (var item in listaVeiculos)
            {
                if (id == item.Id)
                {
                    item.Modelo = veiculo.Modelo;
                    item.Marca = veiculo.Marca;
                    item.Cor = veiculo.Cor;
                    item.Ano= veiculo.Ano;  
                    item.Quilometragem  =  veiculo.Quilometragem;
                    break;
                }
            }
        }

        public void Excluir(int id)
        {
            foreach (var item in listaVeiculos)
            {
                if (id == item.Id)
                {
                    listaVeiculos.Remove(item);
                    break;
                }
            }
        }

    }
}
