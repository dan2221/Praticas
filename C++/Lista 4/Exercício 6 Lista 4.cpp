//Exerc�cio 6 da Lista 4 

//Uma string � considerada pal�ndroma se ela pode ser lida da esquerda para a direita ou 
//da direita para a esquerda com o mesmo significado. Neste caso, n�o podemos considerar acentua��es, 
//letras mai�sculas ou min�sculas, os espa�os e os caracteres especiais. A seguir est�o alguns exemplos:
//Radar, Subi no Onibus, Go dog...
//Fa�a um programa em C++ para verificar se uma express�o � ou n�o pal�ndroma.

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
	string inversao; //palavra invertida
	
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
		cout << x;
		inversao += x;
	}
	cout << endl;
	
	cout << "Inversao: " << inversao <<endl;
	
	// Convers�o de char para string
	std::string str(palavra);
	
	// Comparador para pal�ndromo
	if (palavra == inversao)
	{
		cout << "\nEssa palavra � pal�ndroma! " << endl;
	}
	else
	{
		cout << "\nEssa palvra n�o � pal�ndroma!" << endl;
	}
	
	return 0;
}
