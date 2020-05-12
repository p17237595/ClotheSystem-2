<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebSellApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 292px;
        }
        .auto-style4 {
            width: 292px;
            text-align: right;
        }
        .auto-style5 {
            width: 252px;
        }
        .auto-style6 {
            width: 292px;
            text-align: right;
            height: 33px;
        }
        .auto-style7 {
            width: 252px;
            height: 33px;
        }
        .auto-style8 {
            height: 33px;
        }
        .auto-style9 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Login Page</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">UserName</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUsername" CssClass="auto-style9" ErrorMessage="Please enter the username"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Password</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPass" CssClass="auto-style9" ErrorMessage="Please enter the password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="152px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
