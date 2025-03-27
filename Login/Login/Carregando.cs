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
    public partial class Carregando : Form
    {
        public Carregando()
        {
            InitializeComponent();
            this.Load += async (sender, e) =>
            {
                await Task.Delay(1); // wait for 5 seconds
                this.Hide();
                
                Login page0 = new Login();
                page0.Show();
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Carregando_Load(object sender, EventArgs e)
        {

        }
    }
}
