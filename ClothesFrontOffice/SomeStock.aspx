<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SomeStock.aspx.cs" Inherits="SomeStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SomeStock</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
            <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            </p>
            <p>
            <asp:Label ID="lblSize" runat="server" Text="Size"></asp:Label>
            <asp:TextBox ID="txtSize" runat="server"></asp:TextBox>
            </p>
            <p>
            <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            </p>
            <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </p>
            <p>
            <asp:Label ID="lblInStock" runat="server" Text="InStock"></asp:Label>
            <asp:CheckBox  ID="chkInStock" runat="server" /></asp:CheckBox>
            </p>
            <p>
            <asp:Label ID="lblDateArrived" runat="server" Text="DateArrived"></asp:Label>
            <asp:TextBox ID="txtDateArrived" runat="server"></asp:TextBox>
            </p>
            <p>
            <asp:Label ID="lblActive" runat="server" Text="Active"></asp:Label>
            <asp:CheckBox  ID="chkActive" runat="server" /></asp:CheckBox>
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            </p>
        </div>

        <div>
        <asp:Button ID="btnOK" runat="server" Text="OK" />
        <asp:Button ID="btnFind" runat="server" Text="Find" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
