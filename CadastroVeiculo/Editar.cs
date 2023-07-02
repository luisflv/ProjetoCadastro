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
    public partial class Editar : Form
    {
        ListaVeiculos listaVeiculo;

        public Editar(ListaVeiculos listaVeiculos)
        {
            InitializeComponent();
            this.listaVeiculo = listaVeiculos;

            List<Veiculo> listV = listaVeiculo.Consultar();

            foreach (var item in listV)
            {
                listBox_consulta_editar.Items.Add(item.ToString());
            }
        }

        

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_veiculo_Click(object sender, EventArgs e)
        {
            try { 
            Veiculo v = new Veiculo();

            v.Modelo = txt_modelo_editar.Text;  
            v.Marca = txt_marca_editar.Text;
            v.Cor = txt_cor_editar.Text;
            v.Ano = Convert.ToInt32(txt_ano_editar.Text);
            v.Quilometragem = Convert.ToDouble(txt_quilo_editar.Text);

            int id_atualiza = Convert.ToInt32(txt_id_editar.Text); 

            listaVeiculo.Atualizar(id_atualiza, v);

            List<Veiculo> listV = listaVeiculo.Consultar();

            listBox_consulta_editar.Items.Clear();

            foreach (var item in listV)
            {
                listBox_consulta_editar.Items.Add(item.ToString());
            }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
