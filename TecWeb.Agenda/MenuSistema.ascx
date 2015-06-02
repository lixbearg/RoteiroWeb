<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuSistema.ascx.cs" Inherits="TecWeb.Agenda.MenuSistema" %>

<%if(Session["Usuario"] != null) {%>
<p> <b>Bem vindo, <%=((TecWeb.Agenda.ObjetoNegocio.Usuario)Session["Usuario"]).Nome%>!</b>
</p>
<li><a href="CadastroUsuario.aspx">Cadastrar Usuário</a></li>
<li><a href="CadastroContato.aspx">Cadastrar Contato</a></li>
<li><a href="BuscaContatos.aspx">Buscar Contatos</a></li>
<li><a href="Logout.aspx">Sair do sistema</a></li> <%} else {%>
<li><a href="CadastroUsuario.aspx">Cadastrar Usuário</a></li>
<li><a href="Login.aspx">Login</a></li> <%} %>