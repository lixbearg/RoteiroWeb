using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TecWeb.WS.DAO;
using TecWeb.Agenda.ObjetoNegocio;

namespace TecWeb.Agenda
{
    public partial class CadastroContato : System.Web.UI.Page
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

                PanelMensagem.Visible = false;
            }
        }

        protected void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                ContatoDAO contatoDAO = new ContatoDAO();
                Contato contato = new Contato();
                contato.CategoriaID = DropCategorias.SelectedIndex;
                contato.Nome = TextNome.Text;
                contato.Logradouro = TextLogradouro.Text;
                contato.Numero = Convert.ToInt16(TextNumero.Text);
                contato.Bairro = TextBairro.Text;
                contato.Cidade = TextCidade.Text;
                contato.Estado = TextEstado.Text;
                contato.Cep = TextCEP.Text;
                contato.EnderecoEletronico = TextEndEletronico.Text;
                contato.Email = TextEmail.Text;
                contato.Telefone = TextTelefone.Text;
                contato.TelefoneCelular = TextCelular.Text;
                contatoDAO.AdicionarContato(contato);


                PanelComponentes.Visible = false;
                PanelMensagem.Visible = true;
            }
        }
    }
}