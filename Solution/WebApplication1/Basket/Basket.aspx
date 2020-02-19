<%@ Page Title="Basket" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Basket.aspx.cs" Inherits="WebApplication1.Basket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3><%: Title %></h3>

    <asp:Panel ID="Panel1" runat="server" BackColor="Gray" BorderStyle="Ridge" BorderColor="#0000CC" 
        CssClass="container text-center" Height="630px" Width="1500px">

    <br />
    <br />
    <asp:Label ID="lbInfo" runat="server" Text="U korpi tenutno imate sledece proizvode" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="450px" CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gvProductsToBuy" AutoPostBack="true" runat ="server" CellPadding="4" 
        ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvProductsToBuy_SelectedIndexChanged"
        CssClass= "table table-bordered text-center">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

    <br />
    <br />
    <asp:Label ID="lbTotalCost" runat="server" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="450px" CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btAddToBase" runat="server" Text="CONFIRM TO BASE" OnClick="btAddToBase_Click" 
        CssClass="btn btn-primary" Height="50px" Width="250px" Font-Bold="True"/>

        <asp:Button ID="btBackToProducts" runat="server" Text="Back to Products" 
        CssClass="btn btn-primary" Height="50px" Width="250px" Font-Bold="True" OnClick="btBackToProducts_Click"/>

    <br />
    <br />

     <asp:Label ID="lbSuccessBuy" runat="server" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="450px" CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"
         Text="Uspesno ste potvrdili kupovinu!"></asp:Label>

         </asp:Panel>

</asp:Content>
