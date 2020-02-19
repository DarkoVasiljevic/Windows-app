<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="WebApplication1.categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3><%: Title %></h3>
    
    <asp:Panel ID="Panel1" runat="server" BackColor="Gray" BorderStyle="Ridge" BorderColor="#0000CC" 
        CssClass="container text-center" Height="630px" Width="1500px">
       
     <br />           
            <asp:GridView ID="gvShowAll" runat="server" OnSelectedIndexChanged="gwShowAll_SelectedIndexChanged" Font-Italic="True"  
                CssClass= "table table-bordered text-center" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#0099FF" Font-Bold="True" ForeColor="Black" CssClass="text-center" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#EFF3FB"  />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
          
            <br />
            <p>
                <asp:Button ID="btShowALL" runat="server" Text="Show all categories" OnClick="btShowALL_Click1" 
                    HorizontalAlign="Left" 
                    CssClass="btn btn-primary" Height="50px" Width="250px" />
            </p>
                <br /> 
                <br />
             <div>               
                 <asp:DropDownList ID="ddlCategories" runat="server"
                     CssClass="btn btn-primary dropdown-toggle dropdown-toggle-split" 
                     OnSelectedIndexChanged="ddlCategories_SelectedIndexChanged" Height="50px" Width="350px" 
                     AutoPostBack="True"></asp:DropDownList>
               </div>    
                 <br />
                
                 <asp:Label ID="lbCategoryId" runat="server" Text="Category id" CssClass="label-default text-center" 
                     Font-Size="Medium"  BorderStyle="Ridge" Height="30px" Width="250px" 
                     ForeColor="White" BackColor="#CCCCCC" Font-Bold="True"></asp:Label>
                 <br />
                 <asp:TextBox ID="tbCategoryId" runat="server" OnTextChanged="tbCategoryId_TextChanged"
                            CssClass="form-control container text-center" Height="50px" Width="250px" BackColor="Gray" BorderStyle="Ridge" 
                            Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="White" 
                            BorderColor="White"></asp:TextBox>
                 <br />
                 <asp:Label ID="lbCategoryName" runat="server" Text="Category name" BorderStyle="Ridge" 
                     CssClass="label-default text-center"  Height="30px" Width="250px" Font-Size="Medium" 
                     BackColor="#CCCCCC" ForeColor="White" Font-Bold="True"></asp:Label>
                 <br />
                 <asp:TextBox ID="tbCategoryName" runat="server" OnTextChanged="tbCategoryName_TextChanged"
                             CssClass="form-control container text-center" Height="50px" Width="250px" BackColor="Gray" BorderStyle="Ridge" 
                             Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="White" 
                             BorderColor="White"></asp:TextBox>
                 <br />
                 <asp:Label ID="lbCategoryDesc" runat="server" Text="Category description" BorderStyle="Ridge" 
                     CssClass="label-default text-center" Font-Size="Medium" Height="30px" Width="250px" 
                     BackColor="#CCCCCC" ForeColor="White" Font-Bold="True"></asp:Label>
                 <br />
                 <asp:TextBox ID="tbCtegoryDesc" runat="server" OnTextChanged="tbCtegoryDesc_TextChanged" 
                    CssClass="form-control container text-center" Height="50px" Width="250px" BackColor="Gray" BorderStyle="Ridge" 
                    Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="White" BorderColor="White"></asp:TextBox>
                   <br /> <br />
    </asp:Panel>

</asp:Content>
