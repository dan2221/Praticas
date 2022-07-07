//Exerc�cio 7 da Lista 3 

//Criar um programa que retorne o fatorial de um n�mero, 
//usando uma fun��o que receba um valor e retorne o fatorial desse valor.
//Ex. Fatorial de 5 = 5 x 4 x 3 x 2 x 1 = 120

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;
	
int fatorial(int N, int contador); //Prot�tipo da Fun��o

int main()
{
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	// Defini��o das vari�veis
	int N, contador, F;
	
	cout << "Insira o n�mero: ";
	cin >> N;
	
	F = fatorial(N,contador);
	
	cout << endl << "----------------------------------------";
	cout << "\nO n�mero fatorial �: " << F << endl;
	cout << "----------------------------------------" << endl;
	
	return 0;
}
	//Defini��o da Fun��o
	int fatorial(int N, int contador)
	{
		int F;
		for (contador = N-1; contador !=0; contador-=1)
		F = N *= contador;
		return F;
	}
	
