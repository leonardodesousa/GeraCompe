using GeraCompe.Framework;
using GeraCompe.Model;
using GeraCompe.Util;
using System.ComponentModel;
using System.Windows.Forms;

namespace GeraCompe
{
    public partial class GeraCompe : Form
    {
        public GeraCompe()
        {
            InitializeComponent();
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Gerador de Arquivo de Compensação (Versão {0})", version);

            UserBancoDeDados user = new UserBancoDeDados();
            List<String> login = new List<String>();
            login = user.getLoginBd();

            textBoxLoginBd.Text = login[0];
            textBoxSenhaBd.Text = login[1];

            LeitorArquivoParametros leitor = new LeitorArquivoParametros();
            List<String> lista = new List<string>();
            lista = leitor.BuscaParametros();
                        
            mskTextBoxDtLiq.Text = lista[0];            
            mskTextBoxDtArq.Text = lista[1];
            mskTextBoxEmpresa.Text = lista[2].ToString();
            mskTextBoxUnidade.Text = lista[3].ToString();
            mskTextBoxQtdTitulos.Text = lista[4].ToString().PadLeft(7,'0');
            textBoxDiretorio.Text = lista[5].ToString();
            textBoxModalidade.Text = lista[6].ToString();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            DbParametros db = new DbParametros();
            List<String> dbParametros = new List<string>();
            dbParametros = db.buscaParametrosConexaoOracle();

            DadosCompe dadosCompe = new DadosCompe();
            List<Titulos> titulos = new List<Titulos>();        
            
            titulos = dadosCompe.buscaTitulos(Int32.Parse(mskTextBoxEmpresa.Text.ToString()),
                Int32.Parse(mskTextBoxUnidade.Text.ToString()),
                Int32.Parse(mskTextBoxQtdTitulos.Text.ToString()),
                textBoxModalidade.Text.ToString().Trim().ToUpper());
            
            dadosCompe.GeraArquivoCompe(titulos, DateTime.Parse(mskTextBoxDtArq.Text),
                DateTime.Parse(mskTextBoxDtLiq.Text), textBoxDiretorio.Text.ToString(),
                 textBoxModalidade.Text.ToString().Trim());
            
            LeitorArquivoParametros leitor = new LeitorArquivoParametros();
            List<String> lista = new List<string>();
            lista = leitor.BuscaParametros();

            mskTextBoxDtLiq.Text = lista[0];
            mskTextBoxDtArq.Text = lista[1];                        
            mskTextBoxEmpresa.Text = lista[2].ToString();
            mskTextBoxUnidade.Text = lista[3].ToString();
            mskTextBoxQtdTitulos.Text = lista[4].ToString().PadLeft(7, '0');
            textBoxDiretorio.Text = lista[5].ToString();
            textBoxModalidade.Text = lista[6].ToString().ToUpper();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTextBoxQtdTitulos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTextBoxDataArquivo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTextBoxEmpresa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTextBoxDataLiquidacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTextBoxUnidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxDiretorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLoginBd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenhaBd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtaulizarSenha_Click(object sender, EventArgs e)
        {
            FormAlterarLogin formAlterarLogin = new FormAlterarLogin();
            formAlterarLogin.Show();
        }

        private void mskTextBoxDtArq_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GeraCompe_Load(object sender, EventArgs e)
        {

        }

        private void textBoxModalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModalidade_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProviderApp = new ErrorProvider();
            if (string.IsNullOrWhiteSpace(textBoxModalidade.Text))
            {                
                e.Cancel = true;
                textBoxModalidade.Focus();
                errorProviderApp.SetError(textBoxModalidade, "Campo modalidade percisa ser preenchido!");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(textBoxModalidade, "");
            }
        }
    }
}