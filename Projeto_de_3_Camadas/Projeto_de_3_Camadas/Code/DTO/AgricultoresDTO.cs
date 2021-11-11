using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_3_Camadas.Code.DTO
{
    class AgricultoresDTO
    {
        //Propriedades privadas
        private int _id;
        private string _vendedores;
        private string _agricultores;

        //Métodos de encapsulamento (CTRL+R,E)
        public int id { get => _id; set => _id = value; }
        public object ID { get; internal set; }
        public string Vendedores { get => _vendedores; set => _vendedores = value; }
        public string Agricultores { get => _agricultores; set => _agricultores = value; }
        public object Agricultor { get; internal set; }

        internal void Inserir(AgricultoresDTO agrdto)
        {
            throw new NotImplementedException();
        }
    }
}
