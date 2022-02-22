// Exercício 8

// Faça um programa que leia 15 valores e informe o
// valor da diferença entre a média e o maior valor.

// Bibliotecas
#include <iostream>

using namespace std;

int main()
{	
	// Caractéres especiais (acentos, símbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Variáveis da função
	float media, maior, numero, soma;
	int contador;
	
	maior = 0;
	
	// Limpa a tela
	system("CLS");
	
	// Loop para contar os números
	for (contador = 1; contador <=15; contador++)
	{
		cout << "Escreva o " << contador << "° valor: ";
		cin >> numero;
		soma += numero;
		if (numero > maior)
		{
			maior = numero;
		}
	}
	
	media = soma / 15;
	
	cout << "-------------------------------" << endl;
	cout << "Média: " << media << endl;
	cout << "Maior: " << maior << endl;
	cout << "-------------------------------" << endl;
	
	return 0; //finalizar programa
} 
