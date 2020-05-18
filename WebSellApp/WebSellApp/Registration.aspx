<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebSellApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>New User!</title>
     <link rel="stylesheet" type="text/css" href="css/StyleSheet1.css">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 206px;
        }
        .auto-style3 {
            width: 206px;
            text-align: left;
        }
        .auto-style5 {
            width: 206px;
            height: 25px;
        }
        .auto-style6 {
            height: 25px;
        }
        .auto-style7 {
            width: 309px;
        }
        .auto-style8 {
            height: 25px;
            width: 309px;
        }
        .auto-style9 {
            color: #FF3300;
        }
        .auto-style10 {
            width: 206px;
            text-align: left;
            height: 33px;
        }
        .auto-style11 {
            width: 309px;
            height: 33px;
        }
        .auto-style12 {
            color: #FF3300;
            height: 33px;
        }
        .auto-style13 {
            width: 206px;
            text-align: left;
            height: 62px;
        }
        .auto-style14 {
            width: 309px;
            height: 62px;
        }
        .auto-style15 {
            color: #FF3300;
            height: 62px;
        }
        .auto-style16 {
            width: 206px;
            text-align: left;
            height: 66px;
        }
        .auto-style17 {
            width: 309px;
            height: 66px;
        }
        .auto-style18 {
            color: #FF3300;
            height: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">User Name</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBoxUsername" runat="server" Width="225px"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUsername" ErrorMessage="User name is required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">E-mail</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBoxEmail" runat="server" Width="225px"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Email is required"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Enter a valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">Password</td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password" Width="225px"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPass" ControlToValidate="TextBoxPassC" ErrorMessage="The passwords are different"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Confirm Password</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBoxPassC" runat="server" TextMode="Password" Width="225px"></asp:TextBox>
                </td>
                <td class="auto-style12">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxPassC" ErrorMessage="Confirm Password is required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Go Back!" CausesValidation="false" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" Text="Register!" Width="164px" OnClick="Button1_Click1" />
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
