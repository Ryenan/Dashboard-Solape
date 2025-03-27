using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;
using static Login._dbFluxoAnual;
using System.Globalization;
using static Login._dbFluxoMensal;

namespace Login
{
    class _dbBanco
    {
        
        //atributo
        private static SQLiteConnection conexao;

        //metod ConexaoBanco
        public static SQLiteConnection ConexaoBanco()
        {

            //criar um conexao do tipo SQLiteConnect
            //linkado ao arquivo banco.db
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\..\\..\\banco_de_dados");
            conexao.Open();
            return conexao;
        }
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try {

                using (var cmd = ConexaoBanco().CreateCommand())
                {

                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }

            } catch (Exception ex) {

                ConexaoBanco().Close();
                throw ex;

            }
        }
        public static void Confirmarbanco(SQLiteCommand cmd)
        {
            try
            {
                cmd.ExecuteNonQuery();
                
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
            }
        }

    }

}

