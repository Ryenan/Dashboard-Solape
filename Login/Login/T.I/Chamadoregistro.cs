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
    public partial class Chamadoregistro : Form
    {
        public Chamadoregistro()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolta_Click(object sender, EventArgs e)
        { this.Hide(); }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dbChamados cha = new _dbChamados(txtNomee.Text, listSetor.Text, txtDemanda.Text, dateSetor.Text);
            cha.insert();
        }

        private void txtDemanda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
