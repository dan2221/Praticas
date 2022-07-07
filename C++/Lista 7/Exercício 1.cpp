//Exercício 1 Lista 7

//Considere o seguinte código:
//	int exe1( int x)
//	{
//	 if (x<5)
//		     return(3*x);
//	 else
//		     return(2*exe1(x-5) + 7);
//	}

//O que é retornado nas seguintes chamadas:
//	a) cout << exe1(4)?
//	b) cout << exe1(10)?
//	c) cout << exe1(12)?

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;

// Definição da Função
int exe1(int x)
{
	if (x<5)
	{
		return (3*x);
	}
	else
	{
		return (2*exe1 (x-5) +7);
	}
}

int main()
{
	// Chamadas para retorno de valores
	cout << "Retorno de 4: " << exe1 (4) << endl;
	cout << "Retorno de 10: " << exe1 (10) << endl;
	cout << "Retorno de 12: " << exe1 (12) << endl;
}
