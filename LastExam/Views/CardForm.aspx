<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CardForm.aspx.cs" Inherits="LastExam.Views.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://getbootstrap.com/docs/5.3/assets/css/docs.css" rel="stylesheet" />
    <title>Bootstrap Example</title>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="../JS/JS.js"></script>
</head>

<body>
    <div class="container">
        <nav class="navbar bg-dark" data-bs-theme="dark" style="width: stretch">
            <div class="container-fluid">
                <h1 class="navbar-brand" style="align-content: center">Create new card</h1>
            </div>
        </nav>
    </div>
    <form class="row g-3" method="post" id="Form1" runat="server">
        <div class="col-md-6">
            <label for="inputEmail4" class="form-label">Nombre del representante</label>
            <input type="text" runat="server" class="form-control" id="Name">
        </div>
        <div class="col-md-6">
            <label for="inputEmail4" class="form-label">Numero de la tarjeta</label>
            <input type="number" runat="server" class="form-control" id="CardNumber">
        </div>
        <div class="col-md-6">
            <label for="inputEmail4" class="form-label">Fecha de expiración</label>
            <input type="date" runat="server" class="form-control" id="date">
        </div>
        <div class="col-md-6">
            <label for="inputEmail4" class="form-label">Código CVV</label>
            <input type="number" runat="server" class="form-control" id="CVV">
        </div>
        <div class="col-md-6">
            <label for="inputPassword4" class="form-label">Color de la tarjeta</label>
            <select runat="server" class="form-select" id="Color" aria-label="Default select example">
                <option selected>Seleccione el color de la tarjeta</option>
                <option value="1">Rojo</option>
                <option value="2">Negro</option>
                <option value="3">Blanco</option>
                <option value="4">Azul</option>
                <option value="5">Verde</option>
            </select>
        </div>
        <div class="col-md-6">
            <label for="inputEmail4" class="form-label">Banco</label>
            <select runat="server" id="Banco" class="form-select" aria-label="Default select example">
                <option selected>Seleccione un banco</option>
                <option value="1">Banco Promerica</option>
                <option value="2">Banco de Costa Rica</option>
                <option value="3">BAC Credomatic</option>
            </select>
        </div>
        <div class="col-md-6">
            <label for="inputEmail4" class="form-label">Emisor</label>
            <select runat="server" id="Emisor" class="form-select" aria-label="Default select example">
                <option selected>Seleccione un emisor</option>
                <option value="1">Visa</option>
                <option value="2">MasterCard</option>
            </select>
        </div>

        <br>
        <button type="button" class="btn btn-dark" style="max-width: auto" runat="server" onserverclick="CreateCard_ServerClick">Create Card</button>
        <!-- Modal -->
        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="exampleModalLabel">
                            <label id="lblModalTitle"></label>
                        </h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <label id="lblModalMessage"></label>
                    </div>
                    <div class="modal-footer">
                        <button type="button" runat="server" onserverclick="btnModal_ServerClick" id="btnModal" class="btn btn-primary" data-bs-dismiss="modal">Ok</button>
                    </div>
                </div>
            </div>
        </div>
    </form>



</body>
</html>
