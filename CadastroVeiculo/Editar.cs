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
        }

        

        private void Editar_Load(object sender, EventArgs e)
        {

        }
    }
}
