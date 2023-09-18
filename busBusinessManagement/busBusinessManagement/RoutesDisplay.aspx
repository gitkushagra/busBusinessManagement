<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoutesDisplay.aspx.cs" Inherits="busBusinessManagement.RoutesDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Available Routes</title>
    <style type="text/css">
        #home {
            width: 558px;
            margin-left: 51px;
        }
    </style>
    <h2>All Available Routes</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>We are continuously adding new Routes. You can also suggest us the route that can be added. Most demanding routes will be in action!</p>
            <p><a class="btn btn-default" href="http://localhost:51937/FeedbacklForm.aspx">Please fill out the form here &raquo;</a></p>   
            <br />
            <br />
            <asp:GridView ID="routesGrid" runat="server" OnSelectedIndexChanged="routesGrid_SelectedIndexChanged" Height="338px" Width="1293px"></asp:GridView>
            <br />
            <input id="home" type="button"  onclick="window.location.href='/Home/Index';" value="HOME" />
            <input id="home" type="button"  onclick="window.location.href='/loginPage.aspx';" value="LOGIN" /><br />
            <br />
            &nbsp;</div>
    </form>
</body>
</html>
