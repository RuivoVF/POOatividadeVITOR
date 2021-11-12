using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_de_3_Camadas.Code.DTO;
using Projeto_de_3_Camadas.Code.DAL;
using System.Data;

namespace Projeto_de_3_Camadas.Code.BLL
{
    class LoginBLL
    {
        Acesso_BD conexao = new Acesso_BD();
        string tabela = "tbl_Login";
        private object update;

        public bool RealizarLogin(LoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarGerenciamento(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
