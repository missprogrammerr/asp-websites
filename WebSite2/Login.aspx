<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label runat="server" Text="Username" ID="lblUsername" />
    <asp:TextBox runat="server" ID="txtUsername" placeholder="Username" />
    <span id="errUsername" runat="server"></span>
    <br /><br />
    <asp:Label runat="server" Text="Password" ID="lblPassword" />
    <asp:TextBox TextMode="password" runat="server" ID="txtPassword" placeholder="Password" />
    <span id="errPassword" runat="server"></span>
    <br /><br />
    <asp:Button runat="server" Text="Login" ID="btnLogin" OnClick="btnLogin_Click" />
    </div>
    </form>
</body>
</html>
