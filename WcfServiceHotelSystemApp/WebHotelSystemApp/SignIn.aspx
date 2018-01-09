<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WebHotelSystemApp.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:azure">
    <form id="form1" runat="server">
        <div style="text-align: center">
            <br/><br/><br/><br/>
            <asp:Button ID="Button1" runat="server" Text="Szukaj pokoju" OnClick="Button1_Click"
                PostBackUrl="~/SearchRoom.aspx"/>
            <asp:Button ID="Button2" runat="server" Text="Historia rezerwacji" /> 
        </div>
    </form>
</body>
</html>
