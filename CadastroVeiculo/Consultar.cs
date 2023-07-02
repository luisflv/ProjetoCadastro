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
    public partial class Consultar : Form
    {

        ListaVeiculos listaVeiculoConsultar;

        public Consultar(ListaVeiculos listaVeiculo)
        {
            InitializeComponent();
            this.listaVeiculoConsultar = listaVeiculo;
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Veiculo> listV = listaVeiculoConsultar.Consultar();

            if (listV.Count == 0)
            {
                MessageBox.Show("Lista Vazia!");
            }
            else
            {
                foreach (var item in listV)
                {
                    listBox_consulta.Items.Add(item.ToString());
                }

            }



        }

        private void listBox_consulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
