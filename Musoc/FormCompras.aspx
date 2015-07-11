<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCompras.aspx.cs" Inherits="Musoc.FormCompras" %>

<!DOCTYPE html>
<html>
	<head>
		<link type="text/css" rel="stylesheet" href="Content/StyleSheet.css"/>
		<script type="text/javascript" src="scripts/jquery-1.4.1.min.js" ></script>
		<script type="text/javascript" src="scripts/script.js" ></script>
	</head>
	<body>
		<h2> Elija los asientos haciendo click sobre el asiento:</h2>
		    <div id="bus"> 
		        <ul  id="lugar">
		        </ul>    
		    </div>
		    <div style="float:left;"> 
		    <ul id="DescripcionAsiento">
		        <li style="background:url('images/available_seat_img.gif') no-repeat scroll 0 0 transparent;">Asiento Disponible</li>
		        <li style="background:url('images/booked_seat_img.gif') no-repeat scroll 0 0 transparent;">Asiento Reservado</li>
		        <li style="background:url('images/selected_seat_img.gif') no-repeat scroll 0 0 transparent;">Asiento Seleccionado</li>
		    </ul>
		    </div>
		        <div style="clear:both;width:100%">
		        <input type="button" id="btnShowNew" value="Mostrar Asientos Seleccionados" />
		        <input type="button" id="btnShow" value="Mostrar Todos" />           
		        </div>
	</body>
</html>