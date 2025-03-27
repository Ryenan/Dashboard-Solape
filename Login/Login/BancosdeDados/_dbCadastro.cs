using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class _dbCadastro
    {

        string Nome;
        string Cargo;
        string Horário;
        string Salário;

        public string getNome() { return Nome; }
        public string getCargo() { return Cargo; }
        public string getHorário() { return Horário; }
        public string getSalário() { return Salário; }

        public _dbCadastro(string Nome, string Cargo, string Horário, string Salário)
        {
            this.Nome = Nome;
            this.Cargo = Cargo;
            this.Horário = Horário;
            this.Salário = Salário;
        }
        public void insert()
        {
            try
            {
                using var cmd = _dbBanco.ConexaoBanco().CreateCommand();
                {
                    cmd.CommandText = "INSERT INTO empregados(Nome,Cargo,Horário,Salário) VALUES (@Nome,@Cargo,@Horário,@Salário)";
                    cmd.Parameters.AddWithValue("@Nome", this.Nome);
                    cmd.Parameters.AddWithValue("@Cargo", this.Cargo);
                    cmd.Parameters.AddWithValue("@Horário", this.Horário);
                    cmd.Parameters.AddWithValue("@Salário", this.Salário);

                    _dbBanco.Confirmarbanco(cmd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar");
            }
        }
    }
}
