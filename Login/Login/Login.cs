using finanças_Projeto;
using SolaPe_RH;
using System.Data;

namespace Login
{
    public partial class Login : Form
    {

        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string usuario = txtUser.Text;
            string senha = txtPass.Text;


            string sql = "SELECT * FROM funcionario WHERE usuario = '" + usuario + "' AND senha = '" + senha + "'";
            dt = _dbBanco.consulta(sql);
            if (dt.Rows.Count == 1) //Conta quantas tabelas tem com dados
            {
                string setor = dt.Rows[0]["setor"].ToString();

                if (setor == "T.I")
                {
                    Chamados d = new Chamados();
                    d.Show();
                    this.Hide();
                }
                else if (setor == "Logística")
                {
                    Logistica d = new Logistica();
                    d.Show();
                    this.Hide();
                }
                else if (setor == "RH")
                {
                    rh d = new rh();
                    d.Show();
                    this.Hide();
                }
                else if (setor == "Produção")
                {
                    Tarefasproducao d = new Tarefasproducao();
                    d.Show();
                    this.Hide();
                }
                else
                {
                    txtAviso.Text = "Erro no seu cadastro, por favor consulte o suporte";
                    txtAviso.Location = new Point(710, 359);
                }
            }
            else
            {
                txtAviso.Text = "Usuário ou senha inválido";
                txtAviso.Location = new Point(786, 359);
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
} 
