namespace Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label4 = new Label();
            btnEntrar = new Button();
            txtAviso = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-165, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(789, 549);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 32F);
            label1.Location = new Point(659, 35);
            label1.Name = "label1";
            label1.Size = new Size(98, 52);
            label1.TabIndex = 1;
            label1.Text = "Olá,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Tahoma", 32F);
            label2.Location = new Point(659, 87);
            label2.Name = "label2";
            label2.Size = new Size(332, 52);
            label2.TabIndex = 2;
            label2.Text = "Seja bem-vindo!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(760, 184);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 3;
            label3.Text = "Usuário";
            // 
            // txtUser
            // 
            txtUser.CharacterCasing = CharacterCasing.Upper;
            txtUser.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(760, 206);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(248, 46);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("TechnicBold", 24F);
            txtPass.Location = new Point(760, 299);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(248, 43);
            txtPass.TabIndex = 2;
            txtPass.TextChanged += textBox2_TextChanged;
            txtPass.KeyUp += txtPass_KeyUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(760, 277);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            btnEntrar.Location = new Point(814, 394);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(132, 51);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtAviso
            // 
            txtAviso.AutoSize = true;
            txtAviso.Font = new Font("Tahoma", 12F);
            txtAviso.ForeColor = Color.Red;
            txtAviso.Location = new Point(786, 359);
            txtAviso.Name = "txtAviso";
            txtAviso.Size = new Size(0, 19);
            txtAviso.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1155, 547);
            ControlBox = false;
            Controls.Add(txtAviso);
            Controls.Add(btnEntrar);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1155, 547);
            MinimizeBox = false;
            MinimumSize = new Size(1155, 547);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Página de login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label4;
        private Button btnEntrar;
        private Label txtAviso;
    }
}
