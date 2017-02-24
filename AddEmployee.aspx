<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="TCS.EmpMgmtLayering.UI.AddEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Basic Salary"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtBasicSalary" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Variable Allowance"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtVariableAllowance" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Submit" OnClick="btnSave_Click"></asp:Button></td>
                <td>
                    <asp:Button ID="btnReset" runat="server" Text="Reset"></asp:Button></td>
            </tr>
            <tr><td colspan="2"><asp:Button ID="btnBackToList" runat="server" Text="Back" OnClick="btnBackToList_Click"></asp:Button></td></tr>
        </table>
    </form>
</body>
</html>
