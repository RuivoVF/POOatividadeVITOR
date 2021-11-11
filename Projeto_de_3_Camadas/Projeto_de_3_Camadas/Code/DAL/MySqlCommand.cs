using System;

namespace Projeto_de_3_Camadas.Code.DAL
{
    internal class MySqlCommand
    {
        private string sql;
        private MySqlConnection conexao;

        public MySqlCommand(string sql, MySqlConnection conexao)
        {
            this.sql = sql;
            this.conexao = conexao;
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}