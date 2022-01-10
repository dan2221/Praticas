<?php
$custo = 20; $custo = $custo + 2;
echo("$custo <br>");
// COMENTÁRIOS
// =====================================

// Comentário de uma linha

# Comentário de uma linha

/*
Comentário em
múltiplas linhas
*/

echo 'Exemplo de comentários.';
echo '<br>';
# echo 'Ignorar esta instrução com um comentário.';

// =========================================
// VARIÁVEIS

// No PHP as variáveis ÑÃO SÃO TIPIFICADAS

$variavel;

$variavel = 100;

# Podemos alterar o tipo de variável ao longo do algorítmo:

$variavel = 'texto';

# No php as variáveis são Case Sensitive. Isso significa que a linguagem diferencia caractéres maiúsculos e minúsculos. Exemplo:

$cachorro = "uma variável";
$Cachorro = "outra variável";

/*
Não faça isso em uma variável:

$1var = 0;
$!var = 0;
%variavel(1) = 0;
$variavel um = 0;
$variavel-um = 0;

Pode fazer isso:

$var1 = 0;
$var_um = 0;
$varUm = 0;
$_um = 0;
$_1 = 0;

*/

# Convenções
$umaVariavel = 0; # camel case
$uma_variavel = 0; #com undersores (snake case)
$UmaVariavel = 0; #studly case (não recomendado)

// =============================================
# Concatenar

echo("Exibindo variável: $variavel");
echo("<p>Divisão pelo echo:</p>");
echo 500 - 100;