<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="insertFlower.aspx.cs" Inherits="NeinteenFlowerProject.View.insertFlower" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Insert Flower</h3>
    <br />
    <div>
        <asp:Label ID="Label" runat="server" Text="Flower Name : "></asp:Label>
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <asp:Label ID="errName" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label2" runat="server" Text="Flower Image : "></asp:Label>
        <asp:FileUpload ID="filePic" AllowMultiple="false" runat="server" />
        <asp:Label ID="errImg" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label3" runat="server" Text="Flower Description: "></asp:Label>
        <asp:TextBox ID="tbDesc" runat="server"></asp:TextBox>
        <asp:Label ID="errDesc" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label4" runat="server" Text="Flower Type: "></asp:Label>
        <asp:DropDownList ID="dlType" runat="server"></asp:DropDownList>
        <asp:Label ID="errType" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <div>
        <asp:Label ID="Label5" runat="server" Text="Flower Price: "></asp:Label>
        <asp:TextBox ID="tbPrice" runat="server" TextMode="number"></asp:TextBox>
        <asp:Label ID="errPrice" runat="server" Text=""></asp:Label>
    </div>
    <br />
    <br />
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Insert Flower" OnClick="btnSubmit_Click" />
    </div>
</asp:Content>
