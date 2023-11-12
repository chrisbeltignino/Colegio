<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Formulario de contacto</title>

	<link rel="stylesheet" href="style.css" type="text/css" media="all" />
</head>
<body>
<header>
	<div class="flex">
		<div class="logo"></div>
	</div>
</header>
<label><center>Administrador</center></label>

<?php

$link = mysql_connect("localhost", "nobody");
mysql_select_db("mydb", $link);
$result = mysql_query("SELECT id, nombre, apellido, dni, marca, condicion, tarjeta, cuotas  FROM tabla", $link);
if ($row = mysql_fetch_array($result)){
   echo "<table border = '1'> \n";
   echo "<tr><td>ID</td><td>Nombre</td><td>Apellido</td><td>DNI</td><td>Marca de Auto</td><td>Condicion de Pago</td><td>Tarjeta de Credito</td><td>Cuotas</td></tr> \n";
   do {
      echo "<tr><td>".$row["id"]."</td>
								<td>".$row["nombre"]."</td>
								<td>".$row["apellido"]."</td>
								<td>".$row["dni"]."</td>
								<td>".$row["marca"]."</td>
								<td>".$row["condicion"]."</td>
								<td>".$row["tarjeta"]."</td>
								<td>".$row["cuotas"]."</td>
						</tr> \n";
   } while ($row = mysql_fetch_array($result)); {
   		echo "</table> \n";
   } else {
		echo "¡ No se ha encontrado ningún registro !";
   }
}
?>

	<input type="button" name="consul" value="Consulta" onclick="calcula()">
	<input type="button" name="busca" value="Buscar" onclick="validar()">
</main>

<footer>
<div class="flex">

	<b style="float: right;">MALI</b>
</div>
<br>
</footer>
	<script src="main.js"></script>
</body>
</html>
