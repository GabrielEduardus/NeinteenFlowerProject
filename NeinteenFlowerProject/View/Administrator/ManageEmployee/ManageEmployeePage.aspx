<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="ManageEmployeePage.aspx.cs" Inherits="NeinteenFlowerProject.View.AdminPage.ManageEmployee.ManageEmployeePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Manage Employee Page</h3>
    <br />
    <div>
        <asp:HyperLink ID="insertHyperLink" runat="server" NavigateUrl="~/View/Administrator/ManageEmployee/InsertEmployeePage.aspx" >Insert Employee</asp:HyperLink>
    </div>
    <br />
    <br />
    <asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="False" OnRowEditing="gvEmployee_RowEditing" OnRowDeleting="gvEmployee_RowDeleting" >
        <Columns>
            <asp:BoundField DataField="EmployeeID" HeaderText="ID" />
            <asp:BoundField DataField="EmployeeName" HeaderText="Name" />
            <asp:BoundField DataField="EmployeeDOB" HeaderText="DOB" DataFormatString="{0:d}" />
            <asp:BoundField DataField="EmployeeGender" HeaderText="Gender" />
            <asp:BoundField DataField="EmployeeAddress" HeaderText="Address" />
            <asp:BoundField DataField="EmployeePhone" HeaderText="Phone Number" />
            <asp:BoundField DataField="EmployeeEmail" HeaderText="Email" />
            <asp:BoundField DataField="EmployeeSalary" HeaderText="Salary" />
            <asp:BoundField DataField="EmployeePassword" HeaderText="Password" />
            <asp:CommandField HeaderText="Action" ShowDeleteButton="true" ShowEditButton="true" />
        </Columns>
    </asp:GridView>
</asp:Content>
