using GeraCompe.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeraCompe
{
    public partial class FormAlterarLogin : Form
    {
        public FormAlterarLogin()
        {
            InitializeComponent();

            UserBancoDeDados user = new UserBancoDeDados();
            List<String> login = new List<String>();
            login = user.getLoginBd();

            txtBoxNovoUsuario.Text = login[0];
            txtBoxNovaSenha.Text = login[1];

            //textBoxLoginBd.Text = login[0];
            //textBoxSenhaBd.Text = login[1];
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UserBancoDeDados user = new UserBancoDeDados();
            
            if(txtBoxNovoUsuario.Text.ToString().Trim().Length > 0 && txtBoxNovaSenha.Text.ToString().Trim().Length > 0)
            {
                int validaAtualizacao = user.atualizaLogin(txtBoxNovoUsuario.Text.ToString().Trim(), txtBoxNovaSenha.Text.ToString().Trim());                

                if (validaAtualizacao == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Login atualizado com sucesso! ", "Atualização de login", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ocorreu um erro ao atualizar o login ", "Atualização de login", MessageBoxButtons.OK);
                }



            }
            
            
        }

        private void txtBoxNovoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNovaSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
