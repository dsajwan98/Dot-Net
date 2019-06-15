         <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditRegistrationData.aspx.cs" Inherits="__.EditRegistrationData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Registration Data
    </title>
</head>
<body>
   <div>
       <h1>
           Edit Registration Data
       </h1>
  <form id="form1" runat="server">
       
    <div>
        <h1>Registration Form</h1>
    </div>
    <div>
        <table>
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" MaxLength="50" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstname" runat="server" ErrorMessage="Please insert firstname" ControlToValidate="txtFirstName" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidatorLastname" runat="server" ErrorMessage="Please insert lastname" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>User Name</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidatorUsername" runat="server" ErrorMessage="Please insert username" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtPassword"  runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="Please insert Password" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Email ID</td>
                <td>
                    <asp:TextBox ID="txtEmailId" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Please insert Email" ControlToValidate="txtEmailId"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>State</td>
                <td>
                    <asp:DropDownList ID="DDstate" runat="server" style="margin-left: 0px" AutoPostBack="True" OnSelectedIndexChanged="DDstate_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <asp:DropDownList ID="DDcity" runat="server" style="margin-left: 0px" AutoPostBack="True" OnSelectedIndexChanged="DDcity_SelectedIndexChanged">
                        <asp:ListItem>Select City</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Pincode</td>
                <td>
                    <asp:TextBox ID="txtPin" runat="server" Enabled="False" ></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButton ID="rdbMale" Text="Male" GroupName="gender" runat="server"></asp:RadioButton>
                    <asp:RadioButton ID="rdbFemale" Text="Female" GroupName="gender" runat="server"></asp:RadioButton>
                </td>
            </tr>
             <tr>
                <td>Programming</td>
                <td>
                    <asp:CheckBox ID="chbJava" Text="Java" runat="server"></asp:CheckBox>
                    <asp:CheckBox ID="chbDotNet" Text="DotNet" runat="server"></asp:CheckBox>
                    <asp:CheckBox ID="chbPython" Text="Python" runat="server"></asp:CheckBox>
                    <asp:CheckBox ID="chbCpp" Text="C++" runat="server"></asp:CheckBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" style="height: 26px" />
                    <asp:Label ID="lblUpdate" runat="server" Text="" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
     </div>
    </form>

   </div>
</body>
</html>
