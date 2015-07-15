<script>

    var settings = {
        rows: 4,
        cols: 15,
        rowCssPrefix: 'row-',
        colCssPrefix: 'col-',
        seatWidth: 35,
        seatHeight: 35,
        seatCss: 'asiento',
        selectedSeatCss: 'AsientoSeleccionado',
        selectingSeatCss: 'EligiendoAsiento'
    };

   var init= function(reservedSeat) {
        var str = [], seatNo, className;
        for (i = 0; i < settings.rows; i++) {
            for (j = 0; j < settings.cols; j++) {
                seatNo = (i + j * settings.rows + 1);
                className = settings.seatCss + ' ' + settings.rowCssPrefix + i.toString() + ' ' + settings.colCssPrefix + j.toString();
                if ($.isArray(reservedSeat) && $.inArray(seatNo, reservedSeat) != -1) {
                    className += ' ' + settings.selectedSeatCss;
                }
                str.push('<li class="' + className + '"' +
                          'style="top:' + (i * settings.seatHeight).toString() + 'px;left:' + (j * settings.seatWidth).toString() + 'px">' +
                              '<a title="' + seatNo + '">' + seatNo + '</a>' +
                          '</li>');
            }
        }
        $('#lugar').html(str.join(''));
        chargePerSheet = $('#txtMonto').val();
    };


    $('.' + settings.seatCss).live('click', function () {
        if ($(this).hasClass(settings.selectedSeatCss)) {
            alert('Este asiento ya est');
        }
        else {
            $(this).toggleClass(settings.selectingSeatCss);
        }
    });

    $('#btnComprar').click(function () {
        var str = [];
        $.each($('#lugar li.' + settings.selectingSeatCss + ' a'), function (index, value) {
            str.push($(this).attr('title'));
        });
        if (str.length > 0) {
            $('#txtMonto').val(str.length * chargePerSheet);
            $('#txtNumAsiento').val(str.join(','));
            //alert(str.join(','));
            //window.open("FormFinCompra.aspx");
        }

    })



</script>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCompras.aspx.cs" Inherits="Musoc.FormCompras" %>


<!DOCTYPE html>
<html>
<head>
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
                    <li><a href="FormRutas.aspx">Rutas & Horarios</a> </li>
                    <li><a href="FormCompras.aspx">Compra de boletos</a></li>
                </ul>
            </nav>
        </div>
        <div id="#section">
            <fieldset class="fieldBoleto">

                <table>
                    <tr>
                        <a href="">
                            <div id="alertAlerta" class="alert alert-danger fade in" runat="server" hidden="hidden">
                                <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
                                <strong>
                                    <asp:Label ID="labelTipoAlerta" runat="server" Text="Alerta! "></asp:Label></strong><asp:Label ID="labelAlerta" runat="server" Text="Mensaje de alerta"></asp:Label>
                            </div>
                        </a>
                    </tr>
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
                        <td class="tds">Día:</td>
                        <td class="tds">
                            <input id="diaSeleccionado" type="date" runat="server" autopostback="true" />
                        </td>
                        <td id="tdBoton"></td>
                        <td class="tds">
                            <asp:Button class="botonBuscar" Text="Horas Disponibles" ID="btnFechas" runat="server" OnClick="clickAgregarHora" /></td>
                    </tr>
                    <tr>
                        <td class="tds">Hora:</td>
                        <td class="tds">
                            <asp:DropDownList ID="listHora" runat="server" AutoPostBack="true" OnSelectedIndexChanged="clickMostrarAsientos"></asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
        <!--BUS-->

        <div id="#section">
            <fieldset class="fieldStilo">

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
                    <asp:TextBox ID="txtNumAsiento" runat="server" hidden="true"></asp:TextBox>
                </div>
                <div>
                    <asp:Button class="boton" Text="Siguiente" value="Comprar" ID="btnComprar" runat="server" OnClick="BotonComprar_click" />
                </div>
            </fieldset>
        </div>
    </form>
</body>
</html>
