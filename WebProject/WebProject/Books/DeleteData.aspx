<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteData.aspx.cs" Inherits="WebProject.Books.DeleteData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Удаление</title>
    <style> body {
     position: center;
 }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Удалить?</h1>
        <a href="BooksForm.aspx"><asp:Button ID="Yes" runat="server" Height="60px" Text="Да" Width="87px" OnClick="acceptDeleting" /></a>
        <a href="BooksForm.aspx"><asp:Button ID="No" runat="server" Height="60px" Text="Нет" Width="99px" OnClick="cancelDeleting" /></a>
    </div>
    </form>
    </body>
</html>
