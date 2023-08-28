<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="heading">
            <h3>Student Registration Form</h3>
        </div>
        <br />
        <asp:Label runat="server" ID="lblName">Name:</asp:Label>
        <asp:TextBox runat="server" ID="txtName"/>
        <br /><br />
        <asp:Label runat="server" ID="lblFather">Father's Name:</asp:Label>
        <asp:TextBox runat="server" ID="txtFather"/>
        <br /><br />
        <asp:Label runat="server" ID="lblMother">Mother's Name:</asp:Label>
        <asp:TextBox runat="server" ID="txtMother"/>
        <br /><br />
        <asp:Label runat="server" ID="lblPhone">Phone Number:</asp:Label>
        <asp:TextBox runat="server" ID="txtPhone"/>
        <br /><br />
    </div>
    </form>
</body>
</html>
