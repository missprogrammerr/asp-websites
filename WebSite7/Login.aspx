<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3 runat="server">Login to website</h3>
        <asp:Label runat="server" Text="Email" ID="lblEmail"/>
        <asp:TextBox runat="server" TextMode="Email" ID="txtEmail" placeholder="Enter Email" />
        <span id="errEmail" runat="server"></span>
        <br /><br />
        <asp:Label runat="server" Text="Password" ID="lblPassword" />
        <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" />
        <span id="errPassword" runat="server"></span>
        <br /><br />
        <asp:Button runat="server" Text="Login" ID="btnLogin" OnClick="btnLogin_Click"/>
        <br /><br />
        <span id="errLogin" runat="server"></span>
    </div>
    </form>
</body>
</html>
