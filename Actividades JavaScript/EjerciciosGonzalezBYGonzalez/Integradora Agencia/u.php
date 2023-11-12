<html lang="es">
<head>
	<meta charset="utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Administrador</title>

<script>

	function checkcuitl(){
		var nCuix = document.formulario.cuil.value;// numero de cuil ingresado
		tamanio = nCuix.length;//tiene el tam del cuil tamanio=11
		nVerif = '5432765432';

		if (tamanio == 11)
		{
			aMult = nVerif.split('');//Separa el numero para validar 5,4,3,2,7,6,5,4,3,2
			aCUIx = nCuix.split(''); //Separa el cuil en 2,0,3,2,1,9,2,3,6,7,5

			var iResult = 0;
			for(i = 0; i < 10; i++)
			{
			iResult += aCUIx[i] * aMult[i];
			}
			iResult = (iResult % 11); //suma 124 y el modulo es 3
			iResult = 11 - iResult;

			if (iResult == 11) iResult = 0;
			if (iResult == 10) iResult = 9;

			if (iResult == aCUIx[10])
			{
			alert ('CUIT ' + nCuix + ' valido');
			return true;
			}
			else
			alert ('CUIT ' + nCuix + ' invalido');
			document.getElementById("cuil").focus();
		}
		else alert ('CUIT ' + nCuix + ' invalido');
		document.getElementById("cuil").focus();
		return false;
	}

	function Numeros(string){
		//Solo numeros
		var out = '';
	  var filtro = '1234567890';//Caracteres validos

		//Recorrer el texto y verificar si el caracter se encuentra en la lista de validos
	    for (var i=0; i<string.length; i++)
	       if (filtro.indexOf(string.charAt(i)) != -1)
			   //Se a�aden a la salida los caracteres validos
				 out = out + string.charAt(i);
			   //out += string.charAt(i);

		//Retornar valor filtrado
	    return out;
	}

	function Text(string){//solo letras y numeros
		var out = '';
		//Se añaden las letras validas
	    var filtro = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz';//Caracteres validos

	    for (var i=0; i<string.length; i++)
	       if (filtro.indexOf(string.charAt(i)) != -1)
			   out += string.charAt(i);
	    return out;
	}

	function chek()
	{
		if (document.getElementById("efectivo"))
		{
	    document.getElementById("cuotas").disabled = false;
	    document.getElementById("tarjeta").disabled = false;
	  }

	  if (document.getElementById("financiado"))
	  {
	    document.getElementById("cuotas").disabled = true;
			document.getElementById("tarjeta").disabled = true;
	  }
	}

</script>

	<link rel="stylesheet" href="style.css" type="text/css" media="all" />
</head>
<body>
<header>
	<div class="flex">
		<div class="logo" style="width: 950px"></div>
	</div>
</header>
<label><center>Administrador</center></label>

<main>
	<?php
		$con=mysqli_connect("localhost","root","","mybd")or die("estas en el horno barraza");
	?>
	<table border="1", style="background-color: #F9F9F9">
		<tr>
			<th>ID</th>
			<th>Nombre</th>
			<th>Apellido</th>
			<th>CUIL</th>
			<th>Marca de Autos</th>
			<th>Condicion de Pago</th>
			<th>Tarjeta de Credito</th>
			<th>Cuotas</th>
			<th>Precio Total</th>
			<th>EDITAR</th>
		</tr>
		<?php
			$consulta="SELECT * FROM venta";
			$ejecutar=mysqli_query($con, $consulta);
 			$i = 0;

			while($fila= mysqli_fetch_array($ejecutar)){
   			$id = $fila['id'];
   			$nombre = $fila['nombre'];
   			$apellido = $fila['apellido'];
   			$cuil = $fila['cuil'];
   			$marca = $fila['marca'];
	 			$condicion = $fila['condicion'];
	 			$tarjeta = $fila['tarjeta'];
	 			$cuotas = $fila['cuotas'];
	 			$precio_total = $fila['precio_total'];
   			$i++;
		?>

		<tr align="center">
			<td><?php echo $id; ?></td>
			<td><?php echo $nombre; ?></td>
			<td><?php echo $apellido; ?></td>
			<td><?php echo $cuil; ?></td>
			<td><?php echo $marca; ?></td>
			<td><?php echo $condicion; ?></td>
			<td><?php echo $tarjeta; ?></td>
			<td><?php echo $cuotas; ?></td>
			<td><?php echo $precio_total; ?></td>
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
  		$marca=$fila['marca'];
			$condicion=$fila['condicion'];
			$tarjeta=$fila['tarjeta'];
			$cuotas=$fila['cuotas'];
			$precio_total=$fila['precio_total'];
		}
?>
<br>
<form method="post" name="formulario" id="formulario" action="">

<label for="nombre"><span class="style6">Nombre:</span></label>
<input type="text" name="nombre" onkeyup="this.value=Text(this.value)" required value="<?php echo $nombre; ?>">
<br>
<br>
<label for="apellido"><span class="style6">Apellido:</span></label>
<input type="text" name="apellido" onkeyup="this.value=Text(this.value)" required value="<?php echo $apellido; ?>">
<br>
<br>
<label for="cuit"><span class="style6">CUIL:</span></label>
<input type="text" maxlength="11" onkeyup="this.value=Numeros(this.value)" required name="cuil" value="<?php echo $cuil; ?>">
<input type="button" name="verifica" value="Verificar CUIL" onclick=checkcuitl();>
<br>
<br>
<label for="marcas"><span class="style6">Marca de auto:</span></label>
<select name="marca" id="marca">
	<option id="renault" value="<?php echo $marca; ?>" onclick="auto()"><?php echo $marca; ?>*</option>
	<option id="renault" value="renault" onclick="auto()">Renault</option>
	<option id="fiat" value="fiat" onclick="auto()">Fiat</option>
	<option id="peugeot" value="peugeot" onclick="auto()">Peugeot</option>
	<option id="honda" value="honda" onclick="auto()">Honda</option>
	<option id="toyota" value="toyota" onclick="auto()">Toyota</option>
	<option id="chrysler" value="chrysler" onclick="auto()">Chrysler</option>
	<option id="chevrolet" value="chevrolet" onclick="auto()">Chevrolet</option>
</select>
<br>
<br>

<legend><span class="style2">Condicion de Pago:</span></legend>
<br>
<select  name="condicion" id="condicion">
	<option id="<?php echo $condicion; ?>" onclick="chek()"><?php echo $condicion; ?>*</option>
	<option id="efectivo" value="efectivo" onclick="chek()">Efectivo</option>
	<option id="financiado" value="financiado" onclick="chek()">Financiado</option>
</select>

<br>
<br>
<label><span class="style6">Tarjeta de credito:</span></label>
<input type="text" name="tarjeta" maxlength="19" onkeyup="Card(event, this)" required value="<?php echo $tarjeta; ?>">
<br>
<br>

<label for="cuotas"><span class="style6">Cantidad de Cuotas:</span></label>
<br>
<select name="cuotas" id="cuotas">
	<option id="6" value="<?php echo $cuotas; ?>"><?php echo $cuotas; ?>*</option>
	<option id="6">6</option>
	<option id="12">12</option>
	<option id="24">24</option>
</select>

<br>
<br>
<label for="total"><span class="style6">Precio Total:</span></label>
<input type="text" readonly="readonly" style="width: 70px" name="precio_total" value="<?php echo $precio_total; ?>">
<br>
<br>

<input type="submit" name="actualizar" value="ACTUALIZAR DATOS"/>
<br>
<br>

</form>
	<?php
	if(isset($_POST['actualizar'])){

		$actualizar_nombre = $_POST['nombre'];
    $actualizar_apellido = $_POST['apellido'];
    $actualizar_cuil = $_POST['cuil'];
    $actualizar_marca = $_POST['marca'];
		$actualizar_condicion = $_POST['condicion'];
		$actualizar_tarjeta = $_POST['tarjeta'];
		$actualizar_cuotas = $_POST['cuotas'];
		$actualizar_precio_total = $_POST['precio_total'];

		$actualizar = "UPDATE venta SET nombre='$actualizar_nombre',
																		apellido='$actualizar_apellido',
																		cuil='$actualizar_cuil',
																		marca='$actualizar_marca',
																		condicion='$actualizar_condicion',
																		tarjeta='$actualizar_tarjeta',
																		cuotas='$actualizar_cuotas',
																		precio_total='$actualizar_precio_total' WHERE id='$editar_id'";

		$ejecutar = mysqli_query($con, $actualizar);

		if($ejecutar){

		echo "<script>alert('Datos actualizados!')</script>";
		}
	}

	?>
</main>
</form>
<footer>
<div class="flex">

	<b style="float: right;">@ChrisFacha</b>
</div>
<br>
</footer>
	<script src="main.js"></script>
</body>
</html>
