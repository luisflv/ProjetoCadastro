using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastroPessoa
{
    public partial class Form1 : Form
    {
        //CRIANDO UMA LISTA PARA RECEBER OBJETOS DO TIPO PESSOA
        List<Pessoa> listaPessoa = new List<Pessoa>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cad_Click(object sender, EventArgs e)
        {
            //CRIANDO UM NOVO OBJETO DO TIPO PESSOA
            Pessoa pes = new Pessoa();

            //ARMAZENANDO O NOME DA PESSOA POR MEIO DO TEXBOX
            pes.Nome = txt_nomeCad.Text;
            pes.Id = listaPessoa.Count + 1;

            //INSERINDO O OBJETO NA LISTA
            listaPessoa.Add(pes);

            //APRESENTANDO UMA MENSAGEM AO FINAL
            //MessageBox.Show("Pessoa cadastrada com sucesso!");

        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            listBox_Consulta.Items.Clear();

            foreach (var item in listaPessoa)
            {
                listBox_Consulta.Items.Add(item.Id + " | " + item.Nome);

            }
        }



        private void btn_Atualiza_Click(object sender, EventArgs e)
        {
            int idAtualiza = Convert.ToInt32(txt_Id_Atualiza.Text);

            foreach (var item in listaPessoa)
            {
                if (idAtualiza == item.Id)
                {
                    item.Nome = txt_Nome_Atualiza.Text;
                    break;
                }
            }

            listBox_Consulta.Items.Clear();

            foreach (var item in listaPessoa)
            {
                listBox_Consulta.Items.Add(item.Id + " | " + item.Nome);

            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            int idExcluir = Convert.ToInt32(txt_Id_Excluir.Text);

            foreach (var item in listaPessoa)
            {
                if (idExcluir == item.Id)
                {
                    item.Nome = txt_Id_Excluir.Text;
                    break;
                }
            }


            listBox_Consulta.Items.Clear();


        }
    }
}
