using System;
using POO3C11.DAL;
using POO3C11.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace POO3C11.BLL
{
    class TBLeditoraBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public DataTable ListarTodasE()
        {
            string sql = string.Format($@"select * from tbl_editora");
            return DaoBanco.executarConsulta(sql);
        }
        public void AlterarE(TBLeditoraDTO dtoeditora)
        {
            string sql = string.Format($@"UPDATE tbl_editora set nome = '{dtoeditora.Nome}',
                                                               endereco = '{dtoeditora.Endereco}',
                                                               UF = '{dtoeditora.UF1}'
                                                               where id = '{dtoeditora.IdEditora}';");
            DaoBanco.executarComando(sql);

        }

        public void InserirE(TBLeditoraDTO Objeditora)
        {
            string sql = string.Format($@"INSERT INTO tbl_editora VALUES (NULL,'{Objeditora.Nome}',
                                                                               '{Objeditora.Endereco}',                                                                
                                                                               '{Objeditora.UF1}');");
            DaoBanco.executarComando(sql);


        }

        public void ExcluirE(TBLeditoraDTO objeditora)
        {
            string sql = string.Format($@"DELETE FROM tbl_editora where id = {objeditora.IdEditora};");
            DaoBanco.executarComando(sql);
        }
    }
}
