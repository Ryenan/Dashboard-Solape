namespace Login
{
    partial class Tarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarefas));
            dgvTarefas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtTarefas = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnAdd = new Button();
            mtxtPrazo = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTarefas
            // 
            dgvTarefas.AllowUserToAddRows = false;
            dgvTarefas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarefas.EnableHeadersVisualStyles = false;
            dgvTarefas.Location = new Point(-2, -2);
            dgvTarefas.MultiSelect = false;
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.ReadOnly = true;
            dgvTarefas.RowHeadersVisible = false;
            dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarefas.ShowCellErrors = false;
            dgvTarefas.ShowCellToolTips = false;
            dgvTarefas.ShowEditingIcon = false;
            dgvTarefas.ShowRowErrors = false;
            dgvTarefas.Size = new Size(526, 453);
            dgvTarefas.TabIndex = 1;
            dgvTarefas.CellContentClick += dgvTarefas_CellContentClick;
            dgvTarefas.CellDoubleClick += dgvTarefas_CellDoubleClick;
            dgvTarefas.SelectionChanged += dgvTarefas_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(551, 232);
            label1.Name = "label1";
            label1.Size = new Size(126, 33);
            label1.TabIndex = 2;
            label1.Text = "Tarefas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(551, 298);
            label2.Name = "label2";
            label2.Size = new Size(102, 33);
            label2.TabIndex = 3;
            label2.Text = "Prazo:";
            label2.Click += label2_Click;
            // 
            // txtTarefas
            // 
            txtTarefas.Font = new Font("Tahoma", 12F);
            txtTarefas.Location = new Point(551, 268);
            txtTarefas.Name = "txtTarefas";
            txtTarefas.Size = new Size(459, 27);
            txtTarefas.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Font = new Font("Tahoma", 12F);
            txtId.Location = new Point(928, 334);
            txtId.Name = "txtId";
            txtId.Size = new Size(44, 27);
            txtId.TabIndex = 7;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(922, 304);
            label3.Name = "label3";
            label3.Size = new Size(58, 33);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            label3.Click += label2_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatAppearance.BorderColor = Color.Black;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Tahoma", 17F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(718, 391);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(137, 40);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Silver;
            btnExcluir.FlatAppearance.BorderColor = Color.Black;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Tahoma", 17F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(891, 391);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(137, 40);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 17F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(549, 391);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 40);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // mtxtPrazo
            // 
            mtxtPrazo.Font = new Font("Tahoma", 12F);
            mtxtPrazo.Location = new Point(551, 334);
            mtxtPrazo.Name = "mtxtPrazo";
            mtxtPrazo.Size = new Size(286, 27);
            mtxtPrazo.TabIndex = 10;
            mtxtPrazo.ValueChanged += mtxtPrazo_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(718, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 217);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Tarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1078, 450);
            Controls.Add(pictureBox1);
            Controls.Add(mtxtPrazo);
            Controls.Add(btnAdd);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(txtId);
            Controls.Add(txtTarefas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTarefas);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Tarefas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarefas";
            Load += Tarefas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTarefas;
        private Label label1;
        private Label label2;
        private TextBox txtTarefas;
        private TextBox txtId;
        private Label label3;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnAdd;
        private DateTimePicker mtxtPrazo;
        private PictureBox pictureBox1;
    }
}