<%@ Page Title="" Language="C#" validateRequest="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="XML.aspx.cs" Inherits="WebApplication1.XML.XML" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br/>

    <asp:Label ID="lbReadXML" runat="server" Text="XML file" 
        BorderColor="Blue" BorderStyle="Double"></asp:Label>
      <br/>
    <asp:TextBox ID="tbReadXML" AutoPostBack="true" runat="server" 
        Height="240px" Width="640px"
        TextMode="MultiLine" BorderColor="Blue" BorderStyle="Double" OnTextChanged="tbReadXML_TextChanged"></asp:TextBox>
      <br/>
    <asp:Button ID="btReadXML" runat="server" Text="READ XML" OnClick="btReadXML_Click" />
      <br/><br/>
    <asp:Label ID="lbReadSchema" runat="server" Text="XML Schema"
        BorderColor="Blue" BorderStyle="Double"></asp:Label>
      <br/>
    <asp:TextBox ID="tbReadSchema" AutoPostBack="true" runat="server" 
        Height="240px" Width="640px"  TextMode="MultiLine"
        BorderColor="Blue" BorderStyle="Double" OnTextChanged="tbReadSchema_TextChanged"></asp:TextBox>
    <br/>
    <asp:Button ID="btReadSchema" runat="server" Text="READ SCHEMA" OnClick="btReadSchema_Click" />
      <br/>

</asp:Content>
