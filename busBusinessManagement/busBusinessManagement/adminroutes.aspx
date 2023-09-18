<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminroutes.aspx.cs" Inherits="busBusinessManagement.adminroutes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 166px;
        }
        .auto-style2 {
            margin-left: 114px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td> <b>ADD ROUTES:</b> </td>
                </tr>
                <tr>
                    <td> Enter Route Number: </td>
                    <td>
                        <asp:TextBox ID="routeno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td> Enter Source: </td>
                    <td>
                        <asp:TextBox ID="sourceloc" runat="server" Width="320px"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td> Enter Destination: 
                        <br />
                    </td>
                    <td>
                        <asp:TextBox ID="destination" runat="server" Width="325px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td> Enter Cost:</td>
                    <td>
                        <asp:TextBox ID="cost" runat="server" OnTextChanged="cost_TextChanged" Width="322px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    
                </tr>
            </table>
        </div>
        <p>
                        <asp:Button ID="addroutebtnm" runat="server" Text="ADD ROUTE" CssClass="auto-style2" Width="265px" OnClick="addroutebtnm_Click" />
                        <asp:Button ID="removeroutebtn" runat="server" Text="REMOVE ROUTE" CssClass="auto-style1" OnClick="removeroutebtn_Click" />
                    </p>
    </form>
    <p>
        NOTE: Please enter route number to remove a route.</p>
</body>
</html>
