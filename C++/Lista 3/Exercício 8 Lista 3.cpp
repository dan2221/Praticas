// Exerc�cio 8
/*
Criar um programa que verifique se um n�mero � 
primo ou n�o, atrav�s de uma fun��o. N�mero primo
� divis�vel somente por 1 e por ele mesmo.
*/

// Bibliotecas
#include <iostream>

using namespace std;

// M�todo
void VerificarPrimo(int x)
{
	// Declara��o da vari�vel dentro do loop
	for (int divisor = 2; divisor <x; divisor++){
		
		// � poss�vel fazer calculos dentro da estrutura
		// condicional (if), dispensando a necessidade de
		// criar outras vari�veis.
		if ((x % divisor) == 0){
			cout << endl << "N�o � primo!";
			break;
		}
		if (divisor == (x - 1)){
			cout << endl << "� primo!";
			break;
		}
	}
}


int main()
{	
	// Caract�res especiais (acentos, s�mbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Declara��o de vari�veis
	int numero;
	
	// Inser��o de valor
	cout << "Insira o n�mero: ";
	cin >> numero;
	
	// Chamada de m�todo
	VerificarPrimo(numero);

	return 0; //finalizar programa
}

