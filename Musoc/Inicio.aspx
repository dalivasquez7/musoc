<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Musoc.Inicio" %>

<!DOCTYPE html>
<link rel="stylesheet" href="Content/StyleSheet.css" />

<html xmlns="http://www.w3.org/1999/xhtml">

<body id="body">
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

    <form id="form1" runat="server">
        <div id="nav">
          <p id="fontInicio">Teléfono: 2234-4567<br />
              <br />
                Fax: 2245-5667<br /> <br />
                Correo: musoccr@gmail.com <br />
            </p>
        </div>

        <div id="section2">
            <p id="fontBienvenido">¡Bienvenido a Musoc Online!</p>
            <p>
                <img src="../images/musoc.jpg"              
                         alt="Bus Musoc" />
            </p>
        </div>

    </form>
</body>
</html>
