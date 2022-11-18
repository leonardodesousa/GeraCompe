using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraCompe.Framework
{
    internal class UserBancoDeDados
    {

        public int atualizaLogin(String novoLogin, String novaSenha)
        {
            String path = @"C:\TotalBanco\Crediblaster\GeraCompe\GeraCompePBD.dll";
            String userId;
            String pass;
            int retorno = 0;


            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("userId=" + novoLogin.Trim());
                sw.WriteLine("password=" + novaSenha.Trim());
                retorno = 1;
            }
                return retorno;
        }

        public List<String> getLoginBd()
        {
            List<String> login = new List<String>(); 

            String path = @"C:\TotalBanco\Crediblaster\GeraCompe\GeraCompePBD.dll";
            String userId;
            String pass; 
            
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    String ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        if (ln.Length > 6 && ln.Substring(0, 6).ToUpper() == "USERID")
                        {
                            userId = ln.Substring(7, ln.Length - 7);
                            login.Add(userId.Trim());                            
                        }
                        if (ln.Length > 8 && ln.Substring(0, 8).ToUpper() == "PASSWORD")
                        {
                            pass = ln.Substring(9, ln.Length - 9);
                            login.Add(pass.Trim());                            
                        }                        
                    }                    
                }
            }
                return login;
        }
    }
}
