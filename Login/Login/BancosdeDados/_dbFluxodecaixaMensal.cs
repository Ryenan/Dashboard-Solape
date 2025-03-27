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
    internal class _dbFluxoMensal
    {

        string mês;
        string entrada;
        string retorno;
        string diferença;

        public string getmes() { return mês; }
        public string getentrada() { return entrada; }
        public string getretorno() { return retorno; }
        public string getdiferença() { return diferença; }

        public _dbFluxoMensal(string mês, string entrada, string retorno, string diferença)
        {
            this.mês = mês;
            this.entrada = entrada;
            this.retorno = retorno;
            this.diferença = diferença;
        }
        public class FluxoMes
        {
            public int mes;
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
                    cmd.CommandText = "INSERT INTO mensal(Mês,Entrada,Retorno,Diferença) VALUES (@mês,@entrada,@retorno,@diferença)";
                    cmd.Parameters.AddWithValue("@mês", this.mês);
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


        public static DataTable ObterSemanalId()
        {
            SQLiteDataAdapter di = null;
            DataTable du = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT Mês as 'Mês', Entrada as 'Entrada', Retorno as 'Retorno', Diferença as 'Diferença'FROM mensal";

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


        public static DataTable ObterDadosMensal(int mes)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM mensal WHERE Mês=@mes";
                cmd.Parameters.AddWithValue("@mes", mes);
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
        public static void AtualizarMensal(FluxoMes m)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "UPDATE mensal SET Entrada=@entrada, Retorno=@retorno, Diferença=@diferença WHERE Mês=@mês";
                    cmd.Parameters.AddWithValue("@entrada", m.entrada);
                    cmd.Parameters.AddWithValue("@retorno", m.retorno);
                    cmd.Parameters.AddWithValue("@diferença", m.diferença);
                    cmd.Parameters.AddWithValue("@mês", m.mes);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void DeletarMensal(string mes)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM mensal WHERE Mês=" + mes;
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
