namespace GeraCompe
{
    partial class GeraCompe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeraCompe));
            this.btnGerar = new System.Windows.Forms.Button();
            this.mskTextBoxQtdTitulos = new System.Windows.Forms.MaskedTextBox();
            this.labelQtdTitulos = new System.Windows.Forms.Label();
            this.labelDataLiquidacao = new System.Windows.Forms.Label();
            this.labelDataArquivo = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.mskTextBoxEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBoxUnidade = new System.Windows.Forms.MaskedTextBox();
            this.labelDirGeracaoArquivo = new System.Windows.Forms.Label();
            this.textBoxDiretorio = new System.Windows.Forms.TextBox();
            this.mskTextBoxDtArq = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBoxDtLiq = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModalidade = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLoginBd = new System.Windows.Forms.TextBox();
            this.labelSenhaBd = new System.Windows.Forms.Label();
            this.textBoxSenhaBd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAtaulizarSenha = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(76, 549);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(112, 47);
            this.btnGerar.TabIndex = 20;
            this.btnGerar.Text = "Gerar Arquivo";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // mskTextBoxQtdTitulos
            // 
            this.mskTextBoxQtdTitulos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxQtdTitulos.Location = new System.Drawing.Point(281, 44);
            this.mskTextBoxQtdTitulos.Mask = "000000";
            this.mskTextBoxQtdTitulos.Name = "mskTextBoxQtdTitulos";
            this.mskTextBoxQtdTitulos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxQtdTitulos.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxQtdTitulos.TabIndex = 6;
            this.mskTextBoxQtdTitulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxQtdTitulos.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxQtdTitulos_MaskInputRejected);
            // 
            // labelQtdTitulos
            // 
            this.labelQtdTitulos.AutoSize = true;
            this.labelQtdTitulos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQtdTitulos.Location = new System.Drawing.Point(32, 47);
            this.labelQtdTitulos.Name = "labelQtdTitulos";
            this.labelQtdTitulos.Size = new System.Drawing.Size(240, 20);
            this.labelQtdTitulos.TabIndex = 2;
            this.labelQtdTitulos.Text = "Quantidade de títulos a liquidar ->";
            // 
            // labelDataLiquidacao
            // 
            this.labelDataLiquidacao.AutoSize = true;
            this.labelDataLiquidacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataLiquidacao.Location = new System.Drawing.Point(455, 88);
            this.labelDataLiquidacao.Name = "labelDataLiquidacao";
            this.labelDataLiquidacao.Size = new System.Drawing.Size(258, 20);
            this.labelDataLiquidacao.TabIndex = 4;
            this.labelDataLiquidacao.Text = "Data da liquidação (dd/mm/aaaa) ->";
            // 
            // labelDataArquivo
            // 
            this.labelDataArquivo.AutoSize = true;
            this.labelDataArquivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataArquivo.Location = new System.Drawing.Point(474, 47);
            this.labelDataArquivo.Name = "labelDataArquivo";
            this.labelDataArquivo.Size = new System.Drawing.Size(239, 20);
            this.labelDataArquivo.TabIndex = 6;
            this.labelDataArquivo.Text = "Data do arquivo (dd/mm/aaaa) ->";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmpresa.Location = new System.Drawing.Point(186, 92);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(86, 20);
            this.labelEmpresa.TabIndex = 7;
            this.labelEmpresa.Text = "Empresa ->";
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnidade.Location = new System.Drawing.Point(187, 135);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(85, 20);
            this.labelUnidade.TabIndex = 8;
            this.labelUnidade.Text = "Unidade ->";
            // 
            // mskTextBoxEmpresa
            // 
            this.mskTextBoxEmpresa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxEmpresa.Location = new System.Drawing.Point(281, 85);
            this.mskTextBoxEmpresa.Mask = "00";
            this.mskTextBoxEmpresa.Name = "mskTextBoxEmpresa";
            this.mskTextBoxEmpresa.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxEmpresa.TabIndex = 8;
            this.mskTextBoxEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxEmpresa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxEmpresa_MaskInputRejected);
            // 
            // mskTextBoxUnidade
            // 
            this.mskTextBoxUnidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxUnidade.Location = new System.Drawing.Point(281, 128);
            this.mskTextBoxUnidade.Mask = "00";
            this.mskTextBoxUnidade.Name = "mskTextBoxUnidade";
            this.mskTextBoxUnidade.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxUnidade.TabIndex = 10;
            this.mskTextBoxUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxUnidade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxUnidade_MaskInputRejected);
            // 
            // labelDirGeracaoArquivo
            // 
            this.labelDirGeracaoArquivo.AutoSize = true;
            this.labelDirGeracaoArquivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDirGeracaoArquivo.Location = new System.Drawing.Point(28, 204);
            this.labelDirGeracaoArquivo.Name = "labelDirGeracaoArquivo";
            this.labelDirGeracaoArquivo.Size = new System.Drawing.Size(244, 20);
            this.labelDirGeracaoArquivo.TabIndex = 11;
            this.labelDirGeracaoArquivo.Text = "Diretório de geração do arquivo ->";
            // 
            // textBoxDiretorio
            // 
            this.textBoxDiretorio.Location = new System.Drawing.Point(281, 201);
            this.textBoxDiretorio.Name = "textBoxDiretorio";
            this.textBoxDiretorio.Size = new System.Drawing.Size(538, 23);
            this.textBoxDiretorio.TabIndex = 12;
            this.textBoxDiretorio.TextChanged += new System.EventHandler(this.textBoxDiretorio_TextChanged);
            // 
            // mskTextBoxDtArq
            // 
            this.mskTextBoxDtArq.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxDtArq.Location = new System.Drawing.Point(719, 40);
            this.mskTextBoxDtArq.Mask = "00/00/0000";
            this.mskTextBoxDtArq.Name = "mskTextBoxDtArq";
            this.mskTextBoxDtArq.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxDtArq.TabIndex = 7;
            this.mskTextBoxDtArq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxDtArq.ValidatingType = typeof(System.DateTime);
            this.mskTextBoxDtArq.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxDtArq_MaskInputRejected);
            // 
            // mskTextBoxDtLiq
            // 
            this.mskTextBoxDtLiq.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxDtLiq.Location = new System.Drawing.Point(719, 81);
            this.mskTextBoxDtLiq.Mask = "00/00/0000";
            this.mskTextBoxDtLiq.Name = "mskTextBoxDtLiq";
            this.mskTextBoxDtLiq.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxDtLiq.TabIndex = 9;
            this.mskTextBoxDtLiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxDtLiq.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxModalidade);
            this.groupBox1.Controls.Add(this.mskTextBoxDtLiq);
            this.groupBox1.Controls.Add(this.mskTextBoxDtArq);
            this.groupBox1.Controls.Add(this.textBoxDiretorio);
            this.groupBox1.Controls.Add(this.labelDirGeracaoArquivo);
            this.groupBox1.Controls.Add(this.mskTextBoxUnidade);
            this.groupBox1.Controls.Add(this.mskTextBoxEmpresa);
            this.groupBox1.Controls.Add(this.labelUnidade);
            this.groupBox1.Controls.Add(this.labelEmpresa);
            this.groupBox1.Controls.Add(this.labelDataArquivo);
            this.groupBox1.Controls.Add(this.labelDataLiquidacao);
            this.groupBox1.Controls.Add(this.labelQtdTitulos);
            this.groupBox1.Controls.Add(this.mskTextBoxQtdTitulos);
            this.groupBox1.Location = new System.Drawing.Point(44, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 273);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da geração do Arquivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(603, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Modalidade ->";
            // 
            // textBoxModalidade
            // 
            this.textBoxModalidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxModalidade.Location = new System.Drawing.Point(719, 132);
            this.textBoxModalidade.MaxLength = 8;
            this.textBoxModalidade.Name = "textBoxModalidade";
            this.textBoxModalidade.Size = new System.Drawing.Size(100, 27);
            this.textBoxModalidade.TabIndex = 11;
            this.textBoxModalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxModalidade.TextChanged += new System.EventHandler(this.textBoxModalidade_TextChanged);
            this.textBoxModalidade.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxModalidade_Validating);
            this.textBoxModalidade.Validated += new System.EventHandler(this.btnGerar_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(206, 37);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(66, 20);
            this.labelLogin.TabIndex = 13;
            this.labelLogin.Text = "Login ->";
            // 
            // textBoxLoginBd
            // 
            this.textBoxLoginBd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLoginBd.Location = new System.Drawing.Point(278, 30);
            this.textBoxLoginBd.MaxLength = 25;
            this.textBoxLoginBd.Name = "textBoxLoginBd";
            this.textBoxLoginBd.ReadOnly = true;
            this.textBoxLoginBd.Size = new System.Drawing.Size(201, 27);
            this.textBoxLoginBd.TabIndex = 2;
            this.textBoxLoginBd.TextChanged += new System.EventHandler(this.textBoxLoginBd_TextChanged);
            // 
            // labelSenhaBd
            // 
            this.labelSenhaBd.AutoSize = true;
            this.labelSenhaBd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSenhaBd.Location = new System.Drawing.Point(203, 93);
            this.labelSenhaBd.Name = "labelSenhaBd";
            this.labelSenhaBd.Size = new System.Drawing.Size(69, 20);
            this.labelSenhaBd.TabIndex = 15;
            this.labelSenhaBd.Text = "Senha ->";
            // 
            // textBoxSenhaBd
            // 
            this.textBoxSenhaBd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSenhaBd.Location = new System.Drawing.Point(278, 90);
            this.textBoxSenhaBd.MaxLength = 25;
            this.textBoxSenhaBd.Name = "textBoxSenhaBd";
            this.textBoxSenhaBd.PasswordChar = '*';
            this.textBoxSenhaBd.ReadOnly = true;
            this.textBoxSenhaBd.Size = new System.Drawing.Size(201, 27);
            this.textBoxSenhaBd.TabIndex = 3;
            this.textBoxSenhaBd.TextChanged += new System.EventHandler(this.textBoxSenhaBd_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAtaulizarSenha);
            this.groupBox2.Controls.Add(this.textBoxSenhaBd);
            this.groupBox2.Controls.Add(this.labelSenhaBd);
            this.groupBox2.Controls.Add(this.textBoxLoginBd);
            this.groupBox2.Controls.Add(this.labelLogin);
            this.groupBox2.Location = new System.Drawing.Point(44, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Banco de dados";
            // 
            // btnAtaulizarSenha
            // 
            this.btnAtaulizarSenha.Location = new System.Drawing.Point(719, 79);
            this.btnAtaulizarSenha.Name = "btnAtaulizarSenha";
            this.btnAtaulizarSenha.Size = new System.Drawing.Size(83, 38);
            this.btnAtaulizarSenha.TabIndex = 4;
            this.btnAtaulizarSenha.Text = "Atualizar Senha";
            this.btnAtaulizarSenha.UseVisualStyleBackColor = true;
            this.btnAtaulizarSenha.Click += new System.EventHandler(this.btnAtaulizarSenha_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // GeraCompe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerar);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeraCompe";
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.GeraCompe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGerar;
        private MaskedTextBox mskTextBoxQtdTitulos;
        private Label labelQtdTitulos;
        private Label labelDataLiquidacao;
        private Label labelDataArquivo;
        private Label labelEmpresa;
        private Label labelUnidade;
        private MaskedTextBox mskTextBoxEmpresa;
        private MaskedTextBox mskTextBoxUnidade;
        private Label labelDirGeracaoArquivo;
        private TextBox textBoxDiretorio;
        private MaskedTextBox mskTextBoxDtArq;
        private MaskedTextBox mskTextBoxDtLiq;
        private GroupBox groupBox1;
        private Label labelLogin;
        private TextBox textBoxLoginBd;
        private Label labelSenhaBd;
        private TextBox textBoxSenhaBd;
        private GroupBox groupBox2;
        private Button btnAtaulizarSenha;
        private Label label1;
        private TextBox textBoxModalidade;
        private ErrorProvider errorProvider;
        private ErrorProvider errorProvider2;
    }
}