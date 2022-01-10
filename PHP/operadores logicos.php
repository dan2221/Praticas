<?php

// OPERADORES LÓGICOS

$a = 100;
$b = 200;

$x = ($a < $b) && ($a < 1000);	# AND -> true
$x = ($a > $b) || ($a > 1000);	# OR -> false
$x = ($a < 150) && ($b > 300);	# false
$x = ($a > 10) || ($b > 500);	# true
$x = ($a == 100) && ($b < $a);	# false

// &&
// ||
// and
// or
// xor