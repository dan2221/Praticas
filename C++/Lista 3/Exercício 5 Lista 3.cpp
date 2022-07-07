//Exercício 5 da Lista 3 

//Criar um programa que mostre qual o maior valor entre dois números, 
//utilizando uma função do tipo void (que não retorna valores).

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;
	
void maior(int Va, int Vb); //Protótipo da Função

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Definição das variáveis
	int Va, Vb, M;
	
	cout << "Insira o 1º Valor: ";
	cin >> Va;
	
	cout << "\nInsira o 2º Valor: ";
	cin >> Vb;

	maior(Va,Vb);

	return 0;
}
	//Definição da Função (VOID), não retorna valores!
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
		cout << "\nO maior valor é: " << M << endl;
		cout << "----------------------------------------" << endl;
	}
	
