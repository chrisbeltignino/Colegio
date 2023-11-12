//function validar()
//{
//  if (document.getElementById("NOMBRE").value == '' && document.getElementById("NOMBRE").type == 'text')
//  {
//    alert("El campo " + document.getElementById("NOMBRE").id + " está vacio y es OBLIGATORIO LLENARLO");
//  }
//
//  if (document.getElementById("APELLIDO").value == '' && document.getElementById("APELLIDO").type == 'text')
//  {
//    alert("El campo " + document.getElementById("APELLIDO").id + " está vacio y es OBLIGATORIO LLENARLO");
//  }
//
//  if (document.getElementById("idcuit").value == '' && document.getElementById("idcuit").type == 'number')
//  {
//    alert("El campo " + document.getElementById("idcuit").id + " está vacio y es OBLIGATORIO LLENARLO");
//  }
//
//  if (document.getElementById("TARJETA").value == '' && document.getElementById("TARJETA").type == 'number')
//  {
//    alert("El campo " + document.getElementById("TARJETA").id + " está vacio y es OBLIGATORIO LLENARLO");
//  }
//}

function auto()
{
  alert("BOCA LA CONCHA DE TU MADRE");
}

function chek()
{
  if (document.getElementById("efectivo").checked)
  {
    document.getElementById("cuota").disabled = true;
    document.getElementById("tarj").disabled = true;
  }

  if (document.getElementById("financiado").checked)
  {
    document.getElementById("cuota").disabled = false;
		document.getElementById("tarj").disabled = false;
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
      case 'Renault':
        auto = 70000;
      break;
      case 'Fiat':
        auto = 50000;
      break;
      case 'Peugeot':
        auto = 65000;
      break;
      case 'Honda':
        auto = 100000;
      break;
      case 'Toyota':
        auto = 80000;
      break;
      case 'Chrysler':
        auto = 55000;
      break;
      case 'Chevrolet':
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
      case 'Renault':
        auto = 70000;
      break;
      case 'Fiat':
        auto = 50000;
      break;
      case 'Peugeot':
        auto = 65000;
      break;
      case 'Honda':
        auto = 100000;
      break;
      case 'Toyota':
        auto = 80000;
      break;
      case 'Chrysler':
        auto = 55000;
      break;
      case 'Chevrolet':
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
    var filtro = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';//Caracteres validos

    for (var i=0; i<string.length; i++)
       if (filtro.indexOf(string.charAt(i)) != -1)
		   out += string.charAt(i);
    return out;
}
