<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="NeinteenFlowerProject.View.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Forgot Password Page</h3>
    <br />

    <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
    <br />
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    <asp:Label ID="errorEmail" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="captcha" runat="server" Text="Captcha: "></asp:Label>
    <asp:Label ID="captchaLbl" runat="server" Text=""></asp:Label>
    <br />
    <asp:TextBox ID="captchaTxt" runat="server"></asp:TextBox>
    <asp:Label ID="errorCaptcha" runat="server" Text=""></asp:Label>
    <br />
    <br />

    <asp:Label ID="NewPasswordLbl" runat="server" Text="New Password"></asp:Label>
    <br />
    <asp:TextBox ID="NewPasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Label ID="errorNewPassword" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="ForgotPasswordBtn" runat="server" Text="Submit" OnClick="ForgotPasswordBtn_Click" />
    <asp:Label ID="errorForgotPassword" runat="server" Text=""></asp:Label>
</asp:Content>
