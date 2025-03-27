using Login.BancosdeDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Login
{
    public partial class Tarefas : Form
    {
        public class tarefas
        {
            public int id;
            public string tarefa;
        }
        public Tarefas()
        {
            InitializeComponent();
        }

        private void Tarefas_Load(object sender, EventArgs e)
        {
            dgvTarefas.DataSource = _dbProducao.ObterTarefas();
            dgvTarefas.Columns[0].Width = 25;
            dgvTarefas.Columns[1].Width = 370;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                _dbProducao.DeletarTarefas(txtId.Text);
                dgvTarefas.Rows.Remove(dgvTarefas.CurrentRow);
            }
        }

        
        private void dgvTarefas_SelectionChanged(object sender, EventArgs e)
            {
                if (dgvTarefas.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvTarefas.SelectedRows[0];
                    txtId.Text = row.Cells["ID"].Value.ToString();
                    txtTarefas.Text = row.Cells["Tarefas"].Value.ToString();
                    mtxtPrazo.Text = row.Cells["Dia"].Value.ToString();
                }
            }

       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linha = dgvTarefas.SelectedRows[0].Index;
            _dbProducao.tarefas t = new _dbProducao.tarefas();
            t.id = Convert.ToInt32(txtId.Text);
            t.tarefa = Convert.ToString(txtTarefas.Text);

            // Alterar para lidar com a data como string
            string prazo = mtxtPrazo.Text;
            t.prazo = prazo;

            _dbProducao.AtualizarTarefas(t);
            dgvTarefas.DataSource = _dbProducao.ObterTodasTarefas(t.id);
            dgvTarefas.CurrentCell = dgvTarefas[0, linha];
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _dbProducao taf = new _dbProducao(txtTarefas.Text, mtxtPrazo.Text);
            taf.insert();

            _dbProducao.tarefas t = new _dbProducao.tarefas();
            _dbProducao.AtualizarTarefas(t);
            dgvTarefas.DataSource = _dbProducao.ObterTodasTarefas(t.id);
        }

        private void dgvTarefas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtPrazo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvTarefas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }
    }
}

   

