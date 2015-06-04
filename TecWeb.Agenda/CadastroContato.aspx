<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroContato.aspx.cs" Inherits="TecWeb.Agenda.CadastroContato" %>

<%@ Register Src="MenuSistema.ascx" TagName="MenuSistema" TagPrefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/Styles/Estilo.css" rel="stylesheet" type="text/css" />    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastro de Contatos</h1>
            <hr />
            <table width="100%">
                <tr>
                    <td width="200px" align="left" valign="top">
                        <ul>
                            <uc1:MenuSistema ID="MenuSistema1" runat="server" />
                        </ul>
                    </td>
                    <td valign="top">
                        <asp:Panel runat="server" ID="PanelComponentes" Width="674px">
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
                                    Número
                                </div>
                                <div>
                                    Bairro
                                </div>
                                <div>
                                    Cidade
                                </div>
                                <div>
                                    Estado
                                </div>
                                <div>
                                    CEP
                                </div>
                                <div>
                                    Endereço Eletrônico
                                </div>
                                <div>
                                    E-mail
                                </div>
                                <div>
                                    Telefone
                                </div>
                                <div>
                                    Telefone Celular
                                </div>
                            </div>
                            <div id="divComponentes">
                                <asp:DropDownList ID="DropCategorias" runat="server" DataValueField="Id" DataTextField="Nome">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextNome"
                                    Display="Dynamic" ErrorMessage="O campo 'Nome completo' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />

                                <asp:TextBox ID="TextNome" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextNome"
                                    Display="Dynamic" ErrorMessage="O campo 'Nome' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextLogradouro" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextLogradouro"
                                    Display="Dynamic" ErrorMessage="O campo 'Logradouro' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextNumero" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextNumero"
                                    Display="Dynamic" ErrorMessage="O campo 'Número' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextBairro" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBairro"
                                    Display="Dynamic" ErrorMessage="O campo 'Bairro' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextCidade" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextCidade"
                                    Display="Dynamic" ErrorMessage="O campo 'Cidade' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextEstado" runat="server" Width="150px" MaxLength="2"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextEstado"
                                    Display="Dynamic" ErrorMessage="O campo 'Estado' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextCEP" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextCEP"
                                    Display="Dynamic" ErrorMessage="O campo 'CEP' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />


                                <asp:TextBox ID="TextEndEletronico" runat="server" Width="150px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextEndEletronico"
                                    Display="Dynamic" ErrorMessage="O campo 'Endereço Eletrônico' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextEmail" runat="server" Width="150px" MaxLength="30"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextEmail"
                                    Display="Dynamic" ErrorMessage="O campo 'E-mail' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextTelefone" runat="server" Width="150px"></asp:TextBox>(dd dddd-dddd)
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextTelefone"
                                    Display="Dynamic" ErrorMessage="O campo 'Telefone' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <asp:TextBox ID="TextCelular" runat="server" Width="150px" MaxLength="30"></asp:TextBox>(dd dddd-dddd)
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextCelular"
                                    Display="Dynamic" ErrorMessage="O campo 'Telefone Celular' é de preenchimento obrigatório."
                                    SetFocusOnError="True" ValidationGroup="Usuario">*</asp:RequiredFieldValidator>&nbsp;<br />
                                <br />
                            </div>
                            <br />
                            <br />
                            <asp:Button ID="ButtonCadastrar" runat="server" Text="Cadastrar" OnClick="ButtonCadastrar_Click" />
                        </asp:Panel>
                        <asp:Panel ID="PanelMensagem" runat="server" Width="675px">
                            O contato foi cadastrado com sucesso. Clique <a href="CadastroContato.aspx">aqui</a> para cadastrar um novo contato.
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
