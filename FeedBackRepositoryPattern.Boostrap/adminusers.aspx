<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminusers.aspx.cs" Inherits="FeedBackRepositoryPattern.Boostrap.adminusers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="grdAdminList" runat="server" OnSelectedIndexChanged="grdAdminList_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
        <Columns>
            <asp:CommandField ShowSelectButton="True" SelectText="Delete" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
        ADD NEW ADMIN:<br />

        Username: <asp:TextBox ID="txtAdminUserName" runat="server"></asp:TextBox>
        Password: <asp:TextBox ID="txtAdminPassword" runat="server"></asp:TextBox>
        Email: <asp:TextBox ID="txtAdminEmailAddress" runat="server"></asp:TextBox>
           <br />
    <asp:Button ID="btnAdminAdd" runat="server" Text="Add" OnClick="btnAdminAdd_Click" />
    <asp:Button ID="btnAdminUpdate" runat="server" Text="Update" OnClick="btnAdminUpdate_Click" />
    <asp:Button ID="btnAdminDelete" runat="server" Text="Delete" OnClick="btnAdminDelete_Click" />

 

        </form>
</body>
</html>
