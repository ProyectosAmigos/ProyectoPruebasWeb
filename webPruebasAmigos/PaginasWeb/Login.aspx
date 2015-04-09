<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="webPruebasAmigos.PaginasWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblUserName" runat="server" Text="USUARIO:"></asp:Label>

        &nbsp;

        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

        <asp:Label ID="lbl" runat="server" Text="CONTRASEÑA:"></asp:Label>

        &nbsp;

        <asp:TextBox ID="txtUserPassword" runat="server"></asp:TextBox>
    &nbsp;
        <asp:Button ID="btnLogin" runat="server" Text="Comprobar" OnClick="btnLogin_Click" />
    &nbsp;
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
