<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TecWeb.Agenda.Login" %>
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
            <h1>Login</h1>
            <hr />
            <table width="100%">
                <tr>
                    <td width="200px" align="left" valign="top">
                        <ul>
                            <uc1:menusistema id="MenuSistema1" runat="server" />
                        </ul>
                    </td>
                    <td valign="top">
                        <asp:Panel ID="PanelMensagem" runat="server">
                            <p>Não foi possível efetuar o login com as credenciais informadas.</p>
                        </asp:Panel>
                        <asp:Panel ID="PanelComponentes" runat="server">
                            <div id="divLabels">
                                <div>Nome de usuário</div>
                                <div>Senha</div>
                            </div>
                            <div id="divComponentes">
                                <asp:TextBox ID="TextNomeUsuario" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextNomeUsuario"
                                    Display="Dynamic" ErrorMessage="O campo 'Nome de usuário' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>
                                <br />
                                <asp:TextBox ID="TextSenha" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextSenha"
                                    Display="Dynamic" ErrorMessage="O campo 'Senha' é de preenchimento o obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator><br />
                                <asp:CheckBox ID="CheckLembrar" runat="server" Text="Lembrar usuário e senha nesse computador" /><br />
                            </div>
                            <p>
                                <asp:Button ID="ButtonLogin" runat="server" Text="Ok" OnClick="ButtonLogin_Click" /></p>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
