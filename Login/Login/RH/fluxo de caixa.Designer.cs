namespace finanças_Projeto
{
    partial class fluxo_de_caixa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataMensal = new DataGridView();
            dataAnual = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            label4 = new Label();
            txtmesMes = new TextBox();
            txtdiferencaMes = new TextBox();
            txtentradaMes = new TextBox();
            txtretornoMes = new TextBox();
            label10 = new Label();
            txtanoAno = new TextBox();
            label11 = new Label();
            txtdiferencaAno = new TextBox();
            label12 = new Label();
            txtentradaAno = new TextBox();
            label15 = new Label();
            txtretornoAno = new TextBox();
            button6 = new Button();
            label5 = new Label();
            label6 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataMensal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataAnual).BeginInit();
            SuspendLayout();
            // 
            // dataMensal
            // 
            dataMensal.AllowUserToAddRows = false;
            dataMensal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataMensal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataMensal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataMensal.DefaultCellStyle = dataGridViewCellStyle2;
            dataMensal.EnableHeadersVisualStyles = false;
            dataMensal.Location = new Point(60, 65);
            dataMensal.MultiSelect = false;
            dataMensal.Name = "dataMensal";
            dataMensal.ReadOnly = true;
            dataMensal.RowHeadersVisible = false;
            dataMensal.RowTemplate.ReadOnly = true;
            dataMensal.RowTemplate.Resizable = DataGridViewTriState.False;
            dataMensal.ScrollBars = ScrollBars.None;
            dataMensal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataMensal.ShowCellErrors = false;
            dataMensal.ShowCellToolTips = false;
            dataMensal.ShowEditingIcon = false;
            dataMensal.ShowRowErrors = false;
            dataMensal.Size = new Size(443, 557);
            dataMensal.TabIndex = 1;
            dataMensal.CellContentClick += dataMensal_CellContentClick;
            dataMensal.SelectionChanged += dataMensal_SelectionChanged;
            // 
            // dataAnual
            // 
            dataAnual.AllowUserToAddRows = false;
            dataAnual.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataAnual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataAnual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAnual.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataAnual.EnableHeadersVisualStyles = false;
            dataAnual.Location = new Point(767, 65);
            dataAnual.MultiSelect = false;
            dataAnual.Name = "dataAnual";
            dataAnual.ReadOnly = true;
            dataAnual.RowHeadersVisible = false;
            dataAnual.RowTemplate.ReadOnly = true;
            dataAnual.RowTemplate.Resizable = DataGridViewTriState.False;
            dataAnual.ScrollBars = ScrollBars.None;
            dataAnual.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataAnual.ShowCellErrors = false;
            dataAnual.ShowCellToolTips = false;
            dataAnual.ShowEditingIcon = false;
            dataAnual.ShowRowErrors = false;
            dataAnual.Size = new Size(443, 560);
            dataAnual.TabIndex = 2;
            dataAnual.SelectionChanged += dataAnual_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = Color.White;
            label2.Location = new Point(235, 18);
            label2.Name = "label2";
            label2.Size = new Size(90, 27);
            label2.TabIndex = 4;
            label2.Text = "Mensal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold | FontStyle.Underline);
            label3.ForeColor = Color.White;
            label3.Location = new Point(955, 18);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 5;
            label3.Text = "Anual";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(520, 202);
            button2.Name = "button2";
            button2.Size = new Size(100, 46);
            button2.TabIndex = 40;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Gray;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1216, 205);
            button3.Name = "button3";
            button3.Size = new Size(100, 46);
            button3.TabIndex = 42;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Gray;
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(520, 265);
            button5.Name = "button5";
            button5.Size = new Size(100, 46);
            button5.TabIndex = 46;
            button5.Text = "Limpar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(60, 635);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 54;
            label4.Text = "Mês";
            label4.Click += label4_Click;
            // 
            // txtmesMes
            // 
            txtmesMes.BackColor = Color.WhiteSmoke;
            txtmesMes.Font = new Font("Tahoma", 12F);
            txtmesMes.Location = new Point(60, 661);
            txtmesMes.Name = "txtmesMes";
            txtmesMes.Size = new Size(100, 27);
            txtmesMes.TabIndex = 1;
            // 
            // txtdiferencaMes
            // 
            txtdiferencaMes.BackColor = Color.WhiteSmoke;
            txtdiferencaMes.Font = new Font("Tahoma", 12F);
            txtdiferencaMes.Location = new Point(403, 661);
            txtdiferencaMes.Name = "txtdiferencaMes";
            txtdiferencaMes.Size = new Size(100, 27);
            txtdiferencaMes.TabIndex = 4;
            // 
            // txtentradaMes
            // 
            txtentradaMes.BackColor = Color.WhiteSmoke;
            txtentradaMes.Font = new Font("Tahoma", 12F);
            txtentradaMes.Location = new Point(174, 661);
            txtentradaMes.Name = "txtentradaMes";
            txtentradaMes.Size = new Size(100, 27);
            txtentradaMes.TabIndex = 2;
            // 
            // txtretornoMes
            // 
            txtretornoMes.BackColor = Color.WhiteSmoke;
            txtretornoMes.Font = new Font("Tahoma", 12F);
            txtretornoMes.Location = new Point(289, 661);
            txtretornoMes.Name = "txtretornoMes";
            txtretornoMes.Size = new Size(100, 27);
            txtretornoMes.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(772, 635);
            label10.Name = "label10";
            label10.Size = new Size(47, 23);
            label10.TabIndex = 62;
            label10.Text = "Ano";
            // 
            // txtanoAno
            // 
            txtanoAno.BackColor = Color.WhiteSmoke;
            txtanoAno.Font = new Font("Tahoma", 12F);
            txtanoAno.Location = new Point(772, 661);
            txtanoAno.Name = "txtanoAno";
            txtanoAno.Size = new Size(100, 27);
            txtanoAno.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(1115, 635);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 60;
            label11.Text = "Diferença";
            // 
            // txtdiferencaAno
            // 
            txtdiferencaAno.BackColor = Color.WhiteSmoke;
            txtdiferencaAno.Font = new Font("Tahoma", 12F);
            txtdiferencaAno.Location = new Point(1115, 661);
            txtdiferencaAno.Name = "txtdiferencaAno";
            txtdiferencaAno.Size = new Size(100, 27);
            txtdiferencaAno.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(887, 635);
            label12.Name = "label12";
            label12.Size = new Size(84, 23);
            label12.TabIndex = 58;
            label12.Text = "Entrada";
            // 
            // txtentradaAno
            // 
            txtentradaAno.BackColor = Color.WhiteSmoke;
            txtentradaAno.Font = new Font("Tahoma", 12F);
            txtentradaAno.Location = new Point(887, 661);
            txtentradaAno.Name = "txtentradaAno";
            txtentradaAno.Size = new Size(100, 27);
            txtentradaAno.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(1003, 635);
            label15.Name = "label15";
            label15.Size = new Size(87, 23);
            label15.TabIndex = 56;
            label15.Text = "Retorno";
            label15.Click += label15_Click;
            // 
            // txtretornoAno
            // 
            txtretornoAno.BackColor = Color.WhiteSmoke;
            txtretornoAno.Font = new Font("Tahoma", 12F);
            txtretornoAno.Location = new Point(1003, 661);
            txtretornoAno.Name = "txtretornoAno";
            txtretornoAno.Size = new Size(100, 27);
            txtretornoAno.TabIndex = 3;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Gray;
            button6.FlatAppearance.MouseOverBackColor = Color.Silver;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(1216, 268);
            button6.Name = "button6";
            button6.Size = new Size(100, 46);
            button6.TabIndex = 63;
            button6.Text = "Limpar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(174, 635);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 58;
            label5.Text = "Entrada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(289, 635);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 56;
            label6.Text = "Retorno";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(403, 635);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 60;
            label14.Text = "Diferença";
            // 
            // fluxo_de_caixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1350, 729);
            Controls.Add(label10);
            Controls.Add(txtanoAno);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(txtdiferencaAno);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(txtentradaAno);
            Controls.Add(label6);
            Controls.Add(label15);
            Controls.Add(txtretornoAno);
            Controls.Add(label4);
            Controls.Add(txtmesMes);
            Controls.Add(txtdiferencaMes);
            Controls.Add(txtentradaMes);
            Controls.Add(txtretornoMes);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataAnual);
            Controls.Add(dataMensal);
            Controls.Add(button5);
            Controls.Add(button6);
            Name = "fluxo_de_caixa";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Fluxo de caixa";
            Load += fluxo_de_caixa_Load;
            ((System.ComponentModel.ISupportInitialize)dataMensal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataAnual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataMensal;
        private DataGridView dataAnual;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button5;
        private Label label4;
        private TextBox txtmesMes;
        private TextBox txtdiferencaMes;
        private TextBox txtentradaMes;
        private TextBox txtretornoMes;
        private Label label10;
        private TextBox txtanoAno;
        private Label label11;
        private TextBox txtdiferencaAno;
        private Label label12;
        private TextBox txtentradaAno;
        private Label label15;
        private TextBox txtretornoAno;
        private Button button6;
        private Label label5;
        private Label label6;
        private Label label14;
    }
}