using GeraCompe.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace GeraCompe.Framework
{
    internal class ConexaoBD
    {
        public Boolean testaConexao()
        {
            List<string> parametrosBD = new List<string>();
            DbParametros db = new DbParametros();
            parametrosBD = db.buscaParametrosConexaoOracle();

            List<string> login = new List<string>();
            UserBancoDeDados user = new UserBancoDeDados();
            login = user.getLoginBd();

            string dataBase = parametrosBD[0];
            string host = parametrosBD[1];
            string port = parametrosBD[2];
            string serverName = parametrosBD[3];
            string credimasterOwner = parametrosBD[4];
            string userId = login[0];
            string password = login[1];

            var query = "Select 1 from dual";

            ConexaoBD conBD = new ConexaoBD();
            string oradb = conBD.conecta(dataBase, host, port, serverName, userId, password);

            OracleConnection conn = new OracleConnection(oradb);
            OracleCommand cmd = new OracleCommand(query.ToString(), conn);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();

            int variavel = 0;
            Boolean retorno = false;

            try
            {
                conn.Open();
            }
            catch (OracleException e)
            {
                MessageBox.Show("Impossível conectar ao Banco: " + e);
            }
            try
            {
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    variavel = dr.GetInt32(0);                    
                }
            }
            catch (OracleException e)
            {
                MessageBox.Show("Ocorreu um erro ao consultar o banco de dados: " + e);
            }
            conn.Close();

            if(variavel == 1)
            {
                retorno = true;
            } else
            {
                retorno = false;
            }
            return retorno;
        }

        public String conecta(String banco, String host, String port, String serverName, String userId,String password)
        {
            String conexao;
            StringBuilder sb = new StringBuilder();
            if (banco.ToLower() == "oracle")
            {
                /*
                sb.Append("Data Source=(DESCRIPTION=");
                sb.Append("(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=tfsoraatd.poa01.local)(PORT=1521)))");
                sb.Append("(CONNECT_DATA=(SID=atdindusval)));");
                sb.Append("User Id=leonardodesousa;Password=Leonardo#092022;");
                conexao = sb.ToString();
                */

                sb.Append("Data Source=(DESCRIPTION=");
                sb.Append("(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST="+ host +")(PORT="+ port + ")))");
                sb.Append("(CONNECT_DATA=(SID="+ serverName + ")));");
                sb.Append("User Id=" + userId + ";Password=" + password + ";");
                conexao = sb.ToString();
                return conexao;
            }
            else if (banco == "sqlserver")
            {
                conexao = "Data Source=DESKTOP-N20KA03\\SQL2017;Initial Catalog=crediBlaster;" +
                               "User ID=sa;Password=sa;Language=Portuguese";
                //SqlConnection conexao = new SqlConnection(conec);
                return conexao;
            }



            else
            {
                System.Windows.Forms.MessageBox.Show("Conexão não suportada!");
                conexao = "";
                return conexao;
            }
        }
    }
}
