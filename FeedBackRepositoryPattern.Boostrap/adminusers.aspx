<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminusers.aspx.cs" Inherits="FeedBackRepositoryPattern.Boostrap.adminusers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="grdAdminList" runat="server" OnSelectedIndexChanged="grdAdminList_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
        </form>
</body>
</html>
