<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Administrador</title>

	<link rel="stylesheet" href="style.css" type="text/css" media="all" />
</head>
<body>
<header>
	<div class="flex">
		<div class="logo"></div>
	</div>
</header>
<label><center>Administrador</center></label>

<main>

<?php

$link = mysql_connect("localhost", "root");
mysql_select_db("mybd", $link);
$result = mysql_query("SELECT * FROM venta", $link);
if ($row = mysql_fetch_array($result)){
   echo "<table border = '1'> \n";
   echo "<tr><td>ID</td><td>Nombre</td><td>Apellido</td><td>CUIL</td><td>Marca de Auto</td><td>Condicion de Pago</td><td>Tarjeta de Credito</td><td>Cuotas</td><td>Precio Total</td></tr> \n";
   do {
      echo "<tr><td>".$row["id"]."</td>
				<td>".$row["nombre"]."</td>
				<td>".$row["apellido"]."</td>
				<td>".$row["cuil"]."</td>
				<td>".$row["marca"]."</td>
				<td>".$row["condicion"]."</td>
				<td>".$row["tarjeta"]."</td>
				<td>".$row["cuotas"]."</td>
				<td>".$row["precio_total"]."</td>
			</tr> \n";
   }
	 while ($row = mysql_fetch_array($result));
	 {
   		echo "</table> \n";
   }
}
	else
{
	echo "¡ No se ha encontrado ningún registro !";
}

?>

	<input type="button" name="consul" value="Consulta" onclick="calcula()">
	<input type="button" name="busca" value="Buscar" onclick="validar()">
</main>

<footer>
<div class="flex">

	<b style="float: right;">ATR CUMBIA PRRO CAGETIALA PIOLA GATOOOOOOOOOOOOO!!!!!!!!!!!!!!!!!!!!!</b>
</div>
<br>
</footer>
	<script src="main.js"></script>
</body>
</html>
