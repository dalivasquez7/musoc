<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormFin.aspx.cs" Inherits="Musoc.FormFin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="Content/StyleSheet.css" />
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
            <fieldset class="fieldStilo">
                <div>
                    <h2>Gracias por su compra. Se enviarán los boletos al correo: <asp:Label ID="lblCorreo"runat="server"/></h2>
                </div>               
            </fieldset>
        </div>
    </form>
</body>
</html>
