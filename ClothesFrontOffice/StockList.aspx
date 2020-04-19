<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </div>
        <div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
        </div>
        <div>
            Enter a Gender 
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnApply" runat="server" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" />
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </div>
    </form>
</body>
</html>
