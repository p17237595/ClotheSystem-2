<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmDelete.aspx.cs" Inherits="WebSellApp.ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Delete?</title>
    <link rel="stylesheet" type="text/css" href="css/StyleSheet1.css">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 410px;
        }
        .auto-style3 {
            width: 277px;
        }
        .auto-style4 {
            font-weight: bold;
            background-color: #FF0000;
        }
        .auto-style5 {
            width: 410px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">Are you sure? The account will be deleted</td>
                    <td class="auto-style3"><strong>
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style4" OnClick="Button2_Click" style="height: 36px" Text="Delete" Width="154px" />
                        </strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go Back!" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
