//Exerc�cio 1 da Lista 2

// Dados dois n�meros naturais A e B, calcular o MDC entre A e B.

// Resultado esperado:

// 112 dividido por 80
// resto: 32

// 80 dividido por 32
// resto: 16

// 32 dividido por 16
// resto: 0

#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Defini��o das vari�veis
	int b,a,aux,resto,input1,input2;
	
	// Solicita��o dos n�meros ao usu�rio
	cout << "Escreva o 1� n�mero: ";
	cin >> input1;
	
	cout << endl << "Escreva o 2� n�mero: ";
	cin >> input2;
	
	// Teste de condi��o para definir a ordem de divis�o
	if (input1 < input2){
		
		a = input2; // Maior n�mero
		b = input1; // Menor n�mero
		
	} else {
		
		b = input2; // Menor n�mero
		a = input1; // Maior n�mero
		
	}
	
	cout << endl;
	
	resto = a % b;
	
	// Visualiza��o do c�lculo
	cout << a << " / " << b << endl;
	cout << "resto: " << resto << endl;
	
	// Loop para encontrar o MDC
	while (resto != 0){
		cout << endl;
		aux = resto;
	//	cout << "auxiliar: " << aux << endl;
		
		cout << "\n";
		
		a = b;
		cout << a << " / ";
		
		b = aux;
		cout << b << endl;
		
		resto = a % b;
		cout << "resto: " << resto << endl;
	}
	
	cout << endl << "---------------------" << endl;
	cout << "MDC: " << b << endl;
	cout << "---------------------" << endl;
	
	return 0;
}
