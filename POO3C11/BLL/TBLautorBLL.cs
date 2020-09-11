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
    class TBLautorBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public DataTable ListarTodosA()
        {
            string sql = string.Format($@"select * from tbl_autor");
            return DaoBanco.executarConsulta(sql);
        }
        public void AlterarA(TBLautorDTO dtoautor)
        {
            string sql = string.Format($@"UPDATE tbl_autor set nome = '{dtoautor.Nome}',
                                                               idade = '{dtoautor.Idade}'                                                                                                                              
                                                               where id = '{dtoautor.IdAutor}';");
            DaoBanco.executarComando(sql);

        }

        public void InserirA(TBLautorDTO Objautor)
        {
            string sql = string.Format($@"INSERT INTO tbl_autor VALUES (NULL,'{Objautor.Nome}',                                                                          
                                                                          '{Objautor.Idade}');");
            DaoBanco.executarComando(sql);


        }

        public void ExcluirA(TBLautorDTO objautor)
        {
            string sql = string.Format($@"DELETE FROM tbl_autor where id = {objautor.IdAutor};");
            DaoBanco.executarComando(sql);
        }
    }
}
