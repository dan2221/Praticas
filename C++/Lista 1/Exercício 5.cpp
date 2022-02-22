// Exercício 5

//Apresentar todos os valores numéricos 
//inteiros ímpares situados na faixa de 0 a 20

//Bibliotecas
#include <iostream>

using namespace std;

int main()
{
	// Caractéres especiais (acentos, símbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Variáveis
	float resto;
	int contador;
		
	// Limpa a tela
	system("CLS");
	
	// Loop para contar os números
	for (contador = 0; contador <=20; contador++)
	{
		resto = contador % 2;
		if (resto !=0)
		
		{
			cout << contador << " é impar! \n";
		}
	}
	return 0; //finalizar programa
}
