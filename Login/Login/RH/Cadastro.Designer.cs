namespace SolaPe_RH
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            groupBox1 = new GroupBox();
            tbxSalario = new TextBox();
            txtSalario = new Label();
            tbxUsuario = new TextBox();
            tbxSetor = new ComboBox();
            tbxCargo = new TextBox();
            txtCargo = new Label();
            label5 = new Label();
            tbxSenha = new TextBox();
            tbxHora = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            txtHorario = new Label();
            txtNome = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnCadastrar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(tbxSalario);
            groupBox1.Controls.Add(txtSalario);
            groupBox1.Controls.Add(tbxUsuario);
            groupBox1.Controls.Add(tbxSetor);
            groupBox1.Controls.Add(tbxCargo);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbxSenha);
            groupBox1.Controls.Add(tbxHora);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHorario);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Tahoma", 24F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(14, 278);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(905, 207);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar";
            // 
            // tbxSalario
            // 
            tbxSalario.CharacterCasing = CharacterCasing.Lower;
            tbxSalario.Font = new Font("Tahoma", 16F);
            tbxSalario.Location = new Point(673, 153);
            tbxSalario.Margin = new Padding(4, 3, 4, 3);
            tbxSalario.Name = "tbxSalario";
            tbxSalario.Size = new Size(177, 33);
            tbxSalario.TabIndex = 7;
            // 
            // txtSalario
            // 
            txtSalario.AutoSize = true;
            txtSalario.Font = new Font("Tahoma", 16F);
            txtSalario.Location = new Point(592, 153);
            txtSalario.Margin = new Padding(4, 0, 4, 0);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(86, 27);
            txtSalario.TabIndex = 14;
            txtSalario.Text = "Salário:";
            // 
            // tbxUsuario
            // 
            tbxUsuario.CharacterCasing = CharacterCasing.Upper;
            tbxUsuario.Font = new Font("Tahoma", 16F);
            tbxUsuario.Location = new Point(673, 58);
            tbxUsuario.Margin = new Padding(4, 3, 4, 3);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(177, 33);
            tbxUsuario.TabIndex = 5;
            tbxUsuario.TextChanged += tbxUsuario_TextChanged;
            // 
            // tbxSetor
            // 
            tbxSetor.Font = new Font("Tahoma", 16F);
            tbxSetor.FormattingEnabled = true;
            tbxSetor.Items.AddRange(new object[] { "RH", "T.I", "Logística", "Produção" });
            tbxSetor.Location = new Point(396, 103);
            tbxSetor.Name = "tbxSetor";
            tbxSetor.Size = new Size(171, 33);
            tbxSetor.TabIndex = 3;
            // 
            // tbxCargo
            // 
            tbxCargo.Font = new Font("Tahoma", 16F);
            tbxCargo.Location = new Point(133, 153);
            tbxCargo.Margin = new Padding(4, 3, 4, 3);
            tbxCargo.Name = "tbxCargo";
            tbxCargo.Size = new Size(434, 33);
            tbxCargo.TabIndex = 4;
            // 
            // txtCargo
            // 
            txtCargo.AutoSize = true;
            txtCargo.Font = new Font("Tahoma", 16F);
            txtCargo.Location = new Point(60, 153);
            txtCargo.Margin = new Padding(4, 0, 4, 0);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(77, 27);
            txtCargo.TabIndex = 3;
            txtCargo.Text = "Cargo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16F);
            label5.Location = new Point(326, 106);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 4;
            label5.Text = "Setor:";
            // 
            // tbxSenha
            // 
            tbxSenha.CharacterCasing = CharacterCasing.Lower;
            tbxSenha.Font = new Font("Tahoma", 16F);
            tbxSenha.Location = new Point(673, 106);
            tbxSenha.Margin = new Padding(4, 3, 4, 3);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.PasswordChar = '*';
            tbxSenha.Size = new Size(177, 33);
            tbxSenha.TabIndex = 6;
            // 
            // tbxHora
            // 
            tbxHora.Font = new Font("Tahoma", 16F);
            tbxHora.Location = new Point(133, 103);
            tbxHora.Margin = new Padding(4, 3, 4, 3);
            tbxHora.Name = "tbxHora";
            tbxHora.Size = new Size(171, 33);
            tbxHora.TabIndex = 2;
            tbxHora.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 16F);
            textBox1.Location = new Point(133, 58);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 33);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F);
            label3.Location = new Point(598, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 27);
            label3.TabIndex = 1;
            label3.Text = "Senha:";
            // 
            // txtHorario
            // 
            txtHorario.AutoSize = true;
            txtHorario.Font = new Font("Tahoma", 16F);
            txtHorario.Location = new Point(45, 106);
            txtHorario.Margin = new Padding(4, 0, 4, 0);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(92, 27);
            txtHorario.TabIndex = 1;
            txtHorario.Text = "Horário:";
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Font = new Font("Tahoma", 16F);
            txtNome.Location = new Point(61, 61);
            txtNome.Margin = new Padding(4, 0, 4, 0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(77, 27);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 16F);
            label6.Location = new Point(586, 61);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 27);
            label6.TabIndex = 13;
            label6.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -2);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(938, 525);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Gainsboro;
            btnCadastrar.FlatAppearance.BorderColor = Color.DarkGray;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.White;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.Black;
            btnCadastrar.Location = new Point(785, 228);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(134, 44);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Confirmar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            btnCadastrar.KeyUp += btnCadastrar_KeyUp;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(933, 519);
            Controls.Add(btnCadastrar);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Cadastro";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxHora;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtHorario;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TextBox tbxCargo;
        private Label txtCargo;
        private Label label5;
        private ComboBox tbxSetor;
        private Button btnCadastrar;
        private TextBox tbxUsuario;
        private Label label6;
        private TextBox tbxSalario;
        private Label txtSalario;
    }
}