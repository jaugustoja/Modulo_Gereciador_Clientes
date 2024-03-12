using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void cadastrarCliente(Cliente obj) 
        {
            try
            {
                string sql = @"insert into tb_clientes(nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.RG);
                executacmd.Parameters.AddWithValue("@cpf", obj.CPF);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.CEP);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso");
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
    }
}
