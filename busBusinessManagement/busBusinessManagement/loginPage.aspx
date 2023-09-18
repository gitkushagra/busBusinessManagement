<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginPage.aspx.cs" Inherits="busBusinessManagement.loginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <h2>Login Portal</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <br />
                        Username: 
                        <br />
                    </td>
                    <td>
                        <asp:TextBox ID="username" runat="server" Width="321px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                        Password:<br />
&nbsp;</td>
                    <td>
                        <asp:TextBox ID="password" runat="server" Width="323px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
                        <asp:Button ID="login" runat="server" Text="LOGIN" OnClick="login_Click" Width="448px" />
                    </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="HOME" Width="452px" />
    </form>
</body>
</html>
