<%@ Page Title="Registartion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Registration.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br/>
    <br/>
     <asp:Panel ID="Panel1" runat="server" BackColor="Gray" BorderStyle="Ridge" BorderColor="#0000CC" 
        CssClass="container text-center" Height="630px" Width="1500px">

    <br/>
    <br/>
        
    <asp:Label ID="lbUserName" runat="server" Text="FIRST NAME" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" 
                Width="250px" CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>
            
    <asp:TextBox ID="tbFirstName" runat="server" CssClass="form-control container text-center" 
                Height="30px" Width="250px" ForeColor="White" 
                BackColor="Gray" BorderColor="White" BorderStyle="Ridge" OnTextChanged="tbFirstName_TextChanged" 
                  ></asp:TextBox>
    
    <asp:RequiredFieldValidator ID="rvUserName" runat="server" 
                                ControlToValidate="tbFirstName"
                                ErrorMessage="Reqiured"></asp:RequiredFieldValidator>
    <br/>
    <br/>
    <asp:Label ID="lbPasswd" runat="server" Text="LAST NAME" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="250px" 
            CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>
    
         <asp:TextBox ID="tbLastName" runat="server" 
                CssClass="form-control container text-center" Height="30px" Width="250px" ForeColor="White" 
                BackColor="Gray" BorderColor="White" BorderStyle="Ridge" OnTextChanged="tbLastName_TextChanged" ></asp:TextBox>
    <asp:RequiredFieldValidator ID="rvPasswd" runat="server" 
                                ControlToValidate="tbLastName"
                                ErrorMessage="Reqiured"></asp:RequiredFieldValidator>
    
    <br/>
         <asp:Button ID="btRegEmployee" runat="server" Text="REGISTER - EMPLOYEE" 
         CssClass="btn btn-primary" Height="50px" Width="250px" Font-Bold="True" OnClick="btRegEmployee_Click" />
    <br/><br/>
         <asp:Label ID="lbInfo" runat="server" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="350px" 
             CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>
    
    <br/><br/>
    <br/><br/>

    <asp:Label ID="lbCustomer" runat="server" Text="CONTACT NAME" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" 
                Width="250px" CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>
            
    <asp:TextBox ID="tbCustomer" runat="server" CssClass="form-control container text-center" 
                Height="30px" Width="250px" ForeColor="White" 
                BackColor="Gray" BorderColor="White" BorderStyle="Ridge" OnTextChanged="tbCustomer_TextChanged" 
                  ></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfReg" runat="server" 
                                ControlToValidate="tbCustomer"
                                ErrorMessage="Reqiured"></asp:RequiredFieldValidator>
         
    <br/>
    <br/>

          <asp:Button ID="btRegCustomer" runat="server" Text="REGISTER - CUSTOMER" 
         CssClass="btn btn-primary" Height="50px" Width="250px" Font-Bold="True" 
              OnClick="btRegCustomer_Click" />

          <br/><br/>
         <asp:Label ID="lbInfoCustomer" runat="server" BackColor="#CCCCCC"
             Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="30px" Width="450px" 
             CssClass="text-center" 
             BorderColor="White" BorderStyle="Ridge"></asp:Label>

 </asp:Panel>

</asp:Content>
