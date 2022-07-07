// Exercício 8
/*
Criar um programa que verifique se um número é 
primo ou não, através de uma função. Número primo
é divisível somente por 1 e por ele mesmo.
*/

// Bibliotecas
#include <iostream>

using namespace std;

// Método
void VerificarPrimo(int x)
{
	// Declaração da variável dentro do loop
	for (int divisor = 2; divisor <x; divisor++){
		
		// É possível fazer calculos dentro da estrutura
		// condicional (if), dispensando a necessidade de
		// criar outras variáveis.
		if ((x % divisor) == 0){
			cout << endl << "Não é primo!";
			break;
		}
		if (divisor == (x - 1)){
			cout << endl << "É primo!";
			break;
		}
	}
}


int main()
{	
	// Caractéres especiais (acentos, símbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Declaração de variáveis
	int numero;
	
	// Inserção de valor
	cout << "Insira o número: ";
	cin >> numero;
	
	// Chamada de método
	VerificarPrimo(numero);

	return 0; //finalizar programa
}

