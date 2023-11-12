function todo()
{

  var digitos = document.getElementById("CUIL").value;
  var dv = document.getElementById("NUMERO VERIFICADOR").value;

  //Split divide una cadena en un SET
  digitos = digitos.split("");
  var resultado = validarDV(digitos, dv);
  if (resultado)
  {
    alert("El DÍGITO VERIFICADOR ES CORRECTO");
  }
  else
  {
    alert("El DÍGITO VERIFICADOR ES INCORRECTO");
  }

  function validarDV(digitos,digitoVerificadorAComprobar)
  {
    var serie = []; //La inicializo vacia, depende del largo de "digitos"
    switch (digitos.length)
    {
      case 6:
        serie = [7,6,5,4,3,2];
      break;
      case 7:
        serie = [2,7,6,5,4,3,2];
      break;
      case 8:
        serie = [3,2,7,6,5,4,3,2];
      break;
      case 10:
        serie = [5,4,3,2,7,6,5,4,3,2];
      break;
      default:
        alert ("HA OCURRIDO UN ERROR, EL LARGO DEL cuil/cuit DEBE SER ENTRE 10.");
      return false;
      break;
    }

    var suma = 0;

    for (var i = 0; i < digitos.length; i++)
    {
      suma = suma + digitos[i] * serie[i];
    }

    var parteEntera = parseInt(suma / 11);
    var resto = suma - (11 *  parteEntera);
    var dv = 11 - resto;

      //Comparación
    if (dv == digitoVerificadorAComprobar) return true;
    return false;
  }

}

function validar()
{
  if (document.getElementById("NOMBRE").value == '' && document.getElementById("NOMBRE").type == 'text')
  {
    alert("El campo " + document.getElementById("NOMBRE").id + " está vacio y es OBLIGATORIO LLENARLO");
  }

  if (document.getElementById("APELLIDO").value == '' && document.getElementById("APELLIDO").type == 'text')
  {
    alert("El campo " + document.getElementById("APELLIDO").id + " está vacio y es OBLIGATORIO LLENARLO");
  }

  if (document.getElementById("CUIL").value == '' && document.getElementById("CUIL").type == 'number')
  {
    alert("El campo " + document.getElementById("CUIL").id + " está vacio y es OBLIGATORIO LLENARLO");
  }

  if (document.getElementById("NUMERO VERIFICADOR").value == '' && document.getElementById("NUMERO VERIFICADOR").type == 'number')
  {
    alert("El campo " + document.getElementById("NUMERO VERIFICADOR").id + " está vacio y es OBLIGATORIO LLENARLO");
  }
}

function auto()
{
  alert("BOCA LA CONCHA DE TU MADRE");
}

function chek()
{
  if (document.getElementById("efectivo").checked)
  {
    document.getElementById("cuota").disabled = true;
  }

  if (document.getElementById("financiado").checked)
  {
    document.getElementById("cuota").disabled = false;
		document.getElementById("cred").disabled = false;
  }
}

function calcula()
{
  //var cuota = document.getElementById("cuota");
  if (document.getElementById("efectivo").checked)
  {
    document.getElementById("cuota").disabled = true;
    var auto;
    var op2 = document.getElementById("marca").value;
    switch(op2)
    {
      case 'renault':
        auto = 70000;
      break;
      case 'fiat':
        auto = 50000;
      break;
      case 'peugeot':
        auto = 65000;
      break;
      case 'honda':
        auto = 100000;
      break;
      case 'toyota':
        auto = 80000;
      break;
      case 'chrysler':
        auto = 55000;
      break;
      case 'chevrolet':
       auto = 120000;
      break;
    }
    document.getElementById("precio").value = auto;
    document.getElementById("total").value = auto;
  }
  else
  {
    //var v1 = parseInt(document.getElementById("precio").value);
    //  var pretotal = document.getElementById("pretotal").innerText.value;
    var auto;
    var op2 = document.getElementById("marca").value;
    switch(op2)
    {
      case 'renault':
        auto = 70000;
      break;
      case 'fiat':
        auto = 50000;
      break;
      case 'peugeot':
        auto = 65000;
      break;
      case 'honda':
        auto = 100000;
      break;
      case 'toyota':
        auto = 80000;
      break;
      case 'chrysler':
        auto = 55000;
      break;
      case 'chevrolet':
        auto = 120000;
      break;
    }
    document.getElementById("precio").value = auto;

    var pretotal;
    var op = document.getElementById("cuota").value;
    switch(op)
    {
      case '6':
        pretotal = eval(auto)*1.18;
      break;
      case '12':
        pretotal = eval(auto)*1.29;
      break;
      case '24':
        pretotal = eval(auto)*1.47;
      break;
    }
    document.getElementById("total").value = pretotal;

  }

  if (document.getElementById("financiado").checked)
  {
    document.getElementById("cuota").disabled = false;
  }
}


//Tarjeta de Credito
//El valor es modificado directamente pos la funcion
function Card(event, el){//Validar nombre

	//Obteniendo posicion del cursor
	var val = el.value;//Valor de la caja de texto
	var pos = val.slice(0, el.selectionStart).length;

	var out = '';//Salida
	var filtro = '1234567890';
	var v = 0;//Contador de caracteres validos

	//Filtar solo los numeros
    for (var i=0; i<val.length; i++){
       if (filtro.indexOf(val.charAt(i)) != -1){
		   v++;
		   out += val.charAt(i);

		   //Agregando un espacio cada 4 caracteres
		   if((v==4) || (v==8) || (v==12))
			   out+=' ';
	   }
    }

	//Reemplazando el valor
	el.value = out;

	//En caso de modificar un numero reposicionar el cursor
	if(event.keyCode==8){//Tecla borrar precionada
		el.selectionStart = pos;
		el.selectionEnd = pos;
	}
}
