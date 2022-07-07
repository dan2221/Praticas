//Exercício 3 da Lista 3 

//Criar um programa que receba 2 valores e 
//calcule o produto através de uma função que retorna valores.

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;
	
int produto(int Va, int Vb); //Protótipo da Função

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Definição das variáveis
	int Va, Vb, P;
	
	cout << "Insira o 1º Valor: ";
	cin >> Va;
	
	cout << "\nInsira o 2º Valor: ";
	cin >> Vb;

	P = produto(Va,Vb);
	
	cout << endl << "----------------------------------------";
	cout << "\nO produto dos Valores é: " << P << endl;
	cout << "----------------------------------------" << endl;
	
	return 0;
}
	//Definição da Função
	int produto(int Va, int Vb)
	{
		int P;
		P = Va * Vb;
		return P;
	}
	
	
	
	
