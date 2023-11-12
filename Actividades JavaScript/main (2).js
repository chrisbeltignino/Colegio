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
    var filtro = 'abcdefghijklmnopqrstuvwxyz';//Caracteres validos

    for (var i=0; i<string.length; i++)
       if (filtro.indexOf(string.charAt(i)) != -1)
		   out += string.charAt(i);
    return out;
}

function Espacios(string){
	//Uso de split y join para buscar y reemplazar caracteres
	//Reemplazando espacios por guiones
    return string.split(" ").join("-");
}


function Mayuculas(string){
	//Retornar valor convertido a mayusculas
	return string.toLowerCase();
}


//Tarjeta de Credito
//El valor es modificado directamente pos la funcion
function Card(event, el){//Validar nombre

	//Obteniendo posicion del cursor
	var valor = el.value;//Valor de la caja de texto
	var posicionSelectorDeTexto = el.selectionStart;//Valor de la caja de texto
	var valorDespuesDeSlice=valor.slice(0, posicionSelectorDeTexto)

	var pos = valorDespuesDeSlice.length;

	var out = '';//Salida
	var filtro = '1234567890';
	var v = 0;//Contador de caracteres validos

	//Filtar solo los numeros
    for (var i=0; i<valor.length; i++){
       if (filtro.indexOf(valor.charAt(i)) != -1){
		   v++;
		   out += valor.charAt(i);

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


//Tarjeta de Credito
//El valor es modificado directamente pos la funcion
function Cuil(event, el){//Validar nombre


	var valor = el.value;//Valor de la caja de texto
	var largo = valor.length

	if(largo>13){
		valor=valor.slice(0,13)
	}

	//Obteniendo posicion del cursor
	var posicionSelectorDeTexto = el.selectionStart;//Valor de la caja de texto
	var valorDespuesDeSlice=valor.slice(0, posicionSelectorDeTexto)

	var pos = valorDespuesDeSlice.length;

	var out = '';//Salida
	var filtro = '1234567890';
	var v = 0;//Contador de caracteres validos

	//Filtar solo los numeros
    for (var i=0; i<valor.length; i++){
       if (filtro.indexOf(valor.charAt(i)) != -1){
		   v++;
		   out += valor.charAt(i);

		   //Agregando un espacio cada 4 caracteres
		   if((v==2) || (v==10))
			   out+='-';
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


function validarDV(digitos,digitoVerificadorAComprobar) {
	var serie = []; //La inicializo vací­a, depende del largo de "digitos"

	switch (digitos.length) {
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

	for (var i = 0; i < digitos.length; i++) {
		suma = suma + digitos[i] * serie[i];
	}

	var parteEntera = parseInt(suma / 11);
	var resto = suma - (11 *  parteEntera);
	var dv = 11 - resto;
	//Comparación
	if (dv == digitoVerificadorAComprobar) return true;
	return false;
}

function ValidarCuil(){
	var el=document.getElementById("cuil");
	var value=el.value

	alert("cuil valido")
}

function BorrarCuil(){
	var el=document.getElementById("cuil");
	el.value=""
}
function MostrarCuil(){
	var el=document.getElementById("cuil");
	el.value="XX-XXXXXX-XX"
}
