using SolaPe_RH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static Login._dbBanco;
using System.Xml.Linq;

namespace Login
{
    public partial class controledeinventario : Form
    {
        SQLiteConnection con;
        string connectionString = "Data Source = ..\\..\\..\\..\\..\\banco_de_dados";

        public controledeinventario()
        {
            InitializeComponent();
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(connectionString))
                {
                    con = cn;
                    con.Open();

                    var tbinventario = "SELECT * FROM inventario";
                    using (SQLiteDataAdapter de = new SQLiteDataAdapter(tbinventario, con))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            de.Fill(dt);

                            dataInventario.DataSource = dt;
                            dataInventario.ReadOnly = true;
                            dataInventario.Columns[1].Width = 584;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha de conexão com o banco de dados: {ex.Message}. Por favor, consulte o suporte.");
            }
        }
        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"INSERT INTO empregados"(Nome, Cargo, Horário, Salário) VALUES("Fernando Lero da Silva Lira", "Assistente administrativo", "08:00 - 18:00", "1500");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int linha = dataInventario.SelectedRows[0].Index;
            _dbControle._Produto p = new _dbControle._Produto();
            p.id = Convert.ToInt32(txtID.Text);
            p.produto = txtProduto.Text;
            p.quantia = Convert.ToInt32(txtQuantia.Text);
            _dbControle.AtualizarProduto(p);
            dataInventario.DataSource = _dbControle.ObterProdutoId();
            dataInventario.CurrentCell = dataInventario[0, linha];

            dataInventario.Columns[1].Width = 584;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _dbControle con = new _dbControle(txtProduto.Text, Convert.ToInt32(txtQuantia.Text));
            con.insert();
            dataInventario.DataSource = _dbControle.ObterProdutoId();
            dataInventario.Columns[1].Width = 570;

        }

        private void dataInventario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dataInventario.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                int vid = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
                dt = _dbControle.ObterDadosProduto(vid);
                txtProduto.Text = dt.Rows[0].Field<string>("Produto");

                // Convertendo o valor Decimal para Int64 de forma segura
                decimal quantiaDecimal = dt.Rows[0].Field<decimal>("Quantia");
                long quantiaInt64 = Convert.ToInt64(quantiaDecimal);
                txtQuantia.Text = quantiaInt64.ToString();

                // Convertendo o valor Decimal para Int64 de forma segura
                long idInt64 = Convert.ToInt64(dt.Rows[0]["ID"]);
                txtID.Text = idInt64.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                _dbControle.DeletarProduto(txtID.Text);
                dataInventario.Rows.Remove(dataInventario.CurrentRow);
            }
        }

        private void dataInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void controledeinventario_Load(object sender, EventArgs e)
        {

        }
    }
}
