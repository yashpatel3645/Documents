<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
        <tr>
            <td>Name : </td>
            <td><asp:TextBox runat="server" ID="txtid"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator runat="server" ID="rfvtext" ControlToValidate="txtid"
                 ErrorMessage="Please add Name" Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Birthdate : </td>
            <td><asp:TextBox runat="server" ID="birth" TextMode="Date"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="birth"
                 ErrorMessage="Please Select Birthdate" Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Contact : </td>
            <td><asp:TextBox runat="server" ID="cont"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="cont"
                 ErrorMessage="Please add Name" Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            <td><asp:RegularExpressionValidator runat="server" ID="revcont" ControlToValidate="cont"
ValidationExpression="d{10}" Text="*" ForeColor="Red"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td>Password : </td>
            <td><asp:TextBox runat="server" ID="pass" TextMode="Password"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="txtid"
                 ErrorMessage="Please Enter Password" Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Re Password : </td>
            <td><asp:TextBox runat="server" ID="pass2"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator runat="server" ID="repass" ControlToValidate="txtid"
                 ErrorMessage="Please Enter Password" Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            <td><asp:CompareValidator runat="server" ID="comp" ControlToValidate="pass2" ControlToCompare="pass"
                 ErrorMessage="Password Not Match" Text="*" ForeColor="Red"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td>Email : </td>
            <td><asp:TextBox runat="server" ID="email"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldVal" ControlToValidate="txtid"
                 ErrorMessage="Please Enter Password" Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            <td><asp:RegularExpressionValidator runat="server" ID="RequiredFieldValidator4" ControlToValidate="email" 
                ValidationExpression="/W+@+[a-z].[a-z]" Text="*" ForeColor="Red"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td>Country : </td>
            <td><asp:TextBox runat="server" ID="txtcon" ></asp:TextBox></td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator5" ControlToValidate="txtcon"
                 ErrorMessage="Please Enter Contry" Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td><asp:Button ID="btn" runat="server"></asp:Button> </td>
            <td><asp:ValidationSummary runat="server" ForeColor="Red"></asp:ValidationSummary></td>
        </tr>
    </table>
    </form>
</body>
</html>
