// Exercício 4

//Faça um programa que leia 5 valores e 
//informe o valor do maior

//Bibliotecas
#include <iostream>

using namespace std;

int main()
{	
	// Caractéres especiais (acentos, símbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Variáveis
	float maior, numero;
	int contador;
	
	maior = 0;
	
	// Limpa a tela
	system("CLS");
	
	// Loop para contar os números
	for (contador = 1; contador <=5; contador++)
	{
		cout << "Escreva o " << contador << "° valor: ";
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
