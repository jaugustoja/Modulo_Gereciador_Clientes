using Projeto_Controle_Vendas.br.com.projeto.dao;
using Projeto_Controle_Vendas.br.com.projeto.model;
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
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            
            obj.Nome = textNome.Text;
            obj.RG = maskedTextRG.Text;
            obj.CPF = maskedTextCPF.Text;
            obj.Email = textEmail.Text;
            obj.Telefone = maskedTextTelefone.Text;
            obj.Celular = maskedTextCelular.Text;
            obj.CEP = maskedTextCEP.Text;
            obj.Endereco = textEndereco.Text;
            obj.Numero = int.Parse(textNumero.Text);
            obj.Complemento = textComplemento.Text;
            obj.Bairro = textBairro.Text;
            obj.Cidade = textCidade.Text;
            obj.Estado = comboEstado.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void tabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = textNameConsulta.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.buscarClientePorNome(nome);

            if(tabelaCliente.Rows.Count == 1)
            {
                tabelaCliente.DataSource = null;
                tabelaCliente.DataSource = dao.listarClientes();
            }
        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            textNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            maskedTextRG.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            maskedTextCPF.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            textEmail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            maskedTextTelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            maskedTextCelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            maskedTextCEP.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            textEndereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            textNumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            textComplemento.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            textBairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            textCidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            comboEstado.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.Codigo = int.Parse(textCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);

            tabelaCliente.DataSource = dao.listarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.Nome = textNome.Text;
            obj.RG = maskedTextRG.Text;
            obj.CPF = maskedTextCPF.Text;
            obj.Email = textEmail.Text;
            obj.Telefone = maskedTextTelefone.Text;
            obj.Celular = maskedTextCelular.Text;
            obj.CEP = maskedTextCEP.Text;
            obj.Endereco = textEndereco.Text;
            obj.Numero = int.Parse(textNumero.Text);
            obj.Complemento = textComplemento.Text;
            obj.Bairro = textBairro.Text;
            obj.Cidade = textCidade.Text;
            obj.Estado = comboEstado.Text;

            obj.Codigo = int.Parse(textCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            tabelaCliente.DataSource = dao.listarClientes();
        }
    }
}
