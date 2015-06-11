using System;
using System.Web;
using TecWeb.WS.DAO;
using TecWeb.Agenda.ObjetoNegocio;

namespace TecWeb.Agenda
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PanelMensagem.Visible = false;
                if (Request.Cookies["Usuario"] != null)
                {
                    string nomeUsuario = Request.Cookies["Usuario"].Value;
                    UsuarioDAO isuarioDAO = new UsuarioDAO();
                    Usuario usuario = isuarioDAO.ObterUsuario(nomeUsuario);
                    if (usuario != null)
                    {
                        Session["Usuario"] = usuario;
                        Response.Redirect("Default.aspx");
                    }
                }
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario usuario = usuarioDAO.ObterUsuario(TextNomeUsuario.Text, TextSenha.Text);
            if (usuario != null)
            {
                Session["Usuario"] = usuario;
                HttpCookie cookie = new HttpCookie("Usuario");
                cookie.Value = TextNomeUsuario.Text;
                if (CheckLembrar.Checked)
                {
                    cookie.Expires = DateTime.Now.AddDays(2);
                }
                Response.Cookies.Add(cookie);
            }
            else
            {
                PanelMensagem.Visible = true;
            }
        }
    }
}