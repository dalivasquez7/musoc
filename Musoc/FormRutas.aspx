<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormRutas.aspx.cs" Inherits="Musoc.FormRutas" %>

<!DOCTYPE html>
<link rel="stylesheet" href="Content/StyleSheet.css" />

<html xmlns="http://www.w3.org/1999/xhtml">

<body>
    <form id="form1" runat="server">
        <div class="menu-wrap">
            <nav class="menu">
                <ul class="clearfix">
                    <li><a href="index.html">Inicio</a> </li>
                    <li><a href="FormRutas.aspx">Rutas y Horario</a> </li>
                    <li><a href="FormCompras.aspx">Compra de boletos</a></li>
                </ul>
            </nav>
        </div>


        <div class="grid">
            <legend style="color: #7BC143">Rutas y horarios</legend>
            <table>
                <tr>
                    <td>Origen:</td>
                    <td>
                        <select style="width: 150px" id="cbxOrigen" runat="server">
                            <option value="San Jose">San Jose</option>
                            <option value="San Isidro">San Isidro</option>
                        </select>
                    <td>Destino:</td>
                    <td>
                        <select style="width: 150px" id="cbxDestino" runat="server">
                              <option value="San Isidro">San Isidro</option>
                            <option value="San Jose">San Jose</option>
                        </select>
                    </td>
                    <td>
                        <asp:Button Text="Buscar" class="btn btn-success" ID="btnBuscar" runat="server" OnClick="BotonBuscar_click" />
                    </td>
                </tr>
            </table>
        </div>
        <div class="grid">
            <table>
                <tr>
                    <td>
                        <asp:GridView ID="GridRutas" class="gridEstilo"  runat="server">
                            <SelectedRowStyle BackColor="#7BC143" />
                        </asp:GridView>

            </table>
        </div>


    </form>
</body>
</html>
