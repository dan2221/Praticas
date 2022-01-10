<?php

# Valores iguais?
$a = (2 ==3);		# false
$a = (100 == 100);	# true
$a = (50 == '50');	# true
$a = (50 === '50');	# false
// Os três sinais de igual servem para comparar o valor e também o TIPO de valor (duas verificações).

# Valores diferentes/
$a = (2 != 3);		# true
$a = (2 <> 3);		# true (alternativo)
$a = (50 != 50);	# false
$a = (50 != '50');	# false
$a = (50 !== '50');	# true
// Novamente, operadores de comparação com 3 símbolos, comparam valor e tipo de valor.

# Valores são maiores ou menores?
$a = (2 > 3);		# false
$a = (2 < 3);		# true
$a = (50 >= 50);	# true
$a = (50 <= 50);	# true
$a = (50 < 50);		# false

# No PHP 7 foi adicionado um novo operador de comparação designado por spaceship operator. Ele pode retornar 3 respostas.

$x = 1 <=> 1; # 0 (1 == 1)
$x = 3 <=> 2; # 1 (3 > 2)
$x = 1 <=> 2; # -1 (1 < 2)
