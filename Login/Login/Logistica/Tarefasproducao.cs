using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Tarefasproducao : Form
    {
        public Tarefasproducao()
        {
            InitializeComponent();
            dataGridView1.DataSource = _dbProducao.ObterTarefas();
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 370;
            dataGridView1.Columns[2].Width = 182; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                _dbProducao.DeletarTarefas(txtID.Text);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int passador = 0;
                Login page0 = new Login();
                page0.Show();
                passador = 1;
                if (passador == 1)
                {
                    this.Hide();
                }

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dataGridView1.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                int vid = Convert.ToInt32(dgv.SelectedRows[0].Cells["id"].Value);
                dt = _dbProducao.ObterTodasTarefas(vid);
                txtID.Text = dt.Rows[0].Field<Int64>("id").ToString();
            }
        }
    }
}
