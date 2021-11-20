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
    class Loginbll
    {
        CnxBD conexao = new CnxBD();
        string tabela = "cad_login";

        public bool RealizarLogin(Logindto user)
        {
            string listar = $"select * from {tabela} where login='{user.login}' and senha='{user.senha}' ";
            DataTable dt = conexao.ExecutarConsulta(listar);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
