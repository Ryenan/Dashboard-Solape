using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Login
{
    internal class _dbProducao
    {
        int id;
        string tarefa;
        string prazo;

        public string getId() { return Convert.ToString(id); }
        public string getTarefa() { return tarefa; }
        public string getPrazo() { return prazo; }

        public _dbProducao(string tarefa, string prazo)
        {
            this.tarefa = tarefa;
            this.prazo = prazo;
        }
        public class tarefas
        {
            public int id;
            public string tarefa;
            public string prazo;
        }
        public void insert()
        {
            try
            {
                using (var cmd = _dbBanco.ConexaoBanco().CreateCommand())
                {
                    // Não inclua o ID na inserção, pois ele geralmente é gerado automaticamente
                    cmd.CommandText = "INSERT INTO t_tarefas(tarefas, dia) VALUES (@tarefas, @dia)";
                    cmd.Parameters.AddWithValue("@tarefas", this.tarefa);
                    cmd.Parameters.AddWithValue("@dia", this.prazo);

                    _dbBanco.Confirmarbanco(cmd);
                    MessageBox.Show("Tarefa inserida com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir tarefa: {ex.Message}");
            }
        }
        public static DataTable ObterTarefas()
        {
            SQLiteDataAdapter di = null;
            DataTable du = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id as 'ID',tarefas as 'Tarefas', dia as 'Dia'  FROM t_tarefas";

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
        public static void DeletarTarefasNome(string tarefas)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "DELETE FROM t_tarefas WHERE tarefas=@tarefas";
                    cmd.Parameters.AddWithValue("@tarefas", tarefas);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarTarefas(tarefas t)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "UPDATE t_tarefas SET id=@id, tarefas=@tarefas WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", t.id);
                    cmd.Parameters.AddWithValue("@tarefas", t.tarefa);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
