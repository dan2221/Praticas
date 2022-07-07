//Exercício 7 da Lista 3 

//Criar um programa que retorne o fatorial de um número, 
//usando uma função que receba um valor e retorne o fatorial desse valor.
//Ex. Fatorial de 5 = 5 x 4 x 3 x 2 x 1 = 120

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;
	
int fatorial(int N, int contador); //Protótipo da Função

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Definição das variáveis
	int N, contador, F;
	
	cout << "Insira o número: ";
	cin >> N;
	
	F = fatorial(N,contador);
	
	cout << endl << "----------------------------------------";
	cout << "\nO número fatorial é: " << F << endl;
	cout << "----------------------------------------" << endl;
	
	return 0;
}
	//Definição da Função
	int fatorial(int N, int contador)
	{
		int F;
		for (contador = N-1; contador !=0; contador-=1)
		F = N *= contador;
		return F;
	}
	
