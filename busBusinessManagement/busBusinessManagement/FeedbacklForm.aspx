<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FeedbacklForm.aspx.cs" Inherits="busBusinessManagement.FeedbacklForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Feedback Form</title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
        }
        .auto-style2 {
            margin-left: 40px;
        }
    </style>
    <h2>Feedback Form</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style1">We welcome your feedback! Please provide any complaints/Suggestions. We promise, we care and its between us only.</td>
                </tr>
                <tr>
                    <td>Your UserName:<asp:TextBox ID="username" runat="server" style="margin-left: 29px" Width="892px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp; FeedBack :<asp:TextBox ID="feedback" runat="server" Height="119px" style="margin-left: 44px" Width="789px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="submitfeedback" runat="server" Text="Submit" OnClick="submitfeedback_Click" CssClass="auto-style2" Width="314px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
