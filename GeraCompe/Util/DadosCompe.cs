using GeraCompe.Framework;
using GeraCompe.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraCompe.NovaPasta
{
    internal class DadosCompe
    {
        public List<Titulos> buscaTitulos(int empresa, int unidade, int quantidadeDeTitulos)
        {
            //String dataBase = "oracle";

            List<String> parametrosBD = new List<string>();
            DbParametros db = new DbParametros();
            parametrosBD = db.buscaParametrosConexaoOracle();

            List<String> login = new List<string>();
            UserBancoDeDados user = new UserBancoDeDados();
            login = user.getLoginBd();

            String dataBase = parametrosBD[0];
            String host = parametrosBD[1];
            String port = parametrosBD[2];
            String serverName = parametrosBD[3];
            String credimasterOwner = parametrosBD[4];            
            String userId = login[0];
            String password = login[1];


            List <Titulos> titulos = new List<Titulos>();

            var query = "SELECT LPAD(titu.cd_cli, 8, 0) as cd_cli, " +
                        "       ltrim(rtrim(replace(to_char(sum(titu.vr_tit + coalesce(tiab.vr_prm,0) + coalesce(tiab.vr_mlt,0)), '00000000.00'), '.', ''))) as vr_tit," +
                        "       LPAD(titu.ds_snu, 12, 0) as ds_snu " +
                        "  from " + credimasterOwner + ".t402tiab tiab " +
                        " inner join " + credimasterOwner + ".t402titu titu " +
                        "    on titu.nr_nos_nr = tiab.nr_nos_nr " +
                        " where tiab.dt_inc > '01-jan-2000' " +
                        "   and tiab.sg_mod in ('CBSJ', 'COBGGAR', 'CBSF')" +
                        "   and titu.ds_snu is not null " +
                        "   and titu.id_sit_lqd = 'PA' " +
                        "   and tiab.cd_emp = " + empresa +
                        "   and tiab.cd_und = " + unidade +
                        "   and rownum < " + quantidadeDeTitulos +
                        " group by titu.cd_cli, titu.vr_tit, titu.ds_snu, tiab.dt_ven  " +
                        " order by tiab.dt_ven asc ";                         

            if(dataBase.ToLower() == "oracle")
            {
                ConexaoBD conBD = new ConexaoBD();
                String oradb = conBD.conecta(dataBase, host, port, serverName, userId, password);

                OracleConnection conn = new OracleConnection(oradb);
                OracleCommand cmd = new OracleCommand(query.ToString(), conn);
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                }
                catch (OracleException e)
                {
                    System.Windows.Forms.MessageBox.Show("Impossível conectar ao Banco: " + e);
                }
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Titulos titulo = new Titulos();
                        titulo.codigoCliente = dr.GetString(0);
                        titulo.valorPago = dr.GetString(1);
                        titulo.seuNumero = dr.GetString(2);
                        titulos.Add(titulo);
                        titulo = null;
                    }
                }
                catch (OracleException e)
                {
                    System.Windows.Forms.MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
                }
                conn.Close();
            }            
            return titulos;
        } 

        public void GeraArquivoCompe(List<Titulos> titulos, DateTime dataArquivo, DateTime dataLiquidacao, String diretorio)
        {
            String dataArquivoFormatada = DateTime.Parse(dataArquivo.ToString()).ToString("yyyyMMdd");
            String dataLiquidacaoFromatada = DateTime.Parse(dataLiquidacao.ToString()).ToString("yyMMdd");
            String bancoEmissor = "630";
            String ispbRecebedora = "00416968";            
            int linha = 2;
            String header = "00000000000000000000000000000000000000000000000COB615000001100003" + dataArquivoFormatada.ToString() + "                 011CIPOF                                 58497702           0000000001";            
            String trailer = "99999999999999999999999999999999999999999999999COB615000001100003" + dataArquivoFormatada.ToString() + "00000000430226987011CIPOF                                 58497702           00000";
            String fechamentoArquivo = "      9999999999999999999999999  00000000000479533999       000005999920210909      0000001MG         0         0                  004169685849770204000000";
            String espaco2 = "918738"; //fixo
            String espaco3 = "1"; //fixo
            String espaco4 = "0001400183"; //fixo
            String espaco5 = "      "; //fixo 5 espaços em branco
            String espaco6 = "0001000005900120"; //fixo
            String espaco7 = "009234";
            String espaco8 = "00000010000005923";
            String espaco9 = "                  "; // fixo 18 espaços em branco
            String espaco10 = "5849770204000000"; //fixo

            if (diretorio.Substring(diretorio.Length - 2, 2) != "\\\\")
            {
                diretorio = diretorio + "\\";
            }           

            String nomeDoArquivo = "CB5" + bancoEmissor + "0" + dataArquivoFormatada + "_2.RET" ;

            using (StreamWriter sw = File.CreateText(diretorio + nomeDoArquivo))
            {
                sw.WriteLine(header);
                for (int i = 0; i< titulos.Count; i++)
                {
                    sw.WriteLine(bancoEmissor + espaco2 + titulos[i].valorPago.ToString() + espaco3 + titulos[i].seuNumero.ToString() + 
                        titulos[i].codigoCliente.ToString() + espaco4 + espaco5 + espaco6 + dataLiquidacaoFromatada + espaco7 + "00" + 
                        titulos[i].valorPago.ToString() + espaco8 + espaco9 + ispbRecebedora + espaco10 + linha.ToString().PadLeft(5,'0'));
                    linha++;                    
                }
                sw.WriteLine(fechamentoArquivo + linha.ToString().PadLeft(5,'0'));
                linha++;
                sw.WriteLine(trailer + linha.ToString().PadLeft(5,'0'));
                sw.WriteLine("\u001a");
                System.Windows.Forms.MessageBox.Show("Terminou!");
            }

            String path2 = @"C:\TotalBanco\Crediblaster\GeraCompe\GeraCompe.ini";
            using (StreamWriter sw = File.CreateText(path2))
            {
                sw.WriteLine("DATA_LIQUIDACAO=" + DateTime.Parse(dataLiquidacao.ToString()).ToString("dd/MM/yyyy"));
                sw.WriteLine("DATA_ARQUIVO=" + DateTime.Parse(dataArquivo.ToString()).ToString("dd/MM/yyyy"));
                sw.WriteLine("EMPRESA=" + 36);
                sw.WriteLine("UNIDADE=" + 36);
                sw.WriteLine("QUANTIDADE_TITULOS=" + 15);
                sw.WriteLine("DIRETORIO_DESTINO=" + diretorio);              
            }
        }
    }
}
