<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Preorder.aspx.cs" Inherits="NeinteenFlowerProject.View.Member.Preorder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Preorder Page</h3>
    <br />
    <br />

    <asp:Label ID="quantityLbl" runat="server" Text="Quantity"></asp:Label>
    <br />
    <asp:TextBox ID="quantityTxt" runat="server"></asp:TextBox>
    <asp:Label ID="errorQuantity" runat="server" Text=""></asp:Label>    
    <br />
    <br />

    <asp:Button ID="preorderBtn" runat="server" Text="Preorder" OnClick="preorderBtn_Click" />
</asp:Content>
