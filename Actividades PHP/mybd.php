<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php 
$link = mysql_connect("localhost", "root"); //va sin clave
mysql_select_db("mybd", $link); 
$result = mysql_query("SELECT * FROM agenda", $link); 
echo "Nombre: ".mysql_result($result, 0, "nombre")."<br>"; 
echo "Dirección: ".mysql_result($result, 0, "direccion")."<br>"; 
echo "Teléfono :".mysql_result($result, 0, "telefono")."<br>"; 
echo "E-Mail :".mysql_result($result, 0, "email")."<br>";

?> 


</body>
</html>