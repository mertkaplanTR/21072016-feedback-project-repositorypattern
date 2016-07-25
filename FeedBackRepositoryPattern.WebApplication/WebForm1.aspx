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
        txtAddUsername:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAddUsername" runat="server"></asp:TextBox>
        &nbsp;&nbsp;
        <br />
        txtAddPassword:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtAddPassword" runat="server"></asp:TextBox>
        <br />
        txtAddEmailaddress:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtAddEmailaddress" runat="server"></asp:TextBox>
        <br />
        txtIsActive:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="isActiveDropDown" runat="server" Height="16px" Width="167px">
            <asp:ListItem Value="active">Active</asp:ListItem>
            <asp:ListItem Value="deactive">Deactive</asp:ListItem>
        </asp:DropDownList>
        <br />
        txtAdminRole:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAddAdminRole" runat="server"></asp:TextBox>
        <br />
        CreatedDate:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAddCreatedDate" runat="server"></asp:TextBox>
        <br />
        ModifiedDate:&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAddModifiedDate" runat="server"></asp:TextBox>
        <br />
        ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAddID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AdminAddButton" runat="server" OnClick="AdminAddButton_Click" Text="Add" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="DeleteButton" runat="server" OnClick="DeleteButton_Click" Text="Delete" />
    &nbsp;&nbsp;
        <asp:Button ID="UpdateButtton" runat="server" OnClick="UpdateButton_Click" Text="Update" />
    </div>
    </form>
</body>
</html>
