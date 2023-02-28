namespace Cadastro_projeto
{
    partial class Exibicao
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
            dataGridView1 = new DataGridView();
            Login = new DataGridViewTextBoxColumn();
            situacao = new DataGridViewTextBoxColumn();
            cadastrarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Login, situacao });
            dataGridView1.Location = new Point(-2, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(803, 269);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Login
            // 
            Login.HeaderText = "Login";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            // 
            // situacao
            // 
            situacao.HeaderText = "Situação";
            situacao.MinimumWidth = 6;
            situacao.Name = "situacao";
            // 
            // cadastrarBtn
            // 
            cadastrarBtn.Location = new Point(313, 324);
            cadastrarBtn.Name = "cadastrarBtn";
            cadastrarBtn.Size = new Size(194, 70);
            cadastrarBtn.TabIndex = 1;
            cadastrarBtn.Text = "Cadastrar usuario";
            cadastrarBtn.UseVisualStyleBackColor = true;
            cadastrarBtn.Click += cadastrarBtn_Click;
            // 
            // Exibicao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cadastrarBtn);
            Controls.Add(dataGridView1);
            Name = "Exibicao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exibicao";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn situacao;
        private Button cadastrarBtn;
    }
}