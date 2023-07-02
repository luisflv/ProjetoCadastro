namespace CadastroVeiculo
{
    partial class Excluir
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
            this.btn_excluir_veiculo = new System.Windows.Forms.Button();
            this.listBox_excluir = new System.Windows.Forms.ListBox();
            this.txt_id_excluir = new System.Windows.Forms.TextBox();
            this.lbl_id_excluir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_excluir_veiculo
            // 
            this.btn_excluir_veiculo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_excluir_veiculo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_veiculo.ForeColor = System.Drawing.Color.White;
            this.btn_excluir_veiculo.Location = new System.Drawing.Point(12, 377);
            this.btn_excluir_veiculo.Name = "btn_excluir_veiculo";
            this.btn_excluir_veiculo.Size = new System.Drawing.Size(776, 61);
            this.btn_excluir_veiculo.TabIndex = 14;
            this.btn_excluir_veiculo.Text = "EXCLUIR";
            this.btn_excluir_veiculo.UseVisualStyleBackColor = false;
            this.btn_excluir_veiculo.Click += new System.EventHandler(this.btn_excluir_veiculo_Click);
            // 
            // listBox_excluir
            // 
            this.listBox_excluir.FormattingEnabled = true;
            this.listBox_excluir.Location = new System.Drawing.Point(12, 12);
            this.listBox_excluir.Name = "listBox_excluir";
            this.listBox_excluir.Size = new System.Drawing.Size(776, 316);
            this.listBox_excluir.TabIndex = 15;
            // 
            // txt_id_excluir
            // 
            this.txt_id_excluir.Location = new System.Drawing.Point(15, 353);
            this.txt_id_excluir.Name = "txt_id_excluir";
            this.txt_id_excluir.Size = new System.Drawing.Size(179, 20);
            this.txt_id_excluir.TabIndex = 17;
            // 
            // lbl_id_excluir
            // 
            this.lbl_id_excluir.AutoSize = true;
            this.lbl_id_excluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_excluir.Location = new System.Drawing.Point(12, 337);
            this.lbl_id_excluir.Name = "lbl_id_excluir";
            this.lbl_id_excluir.Size = new System.Drawing.Size(21, 13);
            this.lbl_id_excluir.TabIndex = 16;
            this.lbl_id_excluir.Text = "ID";
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_id_excluir);
            this.Controls.Add(this.lbl_id_excluir);
            this.Controls.Add(this.listBox_excluir);
            this.Controls.Add(this.btn_excluir_veiculo);
            this.Name = "Excluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_excluir_veiculo;
        private System.Windows.Forms.ListBox listBox_excluir;
        private System.Windows.Forms.TextBox txt_id_excluir;
        private System.Windows.Forms.Label lbl_id_excluir;
    }
}