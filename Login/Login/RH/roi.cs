using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finanças_Projeto
{
    public partial class roi : Form
    {
        public roi()
        {
            InitializeComponent();
        }

        private void tbxInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbxRetorno.Text) || string.IsNullOrEmpty(tbxCustos.Text) || string.IsNullOrEmpty(tbxInicial.Text)){ 
                MessageBox.Show("Por favor, preencha os campos!","Erro, caixa em branco!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{

                decimal retorno = Convert.ToDecimal(tbxRetorno.Text);
                decimal custos = Convert.ToDecimal(tbxCustos.Text);
                decimal inicial = Convert.ToDecimal(tbxInicial.Text);

                // Calculando o ROI
                decimal total = retorno - custos - inicial;
                decimal roi = (total/ inicial) * 100;
                roi = Math.Round(roi, 2);
                


            // Exibindo o resultado no rótulo
            lblResul.Text = $"ROI: {roi,2}%";

            if (roi > 0){
                txtnum.Text = "Lucro:" + Convert.ToString(total);
                lblResul.ForeColor = Color.Green;
                txtnum.ForeColor = Color.Green;
            }else if (roi < 0){
                txtnum.Text = "Perda:" + Convert.ToString(total);
                lblResul.ForeColor = Color.Red;
                txtnum.ForeColor = Color.Red;
            }else{
                txtnum.Text = "Retorno:" + Convert.ToString(total);
                lblResul.ForeColor = Color.White;
                txtnum.ForeColor= Color.White;
                }
            }
            }
        private void roi_Load(object sender, EventArgs e)
        {
            
        }
    }
}
