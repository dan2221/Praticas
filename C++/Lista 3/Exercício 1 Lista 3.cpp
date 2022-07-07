//Exercício 1 da Lista 3 

//Criar um programa que permita a entrada de um número 
//inteiro e retorne o seu dobro, através de uma função.

//Bibliotecas
#include <cstdlib>
#include <iostream>

using namespace std;

int dobro (int x); //Protótipo da Função

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Definição das variáveis
	int v;
	
	cout << "Digite o valor:";
	cin>> v;
	
	cout << endl << "----------------------------------------";
	cout << "\nDobro = " << dobro(v) << endl;
	cout << "----------------------------------------" << endl;
	
	return 0;
}
	//Definição da Função
	int dobro (int x)
	{
		return(x*2);
	}
