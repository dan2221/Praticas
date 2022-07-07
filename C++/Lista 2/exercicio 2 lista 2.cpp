//Exercício 2 da Lista 2

// Dados dois números naturais A e B, calcular o MDC entre A e B.

#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Definição das variáveis
	int k, contador;
	float x, input1;
	
	// Solicitação dos números ao usuário
	cout << "Escreva o número: ";
	cin >> input1;
	x = input1;
	
	cout << endl << "Escreva a potência do número: ";
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
