namespace Login
{
    partial class controledeinventario
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controledeinventario));
            dataInventario = new DataGridView();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            txtProduto = new TextBox();
            button2 = new Button();
            label1 = new Label();
            txtQuantia = new TextBox();
            label2 = new Label();
            button1 = new Button();
            labelID = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataInventario
            // 
            dataInventario.AllowUserToAddRows = false;
            dataInventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataInventario.DefaultCellStyle = dataGridViewCellStyle4;
            dataInventario.EnableHeadersVisualStyles = false;
            dataInventario.Location = new Point(35, 22);
            dataInventario.MultiSelect = false;
            dataInventario.Name = "dataInventario";
            dataInventario.ReadOnly = true;
            dataInventario.RowHeadersVisible = false;
            dataInventario.RowTemplate.Height = 35;
            dataInventario.RowTemplate.ReadOnly = true;
            dataInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataInventario.Size = new Size(804, 682);
            dataInventario.TabIndex = 0;
            dataInventario.CellContentClick += dataGridView1_CellContentClick;
            dataInventario.CellContentDoubleClick += dataInventario_CellContentDoubleClick;
            dataInventario.SelectionChanged += dataInventario_SelectionChanged;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GrayText;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.Gray;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(1043, 651);
            button3.Name = "button3";
            button3.Size = new Size(138, 66);
            button3.TabIndex = 3;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(872, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 435);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtProduto
            // 
            txtProduto.Font = new Font("Tahoma", 16F);
            txtProduto.Location = new Point(895, 497);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(434, 33);
            txtProduto.TabIndex = 6;
            txtProduto.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GrayText;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1200, 651);
            button2.Name = "button2";
            button2.Size = new Size(138, 66);
            button2.TabIndex = 2;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(895, 458);
            label1.Name = "label1";
            label1.Size = new Size(115, 36);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // txtQuantia
            // 
            txtQuantia.Font = new Font("Tahoma", 16F);
            txtQuantia.Location = new Point(895, 585);
            txtQuantia.Name = "txtQuantia";
            txtQuantia.Size = new Size(115, 33);
            txtQuantia.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(895, 553);
            label2.Name = "label2";
            label2.Size = new Size(115, 29);
            label2.TabIndex = 9;
            label2.Text = "Quantia:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(881, 651);
            button1.Name = "button1";
            button1.Size = new Size(138, 66);
            button1.TabIndex = 10;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            labelID.ForeColor = Color.White;
            labelID.Location = new Point(1214, 553);
            labelID.Name = "labelID";
            labelID.Size = new Size(52, 29);
            labelID.TabIndex = 9;
            labelID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Tahoma", 16F);
            txtID.Location = new Point(1214, 585);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(115, 33);
            txtID.TabIndex = 8;
            // 
            // controledeinventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1350, 729);
            Controls.Add(button1);
            Controls.Add(labelID);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(txtQuantia);
            Controls.Add(label1);
            Controls.Add(txtProduto);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataInventario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "controledeinventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de inventário";
            Load += controledeinventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataInventario;
        private Button button3;
        private PictureBox pictureBox1;
        private TextBox txtProduto;
        private Button button2;
        private Label label1;
        private TextBox txtQuantia;
        private Label label2;
        private Button button1;
        private Label labelID;
        private TextBox txtID;
    }
}