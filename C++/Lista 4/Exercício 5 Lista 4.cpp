//Exercício 5 da Lista 4 

//Codifique um programa em C++ que leia uma palavra e a imprima de forma invertida.
//Por exemplo: exercício, deverá ser impresso: oicícrexe.

//Bibliotecas
#include <iostream>
#include <stdlib.h>
#include <PILHA.H> 

using namespace std;

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	struct Pilha P;
	
	IniPilha(&P);
	
	// Definição das Variáveis
	char palavra[20];
	int t;  //tamanho da palavra (qtos caracteres ela tem?)
	int i;  //contador do laço
	char x;  //armazena apenas 1 caracter
	
	cout<< "Digite uma palavra: ";
	gets(palavra);   //entrada de dados (gets lê os caracteres especiais e espaço)
	
	t= strlen(palavra);  //strlen conta a qtde caracteres
		
	// empilhar os caracteres através do laço for
	for (i=0;i<t;i++)
	{
		Push(&P,palavra[i]);
	}
	cout << endl;
	
	cout << "Palavra " << palavra << " invertida = " ;
	
	// desempilhar até que a Pilha fique vazia
	while (!pilhavazia(&P))
	{
		x=Pop(&P);
		cout <<x;
	}
	cout << endl;
	
	return 0;
}
