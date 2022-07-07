//Exercício 4 Lista 8

/*
Elaborar um programa recursivo que dado um número
natural K, calcular a potência X elevado a K através
de produtos sucessivos.
Obs.:

	x^k = x * x ^(k-1)	Se k > 1
	x^k = x				Se k=1
	x^k = 1				Se k=0

Independente do valor de k, para X=0 ou 1 o resultado é
imediato, isto é, 0 e 1.
*/

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;

// Função recursiva
int potencia(int x, int k){
	if (k > 1){
		return x * potencia(x, k-1);
	} else {
		if (k == 1){
			return x;
		} else {
			return 1;
		}
	}
}

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	int base, expo;
	cout << "\nDigite o valor da base: ";
	cin >> base;
	
	cout << "\nDigite o valor do expoente: ";
	cin >> expo;
	
	cout << "\nPotência: " << potencia(base,expo) << endl;
	
	return 0;
 }


 
