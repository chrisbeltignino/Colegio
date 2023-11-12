<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

<?php
if (isset($_POST["nombre"])) {
   $nombre = $_POST["nombre"];
   $direccion = $_POST["direccion"];
   $telefono = $_POST["telefono"];
   $email = $_POST["email"];

   $link = mysql_connect("localhost", "root");
   mysql_select_db("mybd",$link);
   mysql_query("INSERT INTO agenda (nombre, direccion, telefono, email) VALUES ('{$_POST['nombre']}','{$_POST['direccion']}','{$_POST['telefono']}','{$_POST['email']}')",$link);
   echo "¡Gracias! Hemos recibido sus datos.\n";
}
?> 


</body>
</html>