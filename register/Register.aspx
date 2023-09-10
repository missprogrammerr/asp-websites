<!--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PNCWebAPP1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Register</title>
</head>
<body>
    <h1>Register Form</h1>
    <form id="form1" runat="server">
        <span id="error_messsage" runat="server"></span>
        <div>
             <asp:Label runat="server" Text="Name" ID="lblName"/>
             <asp:TextBox runat="server" ID="txtName" placeholder="Enter Name" />
             <span ID="errName" runat="server"></span>
             <br />
             <asp:Label runat="server" Text="Email" ID="lblEmail"/>
             <asp:TextBox runat="server" TextMode="Email" ID="txtEmail" placeholder="Enter Email" />
             <span ID="errEmail" runat="server"></span>
             <br />
            <asp:Label runat="server" Text="Phone" ID="lblPhone"/>
            <asp:TextBox runat="server" ID="txtPhone" placeholder="Enter Phone" />
            <span ID="errPhone" runat="server"></span>
            <br />
            <asp:Label runat="server" Text="Address" ID="lblAddress"/>
            <asp:TextBox runat="server" ID="txtAddress" placeholder="Enter Address" />
            <span ID="errAddress" runat="server"></span>
            <br />
            <asp:Label runat="server" Text="Gender" ID="lblGender"/>
            <asp:RadioButtonList ID="rdoGender" runat="server">
                <asp:ListItem Text="Male" Value="Male" />
                <asp:ListItem Text="Female" Value="Female" />
                <asp:ListItem Text="Others" Value="Others" />
            </asp:RadioButtonList>
            <span id="errGender" runat="server"></span>
            <br />
            <asp:Label runat="server" Text="Username" ID="lblUsername"/>
            <asp:TextBox runat="server" ID="txtUsername" placeholder="Enter Username" />
            <span id="errUsername" runat="server"></span>
            <br />
            <asp:Label runat="server" Text="Password" ID="lblPassword"/>
            <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" placeholder="Enter Password" />
            <span id="errPassword" runat="server"></span>
            <br />
            <asp:Button Text="Register" ID="btnRegister" runat="server" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html> -->
