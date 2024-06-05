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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja realmente sair?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void menuCadastroClientes_Click(object sender, EventArgs e)
        {
            Frmclientes telaClientes = new Frmclientes();
            telaClientes.ShowDialog();
        }

        private void menuConsultaClientes_Click(object sender, EventArgs e)
        {
            Frmclientes telaClientes = new Frmclientes();
            telaClientes.tabControl1.SelectedTab = telaClientes.tabPage2;
            telaClientes.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
