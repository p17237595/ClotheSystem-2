<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="todaysWorks._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:ListBox ID="ListBox1" runat="server" Height="409px" Width="856px"></asp:ListBox>
    </div>
    <div>
         <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
         <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    

    </div>


</asp:Content>
