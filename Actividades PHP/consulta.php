<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php
$link = mysql_connect("localhost", "root"); 
mysql_select_db("mybd", $link); 
$result = mysql_query("SELECT id, nombre, apellido, cuil, marca, condicion, tarjeta, cuotas, precio_total FROM venta", $link); 
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
   	} while ($row = mysql_fetch_array($result));
  	   echo "</table> \n";

   	} else {
   		echo "No hay registros";
}

?> 


</body>
</html>