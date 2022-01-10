var nome = "Daniel";
var lista = ["Maçã", "Pêra", "Banana"];	// ARRAY
lista.push("Uva");	// trazer uma variável ao Array

//				ID 0							ID 1
var animais = [{especie:"Cobra", cor:"preto"},{especie:"Urso", cor:"branco"}]

//	Comando ALERT
alert('Meu primeiro JavaScript');
console.log(nome);

//	atributo REPLACE
console.log(nome.replace("Daniel","Michael"));

document.write('Nome normal: ' + nome + '<br>');
document.write('Nome alterado: ' + nome.replace("Daniel","Michael") + '<br>');

// Upper e Lower Case
document.write('Nome maiúsculo: ' + nome.toUpperCase() + '<br>');
document.write('Nome minúsculo: ' + nome.toLowerCase() + '<br>');

// REVERSE
document.write('<br><b>Lista normal:</b> '+ lista);
document.write('<br><b>Menos 1 variável:</b> '+ lista.pop("Uva"));
document.write('<br><b>Lista reversa:</b> '+ lista.reverse());

// Imprimindo apenas 1 elemento
document.write('<br>'+lista[0]);

// Mesma operação, porém
// convertendo Var para String
document.write('<br>'+lista.toString()[0]);

document.write('<br><b> Espaçamento automático: </b>'+lista.join(" "));

document.write('<br><br>' + animais[1].especie + '<br>');

js_resp = window.confirm('Deseja testar as estruturas de repetição?');

if (js_resp == true) {

	var idade = prompt('Digite sua idade');

// IF ---------------------------------------------------------

	if (idade < 18){
		alert('Você é menor de idade!');
	} else {
		alert('Você é maior de idade!');
	}

	var count = prompt('Digite o número de repetições!');
	var num = 0;

// WHILE ------------------------------------------------------

	while (count < 0){
		count = prompt('Digite outro valor!')
	}

	document.write('<p><b>Repetições:</b></p>')
	while (num < count){
		num +=1;
		document.write(num + '<br>');
	}

	num = 0;

// FOR --------------------------------------------------------

	for(num; num < count; num++){
		document.write('<br>' + num);
	}

}

document.write('<p>Dia e Horário</p>');

var d = new Date();

document.write(d + '<br>');

document.write('Dia da semana: ' + d.getDay());
document.write('<br> Horas: ' + d.getHours());
document.write('<br> Minutos: ' + d.getMinutes());