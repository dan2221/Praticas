//Exerc�cio 3 da Lista 3 

//Criar um programa que receba 2 valores e 
//calcule o produto atrav�s de uma fun��o que retorna valores.

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;
	
int produto(int Va, int Vb); //Prot�tipo da Fun��o

int main()
{
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Defini��o das vari�veis
	int Va, Vb, P;
	
	cout << "Insira o 1� Valor: ";
	cin >> Va;
	
	cout << "\nInsira o 2� Valor: ";
	cin >> Vb;

	P = produto(Va,Vb);
	
	cout << endl << "----------------------------------------";
	cout << "\nO produto dos Valores �: " << P << endl;
	cout << "----------------------------------------" << endl;
	
	return 0;
}
	//Defini��o da Fun��o
	int produto(int Va, int Vb)
	{
		int P;
		P = Va * Vb;
		return P;
	}
	
	
	
	
