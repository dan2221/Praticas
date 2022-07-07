//Exercício 2 Lista 7

//Considere o seguinte código:
//	int exe2( int x, int y)
//	{
//	 if (x<y)
//		     return(-3);
//	 else
//		     return(exe2 (x-y,y+3) +y);
//	}

//O que é retornado nas seguintes chamadas:
//	a) cout << exe2(2,7)?
//	b) cout << exe2(5,3)?
//	c) cout << exe2(15,3)?

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;

// Definição da Função
int exe2(int x, int y)
{
	if (x<y)
	{
		return (-3);
	}
	else
	{
		return (exe2 (x-y,y+3) +y);
	}
}

int main()
{
	// Chamadas para retorno de valores
	cout << "Retorno de 2,7: " << exe2 (2,7) << endl;
	cout << "Retorno de 5,3: " << exe2 (5,3) << endl;
	cout << "Retorno de 15,3: " << exe2 (15,3) << endl;
}
