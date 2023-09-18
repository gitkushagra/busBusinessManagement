<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBookings.aspx.cs" Inherits="busBusinessManagement.ViewBookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Bookings</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 90px;
        }
        .auto-style2 {
            margin-left: 139px;
        }
        .auto-style3 {
            margin-left: 68px;
        }
    </style>
    <h2>My Bookings</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td> Here is the list of your bookings: </td>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>Enter Your Username: </td>
                    <td>
                        <asp:TextBox ID="usernametext" runat="server" Width="280px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="displaybookings" runat="server" Text="VIEW BOOKINGS" CssClass="auto-style1" OnClick="displaybookings_Click" />
                    </td>
                </tr>
                
              
            </table>
        </div>
                        <asp:GridView ID="bookingslist" runat="server" Height="600px" OnSelectedIndexChanged="bookingslist_SelectedIndexChanged" Width="975px"></asp:GridView>
        <br />
        To cancel any bookings, please provide following details along with your username:<br />
        <br />
        Source city name:
        <asp:TextBox ID="sourcecity" runat="server" Width="302px"></asp:TextBox>
        <br />
        <br />
        Destination city name:
        <asp:TextBox ID="destinationcity" runat="server" Width="354px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="cancelbookingbtn" runat="server" CssClass="auto-style2" OnClick="cancelbookingbtn_Click" Text="CANCEL BOOKING" Width="235px" />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style3" OnClick="Button1_Click" Text="HOME" Width="170px" />
    </form>
</body>
</html>
