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
    public partial class Excluir : Form
    {
        ListaVeiculos listaVeiculos;

        public Excluir(ListaVeiculos listaVeiculos)
        {
            InitializeComponent();
            this.listaVeiculos= listaVeiculos;
        }
        
    }
}
