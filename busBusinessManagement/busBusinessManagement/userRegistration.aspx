<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userRegistration.aspx.cs" Inherits="busBusinessManagement.userRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 2px;
        }
    </style>
    <h2>Registeration Portal</h2>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Username: </td>
                    <td>
                      <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                    <td>
                     <asp:Button ID="checkusername" runat="server" Text="Check!" OnClick="checkusername_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Password: </td>
                    <td>
                        <asp:TextBox ID="password" runat="server" OnTextChanged="password_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Name: </td>
                    <td>
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Age: </td>
                    <td>
                        <asp:TextBox ID="age" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender: </td>
                    <td>
                        <asp:DropDownList ID="gender" runat="server" OnSelectedIndexChanged="gender_SelectedIndexChanged">
                            <asp:ListItem Value="M">Male</asp:ListItem>
                            <asp:ListItem Value="F">Female</asp:ListItem>
                            <asp:ListItem Value="O">Other</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>

            <br />
      
           <asp:Button ID="createaccount" runat="server" Text="Create Account" OnClick="createaccount_Click" />
            <br />
            <br />
            <asp:Button ID="loginbtn" runat="server" CssClass="auto-style1" OnClick="loginbtn_Click" Text="LOGIN" Width="198px" />
            <p>If you are not satisfied with our service, or have some issue with our service. We recommond you to please fill out oue feedback form.</p>
            <p><a class="btn btn-default" href="http://localhost:51937/FeedbacklForm.aspx">Please fill out the form here &raquo;</a></p>   
            <br />
            <p style="color:red">If you want to delete your account. Just enter your username and press below button..</p>
            <asp:Button ID="deleteAccount" runat="server" Text="Delete" OnClick="deleteAccount_Click" />
            <p>Please note that action is irreversible and all data linked to you will be vanished. However you can create a freah account with the username if not taken later by others.</p>
        </div>
    </form>
</body>
</html>
