<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BooksForm.aspx.cs" Inherits="WebProject.BooksForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Книги</title>
    <style type="text/css">
        #Submit1 {
            width: 271px;
            height: 63px;
        }
        .auto-style1 {
            width: 362px;
        }
        .auto-style3 {
            height: 161px;
        }
    </style>
</head>
<body>
    <h1>Книги</h1>
    <form id="formHome" runat="server">
    <div></div>
        <table>
            <asp:Repeater ID="repeaterBook" runat="server"
                onitemdatabound="RepeaterItemDataBound">
                    <HeaderTemplate>
                        <tr>
                            <th>№</th>
                            <th>Заголовок</th>
                            <th>Жанр</th>
                            <th>Дата выхода</th>
                            <th>Автор</th>
                            <th>Удаление</th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "ID") %>' Runat="server"/></td>
                            <td><a href="EditData.aspx"><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Book_title") %>' Runat="server"/></a></td>
                            <td><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Book_genre") %>' Runat="server"/></td>
                            <td><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Book_release") %>' Runat="server"/></td>
                            <td><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Book_Author") %>' Runat="server"/></td>
                            <td><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/Books/cross.png" OnClick="deleteData"/></td>
                        </tr>
                    </ItemTemplate>
            </asp:Repeater>
        </table>
        <h2>Добавить книгу</h2>
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
            <asp:Button id="AddBook" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Height="48px" OnClick="insertData" Text="Добавить книгу" Width="159px" />
        </p>
    </form>
</body>
</html>
