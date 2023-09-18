<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="busBusinessManagement.Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book My Bus</title>
    <style type="text/css">
        .auto-style1 {
            width: 385px;
        }
        .auto-style4 {
            height: 39px;
        }
        .auto-style5 {
            height: 33px;
        }
        .auto-style6 {
            margin-left: 142px;
        }
        .auto-style7 {
            margin-left: 96px;
        }
        .auto-style8 {
            height: 32px;
        }
    </style>
    <h2>Book My Bus</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style1">Username: </td>
                    <td>
                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Fetch other details: </td>
                    <td>
                        <asp:Button ID="fetch" runat="server" Text="FETCH" OnClick="fetch_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Name: </td>
                    <td>
                        <input id="name" type="text" runat="server" disabled />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Age: </td>
                    <td>
                        <input id="age" type="text" runat="server" disabled />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Gender: </td>
                    <td>
                        <input id="gender" type="text" runat="server" disabled />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Select Source: </td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="sourcelist" runat="server" AutoPostBack="true" OnSelectedIndexChanged="sourcelist_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Select Destination: </td>
                    <td>
                        <asp:DropDownList ID="destinationList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="destinationList_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Select Bus:</td>
                    <td>
                        <asp:DropDownList ID="selectbus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="selectbus_SelectedIndexChanged"></asp:DropDownList>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>Choose Bus Type:</td>
                    <td>
                        <asp:DropDownList ID="bustype" runat="server" AutoPostBack="true" OnSelectedIndexChanged="bustype_SelectedIndexChanged"></asp:DropDownList>
                        <p>Please note AC bus costs additional 1000 Rupees. No additional cost for non-ac tier.</p>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Generated Route ID:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="storerouteid" runat="server" AutoPostBack="true" OnSelectedIndexChanged="storerouteid_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
                  <tr>
                    <td>Alloted Bus Number:</td>
                    <td>
                        <asp:DropDownList ID="storebusid" runat="server" AutoPostBack="true" OnSelectedIndexChanged="storebusid_SelectedIndexChanged"></asp:DropDownList>
                        
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Seats Available:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="seatsavailable" runat="server" AutoPostBack="true" OnSelectedIndexChanged="seatsavailable_SelectedIndexChanged"></asp:DropDownList>
                    </td>
                </tr>
               <tr>
                   <td> Total Price: </td>
                   <td>
                       <asp:TextBox ID="storeprice" runat="server"></asp:TextBox>
                   </td>
               </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>

            </table>
        </div>
        <p>
                        <asp:Button ID="submittostore" runat="server" Text="SUBMIT" CssClass="auto-style6" OnClick="submittostore_Click" Width="270px" />
                        <asp:Button ID="viewbookings" runat="server" Text="VIEW MY BOOKINGS" CssClass="auto-style7" OnClick="viewbookings_Click" />
                    </p>

    </form>
</body>
</html>
