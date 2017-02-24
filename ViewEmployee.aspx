<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewEmployee.aspx.cs" Inherits="TCS.EmpMgmtLayering.UI.ViewEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnAdd" runat="server" Text="Add New Employee" OnClick="btnAdd_Click" />
        <asp:GridView ID="gvEmpDetails" runat="server" AutoGenerateColumns="false" OnRowCommand="gvEmpDetails_RowCommand" >
            <Columns>
                <asp:TemplateField HeaderText="Sr No." ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="Employee ID" DataField="EmployeeID" />
                <asp:BoundField HeaderText="Employee Name" DataField="EmployeeName" />
                <asp:BoundField HeaderText="Basic Salary" DataField="BasicSalary" ItemStyle-HorizontalAlign="Right" />
                <asp:BoundField HeaderText="Variable Allowance" DataField="VariableAllowance" ItemStyle-HorizontalAlign="Right" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="cmdEdit" CommandArgument='<%# Eval("Employeeid") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="cmdDelete" CommandArgument='<%# Eval("Employeeid") %>' OnClientClick="return confirm('Are you sure you want to delete?')" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
