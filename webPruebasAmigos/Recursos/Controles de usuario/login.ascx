<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="webPruebasAmigos.Recursos.Controles_de_usuario.login" %>
<form id="frmLogin" runat="server">
    <div>
    
        <asp:Label ID="lblUserName" runat="server" Text="USUARIO:"></asp:Label>

        &nbsp;

        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

        &nbsp;&nbsp;&nbsp;

        <asp:Label ID="lbl" runat="server" Text="CONTRASEÑA:"></asp:Label>

        &nbsp;

        <asp:TextBox ID="txtUserPassword" runat="server"></asp:TextBox>

        <asp:Button ID="btnLogin" runat="server" Text="Comprobar" OnClick="btnLogin_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </div>
</form>