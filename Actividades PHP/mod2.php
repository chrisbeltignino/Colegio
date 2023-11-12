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

   $link = mysql_connect("localhost", "nobody");
   mysql_select_db("mybd",$link); 
   $sqlnombr = ("UPDATE agenda SET nombre='$_POST[nombren]' WHERE nombre='$_POST[nombrev]'"),$link);
   $sqldirec = ("UPDATE agenda SET direccion='$_POST[direccionn]' WHERE direccion='$_POST[direccionv]'"),$link);
   $sqltelef = ("UPDATE agenda SET telefono='$_POST[telefonon]' WHERE telefono='$_POST[telefonov]'"),$link);
   $sqlemail = ("UPDATE agenda SET email='$_POST[emailn]' WHERE email='$_POST[emailv]'"),$link);

   $result = mysql_query($sqlnombr, $sqldirec, $sqltelef, $sqlemail);
}
else
{
   echo "Se Actualizo la Base de Datos.\n";
}
?>

</body>
</html>