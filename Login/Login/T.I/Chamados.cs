using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Chamados : Form
    {
        public Chamados()
        {

            SQLiteConnection con;
            string connectionString = "Data Source = ..\\..\\..\\..\\..\\banco_de_dados";

            InitializeComponent();

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(connectionString))
                {
                    con = cn;
                    con.Open();

                    var tbchamados = "SELECT * FROM chamados";
                    using (SQLiteDataAdapter Variavelchamados = new SQLiteDataAdapter(tbchamados, con))
                    {
                        using (DataTable Char = new DataTable())
                        {
                            Variavelchamados.Fill(Char);

                            dataGridView1.DataSource = Char;
                            dataGridView1.ReadOnly = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha de conexão com o banco de dados: {ex.Message}. Por favor, consulte o suporte.");
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                _dbChamados.DeletarChamado(txtID.Text);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[1].Width = 305;
                dataGridView1.Columns[2].Width = 652;
                dataGridView1.Columns[3].Width = 180;
            }
        }

        private void Chamados_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dbChamados.ObterChamados();
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 305;
            dataGridView1.Columns[2].Width = 652;
            dataGridView1.Columns[3].Width = 180;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chamadoregistro page4 = new Chamadoregistro();
            page4.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dbChamados.ObterChamados();
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dataGridView1.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                int vid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                dt = _dbChamados.ObterChamadosDados(vid);
                txtID.Text = dt.Rows[0].Field<Int64>("ID").ToString();
            }
        }
    }
}