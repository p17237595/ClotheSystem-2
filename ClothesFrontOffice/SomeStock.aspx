<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SomeStock.aspx.cs" Inherits="SomeStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
            <asp:Label ID="GenderLabel" runat="server" Text="Gender"></asp:Label>
            <asp:TextBox ID="GenderTxt" runat="server"></asp:TextBox>
            </p>
            <p>
            <asp:Label ID="SizeLabel" runat="server" Text="Size"></asp:Label>
            <asp:TextBox ID="SizeText" runat="server"></asp:TextBox>
            </p>
            <p>
            <asp:Label ID="DescriptionLabel" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="DescriptionText" runat="server"></asp:TextBox>
            </p>
            <p>
            <asp:Label ID="PriceLabel" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="PriceText" runat="server"></asp:TextBox>
            </p>
            <p>
            <asp:Label ID="InStockLabel" runat="server" Text="InStock"></asp:Label>
            <asp:CheckBox  ID="InStockCheck" runat="server" /></asp:CheckBox>
            </p>
            <p>
            <asp:Label ID="DateArrivedLabel" runat="server" Text="DateArrived"></asp:Label>
            <asp:TextBox ID="DateArrivedText" runat="server"></asp:TextBox>
            </p>
        </div>

        <div>
        <asp:Button ID="btnOK" runat="server" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
