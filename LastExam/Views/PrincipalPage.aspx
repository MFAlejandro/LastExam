<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrincipalPage.aspx.cs" Inherits="LastExam.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
    <title>My Cards</title>
    <link rel="stylesheet" href="../CSS/Style.css" />
</head>
<body>

    <form id="form1" runat="server">

        <div id="navs" class="container">
            <nav class="navbar bg-dark" data-bs-theme="dark">
                <div class="container-fluid">
                    <h1 class="navbar-brand">My cards</h1>
                    <a class="navbar-brand" href="../Views/CardForm.aspx">Add new +</a>
                </div>
            </nav>
        </div>

        <asp:Repeater runat="server" ID="repCards" OnItemDataBound="repCards_ItemDataBound">
            <ItemTemplate>

                <div id="card" class="<%# Eval("Color")%>">
                    <div class="card-header"><%# Eval("Banco")%></div>
                    <div class="card-body">
                        <h1 class="navbar-brand"><%# Eval("Name")%></h1>
                        <asp:Label ID="lblCardNumber" runat="server" Text='<%# Eval("CardNumber")%>'></asp:Label>
                        <img id="img" src="<%# Eval("Emisor")%>" alt="image" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>




    </form>
</body>
</html>
