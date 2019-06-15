<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="__.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>login form</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>LOGIN</h1>
    <table>
        <tr>
            <td>email Id</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
         <tr>
            <td>password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
            </tr>
         <tr>
            <td>
                <asp:Button ID="btnlogin" runat="server" Text="LOGIN" OnClick="btnlogin_Click" /></td>
            <td>
                <asp:Button ID="Btnsignup" runat="server" Text="SIGNUP" OnClick="Btnsignup_Click" />
                <asp:Label ID="Lblmessage" runat="server" Text=""></asp:Label>
            </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>