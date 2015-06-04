using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using TecWeb.Agenda.DAO;
using TecWeb.Agenda.ObjetoNegocio;

namespace TecWeb.Agenda
{
    public partial class BuscaContatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Usuario"] == null)
            {
                Response.Redirect("/Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                CategoriaDAO categoriaDAO = new CategoriaDAO();
                DropCategorias.DataSource = categoriaDAO.ObterCategorias();
                DropCategorias.DataBind();
                DropCategorias.Items.Insert(0, new ListItem("SELECIONE UMA CATEGORIA", "0"));
            }
        }

        protected void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            ContatoDAO contatoDAO = new ContatoDAO();
            List<Contato> contatos = contatoDAO.ObterContatos(this.TextNome.Text, this.TextLogradouro.Text, this.TextCidade.Text, this.TextEmail.Text, Convert.ToInt32(this.DropCategorias.SelectedValue));
            GridContatos.DataSource = contatos;
            GridContatos.DataBind();
        }
    }
}