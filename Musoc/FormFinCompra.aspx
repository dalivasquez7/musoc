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
                <legend>Información de Compra</legend>
                <table>
                    <tr>
                        <td class="tdsFin">Monto a pagar:</td>
                        <td class="tdsFin">
                      <input id="montoTotal" runat="server" /></td>
                       
                    </tr>
                    <tr>
                        <td class="tdsFin">Nombre que aparece en la tarjeta: </td>
                        <td class="tdsFin">
                            <input type="text" name="nombre" required="required" /></td>
                    </tr>
                    <tr>
                        <td class="tdsFin">Numero de Tarjeta:</td>
                        <td class="tdsFin">
                            <input name="numTarjeta" min="0/" required="required" placeholder="XXXXXXXXXXXXXXXXX" title="Introduzca valor nuúmerico" pattern="^[0-9]$"></td>
                    </tr>
                    <tr>
                        <td class="tdsFin">Fecha de Vencimiento:</td>
                        <td class="tdsFin">
                            <input type="month" name="expDate" required="required"></td>
                    </tr>
                    <tr>
                        <td class="tdsFin">Codigo de Seguridad:</td>
                        <td class="tdsFin">
                            <input  name="codTarjeta" min="0" max="999" required="required" placeholder="XXX"></td>
                    </tr>
                    <tr>
                        <td class="tdsFin">Email:</td>
                        <td class="tdsFin">
                            <input type="email" name="email" required="required" placeholder="ejemplo@corre.com"/></td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td class="tds">
                            <asp:Button type="submit" Text="Finalizar Compra" value="Comprar" ID="btnFinComprar" runat="server" OnClick="BotonFinCompra_click" /></td>
                        <td class="tds">
                           <asp:Button Text="Cancelar" value="Comprar" ID="btnCancelar" runat="server" OnClick="Click_Cancelar" /></td>
                    </tr>
                </table>
            </fieldset>
        </div>
    </form>
</body>
</html>
