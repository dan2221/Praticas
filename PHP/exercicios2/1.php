<?php
/*
1. Defina duas variáveis: o seu nome e o seu apelido.
2. Numa estrutura básica de HTML, apresente um título estático do tipo h3 com o texto "O meu nome é: "
3. Apresente numa tag h1 o nome completo a partir das variáveis iniciadas no ponto 1.
*/

$nome = 'Daniel';
$apelido = 'Chavyn';
?>

<!DOCTYPE html>
<html lang="pt">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Exercícios 2</title>
</head>
<body>
	<h3>O meu nome é:</h3>
	<!-- Inserindo o PHP no body -->
	<h1><?= "$nome $apelido"?></h1>
</body>