using Projeto_de_3_Camadas.Code.BLL;
using Projeto_de_3_Camadas.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_3_Camadas.UI
{
    public partial class FormsFuncionario : Form
    {
        VendedoresBLL venbll = new VendedoresBLL();
        AgricultoresDTO agrdto = new AgricultoresDTO();
        private object dgvVendedor;
        private object txtAgricultores;
        private object txtVendedores;

        public FormsFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            agrdto.Vendedores = txtVendedor.Text;
            agrdto.Agricultor = txtAgricultor.Text;

            agrdto.Inserir(agrdto);

            MessageBox.Show("Cadastrado com sucesso!", "Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtVendedor.Clear();
            txtAgricultor.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            agrdto.id = int.Parse(txtID.Text);
            agrdto.Vendedores = txtVendedor.Text;
            agrdto.Agricultores = txtAgricultor.Text;

            venbll.Editar(agrdto);

            MessageBox.Show("Editado com sucesso!", "Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtVendedor.Clear();
            txtAgricultor.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            agrdto.ID = int.Parse(txtID.Text);

            venbll.Excluir(agrdto);

            MessageBox.Show("Editado com sucesso!", "Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            venbll.Listar();

            txtID.Clear();
            txtVendedor.Clear();
            txtAgricultor.Clear();
        }

        private void Forms_Funcionario_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = venbll.Listar();

        }

        private void dgvVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvFuncionario.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtVendedor.Text = dgvFuncionario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAgricultor.Text = dgvFuncionario.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
