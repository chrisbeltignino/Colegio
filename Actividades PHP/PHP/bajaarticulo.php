<?php
	$mysql=new mysqli("localhost","root","","base1");
	if ($mysql->connect_error)
	  die("Problemas con la conexión a la base de datos");
  
    $mysql->query("DELETE FROM articulos WHERE codigo=$_REQUEST[codigo]") or
        die($mysql->error);    
	
    $mysql->close();
    
    header('Location:mantenimientoarticulos.php');
  ?>  
