<?php
$servidor = "localhost";
$usuario = "root";
$db = "mybd";
$pass = "";
$conexion = new mysqli($servidor,$usuario,$pass,$db);

$nombre = $_POST['nombre'];
$apellido = $_POST['apellido'];
$cuil = $_POST['cuil'];
$marca = $_POST['marca'];
$precio = $_POST['total'];
$condicion = $_POST['option'];
$tarjeta = $_POST['tarjeta'];
$cuotas = $_POST['cuota'];
$total = $_POST['total'];

$sql="INSERT INTO ventas(nombre, apellido, cuil, marca, condicion, tarjeta, cantidad_cuotas, precio_total) VALUES('$nombre','$apellido','$cuil','$marca','$precio','$condicion','$tarjeta','$cuotas','$total')";

if($conexion->query($sql)==TRUE){
	echo "Funco";
}else{
	echo "no funco";
}
$conexion->close();
header("Location: Index2.PHP");
?>
