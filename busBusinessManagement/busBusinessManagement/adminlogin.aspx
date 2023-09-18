<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="busBusinessManagement.adminlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 156px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            margin-left: 46px;
        }
        .auto-style4 {
            margin-left: 13px;
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td> ADMIN username: 
                        <asp:TextBox ID="adminuser" runat="server" CssClass="auto-style4" OnTextChanged="adminuser_TextChanged" Width="249px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td> ADMIN password: `<asp:TextBox ID="adminpass" runat="server" CssClass="auto-style2" OnTextChanged="adminpass_TextChanged" Width="255px"></asp:TextBox>
                        </td>
                    <td>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="adloginbtn" runat="server" Text="ADMIN LOGIN" CssClass="auto-style1" Width="198px" OnClick="adloginbtn_Click" />
                        <asp:Button ID="homebtn" runat="server" CssClass="auto-style3" OnClick="homebtn_Click" Text="HOME" Width="129px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
