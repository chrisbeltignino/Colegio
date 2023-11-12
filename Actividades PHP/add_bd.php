
<!DOCTYPE html>
<html>
<head>
   <title></title>
</head>
<body>

<form method="post" action="add_bd.php">

   Numero de Ingreso:      :<input type="Text" name="numeroingre"><br>
   Nombre:                 :<input type="Text" name="nombre"><br>
   Apellido:               :<input type="Text" name="apellido"><br>
   Edad:                   :<input type="Text" name="edad"><br>
   DNI:                    :<input type="Text" name="dni"><br>

<input type="Submit" name="enviar" value="Enviar Registros">

<?php
if (isset($_POST["id"])) {
   $nombre = $_POST["nombre"];
   $apellido = $_POST["apellido"];
   $cuil = $_POST["cuil"];
   $dni = $_POST["dni"];
   $edad = $_POST["total"];

   $link = mysql_connect("localhost", "nobody");
   mysql_select_db("mibd",$link);
   mysql_query("INSERT INTO carrera (numeroingre, nombre, apellido, edad, dni) VALUES ('{$_POST['numeroingre']}','{$_POST['nombre']}','{$_POST['apellido']}','{$_POST['edad']}','{$_POST['dni']}')",$link);
   echo "¡Gracias! Hemos recibido sus datos.\n";
}
?>
</form>

</body>
</html>