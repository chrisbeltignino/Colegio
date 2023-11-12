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
$sql = "INSERT INTO agenda (nombre, direccion, telefono, email) " +
  "VALUES ('nombre', 'direccion', 'telefono', 'email')";
$result = mysql_query($sql);
echo "¡Gracias! Hemos recibido sus datos.\n";
?>

</body>
</html>