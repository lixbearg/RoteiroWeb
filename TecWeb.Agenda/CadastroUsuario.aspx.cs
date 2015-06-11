using System;
using System.Web.UI;
using TecWeb.Agenda.ObjetoNegocio;

namespace TecWeb.Agenda
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PanelMensagem.Visible = false;
            }
        }

        protected void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioWS.UsuarioWS UsuariosWS = new UsuarioWS.UsuarioWS();
            Page.Validate();
            if (Page.IsValid)
            {
                Usuario usuario = new Usuario();        
                UsuariosWS.adicionaUsuario(TextNome.Text, TextNomeUsuario.Text, TextSenha.Text);
                PanelComponentes.Visible = false;
                PanelMensagem.Visible = true;
            }
        }
    }
}