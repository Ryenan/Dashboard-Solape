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
    public partial class Teladecarregamento : Form
    {
        public Teladecarregamento()
        {
            InitializeComponent();
            this.Load += async (sender, e) =>
            {
                await Task.Delay(3000);
                this.Hide();

                Login page0 = new Login();
                page0.Show();
            };
        }

        private void Teladecarregamento_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
