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
    public partial class Form_Loguin : Form
    {



        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        

        public Form_Loguin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtsenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {

                FormsFuncionario formsFuncionario = new FormsFuncionario();
                formsFuncionario.ShowDialog();

            }
            else
            {
                MessageBox.Show("Verifique o seu e-mail ou a sua senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
