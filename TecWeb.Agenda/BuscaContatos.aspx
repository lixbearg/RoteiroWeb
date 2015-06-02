<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscaContatos.aspx.cs" Inherits="TecWeb.Agenda.BuscaContatos" %>
<%@ Register src="MenuSistema.ascx" tagname="MenuSistema" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/Styles/Estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <h1>Busca de Contatos</h1>
                <hr />
                <table width="100%">
                    <tr>
                        <td width="200px" align="left" valign="top">
                            <ul>
                                <uc1:menusistema id="MenuSistema2" runat="server" />
                            </ul>
                        </td>
                        <td valign="top">
                            <td valign="top">
                                <div id="divLabels">
                                    <div>
                                        Categoria
                                    </div>
                                    <div>
                                        Nome
                                    </div>
                                    <div>
                                        Logradouro
                                    </div>
                                    <div>
                                        Cidade
                                    </div>
                                    <div>
                                        E-mail
                                    </div>
                                </div>
                                <div id="divComponentes">
                                    <asp:DropDownList ID="DropCategorias" runat="server" DataValueField="Id" DataTextField="Nome">
                                    </asp:DropDownList>
                                    <br />
                                    <asp:TextBox ID="TextNome" runat="server"></asp:TextBox><br />
                                    <asp:TextBox ID="TextLogradouro" runat="server"></asp:TextBox>&nbsp;<br />
                                    <asp:TextBox ID="TextCidade" runat="server"></asp:TextBox>
                                    <br />
                                    <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
                                </div>
                                <p>
                                    <asp:Button ID="ButtonPesquisar" runat="server" Text="Pesquisar"
                                        OnClick="ButtonPesquisar_Click" />
                                </p>
                                <hr />
                                <div style="width: 100%; vertical-align: top">
                                    <asp:GridView ID="GridContatos" runat="server" AutoGenerateColumns="False">
                                        <Columns>
                                            <asp:BoundField DataField="CategoriaNome" HeaderText="Categoria" />
                                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                            <asp:BoundField DataField="EnderecoEletronico" HeaderText="Endere&#231;o Eletr&#244;nico" />
                                            <asp:BoundField DataField="Email" HeaderText="E-mail" />
                                            <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                                            <asp:BoundField DataField="TelefoneCelular" HeaderText="Telefone Celular" />
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
