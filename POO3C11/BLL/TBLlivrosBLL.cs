using POO3C11.DAL;
using POO3C11.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C11.BLL
{
    class TBLlivrosBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public DataTable ListarTodosL()
        {
            string sql = string.Format($@"select * from tbl_livro");
            return DaoBanco.executarConsulta(sql);
        }
        public void AlterarL(TBLlivroDTO dtolivro)
        {
            string sql = string.Format($@"UPDATE tbl_livro set idAutor = '{dtolivro.IdAutor}',
                                                               idEditora = '{dtolivro.IdEditora}',
                                                               titulo = '{dtolivro.Titulo}',
                                                               dataCadastro = '{dtolivro.DataCadastro}',
                                                               numPaginas = '{dtolivro.NumPaginas}',
                                                               valor = '{dtolivro.Valor}'
                                                               where idlivro = '{dtolivro.IdLivro}';");
            DaoBanco.executarComando(sql);

        }

        public void InserirL(TBLlivroDTO Objlivro)
        {
            string sql = string.Format($@"INSERT INTO tbl_livro VALUES (NULL,'{Objlivro.IdAutor}',
                                                                             '{Objlivro.IdEditora}',  
                                                                             '{Objlivro.Titulo}',
                                                                             '{Objlivro.DataCadastro}',
                                                                             '{Objlivro.NumPaginas}',
                                                                             '{Objlivro.Valor}');");
            DaoBanco.executarComando(sql);
        }

        public void ExcluirL(TBLlivroDTO objlivro)
        {
            string sql = string.Format($@"DELETE FROM tbl_livro where idLivro = {objlivro.IdLivro};");
            DaoBanco.executarComando(sql);
        }

        public DataTable PesquisarL(string condicao)
        {
            string sql = string.Format($@"select * from tbl_livro where " + condicao);

            return DaoBanco.executarConsulta(sql);
        }
    }
}
