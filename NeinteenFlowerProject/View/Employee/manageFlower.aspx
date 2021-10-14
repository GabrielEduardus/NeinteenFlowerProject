<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="manageFlower.aspx.cs" Inherits="NeinteenFlowerProject.View.manageFlower" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h3>Manage Flower</h3>
        </div>
        <div>
            <asp:HyperLink ID="insertHyperLink" runat="server" NavigateUrl="~/View/Employee/insertFlower.aspx" >Insert Item</asp:HyperLink>
        </div>
    <br />
        <div>
            <asp:GridView ID="gvItem" runat="server" AutoGenerateColumns="False" OnRowEditing ="gvItem_RowEditing" OnRowDeleting="gvItem_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="FlowerId" HeaderText="Flower Id" />
                    <asp:BoundField DataField="FlowerName" HeaderText="Flower Name" />
                    <asp:BoundField DataField="MsFlowerType.FlowerTypeName" HeaderText="Flower Type" />
                    <asp:BoundField DataField="FlowerDescription" HeaderText="Flower Description"/>
                    <asp:BoundField DataField="FlowerPrice" HeaderText="Flower Price" />
                    <asp:ImageField DataImageUrlField="FlowerImage" HeaderText="Flower Image" ControlStyle-Width="200" ControlStyle-Height = "200">
                    </asp:ImageField>
                    <asp:CommandField HeaderText="Action" ShowEditButton="true" ShowDeleteButton="true" />
                </Columns>
               
            </asp:GridView>
        </div>
</asp:Content>
