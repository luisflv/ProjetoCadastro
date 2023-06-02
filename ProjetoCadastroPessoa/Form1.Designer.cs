namespace ProjetoCadastroPessoa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.listBox_Consulta = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_Id_Atualiza = new System.Windows.Forms.TextBox();
            this.lbl_Id_Atualiza = new System.Windows.Forms.Label();
            this.txt_Nome_Atualiza = new System.Windows.Forms.TextBox();
            this.lbl_Nome_Atualiza = new System.Windows.Forms.Label();
            this.lbl_id_excluir = new System.Windows.Forms.Label();
            this.txt_Id_Excluir = new System.Windows.Forms.TextBox();
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.txt_nomeCad = new System.Windows.Forms.TextBox();
            this.lbl_nomeCad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(159, 211);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(144, 67);
            this.btn_Consultar.TabIndex = 2;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(309, 211);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(144, 67);
            this.btn_Atualizar.TabIndex = 3;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualiza_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(459, 211);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(144, 67);
            this.btn_Excluir.TabIndex = 4;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // listBox_Consulta
            // 
            this.listBox_Consulta.FormattingEnabled = true;
            this.listBox_Consulta.Location = new System.Drawing.Point(161, 13);
            this.listBox_Consulta.Name = "listBox_Consulta";
            this.listBox_Consulta.Size = new System.Drawing.Size(142, 186);
            this.listBox_Consulta.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_Id_Atualiza
            // 
            this.txt_Id_Atualiza.Location = new System.Drawing.Point(309, 29);
            this.txt_Id_Atualiza.Name = "txt_Id_Atualiza";
            this.txt_Id_Atualiza.Size = new System.Drawing.Size(144, 20);
            this.txt_Id_Atualiza.TabIndex = 8;
            // 
            // lbl_Id_Atualiza
            // 
            this.lbl_Id_Atualiza.AutoSize = true;
            this.lbl_Id_Atualiza.Location = new System.Drawing.Point(309, 13);
            this.lbl_Id_Atualiza.Name = "lbl_Id_Atualiza";
            this.lbl_Id_Atualiza.Size = new System.Drawing.Size(68, 13);
            this.lbl_Id_Atualiza.TabIndex = 9;
            this.lbl_Id_Atualiza.Text = "Informe o ID:";
            // 
            // txt_Nome_Atualiza
            // 
            this.txt_Nome_Atualiza.Location = new System.Drawing.Point(309, 83);
            this.txt_Nome_Atualiza.Name = "txt_Nome_Atualiza";
            this.txt_Nome_Atualiza.Size = new System.Drawing.Size(144, 20);
            this.txt_Nome_Atualiza.TabIndex = 10;
            // 
            // lbl_Nome_Atualiza
            // 
            this.lbl_Nome_Atualiza.AutoSize = true;
            this.lbl_Nome_Atualiza.Location = new System.Drawing.Point(309, 67);
            this.lbl_Nome_Atualiza.Name = "lbl_Nome_Atualiza";
            this.lbl_Nome_Atualiza.Size = new System.Drawing.Size(83, 13);
            this.lbl_Nome_Atualiza.TabIndex = 11;
            this.lbl_Nome_Atualiza.Text = "Informe o nome:";
            // 
            // lbl_id_excluir
            // 
            this.lbl_id_excluir.AutoSize = true;
            this.lbl_id_excluir.Location = new System.Drawing.Point(456, 13);
            this.lbl_id_excluir.Name = "lbl_id_excluir";
            this.lbl_id_excluir.Size = new System.Drawing.Size(68, 13);
            this.lbl_id_excluir.TabIndex = 12;
            this.lbl_id_excluir.Text = "Informe o ID:";
            // 
            // txt_Id_Excluir
            // 
            this.txt_Id_Excluir.Location = new System.Drawing.Point(459, 29);
            this.txt_Id_Excluir.Name = "txt_Id_Excluir";
            this.txt_Id_Excluir.Size = new System.Drawing.Size(144, 20);
            this.txt_Id_Excluir.TabIndex = 13;
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.Location = new System.Drawing.Point(11, 211);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(144, 67);
            this.btn_Cadastro.TabIndex = 0;
            this.btn_Cadastro.Text = "Cadastrar";
            this.btn_Cadastro.UseVisualStyleBackColor = true;
            this.btn_Cadastro.Click += new System.EventHandler(this.btn_Cad_Click);
            // 
            // txt_nomeCad
            // 
            this.txt_nomeCad.Location = new System.Drawing.Point(11, 29);
            this.txt_nomeCad.Name = "txt_nomeCad";
            this.txt_nomeCad.Size = new System.Drawing.Size(144, 20);
            this.txt_nomeCad.TabIndex = 7;
            // 
            // lbl_nomeCad
            // 
            this.lbl_nomeCad.AutoSize = true;
            this.lbl_nomeCad.Location = new System.Drawing.Point(8, 13);
            this.lbl_nomeCad.Name = "lbl_nomeCad";
            this.lbl_nomeCad.Size = new System.Drawing.Size(83, 13);
            this.lbl_nomeCad.TabIndex = 1;
            this.lbl_nomeCad.Text = "Informe o nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 285);
            this.Controls.Add(this.lbl_nomeCad);
            this.Controls.Add(this.txt_nomeCad);
            this.Controls.Add(this.btn_Cadastro);
            this.Controls.Add(this.txt_Id_Excluir);
            this.Controls.Add(this.lbl_id_excluir);
            this.Controls.Add(this.lbl_Nome_Atualiza);
            this.Controls.Add(this.txt_Nome_Atualiza);
            this.Controls.Add(this.lbl_Id_Atualiza);
            this.Controls.Add(this.txt_Id_Atualiza);
            this.Controls.Add(this.listBox_Consulta);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Consultar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.ListBox listBox_Consulta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_Id_Atualiza;
        private System.Windows.Forms.Label lbl_Id_Atualiza;
        private System.Windows.Forms.TextBox txt_Nome_Atualiza;
        private System.Windows.Forms.Label lbl_Nome_Atualiza;
        private System.Windows.Forms.Label lbl_id_excluir;
        private System.Windows.Forms.TextBox txt_Id_Excluir;
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.TextBox txt_nomeCad;
        private System.Windows.Forms.Label lbl_nomeCad;
    }
}

