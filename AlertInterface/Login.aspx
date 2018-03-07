<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AlertInterface.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>
    <br />
    Username&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    Wachtwoord&nbsp;&nbsp;&nbsp;&nbsp; :
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Height="28px" Text="Button" Width="142px" />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</asp:Content>
