//Exerc�cio 1 da Lista 3 

//Criar um programa que permita a entrada de um n�mero 
//inteiro e retorne o seu dobro, atrav�s de uma fun��o.

//Bibliotecas
#include <cstdlib>
#include <iostream>

using namespace std;

int dobro (int x); //Prot�tipo da Fun��o

int main()
{
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Defini��o das vari�veis
	int v;
	
	cout << "Digite o valor:";
	cin>> v;
	
	cout << endl << "----------------------------------------";
	cout << "\nDobro = " << dobro(v) << endl;
	cout << "----------------------------------------" << endl;
	
	return 0;
}
	//Defini��o da Fun��o
	int dobro (int x)
	{
		return(x*2);
	}
