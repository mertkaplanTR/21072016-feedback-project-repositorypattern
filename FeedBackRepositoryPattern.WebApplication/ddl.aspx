<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ddl.aspx.cs" Inherits="FeedBackRepositoryPattern.WebApplication.ddl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="_OnSelectedIndexChanged" AppendDataBoundItems="true"></asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
