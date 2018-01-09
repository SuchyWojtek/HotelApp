<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HistoryOfReservation.aspx.cs" Inherits="WebHotelSystemApp.HistoryOfReservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Historia rezerwacji</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body style="background-color:azure">
    <form id="form1" runat="server">
        <div>

        </div>
        <div>
            <table class="table">
            <thead>
              <tr>
                <th>roomId</th>
                <th>Begin date</th>
                <th>End date</th>
              </tr>
            </thead>
            <tbody>
                <tr>
                    <td><% Response.Write(ids()); %></td>
                    <td><% Response.Write(begin()); %></td>
                    <td><% Response.Write(end()); %></td>
                </tr>
            </tbody>
                </table>
        </div>
    </form>
</body>
</html>
