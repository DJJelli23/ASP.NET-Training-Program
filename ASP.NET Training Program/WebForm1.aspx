<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.NET_Training_Program.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Training Demo</title>
    <script language="javascript" type="text/javascript">
        // <![CDATA[
        function GetHiddenFieldData()
        {
            alert('EmployeeID = ' + document.getElementById('HiddenField1').value);
        }
        function Button3_onclick()
        {
            GetHiddenFieldData();
        }
        //]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--Hidden Field in ASP.NET - Part 34--%
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <table>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Department</td>
                    <td>
                        <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" /></td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Load Employee" OnClick="Button2_Click" />&nbsp;<input id="Button3" type="button" value="button" /></td>
                </tr>
            </table>
            --%>

        </div>
    </form>
</body>
</html>
