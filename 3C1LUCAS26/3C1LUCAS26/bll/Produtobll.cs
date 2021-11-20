using _3C1LUCAS26.dal;
using _3C1LUCAS26.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1LUCAS26.bll
{
    class Produtobll
    {
        CnxBD conexaoBanco = new CnxBD();
        string tabela = "Cadastrarprodutos";

        public void Inserir(Produtodto produtodto)
        {
            string inserir = $"insert into {tabela} values({produtodto.Nome}','{produtodto.Preco}',{produtodto.Codg_barras}','{produtodto.Quantidade}')";
            conexaoBanco.ExecutarComando(inserir);
        }
        public DataTable Listar()
        {
            string listar = $"select * from {tabela} order by codigo";
            return conexaoBanco.ExecutarConsulta(listar);
        }
        public void excluir(Produtodto produtodto)
        {
            string excluir = $"delete from {tabela} where codigo = '{produtodto.Codg_barras}';";
            conexaoBanco.ExecutarComando(excluir);
        }
    }
}
