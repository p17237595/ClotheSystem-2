<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddressList.aspx.cs" Inherits="todaysWorks.AddressList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstAddressList" runat="server" Height="455px" Width="1278px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="Button1_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" />
    </form>
</body>
</html>
