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

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar c = new Cadastrar(listaVeiculos);
            c.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      
        private void panel_resultado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar cons = new Consultar(listaVeiculos);
            cons.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
