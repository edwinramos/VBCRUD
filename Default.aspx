<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="VBCRUD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div align="center" style="background-color: lightgreen; font-size: xx-large">
        CRUD ASP.NET VB
    </div>
    <br />
    <div style="padding: 15px;">
        <div align="center">
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Add New" />
            <hr />
            <asp:GridView ID="GridView1" runat="server" Width="80%" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="dsEmployees" OnRowEditing="GridView1_RowEditing">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" Visible="False" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="SecondName" HeaderText="SecondName" SortExpression="SecondName" />
                    <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
                    <asp:BoundField DataField="EmployeeType" HeaderText="EmployeeType" SortExpression="EmployeeType" />
                    <asp:ButtonField CommandName="Edit" Text="Edit" />
                </Columns>
                <HeaderStyle BackColor="LightGreen" />
            </asp:GridView>
            <asp:SqlDataSource ID="dsEmployees" runat="server" ConnectionString="<%$ ConnectionStrings:TestCRUD_DBConnectionString %>" ProviderName="<%$ ConnectionStrings:TestCRUD_DBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Employee]"></asp:SqlDataSource>
        </div>
    </div>
    
</asp:Content>
