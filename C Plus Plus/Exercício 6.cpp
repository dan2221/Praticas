// Exercício 6

// Faça um programa que apresente o total da soma obtido dos
// cem primeiros números inteiros. (1+2+3+4+......+100).

// Bibliotecas
#include <iostream>
#include<stdlib.h>

using namespace std;

int main()
{
	// Inserir caractéres especiais (acentos, símbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Variáveis da função
	int contador, soma;
	
	// Limpa a tela
	system("CLS");
	
	// Loop para contar os números
	for (contador = 0; contador <=100; contador++)
	{
		soma += contador;
		cout << contador << ": " << soma << endl;
	}
	
	// Impressão do resultado
	cout << "---------------------" << endl;
	cout << "Soma total é " << soma << endl;
	cout << "---------------------" << endl;
	
	return 0; //pode ser return 0;
} 
