using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Login
{
    public partial class Rastreamento : Form
    {
        public Rastreamento()
        {
            InitializeComponent();
        }

        private void Rastreamento_Load(object sender, EventArgs e)
        {
            dgvRastreamento.DataSource = _dbRastreamento.ObterRastreamento();
            dgvRastreamento.Columns[0].Width = 35;
            dgvRastreamento.Columns[4].Width = 195;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                _dbRastreamento.DeletarRastreamento(txtId.Text);
                dgvRastreamento.Rows.Remove(dgvRastreamento.CurrentRow);
            }
        }

        private void dgvRastreamento_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linha = dgvRastreamento.SelectedRows[0].Index;
            _dbRastreamento.rastreamento r = new _dbRastreamento.rastreamento();
            r.id = Convert.ToInt32(txtId.Text);
            r.produto = Convert.ToString(txtProduto.Text);
            r.origem = Convert.ToString(txtOrigem.Text);
            r.datasaida = Convert.ToString(txtData.Text);
            r.localidade = Convert.ToString(txtLocalidade.Text);
            r.previsaodechegada = Convert.ToString(txtPrevisao.Text);

            _dbRastreamento.AtualizarRastramento(r);
            dgvRastreamento.DataSource = _dbRastreamento.ObterRastreamento();
            dgvRastreamento.CurrentCell = dgvRastreamento[0, linha];
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _dbRastreamento taf = new _dbRastreamento(txtProduto.Text, txtOrigem.Text, txtData.Text, txtLocalidade.Text, txtPrevisao.Text);
            taf.insert();
            dgvRastreamento.DataSource = _dbRastreamento.ObterRastreamento();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnatt_Click(object sender, EventArgs e)
        {

        }

        private void dgvTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRastreamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvRastreamento = (DataGridView)sender;
            int contLinhas = dgvRastreamento.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                int vid = Convert.ToInt32(dgvRastreamento.SelectedRows[0].Cells["id"].Value);
                dt = _dbRastreamento.ObterDadosRastreamento(vid);
                txtId.Text = dt.Rows[0].Field<Int64>("id").ToString();
                txtProduto.Text = dt.Rows[0].Field<String>("produto").ToString();
                txtOrigem.Text = dt.Rows[0].Field<String>("origem").ToString();
                txtData.Text = dt.Rows[0]["datasaida"].ToString();
                txtLocalidade.Text = dt.Rows[0].Field<String>("localidade").ToString();
                txtPrevisao.Text = dt.Rows[0]["previsaodechegada"].ToString();
            }
        }
    }

}
