//Exercício 6 da Lista 4 

//Uma string é considerada palíndroma se ela pode ser lida da esquerda para a direita ou 
//da direita para a esquerda com o mesmo significado. Neste caso, não podemos considerar acentuações, 
//letras maiúsculas ou minúsculas, os espaços e os caracteres especiais. A seguir estão alguns exemplos:
//Radar, Subi no Onibus, Go dog...
//Faça um programa em C++ para verificar se uma expressão é ou não palíndroma.

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
	string inversao; //palavra invertida
	
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
		cout << x;
		inversao += x;
	}
	cout << endl;
	
	cout << "Inversao: " << inversao <<endl;
	
	// Conversão de char para string
	std::string str(palavra);
	
	// Comparador para palíndromo
	if (palavra == inversao)
	{
		cout << "\nEssa palavra é palíndroma! " << endl;
	}
	else
	{
		cout << "\nEssa palvra não é palíndroma!" << endl;
	}
	
	return 0;
}
