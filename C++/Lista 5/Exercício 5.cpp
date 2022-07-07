//Exercício 5

// Criar um programa em C++  que apresente as operações básicas da estrutura de 
// dados Pilha, da seguinte maneira:
//
//	 Menu de opções
//	
//	 1. Inserir um número inteiro na Pilha
//	 2. Remover um elemento da Pilha
//	 3. Mostrar o elemento do topo da Pilha
//	 4. Mostrar os elementos da Pilha
//	 5. Sair
// 
// Obs.: Utilizar a instrução Switch para criar o menu.

//Bibliotecas
#include <iostream>
#include <stdlib.h>
#include <PILHA.H> 

using namespace std;

int main()
{
	// Símbolos, acentos, etc.
	setlocale(LC_ALL, "");
	
	struct Pilha P1;
	struct Pilha P2;

	IniPilha(&P1);
	IniPilha(&P2);
	
	// Definição das Variáveis
	int opcao, x, z;
	
	cout << "              MENU DE OPÇÕES" << endl;
	cout << endl;
	cout << "1. Inserir um número inteiro na Pilha" << endl;
	cout << "2. Remover um elemento da Pilha" << endl;
	cout << "3. Mostrar o elemento no topo da Pilha" << endl;
	cout << "4. Mostrar os elementos da Pilha" << endl;
	cout << "5. Sair" << endl;

	cout << "Digite uma opcao:";

	cin >> opcao;
	
	while (opcao != 5){
		while (opcao == 0 || opcao > 5){
			cout << "Opção inválida! digite novamente:";
			cin >> opcao;
		}
		switch (opcao)
			{
				case 1: // inserir
					cout << "Digite o numero inteiro desejado:";
					cin >> z;
					Push(&P1, z);
					break;
				case 2: // remover
					Pop(&P1);
					break;
				case 3: // mostrar topo
					cout << Top(&P1) << endl;
					break;
				case 4: // mostrar tudo
					P2 = P1;
					while (!pilhavazia(&P2))
					{
						cout << Pop(&P2) << endl;
					}
					break;
				case 5:	// fim do programa
					exit(0);
					break;
			}
		cout << "Digite uma opcao:";
		cin >> opcao;
	}
	
	cout << "Programa finalizado";
	return 0;
}

