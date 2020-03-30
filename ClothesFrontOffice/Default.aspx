<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button id="Add" runat="server" Text="Delete" OnClick="button1Clicked" />
            <asp:Button id="Delete" runat="server" Text="Delete" OnClick="button2Clicked" />

            <br />
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>

        </div>
    </form>
</body>
</html>
