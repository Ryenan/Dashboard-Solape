namespace finanças_Projeto
{
    partial class roi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roi));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxInicial = new TextBox();
            tbxCustos = new TextBox();
            tbxRetorno = new TextBox();
            btnCalc = new Button();
            lblResul = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtnum = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(242, 27);
            label1.TabIndex = 0;
            label1.Text = "Investimento inicial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            label2.Location = new Point(42, 99);
            label2.Name = "label2";
            label2.Size = new Size(245, 27);
            label2.TabIndex = 1;
            label2.Text = "Custos Operacionais:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            label3.Location = new Point(54, 151);
            label3.Name = "label3";
            label3.Size = new Size(233, 27);
            label3.TabIndex = 2;
            label3.Text = "Retorno Financeiro:";
            // 
            // tbxInicial
            // 
            tbxInicial.Font = new Font("Tahoma", 12F);
            tbxInicial.Location = new Point(295, 49);
            tbxInicial.Name = "tbxInicial";
            tbxInicial.Size = new Size(100, 27);
            tbxInicial.TabIndex = 3;
            tbxInicial.TextChanged += tbxInicial_TextChanged;
            // 
            // tbxCustos
            // 
            tbxCustos.Font = new Font("Tahoma", 12F);
            tbxCustos.Location = new Point(295, 101);
            tbxCustos.Name = "tbxCustos";
            tbxCustos.Size = new Size(100, 27);
            tbxCustos.TabIndex = 4;
            // 
            // tbxRetorno
            // 
            tbxRetorno.Font = new Font("Tahoma", 12F);
            tbxRetorno.Location = new Point(295, 153);
            tbxRetorno.Name = "tbxRetorno";
            tbxRetorno.Size = new Size(100, 27);
            tbxRetorno.TabIndex = 5;
            // 
            // btnCalc
            // 
            btnCalc.FlatStyle = FlatStyle.Flat;
            btnCalc.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            btnCalc.Location = new Point(269, 197);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(153, 55);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calcule";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            lblResul.Location = new Point(516, 49);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(0, 39);
            lblResul.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(698, 386);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 62);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Silver;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 376);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(814, 89);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // txtnum
            // 
            txtnum.AutoSize = true;
            txtnum.Font = new Font("Tahoma", 24F, FontStyle.Bold);
            txtnum.Location = new Point(516, 120);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(0, 39);
            txtnum.TabIndex = 11;
            // 
            // roi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnum);
            Controls.Add(pictureBox1);
            Controls.Add(lblResul);
            Controls.Add(btnCalc);
            Controls.Add(tbxRetorno);
            Controls.Add(tbxCustos);
            Controls.Add(tbxInicial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Name = "roi";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Retorno sobre investimento";
            Load += roi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxInicial;
        private TextBox tbxCustos;
        private TextBox tbxRetorno;
        private Button btnCalc;
        private Label lblResul;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label txtnum;
    }
}