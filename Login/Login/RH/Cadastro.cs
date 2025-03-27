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
using System.Data.SQLite;
using System.Linq.Expressions;

namespace SolaPe_RH
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)

        {
            _dbEmpregado empre = new _dbEmpregado(tbxUsuario.Text, tbxSenha.Text, tbxSetor.Text);
            empre.insert();
            
            _dbCadastro cra = new _dbCadastro(textBox1.Text, tbxCargo.Text, tbxHora.Text, tbxSalario.Text);
            cra.insert();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.PerformClick();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
