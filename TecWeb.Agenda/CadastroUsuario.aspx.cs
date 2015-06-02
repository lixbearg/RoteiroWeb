using System;
using System.Web.UI;
using TecWeb.Agenda.DAO;
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
            Page.Validate();
            if (Page.IsValid)
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                Usuario usuario = new Usuario();
                usuario.Nome = TextNome.Text;
                usuario.NomeUsuario = TextNomeUsuario.Text;
                usuario.Senha = TextSenha.Text;
                usuarioDAO.AdicionarUsuario(usuario);
                PanelComponentes.Visible = false;
                PanelMensagem.Visible = true;
            }
        }
    }
}