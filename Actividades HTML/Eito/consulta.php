<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php
$link = mysql_connect("localhost", "root"); 
mysql_select_db("mybd", $link); 
$result = mysql_query("SELECT nombre, email FROM agenda", $link); 
if ($row = mysql_fetch_array($result)){ 
   echo "<table border = '1'> \n"; 
   echo "<tr><td>Nombre</td><td>E-Mail</td></tr> \n"; 
   do { 
      echo "<tr><td>".$row["nombre"]."</td><td>".$row["email"]."</td></tr> \n"; 
   } while ($row = mysql_fetch_array($result));
   echo "</table> \n";

   } else {
   	echo "No hay registros";
}

?> 


</body>
</html>