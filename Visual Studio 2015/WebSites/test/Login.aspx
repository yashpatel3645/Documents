<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left:40%;margin-top:20%">
    <form id="form1" runat="server">
    <table>
        <tr>
            <td>Enrollment : </td>
            <td><asp:TextBox runat="server" ID="enroll" ></asp:TextBox></td>
            <td><asp:RequiredFieldValidator runat="server" ID="rfvenroll" ControlToValidate="enroll" ErrorMessage="Please Enter Enrollment Number." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            <td><asp:RegularExpressionValidator runat="server" ID="revenroll" ControlToValidate="enroll" ValidationExpression="\d{12}" ErrorMessage="Please Enter 12 Digit Enrollment Number." Text="*" ForeColor="Red"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td>Passwrod : </td>
            <td><asp:TextBox runat="server" ID="pass" TextMode="Password"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator runat="server" ID="rfvpass" ControlToValidate="pass" ErrorMessage="Enter the password." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" ID="btnopen" Text="Login" OnClick="btnopen_Click" />
            </td>
            <td><asp:ValidationSummary runat="server" ID="vsbtn" /></td>
        </tr>
    </table>
    </form>
</body>
</html>