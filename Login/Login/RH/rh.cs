using finanças_Projeto;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolaPe_RH
{
    public partial class rh : Form
    {
        public rh()
        {
            InitializeComponent();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void controleDePontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ponto ponto = new Ponto();
            ponto.Show();
        }

        private void gestãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Carregando page0 = new Carregando();
            page0.Show();


            int passador = 0;
            passador = 1;
            if (passador == 1)
            {
                this.Hide();
            }

        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void avaliaçãoDeDesempenhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roi retorno = new roi();
            retorno.Show();
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fluxo_de_caixa fluxo = new fluxo_de_caixa();
            fluxo.Show();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saláriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios a = new Funcionarios();
            a.Show();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chamadoregistro chamadoregis = new Chamadoregistro();
            chamadoregis.Show();
        }
    }
}
