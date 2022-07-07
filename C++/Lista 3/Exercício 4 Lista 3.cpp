//Exercício 4 da Lista 3 

//Criar um programa que receba um grau e o converta para 
//radianos através de uma função. Fórmula: radiano = grau * pi / 180

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;
	
int radiano(int G, int Pi); //Protótipo da Função

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Definição das variáveis
	int R, G, Pi; 
	
	Pi = 3,14;
	
	cout << "Insira o valor em Graus(°): ";
	cin >> G;
	
	R = radiano(G, Pi);
	
	cout << endl << "----------------------------------------";
	cout << "\nO Valor em radianos é: " << R << endl;
	cout << "----------------------------------------" << endl;
	
	return 0;
}
	//Definição da Função
	int radiano(int G, int Pi)
	{
		int R;
		R = G * Pi / 180;
		return R;
	}
