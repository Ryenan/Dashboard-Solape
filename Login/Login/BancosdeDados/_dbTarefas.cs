using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.BancosdeDados
{
    internal class _dbTarefas
    {
        public string id;
        public string tarefa;
        public string dia;

        public _dbTarefas(string id, string tarefa, string dia)
        {
            this.id = id;
            this.tarefa = tarefa;
            this.dia = dia;
        }

        public static DataTable ObterTarefas()
        {
            SQLiteDataAdapter di = null;
            DataTable du = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id as 'ID', tarefas as 'Tarefas', dia as 'Dia' FROM t_tarefas";

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

        public static DataTable ObterTodasTarefas(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id as 'ID', tarefas as 'Tarefas', dia as 'Dia' FROM t_tarefas";
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

        public static void DeletarTarefas(string id)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "DELETE FROM t_tarefas WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarTarefas(_dbTarefas t)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "UPDATE t_tarefas SET tarefas=@tarefas, dia=@dia WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", t.id);
                    cmd.Parameters.AddWithValue("@tarefas", t.tarefa);
                    cmd.Parameters.AddWithValue("@dia", t.dia);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void insert()
        {
            try
            {
                using (var cmd = _dbBanco.ConexaoBanco().CreateCommand())
                {
                    // Não inclua o ID na inserção, pois ele geralmente é gerado automaticamente
                    cmd.CommandText = "INSERT INTO t_tarefas(tarefa, dia) VALUES (@tarefa, @dia)";
                    cmd.Parameters.AddWithValue("@tarefa", this.tarefa);
                    cmd.Parameters.AddWithValue("@dia", this.dia);

                    _dbBanco.Confirmarbanco(cmd);
                    MessageBox.Show("Tarefa inserida com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir tarefa: {ex.Message}");
            }
        }
    }
}
