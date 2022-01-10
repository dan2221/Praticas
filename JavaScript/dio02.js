// FUNÇÔES
var count = 0;

function soma(n1, n2){
	return n1 + n2;
}

function substituir(frase, nome, novo_nome){
	return frase.replace(nome, novo_nome);
}

function validarIdade(idade){
	if (idade < 18){
		return "Menor de idade";
	} else {
		return "Maior de idade"
	}
}

function botao(){
	count += 1;
	document.getElementById("contagem").innerHTML = count;
}

function abrirLink(aba){
	var siteLink = 'https://innovationlabschools.com/global-learning-academy.html';
	if (aba == true){
		// Mesma janela
		window.location.href = siteLink;
	} else {
		// Outra aba
		window.open(siteLink);
	}
}

function trocarTexto(elemento){
	elemento.innerHTML = 'Você trocou a frase !';
}

function voltarTexto(elemento){
	elemento.innerHTML = 'Passe o mouse aqui !';
}

function carregar(){
	alert('Página carregada!')
}

function funcaoChange(elemento){
	var e = document.getElementById("ddlViewBy");
	var numAnimal = e.options[e.selectedIndex].value;
	if (numAnimal == 1){
		document.getElementById("textAnimal").innerHTML = 'Ele gosta de brincar com novelos de lã.';
	}
	if (numAnimal == 2){
		document.getElementById("textAnimal").innerHTML = 'Ele gosta de roer ossos.';
	}
	if (numAnimal == 3){
		document.getElementById("textAnimal").innerHTML = 'Ele gosta de cantar.';
	}
}

// -----------------------------------------------------------

document.write(soma(5, 10)+"<br>");
document.write(substituir("Ele é BluePill!", "BluePill", "RedPill")+"<br>");

/*
var idade = prompt("Qual a sua idade?");
document.write(validarIdade(idade)+"<br>");
*/