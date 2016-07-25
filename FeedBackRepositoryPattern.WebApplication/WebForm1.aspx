<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FeedBackRepositoryPattern.WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Admin Add<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AdminAddButton" runat="server" OnClick="AdminAddButton_Click" Text="Add" />
    </div>
    </form>
</body>
</html>
