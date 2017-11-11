<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BooksForm.aspx.cs" Inherits="WebProject.BooksForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Книги</h1>
    <form id="form" runat="server">
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
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "ID") %>' Runat="server"/></td>
                            <td><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Book_title") %>' Runat="server"/></td>
                            <td><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Book_genre") %>' Runat="server"/></td>
                            <td><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Book_release") %>' Runat="server"/></td>
                            <td><asp:Label Text='<%# DataBinder.Eval(Container.DataItem, "Book_Author") %>' Runat="server"/></td>
                        </tr>
                    </ItemTemplate>
            </asp:Repeater>
        </table>
    </form>
</body>
</html>
