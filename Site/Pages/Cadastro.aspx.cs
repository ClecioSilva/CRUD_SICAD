using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastroAluno(object sender, EventArgs e)
       
        {
            try
            {
                Aluno p = new Aluno();

                
                p.Nome = txtNome.Text;
                p.Data_Nasc = txtData_Nasc.Text;
                p.Idade = txtIdade.Text;
                p.Objetivo_Graduacao = txtObjetivo_Graduacao.Text;
                p.Genero = txtGenero.Text;


                AlunoDAL d = new AlunoDAL();

                

                d.Gravar(p); //gravando o aluno

                lblMensagem.Text = "Aluno " + p.Nome + " Cadastrado com Sucesso!!!";

                
                txtNome.Text = string.Empty;
                txtData_Nasc.Text = string.Empty;
                txtIdade.Text = string.Empty;
                txtObjetivo_Graduacao.Text = string.Empty;
                txtGenero.Text = string.Empty;

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}