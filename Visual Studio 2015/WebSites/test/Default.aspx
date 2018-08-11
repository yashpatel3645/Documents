<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 52px;
        }
    </style>
</head>
<body style="width:auto ; height:auto; margin:0 30%">
    
    <form id="form1" runat="server">
        <div>
    <table>
        <tr>
            <td>Name:</td>
            <td><asp:TextBox runat="server" ID="txtname"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator runat="server" ID="rfvname" ControlToValidate="txtname" ErrorMessage="Please Enter Name." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Birthdate:</td>
            <td><asp:TextBox runat="server" ID="birth" TextMode="Date"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="birth" ErrorMessage="Please Select Birthdate." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>
        <tr>
            <td>Enrollment:</td>
            <td><asp:TextBox runat="server" ID="enroll"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="enroll" ErrorMessage="Please Enter Enrollment." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            <td><asp:RegularExpressionValidator runat="server" ID="revenroll" ControlToValidate="enroll" ValidationExpression="\d{12}" ErrorMessage="Please Enter Proper Enrollment." Text="*" ForeColor="Red"></asp:RegularExpressionValidator></td>
            
        </tr>
        <tr>
            <td>Email:</td>
            <td><asp:TextBox runat="server" ID="email"></asp:TextBox> </td>
            <td><asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="email" ValidationExpression="^[\w-\.]{1,}\@([\da-zA-Z-]{1,}\.){1,}[\da-zA-Z-]{2,6}$" ErrorMessage="Please Enter Proper Email." Text="*" ForeColor="Red"></asp:RegularExpressionValidator></td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator10" ControlToValidate="email" ErrorMessage="Please Enter Email." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Field:</td>
            <td><asp:TextBox runat="server" ID="field"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="field" ErrorMessage="Please Enter Field." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Semester:</td>
            <td><asp:TextBox runat="server" ID="sem"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator4" ControlToValidate="sem" ErrorMessage="Please Enter Semester." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Address:</td>
            <td><asp:TextBox runat="server" ID="add"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator5" ControlToValidate="add" ErrorMessage="Please Enter Address." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Contect:</td>
            <td><asp:TextBox runat="server" ID="contect"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator8" ControlToValidate="contect" ErrorMessage="Please Enter Field." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            <td><asp:RegularExpressionValidator runat="server" ID="revcon" ControlToValidate="contect" ValidationExpression="\d{10}" ErrorMessage="Enter 10 Digit Contect." Text="*"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td>Password:</td>
            <td><asp:TextBox runat="server" ID="pass" TextMode="Password"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator6" ControlToValidate="pass" ErrorMessage="Please Enter Address." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>ReEnter Password:</td>
            <td><asp:TextBox runat="server" ID="pass2" TextMode="Password"></asp:TextBox> </td>
            <td><asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator7" ControlToValidate="pass2" ErrorMessage="Please Enter Address." Text="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
            <td><asp:CompareValidator runat="server" ID="pass3" ControlToValidate="pass2" ControlToCompare="pass" ErrorMessage="Password Not match." Text="*" ForeColor="Red"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td class="auto-style1"><asp:Button runat="server" ID="btnsub" Text="Submit" BackColor="White" OnClick="btnsub_Click"></asp:Button> </td>
            <td class="auto-style1"><asp:ValidationSummary runat="server" ID="vsbtn"></asp:ValidationSummary></td>
        </tr>
    </table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [name], [birthdate], [enrollment], [email], [field], [contect], [address], [semester], [repassword], [password] FROM [registraion]"></asp:SqlDataSource>
    </div>
            </form>
    
</body>
</html>
