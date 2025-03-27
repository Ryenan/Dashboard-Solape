namespace SolaPe_RH
{
    partial class Ponto
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
            label1 = new Label();
            label2 = new Label();
            tbxEntrada = new TextBox();
            tbxSaida = new TextBox();
            btnCalcular = new Button();
            lblHoras = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Tahoma", 24F);
            label1.Location = new Point(86, 91);
            label1.Name = "label1";
            label1.Size = new Size(139, 39);
            label1.TabIndex = 1;
            label1.Text = "Entrada:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Tahoma", 24F);
            label2.Location = new Point(86, 210);
            label2.Name = "label2";
            label2.Size = new Size(105, 39);
            label2.TabIndex = 2;
            label2.Text = "Saida:";
            // 
            // tbxEntrada
            // 
            tbxEntrada.Font = new Font("Tahoma", 24F);
            tbxEntrada.ForeColor = Color.Black;
            tbxEntrada.Location = new Point(86, 127);
            tbxEntrada.Name = "tbxEntrada";
            tbxEntrada.Size = new Size(148, 46);
            tbxEntrada.TabIndex = 3;
            tbxEntrada.TextChanged += tbxEntrada_TextChanged;
            // 
            // tbxSaida
            // 
            tbxSaida.Font = new Font("Tahoma", 24F);
            tbxSaida.ForeColor = Color.Black;
            tbxSaida.Location = new Point(86, 246);
            tbxSaida.Name = "tbxSaida";
            tbxSaida.Size = new Size(148, 46);
            tbxSaida.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Transparent;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            btnCalcular.Location = new Point(304, 352);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(166, 47);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular Horas";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Tahoma", 24F);
            lblHoras.Location = new Point(443, 168);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(0, 39);
            lblHoras.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Tahoma", 24F);
            label4.Location = new Point(341, 91);
            label4.Name = "label4";
            label4.Size = new Size(419, 39);
            label4.TabIndex = 7;
            label4.Text = "O funcionário trabalhou por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8F);
            label3.Location = new Point(109, 177);
            label3.Name = "label3";
            label3.Size = new Size(82, 13);
            label3.TabIndex = 8;
            label3.Text = "Exemplo: 12:30";
            // 
            // Ponto
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lblHoras);
            Controls.Add(btnCalcular);
            Controls.Add(tbxSaida);
            Controls.Add(tbxEntrada);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Ponto";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ponto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEntrada;
        private System.Windows.Forms.TextBox tbxSaida;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label4;
        private Label label3;
    }
}