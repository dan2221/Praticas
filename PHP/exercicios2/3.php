<?php
/*
UPPER CASE

1. Defina duas variáveis: nome e apelido (ambas deverão ter texto com letras minúsculas).
2. Numa página HTML simples, apresente o seguinte texto dentro de um parágrafo:
	O meu nome é NOME e o meu apelido é APELIDO.
As palavras em maiúsculo devem ser transformadas via função!
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
	<p><?= "O meu nome é " . mb_strtoupper($nome) . " e o meu apelido é " .  mb_strtoupper($apelido)?></p>
</body>