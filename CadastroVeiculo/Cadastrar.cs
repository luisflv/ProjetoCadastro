using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CadastroVeiculo
{
    public partial class Cadastrar : Form    {

       
        public ListaVeiculos listaVeiculo;

        Veiculo v = new Veiculo();

        public Cadastrar(ListaVeiculos listaVeiculos)
        {
            InitializeComponent();
            this.listaVeiculo = listaVeiculos;
        }

        private void btn_cad_veiculo_Click(object sender, EventArgs e)
        {
            try
            {
                v.Modelo = txt_modelo.Text;
                v.Marca = txt_marca.Text;
                v.Cor = txt_cor.Text;
                v.Ano = Convert.ToInt32(txt_ano.Text);
                v.Quilometragem = Convert.ToDouble(txt_quilometragem.Text);

                listaVeiculo.Adicionar(v);

                MessageBox.Show("Veículo cadastrado com sucesso!");
            } catch
            {
                MessageBox.Show("Parâmetro inválido. Tente novamente.", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

    }
}
