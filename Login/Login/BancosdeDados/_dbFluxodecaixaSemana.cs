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
    internal class _dbFluxodecaixaSemana
    {
        private string Dia;
        private string Entrada;
        private string Retorno;
        private string Diferença;

        public string getDia() { return Dia; }
        public string getEntrada() { return Entrada; }
        public string getRetorno() { return Retorno; }
        public string getDiferença() { return Diferença; }

        public _dbFluxodecaixaSemana(string Dia, string Entrada, string Retorno, string Diferença)
        {
            this.Dia = Dia;
            this.Entrada = Entrada;
            this.Retorno = Retorno;
            this.Diferença = Diferença;
        }

        public void insert()
        {
            try
            {
                using (var cmd = _dbBanco.ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO semanal(Dia,Entrada,Retorno,Diferença) VALUES (@Dia,@Entrada,@Retorno,@Diferença)";
                    cmd.Parameters.AddWithValue("@Dia", this.Dia);
                    cmd.Parameters.AddWithValue("@Entrada", this.Entrada);
                    cmd.Parameters.AddWithValue("@Retorno", this.Retorno);
                    cmd.Parameters.AddWithValue("@Diferença", this.Diferença);

                    _dbBanco.Confirmarbanco(cmd);
                    MessageBox.Show("Enviado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar: " + ex.Message);
            }
        }

        public static DataTable ObterSemana()
        {
            DataTable du = new DataTable();
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "SELECT Dia as 'Dia', Entrada as 'Entrada', Retorno as 'Retorno', Diferença as 'Diferença' FROM semanal";

                    using (SQLiteDataAdapter di = new SQLiteDataAdapter(cmd.CommandText, vcon))
                    {
                        di.Fill(du);
                    }
                }
                return du;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosSemanal(int dia)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "SELECT * FROM semanal WHERE Dia=@Dia";
                    cmd.Parameters.AddWithValue("@Dia", dia);

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                // Trate a exceção de forma apropriada, por exemplo:
                throw new Exception("Erro ao obter dados semanais", ex);
            }
        }

        public static void AtualizarDados(_dbFluxodecaixaSemana f)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    using (var cmd = vcon.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE semanal SET Entrada = @Entrada, Retorno = @Retorno, Diferença = @Diferença WHERE Dia = @Dia";
                        cmd.Parameters.AddWithValue("@Entrada", f.getEntrada());
                        cmd.Parameters.AddWithValue("@Retorno", f.getRetorno());
                        cmd.Parameters.AddWithValue("@Diferença", f.getDiferença());
                        cmd.Parameters.AddWithValue("@Dia", f.getDia());
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletarSemana(string dia)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    using (var cmd = vcon.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM semanal WHERE Dia = @Dia";
                        cmd.Parameters.AddWithValue("@Dia", dia);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
