<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookList.aspx.cs" Inherits="BookList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gridListBooks" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField ItemStyle-Width="150px" DataField="book_id"
            HeaderText="Book ID" />
            <asp:BoundField ItemStyle-Width="150px" DataField="title"
            HeaderText="Book Title" />
            <asp:BoundField ItemStyle-Width="150px" DataField="publisher"
            HeaderText="Publisher" />
            <asp:BoundField ItemStyle-Width="150px" DataField="author"
            HeaderText="Author" />
            <asp:BoundField ItemStyle-Width="150px" DataField="edition"
            HeaderText="Edition" />
            <asp:BoundField ItemStyle-Width="150px" DataField="pages"
            HeaderText="No of pages" />
            <asp:BoundField ItemStyle-Width="150px" DataField="price"
            HeaderText="Price" />
            <asp:BoundField ItemStyle-Width="150px" DataField="publish_date"
            HeaderText="Publish Date" />
    </Columns>
    </asp:GridView>
    </div>
    <br /><br />
    <div>
    <asp:TextBox runat="server" ID="txtId"/>
    <asp:Button Text="Edit" ID="btnEdit" runat="server" OnClick="btnEdit_Click"
    />
    <asp:Button Text="Delete" ID="btnDelete" runat="server"
    OnClick="btnDelete_Click" />
    </div>
    </form>
</body>
</html>
