<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditData.aspx.cs" Inherits="WebProject.Books.EditData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Редактирование</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Меню редактирования</h1>
        <table class="auto-style1">
            <tr>
                <th>Заголовок</th>
                <th>Жанр</th>
                <th>Дата выхода</th>
                <th>Автор</th>
             </tr>
            <tr>
                <td><asp:TextBox ID="Title" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="Genre" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="Release" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="Author" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        
        <p>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Исправить" />

        </p>
    </div>
    </form>
</body>
</html>
