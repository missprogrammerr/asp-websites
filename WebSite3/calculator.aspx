<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calculator.aspx.cs" Inherits="calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox runat="server" ID="num1" placeholder="Number 1" />
    <br /><br />
    <asp:TextBox runat="server" ID="num2" placeholder="Number 2" />
    <br /><br />
    <span runat="server" id="result"></span>
    <asp:Button runat="server" Text="Add" ID="btnAdd"/>
    <asp:Button runat="server" Text="Subtract" ID="btnSubtract"/>
    <br /><br />
    <asp:Button runat="server" Text="Divide" ID="btnDivide"/>
    <asp:Button runat="server" Text="Multiply" ID="btnMultiply"/>
    </div>
    </form>
</body>
</html>
