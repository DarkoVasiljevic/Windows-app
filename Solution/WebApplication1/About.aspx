<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <br/>
    <br/>
    <asp:Button ID="btTestEvent" runat="server" Text="TEST EVENT" OnClick="btTestEvent_Click" 
         CssClass="btn btn-primary" Height="50px" Width="250px" Font-Bold="True"/>
    <br/>
    <br/>
    <asp:Label ID="lbEvent" AutoPostBack="true" runat="server" Text="Before we test event!"
        BackColor="#CCCCCC" Font-Bold="True" Font-Size="Medium" ForeColor="Black" 
        Height="30px" Width="450px" CssClass="text-center" 
        BorderColor="White" BorderStyle="Ridge"></asp:Label>

    <br/>
    <br/>

    <asp:TextBox ID="tbEvent" AutoPostBack="true"  runat="server"
        Height="100px" Width="450px"></asp:TextBox>
</asp:Content>
