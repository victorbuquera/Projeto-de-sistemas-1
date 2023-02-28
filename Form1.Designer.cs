namespace Cadastro_projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cadastrarBtn = new Button();
            exibicaoBtn = new Button();
            SuspendLayout();
            // 
            // cadastrarBtn
            // 
            cadastrarBtn.Location = new Point(167, 190);
            cadastrarBtn.Name = "cadastrarBtn";
            cadastrarBtn.Size = new Size(194, 70);
            cadastrarBtn.TabIndex = 0;
            cadastrarBtn.Text = "Cadastrar usuario";
            cadastrarBtn.UseVisualStyleBackColor = true;
            cadastrarBtn.Click += cadastrarBtn_Click;
            // 
            // exibicaoBtn
            // 
            exibicaoBtn.Location = new Point(440, 190);
            exibicaoBtn.Name = "exibicaoBtn";
            exibicaoBtn.Size = new Size(194, 70);
            exibicaoBtn.TabIndex = 0;
            exibicaoBtn.Text = "Visualizar cadastros";
            exibicaoBtn.UseVisualStyleBackColor = true;
            exibicaoBtn.Click += cadastroBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exibicaoBtn);
            Controls.Add(cadastrarBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button cadastrarBtn;
        private Button exibicaoBtn;
    }
}