using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraCompe.Framework
{
    internal class DbParametros
    {

        public Boolean dbParametrosChecker()
        {
            Boolean retorno = false;
            List<String> ListaParametros = new List<string>();
            String host;
            String port;
            String serverName;
            String credimasterOwner;
            String banco;


            String path = @"C:\TotalBanco\Crediblaster\GeraCompe\dbparametros.ini";

            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    String ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        if (ln.Length > 4 && ln.Substring(0, 4).ToUpper() == "DBMS")
                        {
                            banco = ln.Substring(5, ln.Length - 5);
                            ListaParametros.Add(banco.Trim());                            
                        }
                        if (ln.Length > 4 && ln.Substring(0, 4).ToUpper() == "HOST")
                        {
                            host = ln.Substring(5, ln.Length - 5);
                            ListaParametros.Add(host.Trim());                            
                        }
                        if (ln.Length > 4 && ln.Substring(0, 4).ToUpper() == "PORT")
                        {
                            port = ln.Substring(5, ln.Length - 5);
                            ListaParametros.Add(port.Trim());                            
                        }
                        if (ln.Length > 10 && ln.Substring(0, 10).ToUpper() == "SERVERNAME")
                        {
                            serverName = ln.Substring(11, ln.Length - 11);
                            ListaParametros.Add(serverName.Trim());                            
                        }
                        if (ln.Length > 17 && ln.Substring(0, 17).ToUpper() == "CREDIMASTER_OWNER")
                        {
                            credimasterOwner = ln.Substring(18, ln.Length - 18);
                            ListaParametros.Add(credimasterOwner.Trim());

                        }
                    }
                }

            }

            if (ListaParametros.Count < 5)
            {                
                DialogResult dialogResult = MessageBox.Show("Faltam dados no arquivo dbParametros.ini. \n" +
                    "Este arquivo é composto pelas seguintes sessões:\n \n" +
                    "HOST \n" +
                    "PORT \n" +
                    "ServerName \n" +
                    "CREDIMASTER_OWNER", "Erro ao buscar parâmetros de conexão!", MessageBoxButtons.OK);
                retorno = false;
            } else
            {
                retorno = true;
            }

            return retorno;

        }

        public List<String> buscaParametrosConexaoOracle()
        {
            List<String> ListaParametros = new List<string>();
            String host;
            String port;
            String serverName;
            String credimasterOwner;
            String banco;


            String path = @"C:\TotalBanco\Crediblaster\GeraCompe\dbparametros.ini";

            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    String ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        if (ln.Length > 4 && ln.Substring(0, 4).ToUpper() == "DBMS")
                        {
                            banco = ln.Substring(5, ln.Length - 5);
                            ListaParametros.Add(banco.Trim());
                            //System.Windows.Forms.MessageBox.Show("Banco recebe " + banco);
                        }
                        if (ln.Length > 4 && ln.Substring(0, 4).ToUpper() == "HOST")
                        {                            
                            host = ln.Substring(5, ln.Length - 5);
                            ListaParametros.Add(host.Trim());
                            //System.Windows.Forms.MessageBox.Show("HOST recebe " + host);
                        }
                        if (ln.Length > 4 && ln.Substring(0, 4).ToUpper() == "PORT")
                        {                            
                            port = ln.Substring(5, ln.Length - 5);
                            ListaParametros.Add(port.Trim());
                            //System.Windows.Forms.MessageBox.Show("port recebe " + port);
                        }
                        if (ln.Length > 10 && ln.Substring(0, 10).ToUpper() == "SERVERNAME")
                        {                            
                            serverName = ln.Substring(11, ln.Length - 11);
                            ListaParametros.Add(serverName.Trim());
                            //System.Windows.Forms.MessageBox.Show("serverName recebe " + serverName);
                        }
                        if (ln.Length > 17 && ln.Substring(0, 17).ToUpper() == "CREDIMASTER_OWNER")
                        {                            
                            credimasterOwner = ln.Substring(18, ln.Length - 18);
                            ListaParametros.Add(credimasterOwner.Trim());
                            
                        }                        
                    }
                }
                
            }     
            
            /*

            if(ListaParametros.Count < 5)
            {
                //throw new InvalidOperationException("Faltam dados no arquivo dbparametros.ini");                
                //System.Windows.Forms.MessageBoxDefaultButton("");
                //DialogResult dialogResult = MessageBox.Show("Login atualizado com sucesso! ", "Atualização de login", MessageBoxButtons.OK);
                DialogResult dialogResult = MessageBox.Show("Faltam dados no arquivo dbParametros.ini. \n" +
                    "Este arquivo é composto pelas seguintes sessões:\n \n" +
                    "HOST \n" +
                    "PORT \n" +
                    "ServerName \n" +
                    "CREDIMASTER_OWNER", "Erro ao buscar parâmetros de conexão!", MessageBoxButtons.OK);
            }
            */

            return ListaParametros;               
        }
    }
}
