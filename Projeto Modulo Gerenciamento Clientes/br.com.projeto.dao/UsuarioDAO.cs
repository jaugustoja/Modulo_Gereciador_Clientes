using MySql.Data.MySqlClient;
using Projeto_Controle_Vendas.br.com.projeto.conexao;
using Projeto_Controle_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_Vendas.br.com.projeto.dao
{
    public class UsuarioDAO
    {
        private MySqlConnection conexao;

        public UsuarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public bool EfetuarLogin(string email, string senha)
        {
            try
            {
                string sql = @"select * from tb_funcionarios 
                             where email = @email and senha = @senha";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);               

                conexao.Open();
                MySqlDataReader reader = executacmd.ExecuteReader();

                if(reader.Read()) 
                {
                    MessageBox.Show("Login realizado com sucesso");
                    conexao.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos");
                    conexao.Close();
                    return false;
                }                

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return false;
            }
        }

    }
}
