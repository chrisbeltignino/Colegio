<?php
	$mysql=new mysqli("localhost","root","","base1");
	if ($mysql->connect_error)
	  die("Problemas con la conexión a la base de datos");
  
    $mysql->query("UPDATE articulos SET descripcion='$_REQUEST[descripcion]', precio=$_REQUEST[precio], codigorubro=$_REQUEST[codigorubro] WHERE codigo=$_REQUEST[codigo]") or die($mysql->error());
	 
    $mysql->close();

    header('Location:mantenimientoarticulos.php');
  ?>  
