<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="TecWeb.Agenda.CadastroUsuario" %>
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
            <h1>Cadastro de Usuarios</h1>
            <hr />
            <table width="100%">
                <tr>
                    <td width="200px" align="left" valign="top">
                        <ul>
                            <uc1:menusistema id="MenuSistema1" runat="server" />
                        </ul>
                    </td>
                    <td valign="top">
                        <asp:Panel runat="server" ID="PanelComponentes" Width="674px">
                            <div id="divLabels">
                                <div>
                                    Nome completo
                                </div>
                                <div>
                                    Nome de usuário
                                </div>
                                <div>
                                    Senha
                                </div>
                                <div>
                                    Confirmação
                                </div>
                            </div>
                            <div id="divComponentes">
                                <asp:TextBox ID="TextNome" runat="server" Width="250px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextNome"
                                    Display="Dynamic" ErrorMessage="O campo 'Nome completo' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextNomeUsuario" runat="server" MaxLength="30"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextNomeUsuario"
                                    Display="Dynamic" ErrorMessage="O campo 'Nome de usuário' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator><br />
                                <asp:TextBox ID="TextSenha" runat="server" TextMode="Password" MaxLength="30"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextSenha"
                                    Display="Dynamic" ErrorMessage="O campo 'Senha' é de preenchimento o obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator><br />
                                <asp:TextBox ID="TextConfirmacaoSenha" runat="server" TextMode="Password" MaxLength="30"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextConfirmacaoSenha"
                                    Display="Dynamic" ErrorMessage="*" ValidationGroup="Usuario"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextSenha"
                                    ControlToValidate="TextConfirmacaoSenha" Display="Dynamic" SetFocusOnError="True"
                                    ValidationGroup="Usuario">As senhas informadas não conferem</asp:CompareValidator><br />
                                <br />
                            </div>
                            <asp:Button ID="ButtonCadastrar" runat="server" Text="Cadastrar" OnClick="ButtonCadastrar_Click" />
                        </asp:Panel>
                        <asp:Panel ID="PanelMensagem" runat="server" Width="675px">
                            O usuário foi cadastrado com sucesso. Clique <a href="Login.aspx">aqui</a> para acessar o sistema
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
