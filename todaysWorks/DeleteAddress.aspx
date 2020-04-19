<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteAddress.aspx.cs" Inherits="todaysWorks.DeleteAddress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 110px;
            width: 509px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Are you sure you want to delete this record?</p>
        <p>
            <asp:Button ID="btnYes_Click" runat="server" OnClick="btnYes_Click_Click" Text="Yes" />
            <asp:Button ID="btnNo_Click" runat="server" Text="No" />
        </p>
    </form>
</body>
</html>
