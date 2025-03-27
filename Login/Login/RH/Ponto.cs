using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SolaPe_RH
{
    public partial class Ponto : Form
    {

        public Ponto()
        {
            InitializeComponent();
           /* this.MouseEnter += new EventHandler(Mouseenter);

            btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCalcular.BackColor = Color.Transparent; */
        }

        private void Mouseenter(object sender, EventArgs e){

            /* this.tbxEntrada.Text = "";
            this.tbxEntrada.ForeColor = Color.Black;
            this.tbxSaida.Text = "";
            this.tbxSaida.ForeColor = Color.Black; */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the start and end times from the TextBox controls
                TimeSpan startTime = TimeSpan.Parse(tbxEntrada.Text);
                TimeSpan endTime = TimeSpan.Parse(tbxSaida.Text);

                // Calculate the total time worked
                TimeSpan totalTime = endTime - startTime;

                // Display the total time worked in the Label control
                lblHoras.Text = totalTime.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Por favor, preencha todos os campos!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbxEntrada_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}