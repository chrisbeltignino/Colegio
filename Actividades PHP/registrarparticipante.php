<?php
if (isset($_POST["id"])) {
   $numeroingre = $_POST["numeroingre"];
   $nombre = $_POST["nombre"];
   $apellido = $_POST["apellido"];
   $edad = $_POST["edad"];
   $dni = $_POST["dni"];

   $link = mysql_connect("localhost", "nobody");
   mysql_select_db("mibd",$link);
   mysql_query("INSERT INTO carrera (numeroingre, nombre, apellido, edad, dni) VALUES ('{$_POST['numeroingre']}','{$_POST['nombre']}','{$_POST['apellido']}','{$_POST['edad']}','{$_POST['dni']}')",$link);
   echo "¡Gracias! Hemos recibido sus datos.\n";
}
?>
<!DOCTYPE html>
<html>
<head>
   <title></title>
</head>
<body>

<form method="post" action="add_bd.php">

   Numero de Ingreso:      :<input type="Text" name="numeroingre"><br>
   Nombre:                 :<input type="Text" name="Nombre"><br>
   Apellido:            :<input type="Text" name="apelido"><br>
   Edad:                :<input type="Text" name="edad"><br>
   DNI:              :<input type="Text" name="dni"><br>

<input type="Submit" name="enviar" value="Enviar Registros">
</form>

</body>
</html>