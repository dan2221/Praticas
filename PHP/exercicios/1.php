<?php
echo'<h3>Exercícios com operadores aritméticos e de atribuição</h3>';
echo'<hr>';
echo('Exercício 0:<br>');

# "A" é igual a 100
# Apresentar o valor de 'a'

$a = 100;
echo $a;

echo('<br><br>Exercício 1:<br>');
# 'a' é igual a 1000 e 'b' é igual a metade de 'a'.
# Apresente o valor de 'b':

$a = 1000;
$b = $a / 2;
echo $b;

echo('<br><br>Exercício 2:<br>');
# 'a' é igual a 100 e 'b' é igual a 3 vezes o valor de 'a'.
# Apresente o valor de 'b':

$a = 100;
$b = 100 * 3;
echo $b;

echo('<br><br>Exercício 3:<br>');
// 'a' é iniciado e apresentado com o valor 20.
// Na instrução seguinte, 'a' deverá ser apresentado com o valor 21:

$a = 20;
echo $a++; //É possível printar e acrescentar um valor no echo.
echo "<br>";
echo $a;

echo('<br><br>Exercício 4:<br>');
/*
'a' é igual a 100
'b' é igual a 250
'c' é igual a 'a' mais 'b'
# Acrescente mais uma unidade a 'c'
# Apresente 'c'
*/ # O resultado será 351
$a = 100;
$b = 250;
$c = $a + $b;
$c++;
echo $c;
# Pode substituir as três linhas acima por isto:
// echo $c = $a + $b + 1;