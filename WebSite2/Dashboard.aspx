<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Welcome back!</h1>
    <form id="form1" runat="server">
    <div>
    <asp:Button runat="server" Text="Logout" ID="btnLogout" OnClick="btnLogout_Click"/>
    </div>
    </form>
</body>
</html>
