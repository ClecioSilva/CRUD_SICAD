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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnExcluirUsuario(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                Aluno p     = new Aluno();
                AlunoDAL d  = new AlunoDAL();

                d.Excluir(Codigo);

                lblMemsagem.Text = "Aluno" + p.Nome + "Excluido com sucesso!";

                txtCodigo.Text      = string.Empty;
                txtNome.Text        = string.Empty;
                txtData_Nasc.Text    = string.Empty;
                txtIdade.Text       = string.Empty;
                txtObjetivo_Graduacao.Text = string.Empty;
                txtGenero.Text = string.Empty;
                


            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void BtnAtualizarUsuario(object sender, EventArgs e)
        {
            try
            {
                Aluno p = new Aluno();

                p.Codigo                = Convert.ToInt32(txtCodigo.Text);
                p.Nome                  = Convert.ToString(txtNome.Text);
                p.Data_Nasc             = Convert.ToString(txtData_Nasc.Text);
                p.Idade                 = Convert.ToString(txtIdade.Text);
                p.Objetivo_Graduacao    = Convert.ToString(txtObjetivo_Graduacao.Text);
                p.Genero                = Convert.ToString(txtGenero.Text);


                AlunoDAL d = new AlunoDAL();
                d.Atualizar(p);

                lblMemsagem.Text = "Aluno " + p.Nome + " Atualizado com Sucesso!";

                txtCodigo.Text      = string.Empty;
                txtNome.Text        = string.Empty;
                txtData_Nasc.Text    = string.Empty;
                txtIdade.Text       = string.Empty;
                txtObjetivo_Graduacao.Text = string.Empty;
                txtGenero.Text = string.Empty;

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnPesquisarAluno(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                AlunoDAL d = new AlunoDAL();
                Aluno p = d.PesquisarporCodigo(Codigo);

                if (p != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                    txtData_Nasc.Text = p.Data_Nasc;
                    txtIdade.Text = p.Idade;
                    txtObjetivo_Graduacao.Text = p.Objetivo_Graduacao;
                    txtGenero.Text = p.Genero;

                }
                else
                { 
                    lblMensagem.Text = "Aluno Não Encontrado";

                    txtCodigo.Text = string.Empty;    
                    
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}