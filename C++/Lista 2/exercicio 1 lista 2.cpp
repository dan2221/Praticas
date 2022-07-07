//Exercício 1 da Lista 2

// Dados dois números naturais A e B, calcular o MDC entre A e B.

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
	
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Definição das variáveis
	int b,a,aux,resto,input1,input2;
	
	// Solicitação dos números ao usuário
	cout << "Escreva o 1° número: ";
	cin >> input1;
	
	cout << endl << "Escreva o 2° número: ";
	cin >> input2;
	
	// Teste de condição para definir a ordem de divisão
	if (input1 < input2){
		
		a = input2; // Maior número
		b = input1; // Menor número
		
	} else {
		
		b = input2; // Menor número
		a = input1; // Maior número
		
	}
	
	cout << endl;
	
	resto = a % b;
	
	// Visualização do cálculo
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
