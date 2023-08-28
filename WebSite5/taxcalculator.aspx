<%@ Page Language="C#" AutoEventWireup="true" CodeFile="taxcalculator.aspx.cs" Inherits="taxcalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Nepalese Income Tax Calculator</h3>
        <span>Assessment Info</span>
        <span>
        <asp:DropDownList runat="server" ID="drpGender">
            <asp:ListItem Text="Male" Value="Male" />
            <asp:ListItem Text="Female" Value="Female" />
        </asp:DropDownList>
        </span>
        <span>
        <asp:DropDownList runat="server" ID="DropDownList1">
            <asp:ListItem Text="Couple Natural Person" Value="person" />
            <asp:ListItem Text="Couple Natural Person" Value="person2" />
        </asp:DropDownList>
        </span>
        <br /><br />
        <asp:Label runat="server" ID="lblSalary">Monthly Salary</asp:Label>
        <asp:TextBox runat="server" ID="txtsalary"></asp:TextBox>
        <br />
        <h4>Annual Income</h4>
        <asp:Label runat="server" ID="lblAnnualsalary">Annual Gross Salary</asp:Label>
        <asp:TextBox runat="server" ID="txtAnnualSalary"></asp:TextBox>
        <br /><br />
        <asp:Button runat="server" ID="btnClear" Text="Clear Inputs"/>
        <asp:Button runat="server" ID="btnCalculate" Text="Calculate Tax" />
    </div>
    </form>
</body>
</html>
