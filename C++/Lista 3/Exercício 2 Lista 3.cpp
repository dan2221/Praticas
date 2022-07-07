// Exercício 2

// Criar um programa que receba 4 notas e calcule
// a média aritmética, através de uma função.

// Bibliotecas
#include <iostream>

using namespace std;

// Declaração de função/método //////////////////

// A declaração só é necessária se a função
// estiver localizada após o main, caso contrário
// não há necessidade de declarar.
float calcMedia( int x1, int x2, int x3, int x4);

int main()
{	
	// Variáveis
	int num1,num2,num3,num4;

	// Caractéres especiais (acentos, símbolos, etc.)
	setlocale(LC_ALL, "");
	
	// inserção de valores
	cout << "Escreva o 1º número: ";
	cin >> num1;
	
	cout << "Escreva o 2º número: ";
	cin >> num2;
	
	cout << "Escreva o 3º número: ";
	cin >> num3;
	
	cout << "Escreva o 4º número: ";	
	cin >> num4;
	
	// ------------------------- Chamada de método
	cout << endl << "Média: " << calcMedia(num1,num2,num3,num4);

	return 0; //finalizar programa
}

// Criação da função/método após o main
float calcMedia( int x1, int x2, int x3, int x4)
{
	// Conversão de tipo de variável
	float media = (float)(x1+x2+x3+x4)/4;
	
	return media;
}
