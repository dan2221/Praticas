// Exerc�cio 6

// Fa�a um programa que apresente o total da soma obtido dos
// cem primeiros n�meros inteiros. (1+2+3+4+......+100).

// Bibliotecas
#include <iostream>
#include<stdlib.h>

using namespace std;

int main()
{
	// Inserir caract�res especiais (acentos, s�mbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Vari�veis da fun��o
	int contador, soma;
	
	// Limpa a tela
	system("CLS");
	
	// Loop para contar os n�meros
	for (contador = 0; contador <=100; contador++)
	{
		soma += contador;
		cout << contador << ": " << soma << endl;
	}
	
	// Impress�o do resultado
	cout << "---------------------" << endl;
	cout << "Soma total � " << soma << endl;
	cout << "---------------------" << endl;
	
	return 0; //pode ser return 0;
} 
