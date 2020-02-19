<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebApplication1.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h3><%: Title %></h3>

    <asp:Panel ID="Panel1" runat="server" BackColor="Gray" BorderStyle="Ridge" BorderColor="#0000CC" 
        CssClass="container text-center" Height="640px" Width="1500px">

    <br />
    <asp:GridView ID="gvProducts" AutoPostBack="true" runat ="server" CellPadding="4" 
        OnSelectedIndexChanged="gvProducts_SelectedIndexChanged"
         CssClass= "table table-bordered text-center" ForeColor="#333333" GridLines="None" EditRowStyle-Width="250">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" VerticalAlign="Middle" Width="250px" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
     </asp:GridView>
    <br />
    <asp:Button ID="btShowAll" AutoPostBack="true" runat="server" Text="Show all products" OnClick="btShowAll_Click"
                    CausesValidation="false" CssClass="btn btn-primary" Font-Bold="True" Height="50px" Width="250px" />

    <br />
         <br />
    <br />
    <asp:DropDownList ID="ddlChooseProduct" AutoPostBack="true" runat="server" 
        OnSelectedIndexChanged="ddlChooseProduct_SelectedIndexChanged" 
         CssClass="btn btn-primary dropdown-toggle dropdown-toggle-split"  Width="350px" Height="50px"></asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lbPrice" runat="server" Text="Price" BackColor="#CCCCCC" CssClass="text-center"
        Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="250px" BorderStyle="Ridge"></asp:Label>
    <br />
    <asp:TextBox ID="tbPrice" AutoPostBack="true" runat="server" OnTextChanged="tbPrice_TextChanged" 
        CssClass="form-control container text-center" Height="50px" Width="250px" BackColor="Gray" BorderStyle="Ridge" 
        Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="White" BorderColor="White"></asp:TextBox>
    <br />
    <asp:Label ID="lbQuantity" runat="server" Text="Quantity" 
        BackColor="#CCCCCC" Font-Bold="True" Font-Size="Medium" 
        ForeColor="White" Height="30px" Width="250px" BorderStyle="Ridge" CssClass="text-center"></asp:Label>
    <br />
    <asp:TextBox ID="tbQuantity" AutoPostBack="true" runat="server" CssClass="form-control container text-center" 
        Height="50px" Width="250px" BackColor="Gray" BorderStyle="Ridge" Font-Bold="True" 
        Font-Italic="True" BorderColor="White" Font-Size="Medium" ForeColor="White"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvQuantity" runat="server" 
                                ErrorMessage="Obavezno polje: quantity"
                                Text =""
                                ControlToValidate="tbQuantity"
                                ></asp:RequiredFieldValidator>
    <asp:ValidationSummary ID="vsProduct" runat="server" />

    <br />
    <br />
        <asp:Button ID="btConfirm" AutoPostBack="true" runat="server" Text="BUY" OnClick="btConfirm_Click" 
            CssClass="btn btn-primary" Height="50px" Width="250px" Font-Bold="True" />
        <br />
         <asp:Label ID="lbInfo" runat="server" Text="Odabrali ste sledeci proizvod" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="250px" CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>
        <br />
        <asp:TextBox ID="tbInform" AutoPostBack="true" TextMode="MultiLine" runat="server" 
            CssClass="form-control container text-center" Height="90px" Width="350px" ForeColor="White" 
            OnTextChanged="tbInform_TextChanged" 
            BackColor="Gray" BorderColor="White" BorderStyle="Ridge"></asp:TextBox>
        <br />
        <asp:Button ID="btConfirmBuy" AutoPostBack="true" runat="server" Text="CONFIRM" 
            OnClick="btConfirmBuy_Click" CssClass="btn btn-primary" Height="50px" Width="250px" Font-Bold="True"  />
        <br />
        <br />

     </asp:Panel>

</asp:Content>
