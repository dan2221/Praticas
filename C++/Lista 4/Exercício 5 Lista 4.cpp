//Exerc�cio 5 da Lista 4 

//Codifique um programa em C++ que leia uma palavra e a imprima de forma invertida.
//Por exemplo: exerc�cio, dever� ser impresso: oic�crexe.

//Bibliotecas
#include <iostream>
#include <stdlib.h>
#include <PILHA.H> 

using namespace std;

int main()
{
	// S�mbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	struct Pilha P;
	
	IniPilha(&P);
	
	// Defini��o das Vari�veis
	char palavra[20];
	int t;  //tamanho da palavra (qtos caracteres ela tem?)
	int i;  //contador do la�o
	char x;  //armazena apenas 1 caracter
	
	cout<< "Digite uma palavra: ";
	gets(palavra);   //entrada de dados (gets l� os caracteres especiais e espa�o)
	
	t= strlen(palavra);  //strlen conta a qtde caracteres
		
	// empilhar os caracteres atrav�s do la�o for
	for (i=0;i<t;i++)
	{
		Push(&P,palavra[i]);
	}
	cout << endl;
	
	cout << "Palavra " << palavra << " invertida = " ;
	
	// desempilhar at� que a Pilha fique vazia
	while (!pilhavazia(&P))
	{
		x=Pop(&P);
		cout <<x;
	}
	cout << endl;
	
	return 0;
}
