//Exerc�cio 5 da Lista 3 

//Criar um programa que mostre qual o maior valor entre dois n�meros, 
//utilizando uma fun��o do tipo void (que n�o retorna valores).

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;
	
void maior(int Va, int Vb); //Prot�tipo da Fun��o

int main()
{
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Defini��o das vari�veis
	int Va, Vb, M;
	
	cout << "Insira o 1� Valor: ";
	cin >> Va;
	
	cout << "\nInsira o 2� Valor: ";
	cin >> Vb;

	maior(Va,Vb);

	return 0;
}
	//Defini��o da Fun��o (VOID), n�o retorna valores!
	void maior(int Va, int Vb)
	{
		int M;
		if (Va > Vb)
		{
			M = Va;
		}
		if (Vb > Va)
		{
			M = Vb;
		}
		cout << endl << "----------------------------------------";
		cout << "\nO maior valor �: " << M << endl;
		cout << "----------------------------------------" << endl;
	}
	
