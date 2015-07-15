<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormRutas.aspx.cs" Inherits="Musoc.FormRutas" %>

<!DOCTYPE html>
<head>
    <title></title>
    <link rel="stylesheet" href="Content/StyleSheet.css" />
</head>

<html xmlns="http://www.w3.org/1999/xhtml">

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
            <fieldset class="fieldStilo">
               
                <table id="tabla">
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
                        <td class="tds">
                            <asp:Button Text="Buscar" class="botonBuscar" ID="btnBuscar" runat="server" OnClick="BotonBuscar_click" />
                        </td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td>
                            <asp:GridView ID="GridRutas" class="Grid" runat="server">
                                <SelectedRowStyle BackColor="#7BC143" />
                            </asp:GridView>
                </table>
            </fieldset>
        </div>
    </form>
</body>
</html>
