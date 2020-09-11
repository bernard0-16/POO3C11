using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C11.DTO
{
    class TBLlivroDTO
    {
        private int idLivro, idAutor, idEditora, numPaginas, valor;
        private string titulo, dataCadastro;
        public int IdLivro { get => idLivro; set => idLivro = value; }
        public int IdAutor { get => idAutor; set => idAutor = value; }
        public int IdEditora { get => idEditora; set => idEditora = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Titulo
        {
            set
            {
                if (value != string.Empty)
                {
                    this.titulo = value;
                }
                else
                {
                    throw new Exception("O campo Titulo é obrigatório.");
                }
            }
            get { return this.titulo; }
        }
        public string DataCadastro { get => dataCadastro; set => dataCadastro = value; }
    }
}
