//Exerc�cio 2 da Lista 2

// Dados dois n�meros naturais A e B, calcular o MDC entre A e B.

#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Defini��o das vari�veis
	int k, contador;
	float x, input1;
	
	// Solicita��o dos n�meros ao usu�rio
	cout << "Escreva o n�mero: ";
	cin >> input1;
	x = input1;
	
	cout << endl << "Escreva a pot�ncia do n�mero: ";
	cin >> k;

	cout << endl;
	
	// Loop
	if (k == 0) {
		cout << "1";
	} else {
		if (k == 1) {
			cout << x;
		} else {
			for (contador = 0; contador <= k; contador++){
				x = x * input1;
				cout << x << endl;
			}			
		}
	}
	
	return 0;
}
