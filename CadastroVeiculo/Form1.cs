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
    public partial class Form1 : Form
    {
        ListaVeiculos listaVeiculos = new ListaVeiculos();   

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar(listaVeiculos);
            cad.Show();

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Consultar cons = new Consultar(listaVeiculos);
            cons.Show();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Editar edit = new Editar(listaVeiculos);
            edit.Show();
        }
    }
}
