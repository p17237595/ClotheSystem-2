<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="WebSellApp.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label_welcome" runat="server" Text="Welcome:"></asp:Label>
            <br />
            <br />
            <asp:Button ID="B_logout" runat="server" OnClick="B_logout_Click1" Text="Logout" />
        </div>
    </form>
</body>
</html>
