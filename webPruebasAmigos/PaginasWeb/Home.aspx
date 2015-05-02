<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="webPruebasAmigos.PaginasWeb.Home" %>

<%@ Register Src="~/Recursos/Controles de usuario/login.ascx" TagPrefix="uc1" TagName="login" %>



<uc1:login runat="server" ID="login" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <div>
        <asp:Label ID="lblHome" runat="server" Text=""></asp:Label>
    </div>

</body>
</html>
