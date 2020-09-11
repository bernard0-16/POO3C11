using System;
using POO3C11.BLL;
using POO3C11.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO3C11
{
    public partial class Form1 : Form
    {
        TBLautorBLL Autorbll = new TBLautorBLL();
        TBLautorDTO Autordto = new TBLautorDTO();
        TBLlivrosBLL Livrobll = new TBLlivrosBLL();
        TBLlivroDTO Livrodto = new TBLlivroDTO();
        TBLeditoraBLL Editorabll = new TBLeditoraBLL();
        TBLeditoraDTO Editoradto = new TBLeditoraDTO();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridAutor.DataSource = Autorbll.ListarTodosA();
            gridEditora.DataSource = Editorabll.ListarTodasE();
            gridLivros.DataSource = Livrobll.ListarTodosL();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                Livrodto.IdAutor = int.Parse(txt_idAutor.Text);
                Livrodto.IdEditora = int.Parse(txt_idEditora.Text);
                Livrodto.Titulo = txt_titulo.Text.ToString();
                Livrodto.DataCadastro = txt_DataCadastro.Text.ToString();
                Livrodto.NumPaginas = int.Parse(txt_numPaginas.Text.ToString());
                Livrodto.Valor = int.Parse(txt_valor.Text.ToString());


                Livrobll.InserirL(Livrodto);
                MessageBox.Show("Livro inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridLivros.DataSource = Livrobll.ListarTodosL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                Livrodto.IdLivro = int.Parse(txt_idLivro.Text);
                Livrodto.IdEditora = int.Parse(txt_idEditora.Text.ToString());
                Livrodto.IdAutor = int.Parse(txt_idAutor.Text.ToString());
                Livrodto.Titulo = txt_titulo.Text.ToString();
                Livrodto.DataCadastro = txt_DataCadastro.Text.ToString();
                Livrodto.NumPaginas = int.Parse(txt_numPaginas.Text);
                Livrodto.Valor = int.Parse(txt_valor.Text);

                Livrobll.AlterarL(Livrodto);
                MessageBox.Show("Alteração Feita com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridLivros.DataSource = Livrobll.ListarTodosL();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o livro selecionado e não poderá ser desfeito! deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Livrodto.IdLivro = Convert.ToInt32(txt_idLivro.Text);
                    Livrobll.ExcluirL(Livrodto);
                    gridLivros.DataSource = Livrobll.ListarTodosL();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string condicao = "titulo like '%" + txt_pesquisar.Text + "%'";
            ;
            gridLivros.DataSource = Livrobll.PesquisarL(condicao);
        }

        private void gridLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idLivro.Text = gridLivros.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_idAutor.Text = gridLivros.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_idEditora.Text = gridLivros.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_titulo.Text = gridLivros.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_DataCadastro.Text = gridLivros.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_numPaginas.Text = gridLivros.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_valor.Text = gridLivros.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
