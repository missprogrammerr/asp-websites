//id, title, publisher, author, edition, no_of_page, price, publish_date, isbn
<span id="message" runat="server"></span>

<div>

<asp:Label runat="server" Text="Book ID:" ID="lblBookid" />
<asp:TextBox runat="server" ID="txtBookid" />
<span id="errBookid" runat="server"></span>
<br /><br />

<asp:Label runat="server" Text="Title:" ID="lblTitle" />
<asp:TextBox runat="server" ID="txtTitle" />
<span id="errTitle" runat="server"></span>
<br /><br />

<asp:Label runat="server" Text="Publisher:" ID="lblPublisher" />
<asp:TextBox runat="server" ID="txtPublisher" />
<span id="errPublisher" runat="server"></span>
<br /><br />

<asp:Label runat="server" Text="Author:" ID="lblAuthor" />
<asp:TextBox runat="server" ID="txtAuthor" />
<span id="errAuthor" runat="server"></span>
<br /><br />

<asp:Label runat="server" Text="Edition:" ID="lblEdition" />
<asp:TextBox runat="server" ID="txtEdition" />
<span id="errEdition" runat="server"></span>
<br /><br />

<asp:Label runat="server" Text="No of page:" ID="lblNoofpage" />
<asp:TextBox runat="server" ID="txtNoofpage" />
<span id="errNoofpage" runat="server"></span>
<br /><br />

<asp:Label runat="server" Text="Price:" ID="lblPrice" />
<asp:TextBox runat="server" ID="txtPrice" />
<span id="errPrice" runat="server"></span>
<br /><br />

<asp:Label runat="server" Text="Publish Date:" ID="lblPublishdate" />
<asp:TextBox ID="txtDob" runat="server" Text='<%# Bind("DateofBirth", "{0:yyyy-MM-dd}") %>' TextMode="Date" />
<span id="errPublishdate" runat="server"></span>
<br /><br />

<asp:Button runat="server" Text="Add Book" ID="btnAdd" />
<asp:Button runat="server" Text="View Books" ID="btnView" />

//list books

<span id="msgInfo" runat="server"></span>
<form id="form1" runat="server">
<div>
<asp:GridView ID="gridListBooks" runat="server" AutoGenerateColumns="false">
<Columns>
<asp:BoundField ItemStyle-Width="150px" DataField="id"
HeaderText="Book ID" />
<asp:BoundField ItemStyle-Width="150px" DataField="title"
HeaderText="Book Title" />
<asp:BoundField ItemStyle-Width="150px" DataField="publisher"
HeaderText="Publisher" />
<asp:BoundField ItemStyle-Width="150px" DataField="author"
HeaderText="Author" />
<asp:BoundField ItemStyle-Width="150px" DataField="edition"
HeaderText="Edition" />
<asp:BoundField ItemStyle-Width="150px" DataField="no_of_pages"
HeaderText="No of pages" />
<asp:BoundField ItemStyle-Width="150px" DataField="price"
HeaderText="Price" />
<asp:BoundField ItemStyle-Width="150px" DataField="publish_date"
HeaderText="Publish Date" />
</Columns>
</asp:GridView>
</div>
<div>
<asp:TextBox runat="server" ID="txtId"/>
<asp:Button Text="Edit" ID="btnEdit" runat="server" OnClick="btnEdit_Click"
/>
<asp:Button Text="Delete" ID="btnDelete" runat="server"
OnClick="btnDelete_Click" />
</div>
</form>
