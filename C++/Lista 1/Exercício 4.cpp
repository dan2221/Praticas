// Exerc�cio 4

//Fa�a um programa que leia 5 valores e 
//informe o valor do maior

//Bibliotecas
#include <iostream>

using namespace std;

int main()
{	
	// Caract�res especiais (acentos, s�mbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Vari�veis da fun��o
	float maior, numero;
	int contador;
	
	maior = 0;
	
	// Limpa a tela
	system("CLS");
	
	// Loop para contar os n�meros
	for (contador = 1; contador <=5; contador++)
	{
		cout << "Escreva o " << contador << "� valor: ";
		cin >> numero;
		if (numero > maior)
		{
			maior = numero;
		}
	}
	
	cout << "-------------------------------" << endl;
    cout << "Maior: " << maior << endl;
	cout << "-------------------------------" << endl;

	return 0; //finalizar programa
} 
