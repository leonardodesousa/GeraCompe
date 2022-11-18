namespace GeraCompe
{
    partial class FormAlterarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarLogin));
            this.txtBoxNovoUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxNovaSenha = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNovoUsuario
            // 
            this.txtBoxNovoUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxNovoUsuario.Location = new System.Drawing.Point(280, 126);
            this.txtBoxNovoUsuario.MaxLength = 25;
            this.txtBoxNovoUsuario.Name = "txtBoxNovoUsuario";
            this.txtBoxNovoUsuario.Size = new System.Drawing.Size(242, 27);
            this.txtBoxNovoUsuario.TabIndex = 0;
            this.txtBoxNovoUsuario.TextChanged += new System.EventHandler(this.txtBoxNovoUsuario_TextChanged);
            // 
            // txtBoxNovaSenha
            // 
            this.txtBoxNovaSenha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxNovaSenha.Location = new System.Drawing.Point(280, 208);
            this.txtBoxNovaSenha.MaxLength = 25;
            this.txtBoxNovaSenha.Name = "txtBoxNovaSenha";
            this.txtBoxNovaSenha.PasswordChar = '*';
            this.txtBoxNovaSenha.Size = new System.Drawing.Size(242, 27);
            this.txtBoxNovaSenha.TabIndex = 1;
            this.txtBoxNovaSenha.TextChanged += new System.EventHandler(this.txtBoxNovaSenha_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(579, 295);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 47);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(165, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Novo Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(165, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nova Senha";
            // 
            // FormAlterarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtBoxNovaSenha);
            this.Controls.Add(this.txtBoxNovoUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlterarLogin";
            this.Text = "Alterar Senha login BD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxNovoUsuario;
        private TextBox txtBoxNovaSenha;
        private Button btnSalvar;
        private Label label1;
        private Label label2;
    }
}