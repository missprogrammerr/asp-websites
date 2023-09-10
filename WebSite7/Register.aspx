<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <span id="error_messsage" runat="server"></span>
        <div>
             <asp:Label runat="server" Text="Name" ID="lblName"/>
             <asp:TextBox runat="server" ID="txtName" placeholder="Enter Name" />
             <span ID="errName" runat="server"></span>
             <br /><br />
             <asp:Label runat="server" Text="Email" ID="lblEmail"/>
             <asp:TextBox runat="server" TextMode="Email" ID="txtEmail" placeholder="Enter Email" />
             <span ID="errEmail" runat="server"></span>
             <br /><br />
            <asp:Label runat="server" Text="Phone" ID="lblPhone"/>
            <asp:TextBox runat="server" ID="txtPhone" placeholder="Enter Phone" />
            <span ID="errPhone" runat="server"></span>
            <br /><br />
            <asp:Label runat="server" Text="Gender" ID="lblGender"/>
            <asp:RadioButtonList ID="rdoGender" runat="server">
                <asp:ListItem Text="Male" Value="Male" />
                <asp:ListItem Text="Female" Value="Female" />
                <asp:ListItem Text="Others" Value="Others" />
            </asp:RadioButtonList>
            <span id="errGender" runat="server"></span>
            <br /><br />
            <asp:Label runat="server" Text="Faculty" ID="lblFaculty" />
            <asp:DropDownList ID="drpFaculty" runat="server">
                <asp:ListItem Text="Humanities & Social Science" Value="humanities_and_social" />
                <asp:ListItem Text="Management" Value="management" />
                <asp:ListItem Text="Law" Value="law" />
                <asp:ListItem Text="Education" Value="education" />
            </asp:DropDownList>
            <span id="errFaculty" runat="server"></span>
            <br /><br />
            <asp:Label runat="server" Text="Password" ID="lblPassword" />
            <asp:TextBox runat="server" TextMode="Password" ID="txtPassword1" />
            <span id="errPassword1" runat="server"></span>
            <br /><br />
            <asp:Label runat="server" Text="Confirm-Password" ID="lblPassword2" />
            <asp:TextBox runat="server" TextMode="Password" ID="txtPassword2" />
            <span id="errPassword2" runat="server"></span>
            <br /><br />
            <asp:Button runat="server" Text="Register" ID="btnRegister" OnClick="btnRegister_Click"/>
    </div>
    </form>
</body>
</html>
