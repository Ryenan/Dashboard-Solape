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

namespace Login
{
    public partial class Logistica : Form
    {
        public Logistica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chamadoregistro page4 = new Chamadoregistro();
            page4.Show();
        }

        private void buttonVolta_Click(object sender, EventArgs e)
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

        private void Logistica_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controledeinventario inventario = new controledeinventario();
            inventario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        { }

        private void button5_Click(object sender, EventArgs e)
        {

            Rastreamento rastreio = new Rastreamento();
            rastreio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tarefas t = new Tarefas();
            t.Show();
        }
    }
}
