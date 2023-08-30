<%@ Page Language="C#" AutoEventWireup="true" CodeFile="simple_intrest.aspx.cs" Inherits="simple_intrest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Simple intrest</h3> 

    <asp:Label runat="server" Text="Principal" ID="lblPrincipal" />
    <br />
    <asp:TextBox runat="server" ID="txtPrincipal"/>
    <span id="errPrincipal" runat="server"></span>
    <br /><br /> 

    <asp:Label runat="server" Text="Rate Of intrest" ID="lblRate" />
    <br />
    <asp:TextBox runat="server" ID="txtRate"/>
    <span id="errRate" runat="server"></span>
    <br /><br />

    <asp:Label runat="server" Text="Time" ID="lblTime" />
    <br />
    <asp:TextBox runat="server" ID="txtTime"/>
    <span id="errTime" runat="server"></span>
    <br /><br />
    <span runat="server" id="errResult"></span>
    <br />
    <span runat="server" id="intrest">Intrest: </span>
    <br /><br />
    <span runat="server" id="totalplusintrest">Total plus intrest: </span>
    <br /><br />
    <asp:Button runat="server" ID="btnResult" Text="Calculate" OnClick="btnResult_Click"/>

    </div>
    </form>
</body>
</html>
