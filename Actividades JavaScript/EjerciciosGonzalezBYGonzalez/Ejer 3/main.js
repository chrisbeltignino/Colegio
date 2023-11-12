function solo() {
  var variable = document.getElementsByTagName('td')['0'].innerHTML;
  alert (variable);
}

function valor_celda(celda) {
  alert (celda.innerHTML);
}

window.onload = function() {
  var ver = new Array();
  var ver = document.getElementsByTagName('td');

  for (i = 0; i < ver.length; i++) {
    ver[i].addEventListener ("click", function() {valor_celda(this)});
  }
}
