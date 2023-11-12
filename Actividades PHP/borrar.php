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
   	
   mysql_query("UPDATE agenda SET nombre='$_POST[nombren]' WHERE nombre='$_POST[nombrev]'"), $link;

   mysql_query("UPDATE agenda SET direccion='$_POST[direccionn]' WHERE direccion='$_POST[direccionv]'"), $link;

   mysql_query("UPDATE agenda SET telefono='$_POST[telefonon]' WHERE telefono='$_POST[telefonov]'"), $link;

   mysql_query("UPDATE agenda SET email='$_POST[emailn]' WHERE email='$_POST[emailv]'"), $link;

   $result = mysql_query(query)

   echo "Se actualizo.\n";
}
?>

</body>
</html>