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
    internal class _dbFluxoAnual
    {
        private string ano;
        private string entrada;
        private string retorno;
        private string diferença;

        public string getano() { return ano; }
        public string getentrada() { return entrada; }
        public string getretorno() { return retorno; }
        public string getdiferença() { return diferença; }

        public _dbFluxoAnual(string ano, string entrada, string retorno, string diferença)
        {
            this.ano = ano;
            this.entrada = entrada;
            this.retorno = retorno;
            this.diferença = diferença;
        }
        public class FluxoAnual
        {
            public int ano;
            public decimal entrada;
            public decimal retorno;
            public decimal diferença;
        }
        public void insert()
        {
            try
            {
                using var cmd = _dbBanco.ConexaoBanco().CreateCommand();
                {
                    cmd.CommandText = "INSERT INTO anual(Ano,Entrada,Retorno,Diferença) VALUES (@ano,@entrada,@retorno,@diferença)";
                    cmd.Parameters.AddWithValue("@ano", this.ano);
                    cmd.Parameters.AddWithValue("@entrada", this.entrada);
                    cmd.Parameters.AddWithValue("@retorno", this.retorno);
                    cmd.Parameters.AddWithValue("@diferença", this.diferença);
                    _dbBanco.Confirmarbanco(cmd);
                    MessageBox.Show("Enviado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar");
            }
        }

        //MÉTODOS DO FORM FLUXOANUAL


        public static DataTable ObterAnualId()
        {
            SQLiteDataAdapter di = null;
            DataTable du = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT Ano as 'Ano', Entrada as 'Entrada', Retorno as 'Retorno', Diferença as 'Diferença'FROM anual";

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

        public static DataTable ObterDadosAnual(int ano)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM anual WHERE Ano=@ano";
                cmd.Parameters.AddWithValue("@ano", ano);
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

        public static void AtualizarAnual(FluxoAnual a)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "UPDATE anual SET Entrada=@entrada, Retorno=@retorno, Diferença=@diferença WHERE Ano=@ano";
                    cmd.Parameters.AddWithValue("@entrada", a.entrada);
                    cmd.Parameters.AddWithValue("@retorno", a.retorno);
                    cmd.Parameters.AddWithValue("@diferença", a.diferença);
                    cmd.Parameters.AddWithValue("@ano", a.ano);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static void DeletarAnual(string ano)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM anual WHERE Ano=" + ano;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //FIM MÉTODOS DO FORM FLUXOANUAL

    }
}


