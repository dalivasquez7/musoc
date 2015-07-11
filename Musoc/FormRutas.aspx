<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormRutas.aspx.cs" Inherits="Musoc.FormRutas" %>

<!DOCTYPE html>
<link rel="stylesheet" href="Content/StyleSheet.css" />

<html xmlns="http://www.w3.org/1999/xhtml">

<body>
    <form id="form1" runat="server">
        <div class="menu-wrap">
            <nav class="menu">
                <ul class="clearfix">
                    <li><a href="Inicio.aspx">Inicio</a> </li>
                    <li><a href="FormRutas.aspx">Rutas y Horario</a> </li>
                    <li><a href="FormCompras.aspx">Compra de boletos</a></li>
                </ul>
            </nav>
        </div>

       
            <div class="grid">
                 <fieldset class="fieldStilo">
            <legend>Rutas y horarios</legend>
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
                        <td class="tds">
                            <asp:Button Text="Buscar" class="btn btn-success" ID="btnBuscar" runat="server" OnClick="BotonBuscar_click" />
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
