<!DOCTYPE html>
<html>
<?php
$con=mysqli_connect("localhost","root","","mybd")or die("estas en el horno barraza");
?>
<head>
	<title></title>
</head>
<body>
<table width="500 px, border="2", style="background-color: #F9F9F9">
<tr>
<th>ID</th>
<th>Nombre</th>
<th>Apellido</th>
<th>CUIL</th>
<th>Total</th>
<th>EDITAR</th>
</tr>
<?php
$consulta="SELECT * FROM venta";
$ejecutar=mysqli_query($con, $consulta);
 $i = 0;
while($fila= mysqli_fetch_array($ejecutar)){
   $id=$fila['id'];
   $nombre=$fila['nombre'];
   $apellido=$fila['apellido'];
   $cuil=$fila['cuil'];
	 $total=$fila['total'];
   $i++;
?>
<tr align="center">
<td><?php echo $id; ?></td>
	<td><?php echo $nombre; ?></td>
	<td><?php echo $apellido; ?></td>
	<td><?php echo $cuil; ?></td>
	<td><?php echo $total; ?></td>
  <td><a href="u.php?editar=<?php echo $id; ?>">Editar</a></td>
</tr>
<?php } ?>

</table>
<?php
		if(isset($_GET['editar'])){

			$editar_id = $_GET['editar'];

			$consulta = "SELECT * FROM venta WHERE id='$editar_id'";
			$ejecutar = mysqli_query($con, $consulta);

			$fila=mysqli_fetch_array($ejecutar);

			$nombre=$fila['nombre'];
			$apellido=$fila['apellido'];
  		$cuil=$fila['cuil'];
			$total=$fila['total'];
		}
?>
</br>
<form method="post" action="">
<input type="text" name="nombre" value="<?php echo $nombre; ?>"><br/>
<input type="text" name="apellido" value="<?php echo $apellido; ?>"><br/>
<input type="text" name="cuil" value="<?php echo $cuil; ?>"><br/>
<input type="text" name="total" value="<?php echo $cuil; ?>"><br/>
<input type="submit" name="actualizar" value="ACTUALIZAR DATOS"/>

</form>
	<?php
	if(isset($_POST['actualizar'])){

		$actualizar_nombre=$_POST['nombre'];
    $actualizar_apellido=$_POST['apellido'];
    $actualizar_cuil=$_POST['cuil'];
		$actualizar_total=$_POST['total'];

		$actualizar = "UPDATE venta SET nombre='$actualizar_nombre', apellido='$actualizar_apellido', cuil='$actualizar_cuil', total='$actualizar_total' WHERE id='$editar_id'";

		$ejecutar = mysqli_query($con, $actualizar);

		if($ejecutar){

		echo "<script>alert('Datos actualizados!')</script>";
		}
	}

	?>
</body>
</html>
