<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="VBCRUD.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox ID="txtFirstName" class="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Second Name"></asp:Label>
    <asp:TextBox ID="txtSecondName" class="form-control" runat="server"></asp:TextBox>

    <br />
    <asp:Label ID="Label3" runat="server" Text="Phone Number"></asp:Label>
    <asp:TextBox ID="txtPhoneNumber" class="form-control" runat="server"></asp:TextBox>

    <br />
    <asp:Label ID="Label4" runat="server" Text="Employee Type"></asp:Label>
    <asp:DropDownList ID="ddlEmployeeType" class="dropdown-toggle" runat="server" DataSourceID="dsEmployeeType" DataTextField="Definition" DataValueField="Code"></asp:DropDownList>
    <asp:SqlDataSource ID="dsEmployeeType" runat="server" ConnectionString="<%$ ConnectionStrings:TestCRUD_DBConnectionString %>" SelectCommand="SELECT * FROM [EmployeeType]"></asp:SqlDataSource>
    <br />
    <br />
    <br />
    <asp:Button ID="Button2" class="btn btn-secondary" runat="server" Text="Cancel" />
    <asp:Button ID="Button3" runat="server" class="btn btn-danger" Text="Delete" />
    <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Save Changes" OnClientClick="return fieldValidation();"/>
</asp:Content>
