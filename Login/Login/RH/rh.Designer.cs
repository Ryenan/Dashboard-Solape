namespace SolaPe_RH
{
    partial class rh
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rh));
            menuStrip1 = new MenuStrip();
            gestãoToolStripMenuItem = new ToolStripMenuItem();
            controleDePontoToolStripMenuItem = new ToolStripMenuItem();
            saláriosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            financeiroToolStripMenuItem1 = new ToolStripMenuItem();
            rOIToolStripMenuItem = new ToolStripMenuItem();
            fluxoDeCaixaToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gray;
            menuStrip1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestãoToolStripMenuItem, financeiroToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1350, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestãoToolStripMenuItem
            // 
            gestãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controleDePontoToolStripMenuItem, saláriosToolStripMenuItem, cadastrarFuncionárioToolStripMenuItem });
            gestãoToolStripMenuItem.Name = "gestãoToolStripMenuItem";
            gestãoToolStripMenuItem.Size = new Size(207, 23);
            gestãoToolStripMenuItem.Text = "Gestão de funcionários";
            gestãoToolStripMenuItem.Click += gestãoToolStripMenuItem_Click;
            // 
            // controleDePontoToolStripMenuItem
            // 
            controleDePontoToolStripMenuItem.Name = "controleDePontoToolStripMenuItem";
            controleDePontoToolStripMenuItem.Size = new Size(254, 24);
            controleDePontoToolStripMenuItem.Text = "Calculador de horas";
            controleDePontoToolStripMenuItem.Click += controleDePontoToolStripMenuItem_Click;
            // 
            // saláriosToolStripMenuItem
            // 
            saláriosToolStripMenuItem.Name = "saláriosToolStripMenuItem";
            saláriosToolStripMenuItem.Size = new Size(254, 24);
            saláriosToolStripMenuItem.Text = "Funcionários";
            saláriosToolStripMenuItem.Click += saláriosToolStripMenuItem_Click;
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            cadastrarFuncionárioToolStripMenuItem.Size = new Size(254, 24);
            cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar funcionário";
            cadastrarFuncionárioToolStripMenuItem.Click += cadastrarFuncionárioToolStripMenuItem_Click_1;
            // 
            // financeiroToolStripMenuItem1
            // 
            financeiroToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { rOIToolStripMenuItem, fluxoDeCaixaToolStripMenuItem });
            financeiroToolStripMenuItem1.Name = "financeiroToolStripMenuItem1";
            financeiroToolStripMenuItem1.Size = new Size(105, 23);
            financeiroToolStripMenuItem1.Text = "Financeiro";
            // 
            // rOIToolStripMenuItem
            // 
            rOIToolStripMenuItem.Name = "rOIToolStripMenuItem";
            rOIToolStripMenuItem.Size = new Size(355, 24);
            rOIToolStripMenuItem.Text = "Retorno sobre investimento (ROI)";
            rOIToolStripMenuItem.Click += rOIToolStripMenuItem_Click;
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            fluxoDeCaixaToolStripMenuItem.Size = new Size(355, 24);
            fluxoDeCaixaToolStripMenuItem.Text = "Fluxo de caixa";
            fluxoDeCaixaToolStripMenuItem.Click += fluxoDeCaixaToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1350, 718);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1214, 677);
            button2.Name = "button2";
            button2.Size = new Size(124, 40);
            button2.TabIndex = 3;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 677);
            button3.Name = "button3";
            button3.Size = new Size(124, 40);
            button3.TabIndex = 4;
            button3.Text = "Chamados";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // rh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1350, 729);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "rh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RH";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDePontoToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private ToolStripMenuItem financeiroToolStripMenuItem1;
        private ToolStripMenuItem rOIToolStripMenuItem;
        private ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private ToolStripMenuItem saláriosToolStripMenuItem;
        private ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
    }
}

