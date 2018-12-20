<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ex13.aspx.cs" Inherits="ADO_DEMO.ex13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 34px;
        }
    </style>
</head>
<body>
    <h1>What is SqlCommandBuilder</h1>
    <p>&nbsp;</p>
    <form id="form1" runat="server">
    <div style="font-family: Arial">
        
        <table border="1">
            <tr>
                <td>Student ID</td>
                <td>
                    <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
                    <asp:Button ID="btnGetStudent" runat="server" Text="Load" OnClick="btnGetStudent_Click" />
                </td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:DropDownList ID="ddlGender" runat="server">
                        <asp:ListItem Text="Select Gender" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Total Marks</td>
                <td>
                    <asp:Textbox ID="txtTotalMarks" runat="server"></asp:Textbox>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style1">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" onclick="btnUpdate_Click" />
                    <asp:Label ID="lblStatus" runat="server" Font-Bold="true"></asp:Label>
                </td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
