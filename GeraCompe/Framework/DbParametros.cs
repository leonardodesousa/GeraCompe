using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraCompe.Framework
{
    internal class DbParametros
    {
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
                            //System.Windows.Forms.MessageBox.Show("credimasterOwner recebe " + credimasterOwner);
                        }                        
                    }
                }

            }
            return ListaParametros;               
        }
    }
}
