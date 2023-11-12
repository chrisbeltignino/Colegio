<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

	<?php
	$servidor = "localhost";
	$usuario = "root";
	$db = "mibd";
	$pass = "";
	$conexion = new mysqli($servidor,$usuario,$pass,$db);

	$id = $_POST["id"];
	$nombre = $_POST['nombre'];
	$apellido = $_POST['apellido'];
	$cuil = $_POST['cuil'];
	$dni = $_POST['dni'];

	$sql="INSERT INTO clientes (nombre, apellido, cuil, dni) VALUES ('$nombre','$apellido','$cuil','$dni')";

	if($conexion->query($sql)==TRUE){
		echo "Funco";
	}else{
		echo "No funco";
	}
	$conexion->close();
	header("Location: index.html");
	?>

</body>
</html>
