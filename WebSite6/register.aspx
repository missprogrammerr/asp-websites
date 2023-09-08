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
        <br/>
        <span id="errName"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblFather">Father's Name:</asp:Label>
        <asp:TextBox runat="server" ID="txtFather"/>
        <br/>
        <span id="errFather"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblMother">Mother's Name:</asp:Label>
        <asp:TextBox runat="server" ID="txtMother"/>
        <br/>
        <span id="errMother"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblPhone">Phone Number:</asp:Label>
        <asp:TextBox runat="server" ID="txtPhone"/>
        <br/>
        <span id="errPhone"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblEmail">Email</asp:Label>
        <asp:TextBox runat="server" ID="txtEmail" placeholder="sample@example.com"></asp:TextBox>
        <br/>
        <span id="errEmail"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblGender">Gender:</asp:Label>
        <asp:RadioButtonList runat="server" ID="chkGender">
        <asp:ListItem Text="Male" Value="male" />
        <asp:ListItem Text="Female" Value="female" />
        <asp:ListItem Text="Others" Value="others" />
        </asp:RadioButtonList>
        <br/>
        <span id="errGender"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblDob">Date of birth:</asp:Label>
        <asp:TextBox ID="txtDob" runat="server" Text='<%# Bind("DateofBirth", "{0:yyyy-MM-dd}") %>' TextMode="Date"></asp:TextBox>
        <br/>
        <span id="errDob"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblAddress">Address</asp:Label>
        <asp:TextBox runat="server" ID="txtAddress" placeholder="Street- House- Road-" />
        <br/>
        <span id="errAddress"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblBloodgrp">Blood Group:</asp:Label>
        <asp:DropDownList runat="server" ID="ddBloodgrp">
        <asp:ListItem Text="A+" Value="a+" />
        <asp:ListItem Text="B+" Value="b+" />
        <asp:ListItem Text="B-" Value="b-" />
        <asp:ListItem Text="O-" Value="o-" />
        <asp:ListItem Text="O+" Value="o+" />
        </asp:DropDownList>
        <br/>
        <span id="errBloodgrp"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblDepartment">Department:</asp:Label>
        <asp:RadioButtonList runat="server" ID="departmentList">
        <asp:ListItem Text="CSE" Value="cse" />
        <asp:ListItem Text="EEE" Value="eee" />
        <asp:ListItem Text="BBA" Value="bba" />
        </asp:RadioButtonList>
        <br/>
        <span id="errDepartment"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblCourses">Courses:</asp:Label>
        <asp:CheckBoxList runat="server" ID="courses">
        <asp:ListItem Text="C" Value="C"/>
        <asp:ListItem Text="C++" Value="c++" />
        <asp:ListItem Text="Java" Value="java" />
        <asp:ListItem Text="AI" Value="ai" />
        <asp:ListItem Text="Machine Learning" Value="ml" />
        </asp:CheckBoxList>
        <br/>
        <span id="errCourses"></span>
        <br /><br />
        <asp:Label runat="server" ID="lblPhoto">Photo:</asp:Label>
        <asp:FileUpload runat="server" ID="filePhoto" />
        <br/>
        <span id="errPhoto"></span>
        <br /><br />
        <asp:Button runat="server" Text="Submit" Value="Submit" ID="btnSubmit"/>
        <asp:Button runat="server" Text="Reset" Value="Reset" ID="btnReset"/>
    </div>
    </form>
</body>
</html>
