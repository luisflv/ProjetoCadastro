namespace CadastroVeiculo
{
    partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_quilometragem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cad_veiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(25, 44);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(183, 20);
            this.txt_modelo.TabIndex = 0;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(25, 107);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(183, 20);
            this.txt_marca.TabIndex = 1;
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(25, 174);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(183, 20);
            this.txt_cor.TabIndex = 2;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(25, 232);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(183, 20);
            this.txt_ano.TabIndex = 3;
            // 
            // txt_quilometragem
            // 
            this.txt_quilometragem.Location = new System.Drawing.Point(25, 292);
            this.txt_quilometragem.Name = "txt_quilometragem";
            this.txt_quilometragem.Size = new System.Drawing.Size(183, 20);
            this.txt_quilometragem.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quilometragem";
            // 
            // btn_cad_veiculo
            // 
            this.btn_cad_veiculo.Location = new System.Drawing.Point(24, 345);
            this.btn_cad_veiculo.Name = "btn_cad_veiculo";
            this.btn_cad_veiculo.Size = new System.Drawing.Size(184, 70);
            this.btn_cad_veiculo.TabIndex = 11;
            this.btn_cad_veiculo.Text = "CADASTRAR VEÍCULO";
            this.btn_cad_veiculo.UseVisualStyleBackColor = true;
            this.btn_cad_veiculo.Click += new System.EventHandler(this.btn_cad_veiculo_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 438);
            this.Controls.Add(this.btn_cad_veiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quilometragem);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_cor);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_modelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_quilometragem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cad_veiculo;
    }
}