﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3 runat="server" id="welcome_msg">Welcome back!</h3>
    <asp:Button runat="server" Text="Logout" ID="btnLogout" OnClick="btnLogout_Click" />
    </div>
    </form>
</body>
</html>
