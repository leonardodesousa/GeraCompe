using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraCompe.Util
{
    internal class LeitorArquivoParametros
    {
        public List<String> BuscaParametros()
        {
            List<String> ListaParametros = new List<string>();
            String dataLiquidacao;
            String dataArquivo;
            String empresa;
            String unidade;
            String quantidadeTitulos;
            String diretorioDestino;


            String path = @"C:\TotalBanco\Crediblaster\GeraCompe\GeraCompe.ini";
            //StreamWriter sw = new StreamWriter(path);            
            if (File.Exists(path))
            {
                //using (StreamReader file = new StreamReader(path, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage)))
                using (StreamReader file = new StreamReader(path))
                {
                    // implementar aqui método de busca dos parametros
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        if (ln.Length > 15 && ln.Substring(0, 15) == "DATA_LIQUIDACAO")
                        {
                            //System.Windows.Forms.MessageBox.Show("NUMERO_ARQUIVO recebe " + ln.Substring(14, ln.Length - 14) +"espaço");
                            dataLiquidacao = ln.Substring(15, ln.Length - 15);
                            ListaParametros.Add(dataLiquidacao.Trim());
                        }
                        if (ln.Length > 12 && ln.Substring(0, 12) == "DATA_ARQUIVO")
                        {
                            dataArquivo = ln.Substring(12, ln.Length - 12);
                            ListaParametros.Add(dataArquivo);
                        }
                        if (ln.Length > 7 && ln.Substring(0, 7) == "EMPRESA")
                        {
                            empresa = ln.Substring(7, ln.Length - 7);
                            ListaParametros.Add(empresa);
                        }
                        if (ln.Length > 7 && ln.Substring(0, 7) == "UNIDADE")
                        {
                            unidade = ln.Substring(7, ln.Length - 7);
                            ListaParametros.Add(unidade);
                        }
                        //System.Windows.Forms.MessageBox.Show("LINHAS_POR_ARQUIVO recebe " + ln/*.Substring(15, ln.Length - 15)*/);
                        if (ln.Length > 17 && ln.Substring(0, 18) == "QUANTIDADE_TITULOS")
                        {
                            quantidadeTitulos = ln.Substring(18, ln.Length - 18);
                            ListaParametros.Add(quantidadeTitulos);
                        }
                        if (ln.Length > 16 && ln.Substring(0, 17) == "DIRETORIO_DESTINO")
                        {
                            diretorioDestino = ln.Substring(18, ln.Length - 18);
                            ListaParametros.Add(diretorioDestino);
                        }
                    }
                }
            }
            return ListaParametros;

        }


    }
}
