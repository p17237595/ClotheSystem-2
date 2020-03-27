<%@ Page Language="C#" Inherits="todayWorks.AnAddress" AutoEventWireup="true" CodeBehind="AnAddress.aspx.cs"   %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>AnAddress</title>
</head>
<body>
	<form id="form1" runat="server">
       <label for="txtHouseNo">House No:</label>
       <input type="text" id="txtHouseNo" name="txtHouseNo"><br>
       <label for="street">Street:</label>
       <input type="text" id="street" name="street"><br>   
       <label for="town">Street:</label>
       <input type="text" id="town" name="town"><br>
       <label for="postalcode">Postal Code:</label>
       <input type="text" id="postalcode" name="postalcode"><br>
       <label for="country">Country:</label>
       <input type="text" id="country" name="country"><br>
       <label for="dateAdded">Date Added:</label>
       <input type="text" id="dateAdded" name="dateAdded"><br>
       <input type="radio" id="active" name="active" value="active">
       <label for="active">Active</label><br>
            
       <asp:Button id="button1" runat="server" Text="OK" OnClick="btnOK_Click" />
            
	</form>
</body>
</html>
