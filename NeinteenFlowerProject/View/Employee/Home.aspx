<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NeinteenFlowerProject.View.Employee.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Employee Home Page</h3>
    <asp:Label ID="WelcomeLbl" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="manageBtn" runat="server" Text="Manage Flower Button" OnClick="manageBtn_Click" />

</asp:Content>
