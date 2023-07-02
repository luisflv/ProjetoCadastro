using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroVeiculo
{
    public partial class Excluir : Form
    {
        ListaVeiculos listaVeiculosExcluir;

        public Excluir(ListaVeiculos listaVeiculos)
        {
            InitializeComponent();
            this.listaVeiculosExcluir = listaVeiculos;

            List<Veiculo> listV = listaVeiculosExcluir.Consultar();

            if (listV.Count == 0)
            {
                MessageBox.Show("Lista Vazia!");
            }
            else
            {
                foreach (var item in listV)
                {
                    listBox_excluir.Items.Add(item.ToString());
                }

            }
        }

        private void btn_excluir_veiculo_Click(object sender, EventArgs e)
        {
            int idExcluir = Convert.ToInt32(txt_id_excluir.Text);

            listaVeiculosExcluir.Excluir(idExcluir);

            MessageBox.Show("Veículo excluído com sucesso!");

            listBox_excluir.Items.Clear();

           
        }
    }
}
