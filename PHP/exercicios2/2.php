<?php
/*
1. Defina duas variáveis: o seu nome e o seu apelido.
2. Apresente o nome completo num parágrafo HTML.
3. No segundo parágrafo apresente o seguinte:
	O meu nome tem x caractéres.
	Sendo x o cálculo total do caractéres do seu nome.
*/

$nome = 'Daniel';
$apelido = 'Chavyn';
$largura = strlen($nome) + strlen($apelido)
?>

<!DOCTYPE html>
<html lang="pt">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Exercícios 2</title>
</head>
<body>
	<p><?= "$nome $apelido"?></p>
	<p><?= "O meu nome tem " . $largura . " caractéres."?></p>
</body>