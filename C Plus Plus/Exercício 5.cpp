// Exerc�cio 5

//Apresentar todos os valores num�ricos 
//inteiros �mpares situados na faixa de 0 a 20

//Bibliotecas
#include <iostream>

using namespace std;

int main()
{
	// Caract�res especiais (acentos, s�mbolos, etc.)
	setlocale(LC_ALL, "");
	
	// Vari�veis da fun��o
	float resto;
	int contador;
		
	// Limpa a tela
	system("CLS");
	
	// Loop para contar os n�meros
	for (contador = 0; contador <=20; contador++)
	{
		resto = contador % 2;
		if (resto !=0)
		
		{
			cout << contador << " � impar! \n";
		}
	}
	return 0; //finalizar programa
}
