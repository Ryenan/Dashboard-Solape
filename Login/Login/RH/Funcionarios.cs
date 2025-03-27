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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            dataFuncionario.DataSource = _dbEmpregado.ObterUsuarioId();
            dataFuncionario.ReadOnly = true;
            dataFuncionario.Columns[1].Width = 405;
            dataFuncionario.Columns[2].Width = 180;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linha = dataFuncionario.SelectedRows[0].Index;
            _dbEmpregado._Funcionario f = new _dbEmpregado._Funcionario();
            f.id = Convert.ToInt32(tbId.Text);
            f.nome = tbNome.Text;
            f.cargo = tbCargo.Text;

            // Remove vírgulas da string de salário antes da conversão
            string salarioString = tbSalario.Text.Replace(",", "");
            f.salario = Convert.ToInt32(salarioString);

            _dbEmpregado.AtualizarUsuario(f);
            dataFuncionario.DataSource = _dbEmpregado.ObterUsuarioId();
            dataFuncionario.CurrentCell = dataFuncionario[0, linha];
        }


        private void dataFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataFuncionario_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dataFuncionario.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                int vid = Convert.ToInt32(dgv.SelectedRows[0].Cells["id"].Value);
                dt = _dbEmpregado.ObterDadosUsuario(vid);
                tbNome.Text = dt.Rows[0].Field<String>("Nome").ToString();
                tbCargo.Text = dt.Rows[0].Field<String>("Cargo").ToString();
                tbSalario.Text = dt.Rows[0].Field<Decimal>("Salário").ToString();
                tbId.Text = dt.Rows[0].Field<Int64>("id").ToString();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string cnome = dataFuncionario.SelectedRows[0].Cells["nome"].Value.ToString();
            DialogResult res = MessageBox.Show("Você tem certeza que deseja excluir "+cnome+"?","Confirmação de exclusão", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                _dbEmpregado.DeletarUsuario(tbId.Text);
                dataFuncionario.Rows.Remove(dataFuncionario.CurrentRow);
            }
        }

        private void tbSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

