<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCompras.aspx.cs" Inherits="Musoc.FormCompras" %>

<!DOCTYPE html>
<html>
<head>
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
                <legend>Rutas</legend>
                <table>
                    <tr>
                        <td class="tds">Origen:</td>
                        <td class="tds">
                            <select style="width: 150px" id="cbxOrigen" runat="server">
                                <option value="San Jose">San Jose</option>
                                <option value="San Isidro">San Isidro</option>
                            </select>
                        </td>
                        <td class="tds">Destino:</td>
                        <td class="tds">
                            <select style="width: 150px" id="cbxDestino" runat="server">
                                <option value="San Isidro">San Isidro</option>
                                <option value="San Jose">San Jose</option>
                            </select>
                        </td>
                        <td class="tds">Hora:</td>
                        <td class="tds">
                            <select style="width: 150px" id="cbxHora" runat="server"></select>
                        </td>
                </table>
            </fieldset>
        </div>

        <!--BUS-->

        <div id="#section">
            <fieldset class="fieldStilo">
                <legend>Asientos</legend>
                <h5>Elija los asientos haciendo click sobre el asiento:</h5>
                <div id="bus">
                    <ul id="lugar">
                    </ul>
                </div>
                <div style="float: left;">
                    <ul id="DescripcionAsiento">
                        <li style="background: url('images/available_seat_img.gif') no-repeat scroll 0 0 transparent;">Asiento Disponible</li>
                        <li style="background: url('images/booked_seat_img.gif') no-repeat scroll 0 0 transparent;">Asiento Reservado</li>
                        <li style="background: url('images/selected_seat_img.gif') no-repeat scroll 0 0 transparent;">Asiento Seleccionado</li>
                    </ul>
                </div>
                <div style="clear: both; width: 100%">
                    <input type="button" id="btnShowNew" value="Mostrar Asientos Seleccionados" />
                    <input type="button" id="btnShow" value="Mostrar Todos" />
                </div>
            </fieldset>
        </div>
    </form>
</body>
</html>
