namespace Login
{
    partial class Chamadoregistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chamadoregistro));
            txtNomee = new TextBox();
            txtNome = new Label();
            label1 = new Label();
            txtDemanda = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            dateSetor = new DateTimePicker();
            label4 = new Label();
            button1 = new Button();
            btnVolta = new Button();
            listSetor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomee
            // 
            txtNomee.Font = new Font("Tahoma", 16F);
            txtNomee.Location = new Point(60, 389);
            txtNomee.Name = "txtNomee";
            txtNomee.Size = new Size(278, 33);
            txtNomee.TabIndex = 2;
            txtNomee.TextChanged += textBox1_TextChanged;
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            txtNome.ForeColor = Color.White;
            txtNome.Location = new Point(60, 357);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(84, 29);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 215);
            label1.Name = "label1";
            label1.Size = new Size(142, 29);
            label1.TabIndex = 3;
            label1.Text = "Ocorrência";
            // 
            // txtDemanda
            // 
            txtDemanda.Font = new Font("Tahoma", 16F);
            txtDemanda.Location = new Point(60, 247);
            txtDemanda.Name = "txtDemanda";
            txtDemanda.Size = new Size(758, 33);
            txtDemanda.TabIndex = 1;
            txtDemanda.TextChanged += txtDemanda_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(863, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(476, 475);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(411, 357);
            label2.Name = "label2";
            label2.Size = new Size(77, 29);
            label2.TabIndex = 6;
            label2.Text = "Setor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(583, 357);
            label3.Name = "label3";
            label3.Size = new Size(69, 29);
            label3.TabIndex = 9;
            label3.Text = "Data";
            // 
            // dateSetor
            // 
            dateSetor.Font = new Font("Tahoma", 16F);
            dateSetor.Location = new Point(583, 389);
            dateSetor.Name = "dateSetor";
            dateSetor.Size = new Size(235, 33);
            dateSetor.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 48F, FontStyle.Bold | FontStyle.Underline);
            label4.ForeColor = Color.White;
            label4.Location = new Point(117, 51);
            label4.Name = "label4";
            label4.Size = new Size(666, 77);
            label4.TabIndex = 11;
            label4.Text = "Cadastrar Chamado";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(73, 580);
            button1.Name = "button1";
            button1.Size = new Size(211, 77);
            button1.TabIndex = 12;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnVolta
            // 
            btnVolta.FlatAppearance.BorderSize = 0;
            btnVolta.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnVolta.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnVolta.FlatStyle = FlatStyle.Flat;
            btnVolta.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            btnVolta.ForeColor = Color.White;
            btnVolta.Location = new Point(607, 580);
            btnVolta.Name = "btnVolta";
            btnVolta.Size = new Size(211, 77);
            btnVolta.TabIndex = 13;
            btnVolta.Text = "Voltar";
            btnVolta.UseVisualStyleBackColor = true;
            btnVolta.Click += btnVolta_Click;
            // 
            // listSetor
            // 
            listSetor.Font = new Font("Tahoma", 16F);
            listSetor.FormattingEnabled = true;
            listSetor.Items.AddRange(new object[] { "RH", "T.I", "Logística", "Produção" });
            listSetor.Location = new Point(390, 389);
            listSetor.Name = "listSetor";
            listSetor.Size = new Size(121, 33);
            listSetor.TabIndex = 14;
            // 
            // Chamadoregistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1350, 729);
            Controls.Add(listSetor);
            Controls.Add(btnVolta);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dateSetor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtDemanda);
            Controls.Add(txtNome);
            Controls.Add(txtNomee);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(1366, 768);
            Name = "Chamadoregistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar chamado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomee;
        private Label txtNome;
        private Label label1;
        private TextBox txtDemanda;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateSetor;
        private Label label4;
        private Button button1;
        private Button btnVolta;
        private ComboBox listSetor;
    }
}