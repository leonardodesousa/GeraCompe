using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraCompe.Framework
{
    internal class ConexaoBD
    {
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
