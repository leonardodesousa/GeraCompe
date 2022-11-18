using GeraCompe.Model;
using GeraCompe.NovaPasta;
using GeraCompe.Util;

namespace GeraCompe
{
    public partial class GeraCompe : Form
    {
        public GeraCompe()
        {
            InitializeComponent();
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Gerador de Arquivo de Compensação - Letsbank (Versão {0})", version);

            LeitorArquivoParametros leitor = new LeitorArquivoParametros();
            List<String> lista = new List<string>();
            lista = leitor.BuscaParametros();

            mskTextBoxDataLiquidacao.Text = lista[0].ToString();
            mskTextBoxDataArquivo.Text = lista[1].ToString();
            mskTextBoxEmpresa.Text = lista[2].ToString();
            mskTextBoxUnidade.Text = lista[3].ToString();
            mskTextBoxQtdTitulos.Text = lista[4].ToString();
            textBoxDiretorio.Text = lista[5].ToString();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show(DateTime.Parse(mskTextBoxDtArq.Text).ToString("yyyyMMdd"));
            //DateTime.Parse(mskTextBoxDtArq.Text).ToString("yyyyMMdd");

            DadosCompe dadosCompe = new DadosCompe();
            List<Titulos> titulos = new List<Titulos>();
            //titulos = dadosCompe.buscaTitulos();
            
            titulos = dadosCompe.buscaTitulos(Int32.Parse(mskTextBoxEmpresa.Text.ToString()),
                Int32.Parse(mskTextBoxUnidade.Text.ToString()),
                Int32.Parse(mskTextBoxQtdTitulos.Text.ToString()));

            //System.Windows.Forms.MessageBox.Show("Estou mandando como Data Arquivo "+ mskTextBoxDataArquivo.Text.ToString());

            dadosCompe.GeraArquivoCompe(titulos, mskTextBoxDataArquivo.Text.ToString(),
                 mskTextBoxDataLiquidacao.Text.ToString(), textBoxDiretorio.Text.ToString());

            /*
            dadosCompe.GeraArquivoCompe(titulos, DateTime.Parse(mskTextBoxDataArquivo.Text),
                mskTextBoxDataLiquidacao.Text.ToString(), textBoxDiretorio.Text.ToString());
            */

            LeitorArquivoParametros leitor = new LeitorArquivoParametros();
            List<String> lista = new List<string>();
            lista = leitor.BuscaParametros();

            mskTextBoxDataLiquidacao.Text = lista[0].ToString();
            mskTextBoxDataArquivo.Text = lista[1].ToString();
            mskTextBoxEmpresa.Text = lista[2].ToString();
            mskTextBoxUnidade.Text = lista[3].ToString();
            mskTextBoxQtdTitulos.Text = lista[4].ToString();
            textBoxDiretorio.Text = lista[5].ToString();
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
    }
}