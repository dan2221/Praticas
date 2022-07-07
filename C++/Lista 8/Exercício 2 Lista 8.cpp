//Exerc�cio 2 Lista 8

// Defina um programa recursivo para, dado
// um n�mero n, imprimi-lo em base bin�ria.

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;

// Fun��o recursiva
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
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	int valor;
	
	cout << "Digite um valor:";
	cin >> valor;
	cout << endl;
	
	cout << "Convers�o: ";
	binario(valor);
	
	return 0;
 }
