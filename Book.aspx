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
