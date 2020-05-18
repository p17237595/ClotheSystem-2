<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="WebSellApp.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Update User</title>
    <link rel="stylesheet" type="text/css" href="css/StyleSheet1.css">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 223px;
        }
        .auto-style3 {
            width: 351px;
        }
        .auto-style4 {
            color: #FF0000;
        }
        .auto-style8 {
            width: 278px;
            height: 31px;
        }
        .auto-style9 {
            margin-right: 8px;
        }
        .auto-style10 {
            font-weight: bold;
            background-color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">username</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBoxUser" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUser" CssClass="auto-style4" ErrorMessage="Enter a Username"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBoxPass" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPass" CssClass="auto-style4" ErrorMessage="Enter a Password"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">email</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBoxEmail" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxEmail" CssClass="auto-style4" ErrorMessage="Enter an email"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" CssClass="auto-style4" ErrorMessage="Enter a valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                <td class="auto-style8">
                    Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBoxCName" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxCName" CssClass="auto-style4" ErrorMessage="Customer name is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                <td class="auto-style8">
                    Address</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBoxCAddress" runat="server" CssClass="auto-style9" Width="270px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxCAddress" CssClass="auto-style4" ErrorMessage="Customer address is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                <td class="auto-style8">
                    Card Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBoxCCName" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxCCName" CssClass="auto-style4" ErrorMessage="Card Name is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                <td class="auto-style8">
                    Card No</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBoxCCNo" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxCCNo" CssClass="auto-style4" ErrorMessage="Card No is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                <td class="auto-style8">
                    Card Expire</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBoxCCExpire" runat="server" Width="270px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxCCExpire" CssClass="auto-style4" ErrorMessage="Card expire date is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button CssClass="back" ID="Button2" runat="server" OnClick="Button2_Click" Text="Go Back" CausesValidation="false" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" Width="145px" />
                    </td>
                    <td>
                        <strong>
        <asp:Button ID="DeleteUser" runat="server" OnClick="DeleteUser_Click" Text="Delete User" CssClass="auto-style10" />
                        </strong>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
