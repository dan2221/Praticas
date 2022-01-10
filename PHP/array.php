<?php

// ARRAYS
//============================================
// ARRAYS NUMÉRICOS

# Jeito antigo de se fazer array:
$valores  =array(1,2,3,10,20,30);
$nomes = array('joão','ana','carlos');

# Jeito novo (a partir do PHP 5.4):
$valores = [1,2,3,10,20,30];
$nomes = ['joão', 'ana', 'carlos'];

# Estes arrays são de índice numérico.
# Para apresentar um dos seus valores, procedemos da segunte forma:
echo $valores[0];
echo $nomes[1];

# Nunca esquecer que os arrays têm índice de base 0!

// ARRAYS ASSOCIATIVOS
# ==================================================
# Ao contrário dos arrays numéricos, as chaves são do tipo string.
# Exemplos:

$dados = [
	'A' => 20,
	'B' => 30,
	'C' => 40,
	'D' => 50,
	'E' => 60
];

$dados = [
	'nome' => 'joão',
	'email' => 'jõao@gmail.com',
	'nacionalidade' => 'Portugal'
	'telefone' => '99999999999'
]

# Da mesma forma que nos arrays numéricos não devem existir duas chaves iguais, nos associativos também não.
# Na apresentação não é gerado nenhum erro, o array definitivo é sempre o último.

// =====================================================
// ARRAYS MISTOS (MIXED ARRAYS)

# Esse tipo de array não é recomendado, mas funciona.

$dados = [
	0 => 10,
	'nome' => 'Gustavo',
	'apelido' => 'Silveira',
	10 => 10000,
	11 => 'Rua de Lisboa',
	12 => 'Portugal'
];

// ARRAYS MULTIDIMENSIONAIS

# São arrays, numéricos ou associativos, cujos valores são outros arrays.

$dados = [
	[10, 20, 30, 40],
	[100, 200, 300, 400],
	[1000, 2000, 3000, 4000]
];

# Neste caso, para apresentar-mos valores deste array:

echo $dados[1][2];	# 300
echo $dados[0][3];	# 40

# Podemos ter arrays multidimensionais associativos:

$cidades = [
	'portugal' => ['Lisboa', 'Porto', 'Coimbra'],
	'brasil' => ['Brasília', 'São Paulo', 'Rio de Janeiro'],
	'espanha' => ['Madrid'. 'Barcelona', 'Servilha']
];

echo $ciaddes['brasil'][1];	# São Paulo
echo $cidades['espanha'][0]; # Madrid
echo $cidades['portugal'][2]; # Coimbra

# Os arrays podem ter mais do que duas dimensões.

# Iremos voltar aos arrays mais à frente para ver algumas funções relacionadas com esta matéria.