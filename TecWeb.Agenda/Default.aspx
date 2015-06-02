<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TecWeb.Agenda.Default" %>

<%@ Register Src="~/MenuSistema.ascx" TagPrefix="uc1" TagName="MenuSistema" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/Styles/Estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Lista Telefônica - OnLine</h1>
            <hr />
            <table width="100%">
                <tr>
                    <td style="text-align: left; vertical-align: top">
                        <ul>
                            <uc1:MenuSistema runat="server" ID="MenuSistema" />
                        </ul>
                    </td>
                    <td valign="top"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
