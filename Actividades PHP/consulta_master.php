<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php

$link = mysql_connect("localhost", "nobody"); 
mysql_select_db("midb", $link); 
$result = mysql_query("SELECT numeroingre, nombre, apellido, edad, dni  FROM carrera", $link); 
if ($row = mysql_fetch_array($result)){ 
   echo "<table border = '1'> \n"; 
   echo "<tr><td>Numero de Ingreso</td><td>Nombre</td><td>Apellido</td><td>Edad</td><td>DNI</td></tr> \n"; 
   do { 
      echo "<tr><td>".$row["numeroingre"]."</td><td>".$row["nombre"]."</td><td>".$row["apellido"]."</td><td>".$row["edad"]."</td><td>".$row["dni"]."</td></tr> \n"; 
   } while ($row = mysql_fetch_array($result)); {
   		echo "</table> \n"; 
   } else {
		echo "¡ No se ha encontrado ningún registro !"; 
   }
} 

?> 


</body>
</html>