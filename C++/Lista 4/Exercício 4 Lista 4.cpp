//Exercício 4 da Lista 4 

//Codifique um programa em C++ que transforme um número decimal 
//em um número hexadecimal. Dica: Se o resto for 10,11,12, 13, 14 ou 15, 
//imprima respectivamente, A,B,C,D,E ou F.

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
	
	z = x % 16; //resto da divisão?

	w = x / 16; //inteiro da divisão?

	Push(&P1,z); //empilha o resto?
		
	while (w != 0)    //inteiro da divisão?
	{
		x = w;
		z = x % 16;
		w = x / 16;
		Push(&P1, z);
	}

	cout <<"\nValor em Hexadecimal:" << endl;
		
	while (! pilhavazia(&P1))
	{
		x = Pop(&P1);
		
		switch (x)
		{
			case 10: cout <<"A";
				break;
			case 11: cout <<"B";
				break;
			case 12: cout <<"C";
				break;
			case 13: cout <<"D";
				break;
			case 14: cout <<"E";
				break;
			case 15: cout <<"F";
				break;
			default: cout << x;
				break;
		}
	}
	
	return 0;
}

