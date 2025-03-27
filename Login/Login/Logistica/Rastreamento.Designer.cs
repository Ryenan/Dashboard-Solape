namespace Login
{
    partial class Rastreamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rastreamento));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnAdicionar = new Button();
            btnEditar = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtProduto = new TextBox();
            txtOrigem = new TextBox();
            txtLocalidade = new TextBox();
            txtData = new DateTimePicker();
            btnatt = new Button();
            dgvRastreamento = new DataGridView();
            pictureBox1 = new PictureBox();
            txtPrevisao = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvRastreamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(659, 89);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(153, 56);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(659, 151);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 56);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(659, 213);
            button5.Name = "button5";
            button5.Size = new Size(153, 56);
            button5.TabIndex = 6;
            button5.Text = "Deletar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1141, 494);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 8;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(659, 368);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 9;
            label2.Text = "PRODUTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(658, 418);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 10;
            label3.Text = "ORIGEM:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(658, 468);
            label4.Name = "label4";
            label4.Size = new Size(168, 23);
            label4.TabIndex = 11;
            label4.Text = "DATA DE SAIDA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(658, 520);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 12;
            label5.Text = "LOCALIDADE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(658, 570);
            label6.Name = "label6";
            label6.Size = new Size(249, 23);
            label6.TabIndex = 13;
            label6.Text = "PREVISÃO DE CHEGADA:";
            // 
            // txtId
            // 
            txtId.Location = new Point(1178, 494);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(34, 23);
            txtId.TabIndex = 14;
            // 
            // txtProduto
            // 
            txtProduto.Font = new Font("Tahoma", 8.25F);
            txtProduto.Location = new Point(660, 394);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(447, 21);
            txtProduto.TabIndex = 15;
            // 
            // txtOrigem
            // 
            txtOrigem.Font = new Font("Tahoma", 8.25F);
            txtOrigem.Location = new Point(660, 444);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.Size = new Size(447, 21);
            txtOrigem.TabIndex = 15;
            // 
            // txtLocalidade
            // 
            txtLocalidade.Font = new Font("Tahoma", 8.25F);
            txtLocalidade.Location = new Point(659, 546);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.Size = new Size(447, 21);
            txtLocalidade.TabIndex = 15;
            // 
            // txtData
            // 
            txtData.CalendarFont = new Font("Tahoma", 8.25F);
            txtData.Location = new Point(659, 494);
            txtData.Name = "txtData";
            txtData.Size = new Size(446, 23);
            txtData.TabIndex = 16;
            txtData.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnatt
            // 
            btnatt.BackgroundImage = (Image)resources.GetObject("btnatt.BackgroundImage");
            btnatt.BackgroundImageLayout = ImageLayout.Zoom;
            btnatt.FlatAppearance.BorderSize = 0;
            btnatt.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnatt.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnatt.FlatStyle = FlatStyle.Flat;
            btnatt.Font = new Font("Tahoma", 14F, FontStyle.Bold | FontStyle.Underline);
            btnatt.ForeColor = Color.White;
            btnatt.Location = new Point(643, 9);
            btnatt.Name = "btnatt";
            btnatt.Size = new Size(30, 30);
            btnatt.TabIndex = 17;
            btnatt.UseVisualStyleBackColor = true;
            btnatt.Click += btnatt_Click;
            // 
            // dgvRastreamento
            // 
            dgvRastreamento.AllowUserToAddRows = false;
            dgvRastreamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRastreamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRastreamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRastreamento.EnableHeadersVisualStyles = false;
            dgvRastreamento.Location = new Point(-1, -1);
            dgvRastreamento.MultiSelect = false;
            dgvRastreamento.Name = "dgvRastreamento";
            dgvRastreamento.ReadOnly = true;
            dgvRastreamento.RowHeadersVisible = false;
            dgvRastreamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRastreamento.Size = new Size(632, 640);
            dgvRastreamento.TabIndex = 18;
            dgvRastreamento.CellDoubleClick += dgvRastreamento_CellDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(864, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 341);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // txtPrevisao
            // 
            txtPrevisao.CalendarFont = new Font("Tahoma", 8.25F);
            txtPrevisao.Location = new Point(658, 596);
            txtPrevisao.Name = "txtPrevisao";
            txtPrevisao.Size = new Size(449, 23);
            txtPrevisao.TabIndex = 20;
            // 
            // Rastreamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1243, 638);
            Controls.Add(txtPrevisao);
            Controls.Add(pictureBox1);
            Controls.Add(dgvRastreamento);
            Controls.Add(btnatt);
            Controls.Add(txtData);
            Controls.Add(txtLocalidade);
            Controls.Add(txtOrigem);
            Controls.Add(txtProduto);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rastreamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rastreamento";
            Load += Rastreamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRastreamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdicionar;
        private Button btnEditar;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtProduto;
        private TextBox txtOrigem;
        private TextBox txtLocalidade;
        private DateTimePicker txtData;
        private Button btnatt;
        private DataGridView dgvRastreamento;
        private PictureBox pictureBox1;
        private DateTimePicker txtPrevisao;
    }
}