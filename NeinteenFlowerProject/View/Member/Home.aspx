<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NeinteenFlowerProject.View.Member.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Member Home Page</h3>
    <asp:Label ID="WelcomeLbl" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <div>
            <asp:GridView ID="gvItem" runat="server" AutoGenerateColumns="False" OnRowEditing="gvItem_RowEditing" >
                <Columns>
                    <asp:BoundField DataField="FlowerId" HeaderText="Flower Id" />
                    <asp:BoundField DataField="FlowerName" HeaderText="Flower Name" />
                    <asp:BoundField DataField="MsFlowerType.FlowerTypeName" HeaderText="Flower Type" />
                    <asp:BoundField DataField="FlowerDescription" HeaderText="Flower Description"/>
                    <asp:BoundField DataField="FlowerPrice" HeaderText="Flower Price" />
                    <asp:ImageField DataImageUrlField="FlowerImage" HeaderText="Flower Image" ControlStyle-Width="200" ControlStyle-Height = "200">
<ControlStyle Height="200px" Width="200px"></ControlStyle>
                    </asp:ImageField>
                    <asp:CommandField HeaderText="Action" ShowEditButton="true" EditText="Preorder" />
                </Columns>
            </asp:GridView>
        </div>
    <br />
    <br />
    <asp:Button ID="viewTransactionBtn" runat="server" Text="View Transaction" OnClick="viewTransactionBtn_Click" />
</asp:Content>
