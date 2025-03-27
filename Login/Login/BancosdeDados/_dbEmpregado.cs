using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
        internal class _dbEmpregado
        {
            string usuario;
            string senha;
            string setor;

            public string getUsuario() { return usuario; }
            public string getSenha() { return senha; }
            public string getSetor() { return setor; }

            public _dbEmpregado(string usuario, string senha, string setor)
            {
                this.usuario = usuario;
                this.senha = senha;
                this.setor = setor;
            }
            public class _Funcionario
            {
                public string nome;
                public string cargo;
                public decimal salario;
                public Int32 id;
            }

        public void insert()
            {
                try
                {
                    using var cmd = _dbBanco.ConexaoBanco().CreateCommand();
                    {
                        cmd.CommandText = "INSERT INTO funcionario(usuario,senha,SETOR) VALUES (@usuario,@senha,@setor)";
                        cmd.Parameters.AddWithValue("@usuario", this.usuario);
                        cmd.Parameters.AddWithValue("@senha", this.senha);
                        cmd.Parameters.AddWithValue("@setor", this.setor);

                        _dbBanco.Confirmarbanco(cmd);
                        MessageBox.Show("Novo funcionário adicionado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar novo usuário");
                }
            }
            public static DataTable ObterUsuarioId()
            {
                SQLiteDataAdapter di = null;
                DataTable du = new DataTable();
                try
                {
                    var vcon = _dbBanco.ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "SELECT id as 'ID', Nome as 'Nome', Cargo as 'Cargo', Salário as 'Salário'FROM empregados";

                    di = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    di.Fill(du);
                    vcon.Close();
                    return du;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public static DataTable ObterDadosUsuario(int id)
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    var vcon = _dbBanco.ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "SELECT * FROM empregados WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public static void AtualizarUsuario(_Funcionario f)
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    var vcon = _dbBanco.ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "UPDATE empregados SET Nome='" + f.nome + "', Cargo='" + f.cargo + "', Salário=" + f.salario + " WHERE id=" + f.id;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


            public static void DeletarUsuario(string id)
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    var vcon = _dbBanco.ConexaoBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "DELETE FROM empregados WHERE id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }  

