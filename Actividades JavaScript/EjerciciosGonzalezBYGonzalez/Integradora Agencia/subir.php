<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>

	<?php
	$servidor = "localhost";
	$usuario = "root";
	$db = "mybd";
	$pass = "";
	$conexion = new mysqli($servidor,$usuario,$pass,$db);

	$id = $_POST["id"];
	$nombre = $_POST['nombre'];
	$apellido = $_POST['apellido'];
	$cuil = $_POST['cuil'];
	$marca = $_POST['marca'];
	$condicion = $_POST['option'];
	$tarjeta = $_POST['tarjeta'];
	$cuota = $_POST['cuota'];
	$total = $_POST['total'];

	$sql="INSERT INTO venta (nombre, apellido, cuil, marca, condicion, tarjeta, cuotas, precio_total) VALUES ('$nombre','$apellido','$cuil','$marca','$condicion','$tarjeta','$cuota','$total')";

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
