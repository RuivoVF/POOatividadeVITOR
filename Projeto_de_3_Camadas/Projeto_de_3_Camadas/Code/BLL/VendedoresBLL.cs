using Projeto_de_3_Camadas.Code.DTO;
using Projeto_de_3_Camadas.Code.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_3_Camadas.Code.BLL
{
    class VendedoresBLL
    {
        Acesso_BD conexao = new Acesso_BD();
        string tabela = "tbl_Vendedores";
        private object update;

        public void Inserir (AgricultoresDTO agrDto)
        {
            string inserir = $"insert into {tabela} values(null,'{agrDto.Vendedores}','{agrDto.Agricultores}')";
            conexao.ExecutarComando(inserir);
        }

        public object Editar(AgricultoresDTO agrDto)
        {
            string alterar = $"update {tabela} set vendedor = 'agrDto.Vendedor', agricultor = '{agrDto.Agricultor}' where id = '{agrDto.ID}';";
            conexao.ExecutarComando(alterar);                              
        }

        public void Excluir (AgricultoresDTO agrDto)
        {
            string excluir = $"delete from {tabela} where id = '{agrDto.ID}';";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarGerenciamento(sql);
        }
    }
}
