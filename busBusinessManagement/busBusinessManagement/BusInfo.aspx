<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusInfo.aspx.cs" Inherits="busBusinessManagement.BusInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bus Information</title>
    <style type="text/css">
        #home {
            width: 502px;
            margin-left: 105px;
        }
        .auto-style1 {
            margin-left: 188px;
        }
        .auto-style2 {
            width: 255px;
            margin-left: 145px;
        }
    </style>
    <h2>Buses We Offer</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>We promise our bus will be your comfortable zone for your journey!</p>
            Non- AC buses:<br />
            <br />
            <asp:GridView ID="businfogrid" runat="server" Height="309px" Width="1213px" OnSelectedIndexChanged="businfogrid_SelectedIndexChanged"></asp:GridView>
            <br />
            AC Buses:<br />
            <asp:GridView ID="acbuseslist" runat="server" Height="230px" OnSelectedIndexChanged="acbuseslist_SelectedIndexChanged" Width="1204px">
            </asp:GridView>
            <br />
            <br />
            <input id="homekey" type="button" onclick="window.location.href='/Home/Index';" value="HOME" class="auto-style2" />
            <asp:Button ID="loogin" runat="server" Text="LOGIN" CssClass="auto-style1" OnClick="loogin_Click" Width="323px" />
            
            <br />
            &nbsp;</div>
        </div>
    </form>
</body>
</html>
