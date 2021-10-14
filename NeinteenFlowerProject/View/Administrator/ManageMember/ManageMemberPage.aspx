<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ManageMemberPage.aspx.cs" Inherits="NeinteenFlowerProject.View.AdminPage.ManageMember.ManageMemberPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Manage Member Page</h3>
    <br />
    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/View/Administrator/ManageMember/InsertMemberPage.aspx" >Insert Member</asp:HyperLink>
    </div>
    <br />
    <br />
    <asp:GridView ID="gvMember" runat="server" AutoGenerateColumns="False" OnRowEditing="gvMember_RowEditing" OnRowDeleting="gvMember_RowDeleting" >
        <Columns>
            <asp:BoundField DataField="MemberID" HeaderText="ID" />
            <asp:BoundField DataField="MemberName" HeaderText="Name" />
            <asp:BoundField DataField="MemberDOB" HeaderText="DOB" DataFormatString="{0:d}" />
            <asp:BoundField DataField="MemberGender" HeaderText="Gender" />
            <asp:BoundField DataField="MemberAddress" HeaderText="Address" />
            <asp:BoundField DataField="MemberPhone" HeaderText="Phone Number" />
            <asp:BoundField DataField="MemberEmail" HeaderText="Email" />
            <asp:BoundField DataField="MemberPassword" HeaderText="Password" />
            <asp:CommandField HeaderText="Action" ShowDeleteButton="true" ShowEditButton="true" />
        </Columns>
    </asp:GridView>
</asp:Content>
