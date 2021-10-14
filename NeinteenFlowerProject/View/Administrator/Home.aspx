<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NeinteenFlowerProject.View.Administrator.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Admin Home Page</h3>
    <asp:Label ID="WelcomeLbl" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="manageMemberBtn" runat="server" Text="Manage Member" OnClick="manageMemberBtn_Click" />
    <asp:Button ID="manageEmployeeBtn" runat="server" Text="Manage Employee" OnClick="manageEmployeeBtn_Click" />
</asp:Content>
