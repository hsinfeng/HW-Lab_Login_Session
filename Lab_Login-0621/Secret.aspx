<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Secret.aspx.cs" Inherits="Secret" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    Content for member only.</p>
<p>
    <asp:Button ID="LogOutButton" runat="server" OnClick="LogOutButton_Click" Text="Logout" Width="98px" />
    <br />
</p>
<p>
</p>
</asp:Content>

