<%@ Page Title="LogIN" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIN.aspx.cs" Inherits="WebApplication1.LogIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br/>
    <br/>
     <asp:Panel ID="Panel1" runat="server" BackColor="Gray" BorderStyle="Ridge" BorderColor="#0000CC" 
        CssClass="container text-center" Height="630px" Width="1500px">

    <br/>
    <br/>
    <asp:Label ID="lbUserName" runat="server" Text="USERNAME" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="250px" CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>

    <asp:TextBox ID="tbUserName" runat="server" CssClass="form-control container text-center" 
                Height="30px" Width="250px" ForeColor="White" 
                BackColor="Gray" BorderColor="White" BorderStyle="Ridge" OnTextChanged="tbUserName_TextChanged"  ></asp:TextBox>
    <asp:RequiredFieldValidator ID="rvUserName" runat="server" 
                                controltovalidate="tbUserName"
                                ErrorMessage=""></asp:RequiredFieldValidator>
    <br/>
    <br/>
    <asp:Label ID="lbPasswd" runat="server" Text="PASSWORD" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="250px" CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>
    
         <asp:TextBox ID="tbPasswd" runat="server" 
                CssClass="form-control container text-center" Height="30px" Width="250px" ForeColor="White" 
                BackColor="Gray" BorderColor="White" BorderStyle="Ridge" OnTextChanged="tbPasswd_TextChanged" ></asp:TextBox>
         <br/>
    <asp:RequiredFieldValidator ID="rvPasswd" runat="server" 
                                controltovalidate="tbPasswd"
                                ErrorMessage=""></asp:RequiredFieldValidator>
    <asp:ValidationSummary ID="vsLogIn" runat="server" 
                            BackColor="#CCCCCC"
                            Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" 
                            Width="350px" CssClass="form-control container text-center"
                            BorderColor="White" BorderStyle="Ridge"                 
                            HeaderText="Obavezna polja: username i password!" />
    <br/>
    <br/>
         <asp:CheckBox ID="cbRemeber" Text="Remember me" runat="server" />
    <br/>
    <asp:Button ID="btLogIn" runat="server" Text="LOG IN" OnClick="btLogIn_Click" 
         CssClass="btn btn-primary" Height="50px" Width="250px" Font-Bold="True" />
    <br/>
    <br/>
         <asp:LinkButton ID="lbRegister" runat="server" ForeColor="Black" Font-Bold="True"
             CausesValidation="false" PostBackUrl="~/Registration/Register.aspx">
             Click here to register</asp:LinkButton>
    <br/>
    <br/>
    <br/>
    <asp:Label ID="lbWarning" runat="server" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="50px" Width="350px" CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>
        <br/>
        <br/>
         <asp:Button ID="btFill_tblUsers" runat="server" Text="FILL USERS" OnClick="btFill_tblUsers_Click" />

         </asp:Panel>

</asp:Content>
