<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnAddress.aspx.cs" Inherits="todaysWorks.AnAddress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <label for="txtHouseNo">House No:</label>
       <input type="text" id="txtHouseNo" name="txtHouseNo"><asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br>
       <label for="street">Street:</label>
       <input type="text" id="txtStreet" name="street"><br>   
       <label for="town">Town:</label>
       <input type="text" id="txtTown" name="town"><br>
       <label for="postalcode">Postal Code:</label>
       <input type="text" id="txtPostalCode" name="postalcode"><br>
       <label for="country">Country:</label>
       <input type="text" id="txtCounty" name="country"><br>
       <label for="dateAdded">Date Added:</label>
       <input type="text" id="txtDateAdded" name="dateAdded"><br>
       <input type="radio" id="active" name="active" value="active">
       <label for="active">Active</label><br>
            
       <asp:Button id="button1" runat="server" Text="OK" OnClick="btnOK_Click" />
    </form>
</body>
</html>
