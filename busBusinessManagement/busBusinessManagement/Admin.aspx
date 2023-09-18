<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="busBusinessManagement.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 126px;
        }
        .auto-style3 {
            margin-left: 89px;
        }
        .auto-style4 {
            margin-left: 548px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td> Manage Bookings: </td>
                    <td>
                        <asp:GridView ID="showbookings" runat="server" Height="434px" Width="670px" OnSelectedIndexChanged="showbookings_SelectedIndexChanged"></asp:GridView>
                        <br />
                    </td>
                </tr>
                <tr>
                     <td> 
                         &nbsp;</td>
                    <td>
                        <asp:Button ID="deletebtn" runat="server" Text="DELETE BOOKING" CssClass="auto-style1" Width="285px" OnClick="deletebtn_Click" />

                        <br />

                        <br />

                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td> Manage Buses: </td>
                    <td>
                        <asp:GridView ID="showbusesinfo" runat="server" Height="332px" Width="665px" OnSelectedIndexChanged="showbusesinfo_SelectedIndexChanged"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td> 
                        <asp:Button ID="managebuses" runat="server" Text="MANAGE BUSES" OnClick="managebuses_Click" />
                    </td>
                </tr>
                <tr>
                    <td> Feedbacks: </td>
                    <td>
                        <asp:GridView ID="feedbackshow" runat="server" Height="345px" Width="657px"></asp:GridView>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td> Please enter username to delete feedback: </td>
                    <td>
                        <asp:TextBox ID="feedbackuser" runat="server" Width="195px"></asp:TextBox>
                        <asp:Button ID="deletefeedbackbtn" runat="server" Text="REMOVE FEEDBACK" CssClass="auto-style3" Width="346px" OnClick="deletefeedbackbtn_Click" />
                    </td>
                    <td>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td> Manage Routes: </td>
                    <td>
                        <asp:GridView ID="routesview" runat="server" Height="346px" Width="652px"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="manageroutesbtn" runat="server" Text="MANAGE ROUTES" OnClick="manageroutesbtn_Click" />
                    </td>
                </tr>
                <tr>
                    <td> Total Earnings: </td>
                    <td>
                        <asp:TextBox ID="earningstxt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td><b>ADD ADMIN: </b></td>
                </tr>
                <tr>
                    <td>Username: </td>
                    <td>
                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password: </td>
                    <td>
                        <asp:TextBox ID="password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="admincreateaccount" runat="server" Text="CREATE ADMIN CREDENTIAL" Width="279px" OnClick="admincreateaccount_Click" />
                    </td>
                </tr>
                <tr>
                    <td> Following button will delete admin credential if any other credential is available.</td>
                    <td>
                        <asp:Button ID="deleteAdmin" runat="server" Text="REMOVE THIS CREDENTIAL" OnClick="deleteAdmin_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style4" OnClick="Button1_Click" Text="HOME" Width="261px" />
    </form>
</body>
</html>
