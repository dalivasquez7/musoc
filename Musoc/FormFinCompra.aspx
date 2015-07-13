<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormFinCompra.aspx.cs" Inherits="Musoc.FormFinCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="Content/StyleSheet.css" />
    <script type="text/javascript" src="scripts/jquery-1.4.1.min.js"></script>
    <script type="text/javascript" src="scripts/script.js"></script>
</head>

<body>
    <form id="form1" runat="server">
        <div class="menu-wrap">
            <div class="logo">
                <h1 class="logoFont">MUSOC</h1>
            </div>
            <nav class="menu">
                <ul class="clearfix">
                    <li><a href="Inicio.aspx">Inicio</a> </li>
                    <li><a href="FormRutas.aspx">Rutas y Horario</a> </li>
                    <li><a href="FormCompras.aspx">Compra de boletos</a></li>
                </ul>
            </nav>
        </div>
        <div id="#section">
            <fieldset class="fieldStilo">
                <legend>Comprador</legend>
                <p>
                    Monto a pagar:
                    <asp:TextBox ID="txtMonto" runat="server" ReadOnly="true"></asp:TextBox>
                    Nombre que aparece en la tarjeta:
                    <br>
                    <input type="text" name="nombre" /><br>
                    <br>
                    Numero de Tarjeta:
                    <br>
                    <input type="number" name="numTarjeta" min="0/"><br />
                    <br />
                    Fecha de Vencimiento:
                    <br>
                    <input type="month" name="expDate"><br>
                    <br>
                    Codigo de Seguridad:
                    <br>
                    <input type="number" name="codTarjeta" min="0" max="999" /><br>
                    <br>
                    Email:
                    <br>
                    <input type="email" name="email" /><br>
                    <br>
                    <asp:Button Text="Finalizar Compra" value="Comprar" id="btnFinComprar" runat="server" OnClick="BotonFinCompra_click" />
          
                    <input type="reset">
                </p>
            </fieldset>
        </div>
    </form>
</body>
</html>
