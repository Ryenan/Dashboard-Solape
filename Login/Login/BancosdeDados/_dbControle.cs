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
    internal class _dbControle
    {
        public Int32 id;
        public string produto;
        public Int32 quantia;

        public Int32 getid() { return id; }
        public string getproduto() { return produto; }
        public Int32 getquantia() { return quantia; }
        public _dbControle(string produto, Int32 quantia)
        {
            this.produto = produto;
            this.quantia = quantia;
        }
        public class _Produto
        {
            public Int32 id;
            public string produto;
            public Int32 quantia;
        }

        public static DataTable ObterProdutoId()
        {
            SQLiteDataAdapter di = null;
            DataTable du = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT ID as 'ID', Produto as 'Nome', Quantia as 'Quantia'FROM inventario";

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

        public static DataTable ObterDadosProduto(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM inventario WHERE ID=@id";
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

        public static void AtualizarProduto(_Produto p)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE inventario SET Produto='" + p.produto + "', Quantia=" + p.quantia + " WHERE ID=" + p.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
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
                    cmd.CommandText = "INSERT INTO inventario(produto, quantia) VALUES (@produto, @quantia)";
                    cmd.Parameters.AddWithValue("@produto", this.produto);
                    cmd.Parameters.AddWithValue("@quantia", this.quantia);

                    _dbBanco.Confirmarbanco(cmd);
                    MessageBox.Show("Tarefa inserida com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir tarefa: {ex.Message}");
            }
        }
        public static void DeletarProduto(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM inventario WHERE ID=" + id;
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
