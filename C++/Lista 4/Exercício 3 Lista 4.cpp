//Exerc�cio 3 da Lista 4 

//Codifique um programa em C++ que transforme um n�mero decimal em um n�mero octal.

//Bibliotecas
#include <iostream>
#include <stdlib.h>
#include <PILHA.H> 

using namespace std;

int main()
{
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	struct Pilha P1;

	IniPilha(&P1); 
	
	// Defini��o das Vari�veis
	int x,z,w;

	cout << "Digite um numero inteiro:" << endl;

	cin >> x;
	
	z = x % 8; //resto da divis�o?

	w = x / 8; //inteiro da divis�o?

	Push(&P1,z); //empilha o resto?
		
	while (w != 0)    //inteiro da divis�o?
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

