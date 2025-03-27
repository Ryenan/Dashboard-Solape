using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Login._dbEmpregado;

namespace Login
{
    internal class _dbChamados
    {
        string Nome;
        string Setor;
        string Demanda;
        string Data;

        public string getUsuario() { return Nome; }
        public string getSetor() { return Setor; }
        public string getDemanda() { return Demanda; }
        public string getData() { return Data; }

        public _dbChamados(string nome, string setor, string Demanda, string data)
        {
            this.Nome = nome;
            this.Setor = setor;
            this.Demanda = Demanda;
            this.Data = data;
        }

        public void insert()
        {
            try
            {
                using var cmd = _dbBanco.ConexaoBanco().CreateCommand();
                {
                    cmd.CommandText = "INSERT INTO chamados(Nome,Setor,Demanda,Data) VALUES (@Nome,@Setor,@Demanda,@Data)";
                    cmd.Parameters.AddWithValue("@Nome", this.Nome);
                    cmd.Parameters.AddWithValue("@Setor", this.Setor);
                    cmd.Parameters.AddWithValue("@Demanda", this.Demanda);
                    cmd.Parameters.AddWithValue("@Data", this.Data);

                    _dbBanco.Confirmarbanco(cmd);
                    MessageBox.Show("Demanda enviada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar");
            }
        }
        public static void DeletarChamado(string id)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "DELETE FROM chamados WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ObterChamados()
        {
            SQLiteDataAdapter di = null;
            DataTable du = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT ID as 'ID', Nome as 'Nome', Setor as 'Cargo', Demanda as 'Demanda', Data as 'Data' FROM chamados";

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
        public static DataTable ObterChamadosDados(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM chamados WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", id);
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
    }
}
