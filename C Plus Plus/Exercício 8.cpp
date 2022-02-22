// Exerc�cio 8

// Fa�a um programa que leia 15 valores e informe o
// valor da diferen�a entre a m�dia e o maior valor.

// Bibliotecas
#include <iostream>

using namespace std;

int main()
{	
	// Caract�res especiais (acentos, s�mbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Vari�veis da fun��o
	float media, maior, numero, soma;
	int contador;
	
	maior = 0;
	
	// Limpa a tela
	system("CLS");
	
	// Loop para contar os n�meros
	for (contador = 1; contador <=15; contador++)
	{
		cout << "Escreva o " << contador << "� valor: ";
		cin >> numero;
		soma += numero;
		if (numero > maior)
		{
			maior = numero;
		}
	}
	
	media = soma / 15;
	
	cout << "-------------------------------" << endl;
	cout << "M�dia: " << media << endl;
	cout << "Maior: " << maior << endl;
	cout << "-------------------------------" << endl;
	
	return 0; //finalizar programa
} 
