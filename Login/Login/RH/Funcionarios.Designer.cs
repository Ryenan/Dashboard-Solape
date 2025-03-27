namespace Login
{
    partial class Funcionarios
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
            dataFuncionario = new DataGridView();
            btnEditar = new Button();
            label1 = new Label();
            tbId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbSalario = new TextBox();
            tbCargo = new TextBox();
            tbNome = new TextBox();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataFuncionario).BeginInit();
            SuspendLayout();
            // 
            // dataFuncionario
            // 
            dataFuncionario.AllowUserToAddRows = false;
            dataFuncionario.AllowUserToDeleteRows = false;
            dataFuncionario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFuncionario.EnableHeadersVisualStyles = false;
            dataFuncionario.Location = new Point(436, -1);
            dataFuncionario.MultiSelect = false;
            dataFuncionario.Name = "dataFuncionario";
            dataFuncionario.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataFuncionario.Size = new Size(747, 862);
            dataFuncionario.TabIndex = 0;
            dataFuncionario.CellContentClick += dataFuncionario_CellContentClick;
            dataFuncionario.SelectionChanged += dataFuncionario_SelectionChanged;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(104, 173);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(117, 40);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(288, 73);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // tbId
            // 
            tbId.Location = new Point(322, 75);
            tbId.Name = "tbId";
            tbId.ReadOnly = true;
            tbId.Size = new Size(37, 23);
            tbId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(13, 71);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 5;
            label3.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 6;
            label4.Text = "Salário:";
            // 
            // tbSalario
            // 
            tbSalario.Location = new Point(74, 114);
            tbSalario.Name = "tbSalario";
            tbSalario.Size = new Size(185, 23);
            tbSalario.TabIndex = 3;
            tbSalario.TextChanged += tbSalario_TextChanged;
            // 
            // tbCargo
            // 
            tbCargo.Location = new Point(74, 73);
            tbCargo.Name = "tbCargo";
            tbCargo.Size = new Size(185, 23);
            tbCargo.TabIndex = 3;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(74, 32);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(345, 23);
            tbNome.TabIndex = 3;
            tbNome.TextChanged += tbNome_TextChanged;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Silver;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.Black;
            btnRemover.Location = new Point(274, 173);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(117, 40);
            btnRemover.TabIndex = 7;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // Funcionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1184, 861);
            Controls.Add(btnRemover);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbNome);
            Controls.Add(tbCargo);
            Controls.Add(tbSalario);
            Controls.Add(tbId);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(dataFuncionario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Funcionarios";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de funcionários";
            Load += Funcionarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataFuncionario;
        private Button btnEditar;
        private Label label1;
        private TextBox tbId;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbSalario;
        private TextBox tbCargo;
        private TextBox tbNome;
        private Button btnRemover;
    }
}