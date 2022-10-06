using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Exc1
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexao;
        private MySqlDataReader rd;
        private String sql;
        private MySqlCommand stm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("server=localhost; user=root; password=root; database=eventoseinstituicoes");
            conexao.Open();
        }

        // Evento
        // txtvalorev
        private void btncadastrarEv_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO eventos (id_evento, evento, data_inicio, data_termino, local, valor) values(" + txtidev.Text + ", '" + txteventoev.Text + "', " + txtinicioev.Text + ", '" + txtterminoev.Text + "', " + txtlocalev.Text + "', " + txtvalorev.Text + "');'";
            stm = new MySqlCommand(sql, conexao);
            int retorno = stm.ExecuteNonQuery();
            if (retorno > 0)
            {
                MessageBox.Show("Cadastro Efetuado!");
            }
            else
            {
                MessageBox.Show("Erro no Cadastro!");
            }
            stm.Dispose();
        }

        private void btnconsultaEv_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM eventos WHERE id_evento=" + txtidev.Text;
            stm = new MySqlCommand(sql, conexao);
            rd = stm.ExecuteReader();
            if (rd.Read)
            {
                txteventoev.Text = rd.GetString("evento");
                txtinicioev.Text = rd.GetString("data_inicio");
                txtterminoev.Text = rd.GetString("data_termino");
                txtlocalev.Text = rd.GetString("local");
                txtvalorev.Text = rd.GetString("valor");

            }
            else
            {
                MessageBox.Show("Evento não Encontrado!");
            }
            stm.Dispose();
            rd.Close();
        }

        private void btnalterarEv_Click(object sender, EventArgs e)
        {
            sql = "UPDATE eventos SET evento='" + txteventoev.Text + "'data_inicio= '" + txtinicioev.Text + "'data_termino= '" + txtterminoev.Text + "'local= '" + txtlocalev.Text + "'valor= '" + txtvalorev.Text + "' where id_evento=" + txtidev.Text;
            stm = new MySqlCommand(sql, conexao);
            int retorno = stm.ExecuteNonQuery();
            if (retorno > 0)
            {
                MessageBox.Show("Dados Alterados Com Sucesso!");
            }
            else
            {
                MessageBox.Show("Erro na Alteração!");
            }
            stm.Dispose();
        }

        private void btnexcluirEv_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM eventos WHERE id_evento=" + txtidev.Text;
            stm = new MySqlCommand(sql, conexao);
            int retorno = stm.ExecuteNonQuery();
            if (retorno > 0)
            {
                MessageBox.Show("Itens Excluidos!");
            }
            else
            {
                MessageBox.Show("Erro Na Exclusão!");
            }
            stm.Dispose();
        }

        // Instituicao
        // txtidin, txtnomein, txtcidadein, txtestadoin
        private void btncadastrarIn_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO instituicoes (id_instituicao, nm_instituicao, ds_cidade, ds_uf) values(" + txtidin.Text + ", '" + txtnomein.Text + "', " + txtcidadein.Text + ", '" + txtestadoin + "');'";
            stm = new MySqlCommand(sql, conexao);
            int retorno = stm.ExecuteNonQuery();
            if (retorno > 0)
            {
                MessageBox.Show("Cadastro Efetuado!");
            }
            else
            {
                MessageBox.Show("Erro no Cadastro!");
            }
            stm.Dispose();
        }

        private void btnconsultaIn_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM instituicoes WHERE id_instituicao=" + txtidin.Text;
            stm = new MySqlCommand(sql, conexao);
            rd = stm.ExecuteReader();
            if (rd.Read)
            {
                txtnomein.Text = rd.GetString("nm_instituicao");
                txtcidadein.Text = rd.GetString("ds_cidade");
                txtestadoin.Text = rd.GetString("ds_uf");
            }
            else
            {
                MessageBox.Show("Instituicao não Encontrada!");
            }
            stm.Dispose();
            rd.Close();
        }

        private void btnalterarIn_Click(object sender, EventArgs e)
        {
            sql = "UPDATE instituicoes SET nm_instituicao='" + txtnomein.Text + "'ds_cidade= '" + txtcidadein.Text + "'ds_uf= '" +txtestadoin.Text + "'where id_instituicao=" + txtidin.Text;
            stm = new MySqlCommand(sql, conexao);
            int retorno = stm.ExecuteNonQuery();
            if (retorno > 0)
            {
                MessageBox.Show("Dados Alterados Com Sucesso!");
            }
            else
            {
                MessageBox.Show("Erro na Alteração!");
            }
            stm.Dispose();
        }

        private void btnexcluirIn_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM instituicoes WHERE id_instituicao=" + txtidin.Text;
            stm = new MySqlCommand(sql, conexao);
            int retorno = stm.ExecuteNonQuery();
            if (retorno > 0)
            {
                MessageBox.Show("Itens Excluidos!");
            }
            else
            {
                MessageBox.Show("Erro Na Exclusão!");
            }
            stm.Dispose();
        }

        // Form Closer
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();
        }

    }
}
