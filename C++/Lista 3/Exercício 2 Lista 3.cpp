// Exerc�cio 2

// Criar um programa que receba 4 notas e calcule
// a m�dia aritm�tica, atrav�s de uma fun��o.

// Bibliotecas
#include <iostream>

using namespace std;

// Declara��o de fun��o/m�todo //////////////////

// A declara��o s� � necess�ria se a fun��o
// estiver localizada ap�s o main, caso contr�rio
// n�o h� necessidade de declarar.
float calcMedia( int x1, int x2, int x3, int x4);

int main()
{	
	// Vari�veis
	int num1,num2,num3,num4;

	// Caract�res especiais (acentos, s�mbolos, etc.)
	setlocale(LC_ALL, "");
	
	// inser��o de valores
	cout << "Escreva o 1� n�mero: ";
	cin >> num1;
	
	cout << "Escreva o 2� n�mero: ";
	cin >> num2;
	
	cout << "Escreva o 3� n�mero: ";
	cin >> num3;
	
	cout << "Escreva o 4� n�mero: ";	
	cin >> num4;
	
	// ------------------------- Chamada de m�todo
	cout << endl << "M�dia: " << calcMedia(num1,num2,num3,num4);

	return 0; //finalizar programa
}

// Cria��o da fun��o/m�todo ap�s o main
float calcMedia( int x1, int x2, int x3, int x4)
{
	// Convers�o de tipo de vari�vel
	float media = (float)(x1+x2+x3+x4)/4;
	
	return media;
}
