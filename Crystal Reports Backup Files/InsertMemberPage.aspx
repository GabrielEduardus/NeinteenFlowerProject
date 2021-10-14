<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="InsertMemberPage.aspx.cs" Inherits="NeinteenFlowerProject.View.AdminPage.ManageMember.InsertMemberPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Insert Member Page</h3>
    <br />
    <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
    <br />
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    <asp:Label ID="errorEmail" runat="server" Text=""></asp:Label>
    <br />
    <br />

    <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
    <br />
    <asp:TextBox ID="passwordTxt" runat="server" type="password" ></asp:TextBox>
    <asp:Label ID="errorPassword" runat="server" Text=""></asp:Label>
    <br />
    <br />

    <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
    <br />
    <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    <asp:Label ID="errorName" runat="server" Text=""></asp:Label>
    <br />
    <br />

    <asp:Label ID="ageLbl" runat="server" Text="Age"></asp:Label>
    <br />
    <asp:TextBox ID="ageTxt" runat="server" TextMode="Date" ></asp:TextBox>
    <asp:Label ID="errorAge" runat="server" Text=""></asp:Label>
    <br />
    <br />

    <asp:Label ID="radioLbl" runat="server" Text="Gender"></asp:Label>
    <br />
    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender" />
    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender" />
    <asp:Label ID="errorGender" runat="server" Text=""></asp:Label>
    <br />
    <br />

    <asp:Label ID="phoneNumberLbl" runat="server" Text="Phone Number"></asp:Label>
    <br />
    <asp:TextBox ID="phoneNumberTxt" runat="server" ></asp:TextBox>
    <asp:Label ID="errorPhoneNumber" runat="server" Text=""></asp:Label>
    <br />
    <br />

    <asp:Label ID="addressLbl" runat="server" Text="Address"></asp:Label>
    <br />
    <asp:TextBox ID="addressTxt" runat="server" ></asp:TextBox>
    <asp:Label ID="errorAddress" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />

    <div>
        <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
    </div>
    <br />
</asp:Content>
