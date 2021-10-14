<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NeinteenFlowerProject.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Login Page</h3>
    <br />

    <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
    <br />
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    <asp:Label ID="errorEmail" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
    <br />
    <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password" ></asp:TextBox>
    <asp:Label ID="errorPassword" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:CheckBox ID="RememberMeCheck" runat="server" Text="Remember Me"/>
    <br />
    <br />
    <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
    <asp:Label ID="errorLogin" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:HyperLink ID="RegisterHyperLink" runat="server" NavigateUrl="~/View/Guest/Register.aspx">Register</asp:HyperLink>
    <br />
    <asp:HyperLink ID="ForgotPassHyperLink" runat="server" NavigateUrl="~/View/Guest/ForgotPassword.aspx">Forgot Password</asp:HyperLink>
</asp:Content>
