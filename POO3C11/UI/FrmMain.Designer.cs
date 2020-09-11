namespace POO3C11
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_numPaginas = new System.Windows.Forms.TextBox();
            this.txt_idEditora = new System.Windows.Forms.TextBox();
            this.txt_DataCadastro = new System.Windows.Forms.TextBox();
            this.txt_idAutor = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_idLivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAutor = new System.Windows.Forms.DataGridView();
            this.gridEditora = new System.Windows.Forms.DataGridView();
            this.gridLivros = new System.Windows.Forms.DataGridView();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(536, 219);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(100, 23);
            this.btn_pesquisar.TabIndex = 57;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = "Felipe Braz - 09";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 24);
            this.label11.TabIndex = 53;
            this.label11.Text = "Bernardo Augusto - 02";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(663, 248);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 23);
            this.btn_sair.TabIndex = 52;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(663, 219);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 23);
            this.btn_editar.TabIndex = 51;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(663, 190);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 23);
            this.btn_excluir.TabIndex = 50;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(663, 161);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(100, 23);
            this.btn_inserir.TabIndex = 49;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Preco de Venda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Num Paginas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Data Cadastro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Titulo do Livro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Id da Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Id do Livro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Id do Autor";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(402, 240);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 41;
            // 
            // txt_numPaginas
            // 
            this.txt_numPaginas.Location = new System.Drawing.Point(402, 201);
            this.txt_numPaginas.Name = "txt_numPaginas";
            this.txt_numPaginas.Size = new System.Drawing.Size(100, 20);
            this.txt_numPaginas.TabIndex = 40;
            // 
            // txt_idEditora
            // 
            this.txt_idEditora.Location = new System.Drawing.Point(280, 242);
            this.txt_idEditora.Name = "txt_idEditora";
            this.txt_idEditora.Size = new System.Drawing.Size(100, 20);
            this.txt_idEditora.TabIndex = 39;
            // 
            // txt_DataCadastro
            // 
            this.txt_DataCadastro.Location = new System.Drawing.Point(402, 164);
            this.txt_DataCadastro.Name = "txt_DataCadastro";
            this.txt_DataCadastro.Size = new System.Drawing.Size(100, 20);
            this.txt_DataCadastro.TabIndex = 38;
            // 
            // txt_idAutor
            // 
            this.txt_idAutor.Location = new System.Drawing.Point(280, 205);
            this.txt_idAutor.Name = "txt_idAutor";
            this.txt_idAutor.Size = new System.Drawing.Size(100, 20);
            this.txt_idAutor.TabIndex = 37;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(280, 281);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(100, 20);
            this.txt_titulo.TabIndex = 36;
            // 
            // txt_idLivro
            // 
            this.txt_idLivro.Enabled = false;
            this.txt_idLivro.Location = new System.Drawing.Point(280, 164);
            this.txt_idLivro.Name = "txt_idLivro";
            this.txt_idLivro.Size = new System.Drawing.Size(100, 20);
            this.txt_idLivro.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Editora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Livros";
            // 
            // gridAutor
            // 
            this.gridAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutor.Location = new System.Drawing.Point(523, 18);
            this.gridAutor.Name = "gridAutor";
            this.gridAutor.Size = new System.Drawing.Size(240, 124);
            this.gridAutor.TabIndex = 31;
            // 
            // gridEditora
            // 
            this.gridEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEditora.Location = new System.Drawing.Point(12, 18);
            this.gridEditora.Name = "gridEditora";
            this.gridEditora.Size = new System.Drawing.Size(240, 124);
            this.gridEditora.TabIndex = 30;
            // 
            // gridLivros
            // 
            this.gridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLivros.Location = new System.Drawing.Point(270, 18);
            this.gridLivros.Name = "gridLivros";
            this.gridLivros.Size = new System.Drawing.Size(240, 124);
            this.gridLivros.TabIndex = 29;
            this.gridLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLivros_CellContentClick);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(536, 192);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(100, 20);
            this.txt_pesquisar.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(533, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Pesquisar Nome L";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 312);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_numPaginas);
            this.Controls.Add(this.txt_idEditora);
            this.Controls.Add(this.txt_DataCadastro);
            this.Controls.Add(this.txt_idAutor);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.txt_idLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAutor);
            this.Controls.Add(this.gridEditora);
            this.Controls.Add(this.gridLivros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_numPaginas;
        private System.Windows.Forms.TextBox txt_idEditora;
        private System.Windows.Forms.TextBox txt_DataCadastro;
        private System.Windows.Forms.TextBox txt_idAutor;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_idLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridAutor;
        private System.Windows.Forms.DataGridView gridEditora;
        private System.Windows.Forms.DataGridView gridLivros;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Label label13;
    }
}

