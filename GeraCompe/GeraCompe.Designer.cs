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
            this.btnGerar = new System.Windows.Forms.Button();
            this.mskTextBoxQtdTitulos = new System.Windows.Forms.MaskedTextBox();
            this.labelQtdTitulos = new System.Windows.Forms.Label();
            this.mskTextBoxDataLiquidacao = new System.Windows.Forms.MaskedTextBox();
            this.labelDataLiquidacao = new System.Windows.Forms.Label();
            this.mskTextBoxDataArquivo = new System.Windows.Forms.MaskedTextBox();
            this.labelDataArquivo = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.mskTextBoxEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBoxUnidade = new System.Windows.Forms.MaskedTextBox();
            this.labelDirGeracaoArquivo = new System.Windows.Forms.Label();
            this.textBoxDiretorio = new System.Windows.Forms.TextBox();
            this.mskTextBoxDtArq = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(60, 424);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(112, 47);
            this.btnGerar.TabIndex = 10;
            this.btnGerar.Text = "Gerar Arquivo";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // mskTextBoxQtdTitulos
            // 
            this.mskTextBoxQtdTitulos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxQtdTitulos.Location = new System.Drawing.Point(309, 88);
            this.mskTextBoxQtdTitulos.Mask = "000000";
            this.mskTextBoxQtdTitulos.Name = "mskTextBoxQtdTitulos";
            this.mskTextBoxQtdTitulos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskTextBoxQtdTitulos.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxQtdTitulos.TabIndex = 1;
            this.mskTextBoxQtdTitulos.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxQtdTitulos_MaskInputRejected);
            // 
            // labelQtdTitulos
            // 
            this.labelQtdTitulos.AutoSize = true;
            this.labelQtdTitulos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQtdTitulos.Location = new System.Drawing.Point(60, 91);
            this.labelQtdTitulos.Name = "labelQtdTitulos";
            this.labelQtdTitulos.Size = new System.Drawing.Size(240, 20);
            this.labelQtdTitulos.TabIndex = 2;
            this.labelQtdTitulos.Text = "Quantidade de títulos a liquidar ->";
            // 
            // mskTextBoxDataLiquidacao
            // 
            this.mskTextBoxDataLiquidacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxDataLiquidacao.Location = new System.Drawing.Point(729, 129);
            this.mskTextBoxDataLiquidacao.Mask = "000000";
            this.mskTextBoxDataLiquidacao.Name = "mskTextBoxDataLiquidacao";
            this.mskTextBoxDataLiquidacao.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxDataLiquidacao.TabIndex = 4;
            this.mskTextBoxDataLiquidacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxDataLiquidacao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxDataLiquidacao_MaskInputRejected);
            // 
            // labelDataLiquidacao
            // 
            this.labelDataLiquidacao.AutoSize = true;
            this.labelDataLiquidacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataLiquidacao.Location = new System.Drawing.Point(483, 132);
            this.labelDataLiquidacao.Name = "labelDataLiquidacao";
            this.labelDataLiquidacao.Size = new System.Drawing.Size(230, 20);
            this.labelDataLiquidacao.TabIndex = 4;
            this.labelDataLiquidacao.Text = "Data da liquidação (aammdd) ->";
            // 
            // mskTextBoxDataArquivo
            // 
            this.mskTextBoxDataArquivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxDataArquivo.Location = new System.Drawing.Point(729, 88);
            this.mskTextBoxDataArquivo.Mask = "00000000";
            this.mskTextBoxDataArquivo.Name = "mskTextBoxDataArquivo";
            this.mskTextBoxDataArquivo.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxDataArquivo.TabIndex = 2;
            this.mskTextBoxDataArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxDataArquivo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxDataArquivo_MaskInputRejected);
            // 
            // labelDataArquivo
            // 
            this.labelDataArquivo.AutoSize = true;
            this.labelDataArquivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataArquivo.Location = new System.Drawing.Point(483, 91);
            this.labelDataArquivo.Name = "labelDataArquivo";
            this.labelDataArquivo.Size = new System.Drawing.Size(227, 20);
            this.labelDataArquivo.TabIndex = 6;
            this.labelDataArquivo.Text = "Data do arquivo (aaaammdd) ->";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmpresa.Location = new System.Drawing.Point(214, 136);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(86, 20);
            this.labelEmpresa.TabIndex = 7;
            this.labelEmpresa.Text = "Empresa ->";
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnidade.Location = new System.Drawing.Point(215, 179);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(85, 20);
            this.labelUnidade.TabIndex = 8;
            this.labelUnidade.Text = "Unidade ->";
            // 
            // mskTextBoxEmpresa
            // 
            this.mskTextBoxEmpresa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxEmpresa.Location = new System.Drawing.Point(309, 129);
            this.mskTextBoxEmpresa.Mask = "00";
            this.mskTextBoxEmpresa.Name = "mskTextBoxEmpresa";
            this.mskTextBoxEmpresa.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxEmpresa.TabIndex = 3;
            this.mskTextBoxEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxEmpresa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxEmpresa_MaskInputRejected);
            // 
            // mskTextBoxUnidade
            // 
            this.mskTextBoxUnidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxUnidade.Location = new System.Drawing.Point(309, 172);
            this.mskTextBoxUnidade.Mask = "00";
            this.mskTextBoxUnidade.Name = "mskTextBoxUnidade";
            this.mskTextBoxUnidade.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxUnidade.TabIndex = 5;
            this.mskTextBoxUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxUnidade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxUnidade_MaskInputRejected);
            // 
            // labelDirGeracaoArquivo
            // 
            this.labelDirGeracaoArquivo.AutoSize = true;
            this.labelDirGeracaoArquivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDirGeracaoArquivo.Location = new System.Drawing.Point(56, 248);
            this.labelDirGeracaoArquivo.Name = "labelDirGeracaoArquivo";
            this.labelDirGeracaoArquivo.Size = new System.Drawing.Size(244, 20);
            this.labelDirGeracaoArquivo.TabIndex = 11;
            this.labelDirGeracaoArquivo.Text = "Diretório de geração do arquivo ->";
            // 
            // textBoxDiretorio
            // 
            this.textBoxDiretorio.Location = new System.Drawing.Point(309, 245);
            this.textBoxDiretorio.Name = "textBoxDiretorio";
            this.textBoxDiretorio.Size = new System.Drawing.Size(520, 23);
            this.textBoxDiretorio.TabIndex = 12;
            this.textBoxDiretorio.TextChanged += new System.EventHandler(this.textBoxDiretorio_TextChanged);
            // 
            // mskTextBoxDtArq
            // 
            this.mskTextBoxDtArq.Location = new System.Drawing.Point(877, 88);
            this.mskTextBoxDtArq.Mask = "00/00/0000";
            this.mskTextBoxDtArq.Name = "mskTextBoxDtArq";
            this.mskTextBoxDtArq.Size = new System.Drawing.Size(100, 23);
            this.mskTextBoxDtArq.TabIndex = 13;
            this.mskTextBoxDtArq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxDtArq.ValidatingType = typeof(System.DateTime);
            // 
            // GeraCompe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 572);
            this.Controls.Add(this.mskTextBoxDtArq);
            this.Controls.Add(this.textBoxDiretorio);
            this.Controls.Add(this.labelDirGeracaoArquivo);
            this.Controls.Add(this.mskTextBoxUnidade);
            this.Controls.Add(this.mskTextBoxEmpresa);
            this.Controls.Add(this.labelUnidade);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.labelDataArquivo);
            this.Controls.Add(this.mskTextBoxDataArquivo);
            this.Controls.Add(this.labelDataLiquidacao);
            this.Controls.Add(this.mskTextBoxDataLiquidacao);
            this.Controls.Add(this.labelQtdTitulos);
            this.Controls.Add(this.mskTextBoxQtdTitulos);
            this.Controls.Add(this.btnGerar);
            this.Name = "GeraCompe";
            this.Text = "Tela Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGerar;
        private MaskedTextBox mskTextBoxQtdTitulos;
        private Label labelQtdTitulos;
        private MaskedTextBox mskTextBoxDataLiquidacao;
        private Label labelDataLiquidacao;
        private MaskedTextBox mskTextBoxDataArquivo;
        private Label labelDataArquivo;
        private Label labelEmpresa;
        private Label labelUnidade;
        private MaskedTextBox mskTextBoxEmpresa;
        private MaskedTextBox mskTextBoxUnidade;
        private Label labelDirGeracaoArquivo;
        private TextBox textBoxDiretorio;
        private MaskedTextBox mskTextBoxDtArq;
    }
}