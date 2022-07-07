//Exerc�cio 2 da Lista 4 

//Codifique um programa em C++ que reverta uma s�rie de n�meros 
//at� que 999 seja digitado. Teste o seu programa com a s�rie 1,3,5,7,9,2,4,6,8.

//Bibliotecas
#include <iostream>
#include <stdlib.h>
#include <PILHA.H> 

using namespace std;

int main()
{
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	struct Pilha P1;

	IniPilha(&P1); 
	
	// Defini��o das Vari�veis
	int x;

	cout << "Digite um numero inteiro:" << endl;

	cin >> x;
	
	while (x != 999)
	{
		Push(&P1, x);
		cin >> x;
	}

	cout << "\nValores desempilhados: "<< endl;	
	
	while (! pilhavazia(&P1))
	{
		x = Pop(&P1);
		cout << "\n     " << x << endl;
	}
	
	return 0;
}

