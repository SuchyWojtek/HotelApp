<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebHotelSystemApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:azure">
    <form id="form1" runat="server" style="text-align: center">
        <div>
        </div>
        <div style="text-align=center">
            <h1>Witaj na stronie Hotelu pod gołym niebem !</h1>
        </div>
        <div style="height: 262px">
            <br/><br/><br/>
            <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label2" runat="server" Text="Hasło"></asp:Label>
            <br/>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />
            <div style="align-items: baseline">
                <asp:Button ID="Button1" runat="server" Text="Zaloguj się" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Załóż konto" OnClick="Button2_Click"
                    PostBackUrl ="~/SignUp.aspx"/>
        </div>
        </div>
        
    </form>
</body>
</html>
