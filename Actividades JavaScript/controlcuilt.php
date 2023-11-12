<html>
<head>
<title>Control de CUIL/CUIT</title>

<script>
function checkcuitl(){
	var nCuix = document.formulario.cuitl.value;// numero de cuil ingresado
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
		document.getElementById("idcuit").focus();
	}
	else alert ('CUIT ' + nCuix + ' invalido');
	document.getElementById("idcuit").focus();
	return false;
}
</script>
</head>
<body>
<form action="#" name="formulario" id="formulario" method="POST">

CUIL: <input type="text" name="cuitl" id="idcuit" maxlength="11" onchange=checkcuitl(); value="" placeholder="Codigo">

</form>
</body>
</html>
