//Exerc�cio 4 da Lista 3 

//Criar um programa que receba um grau e o converta para 
//radianos atrav�s de uma fun��o. F�rmula: radiano = grau * pi / 180

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;
	
int radiano(int G, int Pi); //Prot�tipo da Fun��o

int main()
{
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Defini��o das vari�veis
	int R, G, Pi; 
	
	Pi = 3,14;
	
	cout << "Insira o valor em Graus(�): ";
	cin >> G;
	
	R = radiano(G, Pi);
	
	cout << endl << "----------------------------------------";
	cout << "\nO Valor em radianos �: " << R << endl;
	cout << "----------------------------------------" << endl;
	
	return 0;
}
	//Defini��o da Fun��o
	int radiano(int G, int Pi)
	{
		int R;
		R = G * Pi / 180;
		return R;
	}
