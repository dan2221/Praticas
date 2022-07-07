//Exerc�cio 3 Lista 7

//Considere o seguinte c�digo:
//	int exe3( int x, int y)
//	{
//	 if (x>y)
//		     return(-1);
//	 else
//   {
//     if (x==y)
//             return(1);
//     else
//		       return(x*exe3 (x+1,y));
//   }
//	}

//O que � retornado nas seguintes chamadas:
//	a) cout << exe3(10,4)?
//	b) cout << exe3(4,3)?
//	c) cout << exe3(4,7)?
//	d) cout << exe3(0,0)?

//Bibliotecas
#include <iostream>
#include <stdlib.h>

using namespace std;

// Defini��o da Fun��o
int exe3(int x, int y)
{
	if (x>y)
	{
		return (-1);
	}
	else
	{
		if (x==y)
		{
			return (1);
		}
		else
		{
			return (x*exe3 (x+1,y));
		}
	}
}

int main()
{
	// Chamadas para retorno de valores
	cout << "Retorno de 10,4: " << exe3 (10,4) << endl;
	cout << "Retorno de 4,3: " << exe3 (4,3) << endl;
	cout << "Retorno de 4,7: " << exe3 (4,7) << endl;
	cout << "Retorno de 0,0: " << exe3 (0,0) << endl;
}
