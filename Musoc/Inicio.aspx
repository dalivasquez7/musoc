<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Musoc.Inicio" %>

<!DOCTYPE html>
<link rel="stylesheet" href="Content/StyleSheet.css" />

<html xmlns="http://www.w3.org/1999/xhtml">

<body>
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

    <form id="form1" runat="server">
        <div id="nav">
            Infor musoc
        </div>
        <div id="section">FOTO MUSOS</div>

    </form>
</body>
</html>
