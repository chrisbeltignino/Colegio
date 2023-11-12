<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php
// process form
$link = mysql_connect("localhost", "root");
mysql_select_db("mybd",$link);
$sql = "INSERT INTO venta (nombre, apellido, cuil, total) " + "VALUES ('nombre', 'apellido', 'cuil', 'total')";
$result = mysql_query($sql);
echo "¡Gracias! Hemos recibido sus datos.\n";
?>

</body>
</html>