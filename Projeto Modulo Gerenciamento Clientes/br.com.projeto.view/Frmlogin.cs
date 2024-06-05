using Projeto_Controle_Vendas.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string senha = textSenha.Text;

            UsuarioDAO dao = new UsuarioDAO();

            if(dao.EfetuarLogin(email, senha))
            {
                
                FrmMenu telaMenu = new FrmMenu();
                this.Hide();
                telaMenu.txtusuario.Text = email;
                telaMenu.Show();
            }
        }
    }
}
