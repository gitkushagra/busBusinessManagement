<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminbus.aspx.cs" Inherits="busBusinessManagement.adminbus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 85px;
        }
        .auto-style2 {
            margin-left: 86px;
        }
        .auto-style3 {
            margin-left: 192px;
            margin-top: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td> <b>Add Bus: </b> </td>
                    </tr>
                <tr>
                    <td> Enter bus Number: </td>
                    <td>
                        <asp:TextBox ID="busid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td> Enter Bus Name: </td>
                    <td>
                        <asp:TextBox ID="busname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td> Enter Capacity: </td>
                    <td>
                        <asp:TextBox ID="capacity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td> Enter Source Location: </td>
                    <td>
                        <asp:DropDownList ID="slocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="slocation_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td> Enter Destination Location: </td>
                    <td>
                        <asp:DropDownList ID="dlocation" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td> Enter Available seats: </td>
                    <td>
                        <asp:TextBox ID="seatsnumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td> Choose Bus Type: </td>
                    <td>
                        <asp:DropDownList ID="bustype" runat="server">
                            <asp:ListItem>AC</asp:ListItem>
                            <asp:ListItem>Non-AC</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
                        <asp:Button ID="addbusbtn" runat="server" Text="ADD BUS" CssClass="auto-style1" Width="308px" OnClick="addbusbtn_Click" />
                    </p>

        <table>
            <tr>
                <td> Please enter bus number to delete a bus:</td>
                <td>
                    <asp:Button ID="deletebusbtn" runat="server" Text="REMOVE BUS" CssClass="auto-style2" Width="271px" OnClick="deletebusbtn_Click" />
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="backbtn" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="GO BACK" Width="272px" />
        </p>
    </form>
</body>
</html>
