//Exercício 3 da Lista 4 

//Codifique um programa em C++ que transforme um número decimal em um número octal.

//Bibliotecas
#include <iostream>
#include <stdlib.h>
#include <PILHA.H> 

using namespace std;

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	struct Pilha P1;

	IniPilha(&P1); 
	
	// Definição das Variáveis
	int x,z,w;

	cout << "Digite um numero inteiro:" << endl;

	cin >> x;
	
	z = x % 8; //resto da divisão?

	w = x / 8; //inteiro da divisão?

	Push(&P1,z); //empilha o resto?
		
	while (w != 0)    //inteiro da divisão?
	{
		x = w;
		z = x % 8;
		w = x / 8;
		Push(&P1, z);
	}

	cout <<"\nValor em Octal:" << endl;
		
	while (! pilhavazia(&P1))
	{
		x = Pop(&P1);
		cout << x ;
	}
	
	return 0;
}

