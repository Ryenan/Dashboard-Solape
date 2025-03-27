using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Login
{
    internal class _dbRastreamento
    {
        public int id;
        public string produto;
        public string origem;
        public string datasaida;
        public string localidade;
        public string previsaodechegada;

        public int getid() { return id; }
        public string getproduto() { return produto; }
        public string getorigem() { return origem; }
        public string getdatasaida() { return datasaida; }
        public string getlocalidade() { return localidade; }
        public string getprevisaodechegada() { return previsaodechegada; }

        public _dbRastreamento(string produto, string origem, string datasaida, string localidade, string previsaodechegada)
        {
            this.produto = produto;
            this.origem = origem;
            this.datasaida = datasaida;
            this.localidade = localidade;
            this.previsaodechegada = previsaodechegada;
        }


        public class rastreamento
        {
            public int id;
            public string produto;
            public string origem;
            public string datasaida;
            public string localidade;
            public string previsaodechegada;
        }
        
        public void insert()
        {
            try
            {
                using (var cmd = _dbBanco.ConexaoBanco().CreateCommand())
                {
                    // Não inclua o ID na inserção, pois ele geralmente é gerado automaticamente
                    cmd.CommandText = "INSERT INTO rastreamento ( produto, origem, datasaida, localidade, previsaodechegada) VALUES ( @produto, @origem, @datasaida, @localidade, @previsaodechegada)";
                    cmd.Parameters.AddWithValue("@produto", this.produto);
                    cmd.Parameters.AddWithValue("@origem", this.origem);
                    cmd.Parameters.AddWithValue("@datasaida", this.datasaida);
                    cmd.Parameters.AddWithValue("@localidade", this.localidade);
                    cmd.Parameters.AddWithValue("@previsaodechegada", this.previsaodechegada);

                    _dbBanco.Confirmarbanco(cmd);
                    MessageBox.Show("Tarefa inserida com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir tarefa: {ex.Message}");
            }
        }
        public static DataTable ObterRastreamento()
        {
            SQLiteDataAdapter di = null;
            DataTable du = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id as 'ID',produto as 'Produto',origem as 'Origem', datasaida as 'Data de Saída', localidade as 'Localidade',previsaodechegada as 'Previsão de Chegada' FROM rastreamento";

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
        public static void DeletarRastreamento(string id)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "DELETE FROM rastreamento WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ObterDadosRastreamento(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM rastreamento WHERE id=@id";
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
        public static void AtualizarRastramento(rastreamento r)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "UPDATE rastreamento SET produto=@produto, origem=@origem, datasaida=@datasaida, localidade=@localidade, previsaodechegada=@previsaodechegada WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", r.id);
                    cmd.Parameters.AddWithValue("@produto", r.produto);
                    cmd.Parameters.AddWithValue("@origem", r.origem);
                    cmd.Parameters.AddWithValue("@datasaida", r.datasaida);
                    cmd.Parameters.AddWithValue("@localidade", r.localidade);
                    cmd.Parameters.AddWithValue("@previsaodechegada", r.previsaodechegada);
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
