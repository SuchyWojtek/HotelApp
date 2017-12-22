<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebHotelSystemApp.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:azure">
    <form id="form1" runat="server">
        <div>
        </div>
        <div style="text-align:center">
            <asp:Label ID="Label1" runat="server" Text="Login:"></asp:Label>
            <asp:TextBox ID="txbLog" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txbPass" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label3" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="txbName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label4" runat="server" Text="Surname:"></asp:Label>
            <asp:TextBox ID="txbSurname" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label5" runat="server" Text="Date of birth:"></asp:Label>
            <asp:TextBox ID="txbDate" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label6" runat="server" Text="Male:"></asp:Label>
            <asp:TextBox ID="txbMale" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label7" runat="server" Text="Address:"></asp:Label>
            <asp:TextBox ID="txbAddress" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label8" runat="server" Text="Post Code:"></asp:Label>
            <asp:TextBox ID="txbPostCode" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnConfirmData" runat="server" Text="Confirm" OnClick="btnConfirmData_Click" />
        </div>
    </form>
</body>
</html>
