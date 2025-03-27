using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Data.SQLite;

namespace finanças_Projeto
{
    public partial class fluxo_de_caixa : Form
    {
        SQLiteConnection con;
        string connectionString = "Data Source = ..\\..\\..\\..\\..\\banco_de_dados";

        public fluxo_de_caixa()
        {
            InitializeComponent();

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(connectionString))
                {
                    con = cn;
                    con.Open();

                    var tbmensal = "SELECT * FROM mensal";
                    using (SQLiteDataAdapter de = new SQLiteDataAdapter(tbmensal, con))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            de.Fill(dt);

                            dataMensal.DataSource = dt;
                            dataMensal.ReadOnly = true;
                        }

                    }
                    var tbanual = "SELECT * FROM anual";
                    using (SQLiteDataAdapter de = new SQLiteDataAdapter(tbanual, con))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            de.Fill(dt);

                            dataAnual.DataSource = dt;
                            dataAnual.ReadOnly = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha de conexão com o banco de dados: {ex.Message}. Por favor, consulte o suporte.");
            }
        }

        private void fluxo_de_caixa_Load(object sender, EventArgs e)
        {
            dataMensal.Columns[0].Width = 111;
            dataMensal.Columns[1].Width = 111;
            dataMensal.Columns[2].Width = 111;
            dataMensal.Columns[3].Width = 111;
            dataAnual.Columns[0].Width = 111;
            dataAnual.Columns[1].Width = 111;
            dataAnual.Columns[2].Width = 111;
            dataAnual.Columns[3].Width = 111;
            dataMensal.Columns["Mês"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataMensal.Columns["Entrada"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataMensal.Columns["Retorno"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataMensal.Columns["Diferença"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataAnual.Columns["Ano"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataAnual.Columns["Entrada"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataAnual.Columns["Retorno"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataAnual.Columns["Diferença"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int linha = dataMensal.SelectedRows[0].Index;
            _dbFluxoMensal.FluxoMes m = new _dbFluxoMensal.FluxoMes();
            m.mes = Convert.ToInt32(txtmesMes.Text);
            m.entrada = Convert.ToDecimal(txtentradaMes.Text);
            m.retorno = Convert.ToDecimal(txtretornoMes.Text);
            m.diferença = Convert.ToDecimal(txtdiferencaMes.Text);

            _dbFluxoMensal.AtualizarMensal(m);
            dataMensal.DataSource = _dbFluxoMensal.ObterSemanalId();
            dataMensal.CurrentCell = dataMensal[0, linha];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int linha = dataAnual.SelectedRows[0].Index;
            _dbFluxoAnual.FluxoAnual m = new _dbFluxoAnual.FluxoAnual();
            m.ano = Convert.ToInt32(txtanoAno.Text);
            m.entrada = Convert.ToDecimal(txtentradaAno.Text);
            m.retorno = Convert.ToDecimal(txtretornoAno.Text);
            m.diferença = Convert.ToDecimal(txtdiferencaAno.Text);

            _dbFluxoAnual.AtualizarAnual(m);
            dataAnual.DataSource = _dbFluxoAnual.ObterAnualId();
            dataAnual.CurrentCell = dataAnual[0, linha];
        }




        private void txtdiasemana_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataAnual_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dataAnual.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                int vid = Convert.ToInt32(dgv.SelectedRows[0].Cells["Ano"].Value);
                dt = _dbFluxoAnual.ObterDadosAnual(vid);
                txtanoAno.Text = dt.Rows[0].Field<Int64>("Ano").ToString();
                txtentradaAno.Text = dt.Rows[0].Field<Decimal>("Entrada").ToString();
                txtretornoAno.Text = dt.Rows[0].Field<Decimal>("Retorno").ToString();
                txtdiferencaAno.Text = dt.Rows[0].Field<Decimal>("Diferença").ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                _dbFluxoAnual.DeletarAnual(txtanoAno.Text);
                dataAnual.Rows.Remove(dataAnual.CurrentRow);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                _dbFluxoMensal.DeletarMensal(txtmesMes.Text);
                dataMensal.Rows.Remove(dataMensal.CurrentRow);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataMensal_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dataMensal.SelectedRows.Count;
            if (contLinhas > 0){
                DataTable dt = new DataTable();
                int vid = Convert.ToInt32(dgv.SelectedRows[0].Cells["Mês"].Value);
                dt = _dbFluxoMensal.ObterDadosMensal(vid);

                txtmesMes.Text = dt.Rows[0].Field<Int64>("Mês").ToString();

                if (dt.Rows[0]["Entrada"] != DBNull.Value){
                    txtentradaMes.Text = dt.Rows[0].Field<Decimal>("Entrada").ToString();
                }
                else{
                    txtentradaMes.Text = ""; 
                }

                if (dt.Rows[0]["Retorno"] != DBNull.Value){
                    txtretornoMes.Text = dt.Rows[0].Field<Decimal>("Retorno").ToString();
                }
                else{
                    txtretornoMes.Text = ""; 
                }

                if (dt.Rows[0]["Diferença"] != DBNull.Value){
                    txtdiferencaMes.Text = dt.Rows[0].Field<Decimal>("Diferença").ToString();
                }
                else
                {
                    txtdiferencaMes.Text = ""; 
                }
            }
            else if (string.IsNullOrEmpty(txtmesMes.Text) || string.IsNullOrEmpty(txtentradaMes.Text) || string.IsNullOrEmpty(txtretornoMes.Text) || string.IsNullOrEmpty(txtdiferencaMes.Text)){
                MessageBox.Show("Um ou mais campos em branco");
            }
        }
        private void dataSemanal_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void dataMensal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}