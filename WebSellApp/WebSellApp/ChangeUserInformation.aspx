<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeUserInformation.aspx.cs" Inherits="WebSellApp.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 278px;
        }
        .auto-style3 {
            width: 246px;
        }
        .auto-style4 {
            color: #FF0000;
        }
        .auto-style5 {
            width: 278px;
            height: 80px;
        }
        .auto-style6 {
            width: 246px;
            height: 80px;
        }
        .auto-style8 {
            width: 278px;
            height: 31px;
        }
        .auto-style9 {
            width: 246px;
            height: 31px;
        }
        .auto-style13 {
            margin-right: 0px;
        }
        .auto-style14 {
            height: 80px;
            width: 450px;
        }
        .auto-style15 {
            width: 450px;
        }
        .auto-style16 {
            height: 31px;
            width: 450px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Email</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxEmail" CssClass="auto-style4" ErrorMessage="Email required"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" CssClass="auto-style4" ErrorMessage=" Enter a valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxPass" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPass" CssClass="auto-style4" ErrorMessage="Password required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Confirm Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxPassC" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style15">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxPassC" CssClass="auto-style4" ErrorMessage="Confirm Password is required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style16">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPass" ControlToValidate="TextBoxPassC" CssClass="auto-style4" ErrorMessage="Confirm Password is different to password"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    Name</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxCName" runat="server" Width="210px"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxCName" CssClass="auto-style4" ErrorMessage="Customer Name required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    Address</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxCAddress" runat="server" CssClass="auto-style13" Width="210px"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxCAddress" CssClass="auto-style4" ErrorMessage="Customer Address required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    Card Name</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxCCName" runat="server" Width="210px"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxCCName" CssClass="auto-style4" ErrorMessage="Card Name required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    Card No</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxCCNo" runat="server" Width="210px"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxCCNo" CssClass="auto-style4" ErrorMessage="Card Number required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    Card Expire</td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBoxCCExpire" runat="server" Width="210px"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBoxCCExpire" CssClass="auto-style4" ErrorMessage="Card expire date required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go Back"  CausesValidation="false" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Change Customer Data" Width="235px" />
                </td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
