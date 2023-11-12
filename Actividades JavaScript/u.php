<!DOCTYPE html>
<html>


<?php
//define una coneccion para eso usa la funcion mysqli_connect()
$con=mysqli_connect("localhost","root","","mibd")or die("estas en el horno barraza");
?>



<head>
	<title></title>
</head>
<body>
<table width="500 px", border="1", style="background-color: #F9F9F9">
<tr>
<th>ID</th>
<th>Nombre</th>
<th>Apellido</th>
<th>CUIL</th>
<th>DNI</th>
<th>EDITAR</th>
</tr>
<?php
//armo la consulta
$consulta="SELECT * FROM clientes";
//ejecuta consulta con la funcion mysqli_query()
$resultado_consulta=mysqli_query($con, $consulta);

$i = 0;
while($fila= mysqli_fetch_array($resultado_consulta)){
   $id=$fila['id'];
   $nombre=$fila['nombre'];
   $apellido=$fila['apellido'];
   $cuil=$fila['cuil'];
   $dni=$fila['dni'];
   $i++;
?>


<tr align="center">
<td><?php echo $id; ?></td>
	<td><?php echo $nombre; ?></td>
	<td><?php echo $apellido; ?></td>
	<td><?php echo $cuil; ?></td>
	<td><?php echo $dni; ?></td>
    <td><a href="u.php?editar=<?php echo $id; ?>">Editar</a></td>
</tr>
<?php
}

?>

</table>
<?php
		if(isset($_GET['editar'])){

			$editar_id = $_GET['editar'];

			$consulta = "SELECT * FROM clientes WHERE id='$editar_id'";
			$ejecutar = mysqli_query($con, $consulta);

			$fila=mysqli_fetch_array($ejecutar);

			$nombre=$fila['nombre'];
			$apellido=$fila['apellido'];
		  	$cuil=$fila['cuil'];
		  	$dni=$fila['dni'];
		}
?>
</br>
<form method="post" action="u.php">
<input type="text" name="nombre" value="<?php echo $nombre; ?>"><br/>
<input type="text" name="apellido" value="<?php echo $apellido; ?>"><br/>
<input type="text" name="cuil" value="<?php echo $cuil; ?>"><br/>
<input type="text" name="dni" value="<?php echo $dni; ?>"><br/>
<input type="submit" name="actualizar" value="ACTUALIZAR DATOS"/>

</form>
	<?php
	if(isset($_POST['actualizar'])){


		$con=mysqli_connect("localhost","root","","mibd")or die("estas en el horno barraza");
		$actualizar_Nombre=$_POST['nombre'];
    $actualizar_Apellido=$_POST['apellido'];
    $actualizar_Cuil=$_POST['cuil'];
    $actualizar_Dni=$_POST['dni'];

		$actualizar = "UPDATE clientes SET nombre='$actualizar_Nombre', apellido='$actualizar_Apellido', cuil=$actualizar_Cuil, dni=$actualizar_Dni WHERE id='$editar_id'";

		$ejecutar = mysqli_query($con, $actualizar);
		if($ejecutar){

		echo "<script>alert('Datos actualizados!')</script>";

	}else{
		echo "<script>alert('ERROR, datos no actualizados!')</script>";
	}
	}

	?>
</body>
</html>
