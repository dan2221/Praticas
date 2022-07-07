//Exercício 2 Lista 8

// Defina um programa recursivo para, dado
// um número n, imprimi-lo em base binária.

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;

// Função recursiva
int binario(int numero){
	if (numero == 1){
		cout << numero;
	} else {
		binario(numero/2);
		cout << numero % 2;
	}
}

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	int valor;
	
	cout << "Digite um valor:";
	cin >> valor;
	cout << endl;
	
	cout << "Conversão: ";
	binario(valor);
	
	return 0;
 }
