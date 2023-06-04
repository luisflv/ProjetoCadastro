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

        ListaVeiculos listaVeiculo;

        public Consultar(ListaVeiculos listaVeiculo)
        {
            InitializeComponent();
            this.listaVeiculo = listaVeiculo;
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Veiculo> listV = listaVeiculo.Consultar();

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
    }
}
