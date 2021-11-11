using System;
using System.Data;

namespace Projeto_de_3_Camadas.Code.DAL
{
    internal class MySqlDataAdapter
    {
        private string sql;
        private MySqlConnection conexao;

        public MySqlDataAdapter(string sql, MySqlConnection conexao)
        {
            this.sql = sql;
            this.conexao = conexao;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}