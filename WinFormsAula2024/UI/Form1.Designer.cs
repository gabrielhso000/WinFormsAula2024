namespace WinFormsAula2024
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
            label1 = new Label();
            lstNomes = new ListBox();
            txtNome = new TextBox();
            btnAdd = new Button();
            btnSair = new Button();
            btnExcluirNome = new Button();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomRight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nomes";
            // 
            // lstNomes
            // 
            lstNomes.FormattingEnabled = true;
            lstNomes.ItemHeight = 15;
            lstNomes.Location = new Point(12, 27);
            lstNomes.Name = "lstNomes";
            lstNomes.Size = new Size(120, 94);
            lstNomes.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 26);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(102, 23);
            txtNome.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(140, 114);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(191, 139);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(52, 24);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnExcluirNome
            // 
            btnExcluirNome.Location = new Point(13, 127);
            btnExcluirNome.Name = "btnExcluirNome";
            btnExcluirNome.Size = new Size(117, 23);
            btnExcluirNome.TabIndex = 5;
            btnExcluirNome.Text = "Excluir Nome";
            btnExcluirNome.UseVisualStyleBackColor = true;
            btnExcluirNome.Click += btnExcluirNome_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(139, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(101, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(138, 85);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(102, 23);
            txtTelefone.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 175);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(btnExcluirNome);
            Controls.Add(btnSair);
            Controls.Add(btnAdd);
            Controls.Add(txtNome);
            Controls.Add(lstNomes);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Nomes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNomes;
        private TextBox txtNome;
        private Button btnAdd;
        private Button btnSair;
        private Button btnExcluirNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
    }
}
